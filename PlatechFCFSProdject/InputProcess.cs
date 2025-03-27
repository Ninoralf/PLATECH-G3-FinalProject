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
    public partial class InputProcess : Form
    {
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
            else {
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
            int GoalLHeightWhitePanel = 701;

            Thread thread = new Thread(() =>
            {
                int FirstHeightWhitePanel = WhitePanel.Height;
                //=================================================

                while (FirstHeightWhitePanel < GoalLHeightWhitePanel)
                {
                    FirstHeightWhitePanel += 10;
                    Invoke((MethodInvoker)(() =>
                    {
                        WhitePanel.Height = FirstHeightWhitePanel;
                    }));

                    Thread.Sleep(4);
                }
            });

            thread.IsBackground = true;
            thread.Start();
        }


        private void ShowTable()
        {
            panel1.Visible = true;
            panel1.Controls.Clear();

            int processCount;

            if (int.TryParse(kryptonTextBox1.Text, out processCount))
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
                                Name = $"txt_{i}_{j}"
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
                    LabelProcessNO.Text = kryptonTextBox1.Text;
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

                    Thread.Sleep(4);
                }
            });

            thread.IsBackground = true;
            thread.Start();
        }
    }
}
