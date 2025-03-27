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
    public partial class ShowTable : Form
    {
        public ShowTable()
        {
            InitializeComponent();

            int startHeight = 50;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ClientSize = new Size(1270, startHeight);
            ////this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
            ////              ControlStyles.AllPaintingInWmPaint |
            ////              ControlStyles.UserPaint, true);
            //this.UpdateStyles();
      
            this.Shown += AnimateHeight;
        }

        private void AnimateHeight(object sender, EventArgs e)
        {
          
            int targetHeight = 721;
            Thread thread = new Thread(() =>
            {
                int currentHeight = this.ClientSize.Height;

                while (currentHeight < targetHeight)
                {
                    currentHeight += 10;
                    if (currentHeight > targetHeight)
                        currentHeight = targetHeight;

                    Invoke((MethodInvoker)(() =>
                    {
                        this.ClientSize = new Size(1270, currentHeight);
                    }));

                    Thread.Sleep(4);
                }
            });

            thread.IsBackground = true;
            thread.Start();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TextBox_Leave_AddMsec(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;

            if (int.TryParse(txt.Text.Trim(), out int value))
            {
                txt.Text = $"{value} msec";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.Controls.Clear();

            int processCount;

            if (int.TryParse(Process.Text, out processCount))
            {
                Panel[] arrayPanel = new Panel[processCount];

                for (int i = 0; i < processCount; i++)
                {


                    Panel header = new Panel
                    {
                        Width = panel1.Width - 25,
                        Height = 40,
                        Location = new Point(10, 0),
                      
                    };

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
                        }

                        row.Controls.Add(txt);
                    }

                    panel1.Controls.Add(row);
                }

  
                panel1.Height = Math.Min(processCount * 45 + 10, this.ClientSize.Height - 50);
            }
        }
    }
}
