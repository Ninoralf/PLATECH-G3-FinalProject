using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlatechFCFSProdject
{
    public partial class Perform : Form
    {
        ProcessList pList = new ProcessList();
        public Perform()
        {
            InitializeComponent();
            ShowTable();
        }

        public void SetProcessList(List<Process> process)
        {
            pList.processList = process;
        }

        private void ContinueButt_MouseClick(object sender, MouseEventArgs e)
        {

        }

        public void ShowTable()
        {
            panel1.Visible = true;

            Panel[] arrayPanel = new Panel[pList.processList.Count];

            Panel header = new Panel
            {
                Width = panel1.Width - 25,
                Height = 40,
                Location = new Point(10, 0),
            };

            for (int i = 0; i < pList.processList.Count; i++)
            {
                string[] headers = { "Process ID", "Burst Time", "Arrival Time" };
                for (int j = 0; j < headers.Length; j++)
                {
                    Label lbl = new Label
                    {
                        Text = headers[j],
                        Width = (header.Width / 3) - 10,
                        Location = new Point(j * (header.Width / 3), 10),
                        TextAlign = ContentAlignment.MiddleCenter,
                        Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point, 0),
                    };
                    header.Controls.Add(lbl);
                }

                panel1.Controls.Add(header);

                Panel row = new Panel
                {
                    Size = new Size(492, 39),
                    TabIndex = 2,
                    Width = panel1.Width - 18,
                    Height = 40,
                    Location = new Point(10, (i + 1) * 45),
                    Name = $"panelRow_{i}",
                    BackColor = SystemColors.AppWorkspace
                };

                var Plist = pList.processList[i];
                for (int j = 0; j < 3; j++)
                {
                    TextBox txt = new TextBox
                    {
                        Multiline = true,
                        Size = new Size(158, 38),
                        Font = new Font("Verdana", 15F, FontStyle.Regular),
                        TextAlign = HorizontalAlignment.Center,
                        Width = (row.Width / 3),
                        Location = new Point(j * (row.Width / 3), 5),
                        Name = $"Text_Box_{j}",
                        Enabled = false
                    };

                    if (j == 0)
                    {
                        txt.Text = Plist.ProcessID;
                        txt.Enabled = false;
                        txt.Font = new Font("Verdana", 15F, FontStyle.Bold);
                    }
                    else if (j == 1)
                    {
                        string burstDisplay = Plist.BurstTime % 1 == 0 ? ((int)Plist.BurstTime).ToString() : Plist.BurstTime.ToString("0.##");
                        txt.Text = $"{burstDisplay} msec";
                    }
                    else if (j == 2)
                    {
                        string arrivalDisplay = Plist.ArrivalTime % 1 == 0 ? ((int)Plist.ArrivalTime).ToString() : Plist.ArrivalTime.ToString("0.##");
                        txt.Text = $"{arrivalDisplay} msec";
                    }
                    row.Controls.Add(txt);
                }

                panel1.Controls.Add(row);
            }

            panel1.Height = Math.Min(pList.processList.Count * 60 + 15, this.ClientSize.Height - 410);
        }

        private void ContinueButt_Click(object sender, EventArgs e)
        {
            ShowTable();
            GenerateGanttChart();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GenerateGanttChart()
        {
            for (int i = 0; i < pList.processList.Count - 1; i++)
            {
                for (int j = i + 1; j < pList.processList.Count; j++)
                {
                    bool shouldSwap = false;

                    float arrival1 = pList.processList[i].ArrivalTime;
                    float arrival2 = pList.processList[j].ArrivalTime;

                    float burst1 = pList.processList[i].BurstTime;
                    float burst2 = pList.processList[j].BurstTime;

                    if (arrival1 > arrival2)
                    {
                        shouldSwap = true;
                    }
                    else if (arrival1 == arrival2)
                    {
                        if (burst1 > burst2)
                        {
                            shouldSwap = true;
                        }
                        else if (burst1 == burst2)
                        {
                            int num1 = int.Parse(pList.processList[i].ProcessID.Substring(1));
                            int num2 = int.Parse(pList.processList[j].ProcessID.Substring(1));

                            if (num1 > num2)
                                shouldSwap = true;
                        }
                    }

                    if (shouldSwap)
                    {
                        Process temp = pList.processList[i];
                        pList.processList[i] = pList.processList[j];
                        pList.processList[j] = temp;
                    }
                }
            }

            ganttChartPanel.Controls.Clear();

            float x = 0;
            int sizeOfWidth = 16;
            float currentTime = 0f;

            foreach (var proc in pList.processList)
            {
                if (currentTime < proc.ArrivalTime)
                {
                    float EmptyDuration = proc.ArrivalTime - currentTime;
                    AddGanttBox("Empty", x, EmptyDuration * sizeOfWidth, Color.Gray);
                    x += EmptyDuration * sizeOfWidth;
                    currentTime = proc.ArrivalTime;
                }

                float width = proc.BurstTime * sizeOfWidth;
                AddGanttBox(proc.ProcessID, x, width, Color.Teal);
                x += width;
                currentTime += proc.BurstTime;
            }

            float endTime = currentTime;
            float endPixel = endTime * sizeOfWidth;
            Label timeEndLabel = new Label
            {
                Text = endTime % 1 == 0 ? ((int)endTime).ToString() : endTime.ToString("0.##"),
                Location = new Point((int)endPixel, 120),
                Font = new Font("Verdana", 10F, FontStyle.Bold),
                AutoSize = true
            };
            ganttChartPanel.Controls.Add(timeEndLabel);
        }

        private void AddGanttBox(string label, float x, float width, Color color)
        {
            Label ganttBlock = new Label
            {
                Text = label,
                Width = (int)width,
                Height = 90,
                BackColor = color,
                ForeColor = Color.White,
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point((int)x, 20),
                Font = new Font("Verdana", 10F, FontStyle.Bold),
                BorderStyle = BorderStyle.FixedSingle
            };
            ganttChartPanel.Controls.Add(ganttBlock);

            float time = x / 16f;
            Label timeLabel = new Label
            {
                Text = time % 1 == 0 ? ((int)time).ToString() : time.ToString("0.##"),
                Location = new Point((int)x, 120),
                Font = new Font("Verdana", 10F, FontStyle.Bold),
                AutoSize = true
            };
            ganttChartPanel.Controls.Add(timeLabel);
        }
    }
}
