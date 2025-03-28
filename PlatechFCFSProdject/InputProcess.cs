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
    public partial class InputProcess : Form
    {
        List<Process> processList = new List<Process>();
        public InputProcess()
        {
            InitializeComponent();
        }

        private void TextBox_Leave_AddMsec(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (string.IsNullOrEmpty(txt.Text))
            {
                MessageBox.Show("This field cannot be empty.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt.Focus();
                return;
            }

            if (float.TryParse(txt.Text.Trim(), out float value))
            {
                txt.Text = $"{value} msec";
                txt.BackColor = Color.Teal;
            }
            else
            {
                MessageBox.Show("Numbers only!.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt.Focus();
                return;

            }

            if (txt.Text.Contains(" msec"))
            {
                txt.BackColor = Color.Teal;
            }
            else
            {
                txt.BackColor = Color.White;
            }
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            txt.BackColor = Color.White;
            txt.Text = txt.Text.Replace(" msec", "").Trim();
        }

        private void ContinueButt_Click(object sender, EventArgs e)
        {
            ShowTable();

        }


        private void ChangeBackground()
        {
            BackButton.Visible = false;
            ContinueButs.Visible = false;
            label1.Visible = false;
            int GoalLHeightWhitePanel = 701;

            Thread thread = new Thread(() =>
            {
                int FirstHeightWhitePanel = WhitePanel.Height;
                //=================================================

                while (FirstHeightWhitePanel < GoalLHeightWhitePanel)
                {
                    FirstHeightWhitePanel += 12;
                    Invoke((MethodInvoker)(() =>
                    {
                        WhitePanel.Height = FirstHeightWhitePanel;
                    }));

                    Thread.Sleep(2);
                }
                BackButton.Visible = true;
                ContinueButs.Visible = true;
                label1.Visible = true;
                TextBoxInputPross.Visible = false;
                ContinueButt.Visible = false;
                
            });
           
            thread.IsBackground = true;
            thread.Start();
        }


        private void ShowTable()
        {
            panel1.Visible = true;
            panel1.Controls.Clear();

            int processCount;

            if (int.TryParse(TextBoxInputPross.Text, out processCount))
            {
                if (processCount >= 2 && processCount <= 5)
                {
                    Panel[] arrayPanel = new Panel[processCount];

                    Panel header = new Panel
                    {
                        Width = panel1.Width - 25,
                        Height = 40,
                        Location = new Point(10, 0),

                    };

                    for (int i = 0; i < processCount; i++)
                    {

                        string[] headers = { "Process ID", "Burst Time", "Arrival Time" };
                        // FOR LABEL OF HEADERS -----------------------
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

                        // FOR ROW PANEL -----------------------
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
                        // FOR TEXTBOX -----------------------
                        for (int j = 0; j < 3; j++)
                        {
                            TextBox txt = new TextBox
                            {
                                Multiline = true,
                                Size = new Size(158, 38),
                                Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point, 0),
                                TextAlign = HorizontalAlignment.Center,
                                Width = (row.Width / 3),
                                Location = new Point(j * (row.Width / 3), 5),
                                Name = $"Text_Box_{j}"
                            };

                            if (j == 0)
                            {
                                txt.Text = $"P{i + 1}";
                                txt.Enabled = false;
                                txt.TextAlign = HorizontalAlignment.Center;
                                txt.Font = new Font("Verdana", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
                            }
                            else
                            {
                                txt.Leave += TextBox_Leave_AddMsec;
                                txt.Enter += TextBox_Enter;
                            }
                            row.Controls.Add(txt);
                        }

                        panel1.Controls.Add(row);

                    }
                    LabelProcessNO.Text = TextBoxInputPross.Text;
                    panel1.Height = Math.Min(processCount * 45 + 10, this.ClientSize.Height - 50);
                    ChangeBackground();
                }
                else
                {
                    ErrorLabel.Text = "Minimum of 2, Maximum of 5";
                }

            }
            else
            {
                ErrorLabel.Text = "Integers only, please try again!";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void kryptonTextBox1_MouseEnter(object sender, EventArgs e)
        {
            ErrorLabel.Text = "";
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            BackButton.Visible = false;
            ContinueButs.Visible = false;

            int GoalLHeightWhitePanel = 0;

            Thread thread = new Thread(() =>
            {
                int FirstHeightWhitePanel = WhitePanel.Height;
                //=================================================

                while (FirstHeightWhitePanel > GoalLHeightWhitePanel)
                {
                    FirstHeightWhitePanel -= 10;
                    Invoke((MethodInvoker)(() =>
                    {
                        WhitePanel.Height = FirstHeightWhitePanel;
                    }));

                    Thread.Sleep(2);

                }
                TextBoxInputPross.Visible = true;
                ContinueButt.Visible = true;
            });

            thread.IsBackground = true;
            thread.Start();
        }


        bool allIsNotEmpty = false;
       
        
        private void GetProcessData()
        {
            foreach (Control control in panel1.Controls)
            {
                if (control is Panel rowPanel && rowPanel.Name.StartsWith("panelRow_"))
                {
                    Process proc = new Process();

                    foreach (Control txtControl in rowPanel.Controls)
                    {             
                        if (txtControl is TextBox txtBox)
                        {
                            allIsNotEmpty = false;
                            string[] parts = txtBox.Name.Split('_');
                            int colIndex = int.Parse(parts[2]);

                            string inputValue = txtBox.Text.Replace(" msec", "").Trim();

                            if (string.IsNullOrEmpty(txtBox.Text))
                            {

                                MessageBox.Show($"TextBox field cannote be empty.",
                                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                txtBox.Focus();
                                return;
                            }
                            else {
                                if (colIndex == 0)
                                {
                                    proc.ProcessID = txtBox.Text;
                                }
                                else
                                {

                                    if (float.TryParse(inputValue, out float value))
                                    {
                                        if (value > 20 || value < 0)
                                        {
                                            MessageBox.Show($"Value in {proc.ProcessID} {txtBox.Name} cannot be more than 20.",
                                                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                            txtBox.Focus();
                                            return;
                                        }
                                        if (colIndex == 1)
                                        {
                                            if (value > 20 || value < 2)
                                            {
                                                MessageBox.Show($"Value in {proc.ProcessID} {txtBox.Name} cannot be more than 20 and less than 2.",
                                                           "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                txtBox.Focus();
                                                return;

                                            }
                                            else proc.BurstTime = value;
                                        }
                                        if (colIndex == 2) proc.ArrivalTime = value;
                                    }

                                    
                                }
                                allIsNotEmpty = true;
                            }
                           
                        }
                    }
                    var existing = processList.FirstOrDefault(p => p.ProcessID == proc.ProcessID);
                    if (existing != null)
                    {
                        existing.BurstTime = proc.BurstTime;
                        existing.ArrivalTime = proc.ArrivalTime;
                    }
                    else
                    {
                        processList.Add(proc);
                    }
                }
            }    
        }

        private void ContinueButs_Click(object sender, EventArgs e)
        {
            GetProcessData();

            if (allIsNotEmpty)
            {
                this.Hide();
                Perform perform = new Perform();
                perform.SetProcessList(processList);
                perform.Show();
            }
        }


        //private void GenerateGanttChart()
        //{
        //    var processList = processData.OrderBy(p => p.Value.ArrivalTime).ToList(); // Sort by Arrival Time
        //    float currentTime = 0;
        //    panelGantt.Controls.Clear();
        //    int xPosition = 10; // Initial position for Gantt Chart Blocks

        //    foreach (var process in processList)
        //    {
        //        string processID = process.Key;
        //        float arrivalTime = process.Value.ArrivalTime;
        //        float burstTime = process.Value.BurstTime;

        //        // If the CPU is idle, move to the next arrival time
        //        if (currentTime < arrivalTime)
        //        {
        //            currentTime = arrivalTime;
        //        }

        //        float startTime = currentTime;
        //        float finishTime = startTime + burstTime;
        //        currentTime = finishTime;

        //        // Create Panel for Gantt Chart Block
        //        Panel ganttBlock = new Panel
        //        {
        //            Width = (int)(burstTime * 20),  // Scale burst time for visibility
        //            Height = 50,
        //            Location = new Point(xPosition, 10),
        //            BackColor = Color.LightBlue,
        //            BorderStyle = BorderStyle.FixedSingle
        //        };

        //        // Label for Process ID
        //        Label lblProcess = new Label
        //        {
        //            Text = processID,
        //            AutoSize = true,
        //            Location = new Point(5, 15),
        //            Font = new Font("Verdana", 10F, FontStyle.Bold),
        //            ForeColor = Color.Black
        //        };

        //        // Label for Time (Start & Finish)
        //        Label lblTime = new Label
        //        {
        //            Text = $"{(int)startTime} - {(int)finishTime}",
        //            AutoSize = true,
        //            Location = new Point(5, 30),
        //            Font = new Font("Verdana", 8F, FontStyle.Regular),
        //            ForeColor = Color.Black
        //        };

        //        ganttBlock.Controls.Add(lblProcess);
        //        ganttBlock.Controls.Add(lblTime);
        //        panelGantt.Controls.Add(ganttBlock);

        //        xPosition += ganttBlock.Width + 5; // Move to the next position
        //    }
        //}
    }
}
