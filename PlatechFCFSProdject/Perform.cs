using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
                        txt.Text = $"{Plist.BurstTime} msec";
                    }
                    else if (j == 2)
                    {
                        txt.Text = $"{Plist.ArrivalTime} msec";
                    }
                    row.Controls.Add(txt);
                }

                panel1.Controls.Add(row);

            }

            panel1.Height = Math.Min(pList.processList.Count * 60 + 15 , this.ClientSize.Height - 410);
        }

        private void ContinueButt_Click(object sender, EventArgs e)
        {
            ShowTable();
            //foreach (var process in pList.processList)
            //{
            //    MessageBox.Show($"{process.ProcessID}: Burst = {process.BurstTime}, Arrival = {process.ArrivalTime}");
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
