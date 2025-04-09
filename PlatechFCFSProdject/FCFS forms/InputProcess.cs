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
        public List<Process> processList = new List<Process>();
        public bool ResetProcessNo = false;
        private bool allIsNotEmpty = false;
        private int processCount = 0;
        private bool isUpdating = false;
        public InputProcess()
        {
            InitializeComponent();
        }
        // HELPER METHOD ==================================================================
        private void TextBox_Leave_AddMsec(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (float.TryParse(txt.Text.Trim(), out float value))
            {
                txt.Text = $"{value} msec";
                txt.BackColor = Color.Teal;
            }

            if (txt.Text.Contains(" msec"))
            {
                txt.BackColor = Color.Teal; // TURN TEAL COLOR IF THERE'S A INPUT VALUE
            }
            else
            {
                txt.BackColor = Color.White; // TURN WHITE COLOR IF EMTPY.
            }
        }
        private void TextBox_Enter(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            txt.BackColor = Color.White;
            txt.Text = txt.Text.Replace(" msec", "").Trim(); // REMOVE MSEC IF THE USER PRESS AGAIN TO THE TEXTBOX
        }
        // THIS METHOD CREATE THE TABLE OF PROCESS
        private void ShowTable()
        {
            panel1.Visible = true; 
            panel1.Controls.Clear();

            if (!string.IsNullOrEmpty(TextBoxInputPross.Text))
            {

                if (int.TryParse(TextBoxInputPross.Text, out processCount))
                {
                    if (processCount >= 2 && processCount <= 5)
                    {
                        Panel[] arrayPanel = new Panel[processCount];
                        // HEADER PANEL =====
                        Panel header = new Panel
                        {
                            Width = panel1.Width - 25,
                            Height = 40,
                            Location = new Point(10, 0),

                        };

                        for (int i = 0; i < processCount; i++)
                        {   
                            string[] headers = { "Process ID", "CPU Burst Time", "Arrival Time" };
                            // FOR LABEL OF HEADERS -----------------------
                            for (int j = 0; j < headers.Length; j++)
                            {
                                Label lbl = new Label
                                {
                                    Text = headers[j],
                                    Width = (header.Width / 3) - 3,
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
                            // FOR TEXTBOX INSIDE THE ROW PANEL-----------------------
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
                        AnimateHandlePanelHide();
                    }
                    else
                    {
                        ErrorLabel.Text = "Minimum of 2, Maximum of 5.";
                    }

                }
                else
                {
                    ErrorLabel.Text = "Integers only, please try again.";
                }
            }
            else {
                ErrorLabel.Text = "Cannot be empty, please enter the process no.";
            }

          
        }
        // THIS METHOD FOR INPUT VALUE AND STORE THE VALUE TO THE LIST PROCESS.
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
                            allIsNotEmpty = false; // SET IT FIRST TO FALSE
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
                            else
                            {
                                if (colIndex == 0)
                                {
                                    proc.ProcessID = txtBox.Text;
                                }
                                else
                                {

                                    if (float.TryParse(inputValue, out float value))
                                    {
                                        if (value > 15 || value < 0)
                                        {
                                            MessageBox.Show($"Value in {proc.ProcessID} {txtBox.Name} cannot be more than 15\n and less than 0.",
                                                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                            txtBox.Focus();
                                            return;
                                        }
                                        if (colIndex == 1)
                                        {
                                            if (value > 15 || value < 1)
                                            {
                                                MessageBox.Show($"Value in {proc.ProcessID} {txtBox.Name} cannot be more than 15\n and less than 1.",
                                                           "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                txtBox.Focus();
                                                return;

                                            }
                                            else proc.BurstTime = value;
                                        }
                                        if (colIndex == 2) proc.ArrivalTime = value;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Numbers only!.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        txtBox.Focus();
                                        return;

                                    }
                                }
                                allIsNotEmpty = true; // SET TO TRUE.
                            }

                        }
                    }
                    // THIS IS THE SAME OF FOREACH LOOP. IT CHECK IF THE PROCESS ID ADDED MULTIPLE TIMES.
                    // IF USER CHANGE THE VALUE, THEN THE VALUE ONLY WILL CHANGE NOT THE PROCESS ID WILL ADD TO LIST.
                    var isProcessAlreadyList = processList.Find(p => p.ProcessID == proc.ProcessID); 
                    if (isProcessAlreadyList != null)
                    {
                        isProcessAlreadyList.BurstTime = proc.BurstTime;
                        isProcessAlreadyList.ArrivalTime = proc.ArrivalTime;
                    }
                    else
                    {   
                        // ELSE IF NO CHANGES.
                        processList.Add(proc);
                    }
                }
            }
        }
        private void SetButtonsVisibility(bool isVisible)
        {
            if (!isVisible)
            {

                BackButton.Visible = false;
                ContinueButs.Visible = false;
                label3.Visible = false;
                LabelProcessNO.Visible = false;
                panel1.Visible = false;
                BackButton.Visible = false;
                ContinueButs.Visible = false;

            }
            else
            {
                BackButton.Visible = true;
                ContinueButs.Visible = true;
                label3.Visible = true;
                LabelProcessNO.Visible = true;
                panel1.Visible = true;
                BackButton.Visible = true;
                ContinueButt.Visible = true;
            }
        }

        // CLICKABLE BUTTONS AND ANOTHER EVENT METHOD =======================================================
        private void ContinueButt_Click(object sender, EventArgs e)
        {
            ShowTable();
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

            SetButtonsVisibility(false);
            int GoalLHeightWhitePanel = 0;
            panelSlide.Visible = false;
            panel3.Visible = false;
            Thread thread = new Thread(() =>
            {
                int FirstWidthWhitePanel = WhitePanel.Width;
                //=================================================

                while (FirstWidthWhitePanel > GoalLHeightWhitePanel)
                {
                    FirstWidthWhitePanel -= 12;
                    Invoke((MethodInvoker)(() =>
                    {
                        WhitePanel.Width = FirstWidthWhitePanel;
                    }));

                    Thread.Sleep(2);

                }
                panelSlide.Visible = true;
                panel3.Visible = true;
                ContinueButt.Visible = true;
                AnimateHandlePanelShow();
            });
            thread.IsBackground = true;
            thread.Start();
   
        }
        private void ContinueButs_Click(object sender, EventArgs e)
        {
          

            GetProcessData();

            if (allIsNotEmpty)
            {
                //prevCount = processCount
                AnimateTableProcced();
            }
        }

        // ANIMATED METHOD ================================================================
        private void ChangeBackground()
        {
            SetButtonsVisibility(false);
            panelSlide.Visible = false;
            panel3.Visible = false;
            int GoalLHeightWhitePanel = 1256;

            Thread thread = new Thread(() =>
            {
                int FirstWidthWhitePanel = 0;
                //=================================================

                while (FirstWidthWhitePanel < GoalLHeightWhitePanel)
                {
                    FirstWidthWhitePanel += 12;
                    Invoke((MethodInvoker)(() =>
                    {
                        WhitePanel.Width = FirstWidthWhitePanel;
                    }));

                    Thread.Sleep(2);
                }
                panel3.Visible = true;
                panelSlide.Visible = true;
                PleaseWaitLabel.Visible = false;
                Pbar.Visible = false;
                SetButtonsVisibility(true);
            });

            thread.IsBackground = true;
            thread.Start();
        }
        private void AnimateHandlePanelHide() {
            int GoalLocation = 1253;
            Thread thread = new Thread(() =>
            {
                int CurrentLoc = 291;
                while (CurrentLoc < GoalLocation) {
                    CurrentLoc += 12;
                        Invoke((MethodInvoker)(() => {

                            HandlePanel.Location = new Point(CurrentLoc, 70);

                        }));
                    Thread.Sleep(10);
                }
            });
            thread.IsBackground = true;
            thread.Start();
        }
        private void AnimateHandlePanelShow()
        {
            int GoalLocation = 291;
            Thread thread = new Thread(() =>
            {
                int CurrentLoc = 1253;
                while (CurrentLoc > GoalLocation)
                {
                    CurrentLoc -= 12;
                    Invoke((MethodInvoker)(() => {

                        HandlePanel.Location = new Point(CurrentLoc, 70);

                    }));
                    Thread.Sleep(10);
                }
            });
            thread.IsBackground = true;
            thread.Start();
        }
        private void AnimateTableProcced()
        {
            if (isUpdating)
            {
                PleaseWaitLabel.Text = "Updating, please wait...";
            }
            else {
                PleaseWaitLabel.Text = "Processing, please wait...";
            }
            BackButton.Enabled = false;
            ContinueButs.Enabled = false;
            int GoalSize = 20;
            int CloseSize = 635;
            int progressMax = 100;
            Thread thread = new Thread(() =>
            {
                int currentSize = panelSlide.Width;

                while (currentSize > GoalSize)
                {
                    currentSize -= 6;
                    Invoke((MethodInvoker)(() =>
                    {
                        panelSlide.Width = currentSize;
                    }));
                    Thread.Sleep(1);
                }
                Invoke((MethodInvoker)(() =>
                {
                    panelSlide.BringToFront();
                }));

                while (currentSize < CloseSize)
                {
                    currentSize += 6;
                    Invoke((MethodInvoker)(() =>
                    {
                        panelSlide.Width = currentSize;
                    }));
                    Thread.Sleep(1);
                }
                PleaseWaitLabel.Visible = true;
                Pbar.Visible = true;
                int minumum = 0;
                while (minumum < progressMax)
                {
                    minumum += 1;
                    Invoke((MethodInvoker)(() =>
                    {
                        Pbar.Value = minumum;

                        if (Pbar.Value == 80) PleaseWaitLabel.Text = "Opening the next form...";

                    }));
                    Thread.Sleep(30);
                }

                Invoke((MethodInvoker)(() =>
                {
                    this.Hide();
                    Perform perform = new Perform(this);
                    perform.SetProcessList(processList);
                    perform.Show();
                    perform.ShowTable();
                    perform.animatedOpenTable();
                    isUpdating = true;
                }));

            });
            thread.Start();
        }
        public void AnimateTableBack()
        {     
            PleaseWaitLabel.Visible = false;
            Pbar.Visible = false;
            int GoalSize = 20;
            int CloseSize = 635;
            Thread thread = new Thread(() => {
                int currentSize = panelSlide.Width;
                
                while (currentSize > GoalSize)
                {
                    currentSize -= 6;
                    Invoke((MethodInvoker)(() => {
                        panelSlide.Width = currentSize;
                    }));
                    Thread.Sleep(1);
                }
                Invoke((MethodInvoker)(() => {
                   
                    panelSlide.SendToBack();
                    panel3.SendToBack();
                }));

                while (currentSize < CloseSize)
                {
                    currentSize += 6;
                    Invoke((MethodInvoker)(() => {
                        panelSlide.Width = currentSize;
                    }));
                    Thread.Sleep(1);
                }

                BackButton.Enabled = true;
                ContinueButs.Enabled = true;
            });
            thread.Start();
        }
    }
}
