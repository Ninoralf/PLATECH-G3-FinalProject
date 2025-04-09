using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace PlatechFCFSProdject
{
    public partial class Perform : Form
    {
        ProcessList pList = new ProcessList();
        private bool isToOpenTable = false;
        private InputProcess input;
        private bool isGranttChartOpen = false;
        private bool isTableTop = false;
        private bool isTableUp = false;
        public Perform(InputProcess inputProcess)
        {
            InitializeComponent();
            ShowTable();
            this.input = inputProcess;
        }

        // HELPER METHOD ===============================================================================
        public void SetProcessList(List<Process> process)
        {
            pList.processList = process; // set processList to Process
        }
        public void ShowTable()
        {
            panel1.Visible = true; // set Visible True

            Panel[] arrayPanel = new Panel[pList.processList.Count];

            Panel header = new Panel
            {
                Width = panel1.Width - 25,
                Height = 40,
                Location = new Point(10, 0),
            };

            for (int i = 0; i < pList.processList.Count; i++)
            {
                string[] headers = { "Process ID", "CPU Burst Time", "Arrival Time" };
                for (int j = 0; j < headers.Length; j++)
                {   
                    // SET LABEL HEADER
                    Label lbl = new Label
                    {
                        Text = headers[j],
                        Width = (header.Width / 3),
                        Location = new Point(j * (header.Width / 3), 10),
                        TextAlign = ContentAlignment.MiddleCenter,
                        Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0),
                    };
                    header.Controls.Add(lbl);
                }

                panel1.Controls.Add(header);
                // ROW PANEL 
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
                    // 3 TEXTBOX OF THE ROW PANEL
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
                    // SET PROCESS ID LABEL IN FIRST TEXTBOX, AND SO ON..
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
                    row.Controls.Add(txt); // ADD TO ROW PANEL
                }

                panel1.Controls.Add(row); // ROW PANEL ADD TO PANEL1 THE MAIN
            }
            panel1.Height = Math.Min(pList.processList.Count * 60 + 15, this.ClientSize.Height - 410);
            panelTable.Height = Math.Min(pList.processList.Count * 60 + 50, this.ClientSize.Height - 390);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit(); // EXIT PROGRAM
        }
        private void GenerateGanttChart()
        {   
            // SORTING LOOP
            for (int i = 0; i < pList.processList.Count - 1; i++)
            {
                for (int j = i + 1; j < pList.processList.Count; j++)
                {
                    bool shouldSwap = false;

                    float arrival1 = pList.processList[i].ArrivalTime;
                    float arrival2 = pList.processList[j].ArrivalTime;

                    float burst1 = pList.processList[i].BurstTime;
                    float burst2 = pList.processList[j].BurstTime;

                    // IF ARRIVAL PNo. IS GREATER THAN TO ANOTHER PNo
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

                    // THEN SWAP
                    if (shouldSwap)
                    {   
                        // MAKE A TEMP PROCESS. 
                        Process temp = pList.processList[i];
                        pList.processList[i] = pList.processList[j];
                        pList.processList[j] = temp;
                    }
                }
            }

            ganttChartPanel.Controls.Clear(); // CLEAR THE GANTCHART SO THAT IT WILL APPLY CLEARLY
            int countHighBurstTime = 0;
            foreach (var list in pList.processList)
            {
                // IF THE BURST TIME AND ARRIVAL TIME GREATER THAN 13 THEN ADJUST THE WIDTH
                if (list.BurstTime >= 13 && list.ArrivalTime >= 13) {
                    countHighBurstTime++;
                }
            }
            
            int sizeOfWidth = 0;
            if (countHighBurstTime == 5) sizeOfWidth = 13;
            else sizeOfWidth = 15;
            
            float x = 0;
            float currentTime = 0f;

            foreach (var proc in pList.processList)
            {   
                // THIS IS FOR STARTING PROCESS NO.
                if (currentTime < proc.ArrivalTime)
                {
                    float EmptyDuration = proc.ArrivalTime - currentTime;
                    AddGanttBox("Empty", x, EmptyDuration * sizeOfWidth, Color.Gray, sizeOfWidth);
                    x += EmptyDuration * sizeOfWidth;
                    currentTime = proc.ArrivalTime;
                }

                // FOR BURST TIME
                float width = proc.BurstTime * sizeOfWidth; 
                float StartTime;
                if (sizeOfWidth == 13) StartTime = x / 13f;
                else StartTime = x / 15f;
                
                proc.StartTime = StartTime; 
                AddGanttBox(proc.ProcessID, x, width, Color.Teal , sizeOfWidth);
                x += width; 
                currentTime += proc.BurstTime;
                proc.CompletionTime = currentTime; 
            }

            float endTime = currentTime; 
            float endPoint = endTime * sizeOfWidth;
            Label timeEndLabel = new Label
            {
                BackColor = Color.Transparent,
                Text = endTime % 1 == 0 ? ((int)endTime).ToString() : endTime.ToString("0.##"),
                Location = new Point((int)endPoint, 115),
                Font = new Font("Verdana", 10F, FontStyle.Bold),
                AutoSize = true
            };
            ganttChartPanel.Controls.Add(timeEndLabel);
        }
        private void AddGanttBox(string label, float x, float width, Color color, int sizeOfWidth)
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

            float time = x / 15f;
            if (sizeOfWidth == 13) time = x / 13f;
            else time = x / 15f;

            Label timeLabel = new Label
                {
                    Text = time % 1 == 0 ? ((int)time).ToString() : time.ToString("0.##"),
                    Location = new Point((int)x, 115),
                    BackColor = Color.Transparent,
                    Font = new Font("Verdana", 10F, FontStyle.Bold),
                    AutoSize = true
                };
            ganttChartPanel.Controls.Add(timeLabel);
        }
        private void ClickedButton(Krypton.Toolkit.KryptonButton ActiveButtons, params Krypton.Toolkit.KryptonButton[] buttons)
        {
            ActiveButtons.Enabled = false;
            ActiveButtons.OverrideDefault.Back.Color1 = Color.Transparent;
            ActiveButtons.OverrideDefault.Back.Color2 = Color.FromArgb(64, 64, 64);
            ActiveButtons.OverrideDefault.Back.ColorAngle = 5F;
            ActiveButtons.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Rounding5;
            ActiveButtons.OverrideDefault.Border.Color1 = Color.White;
            ActiveButtons.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Right;


            foreach (var defaultButt in buttons)
            {
                defaultButt.Enabled = true;
                defaultButt.OverrideDefault.Back.Color1 = Color.Gray;
                defaultButt.OverrideDefault.Back.Color2 = Color.Transparent;
                defaultButt.OverrideDefault.Back.ColorAngle = 5F;
                defaultButt.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.ExpertSquareHighlight2;
                defaultButt.OverrideDefault.Border.Color1 = Color.Black;
                defaultButt.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
                defaultButt.OverrideDefault.Border.Width = 1;
            }
        }
        private void ReArrangeProcessNo()
        {
            // reArrange / Back To Normal -> Ex. P1 to P5: WE USE SORTING IN GenerateGanttChart(). THIS IS FOR BACK TO NORMAL
            for (int i = 0; i < pList.processList.Count - 1; i++)
            {
                for (int j = i + 1; j < pList.processList.Count; j++)
                {
                    int num1 = int.Parse(pList.processList[i].ProcessID.Substring(1));
                    int num2 = int.Parse(pList.processList[j].ProcessID.Substring(1));

                    if (num1 > num2)
                    {
                        Process temp = pList.processList[i];
                        pList.processList[i] = pList.processList[j];
                        pList.processList[j] = temp;
                    }
                }
            }
        }
        private void AverageDisplay(string title, float totalAver)
        {     
            AnimatedAverageDisplay();
            string TextResult = "(";

            for (int i = 0; i < pList.processList.Count; i++)
            {
                var Plist = pList.processList[i];
                if (title == "AWT") TextResult += $"{(Plist.PWT % 1 == 0 ? Plist.PWT.ToString("0") : Plist.PWT.ToString("F"))}";
                else if (title == "ACT") TextResult += $"{(Plist.PCT % 1 == 0 ? Plist.PCT.ToString("0") : Plist.PCT.ToString("F"))}";
                else TextResult += $"{(Plist.PTAT % 1 == 0 ? Plist.PTAT.ToString("0") : Plist.PTAT.ToString("F"))}";
                if (i < pList.processList.Count - 1)
                {
                    TextResult += " + ";
                }
            }
            TextResult += ")";

            Invoke((MethodInvoker)(() => {
                AverageDisplays.Controls.Clear();

                int startX = 14; // Start with Location of X to 14

                Label TitleProcess = new Label
                {
                    AutoSize = true,
                    Font = new Font("Sans Serif Collection", 8F, FontStyle.Bold),
                    Location = new Point(startX, 18),
                    Text = $"{title}:"
                };
                AverageDisplays.Controls.Add(TitleProcess);
                startX += TitleProcess.Width + 10; // 10 is the Gap or Space Before Displaying the Msec.

                Label displayMsec = new Label
                {
                    AutoSize = true,
                    Font = new Font("Verdana", 14F, FontStyle.Bold),
                    ForeColor = Color.Black,
                    Location = new Point(startX, 13),
                    Text = TextResult,
                    TextAlign = ContentAlignment.TopCenter
                };
                AverageDisplays.Controls.Add(displayMsec);
                startX += displayMsec.Width + 10;

                Label DivideProcess = new Label
                {
                    AutoSize = true,
                    Font = new Font("Verdana", 20F, FontStyle.Bold),
                    ForeColor = Color.Black,
                    Location = new Point(startX, 13),
                    Text = $"/ {pList.processList.Count} =",
                    TextAlign = ContentAlignment.TopCenter
                };
                AverageDisplays.Controls.Add(DivideProcess);
                startX += DivideProcess.Width + 10;

                Label TotalAverage = new Label
                {
                    AutoSize = true,
                    Font = new Font("Verdana", 20F, FontStyle.Bold),
                    ForeColor = Color.Black,
                    Location = new Point(startX, 13),
                    Text = $"{(totalAver % 1 == 0 ? totalAver.ToString("0") : totalAver.ToString("F"))} msec.",
                    TextAlign = ContentAlignment.TopCenter
                };
                AverageDisplays.Controls.Add(TotalAverage); 
            }));
        }
        private void displayMsec(string title)
        {

            if (!isTableTop)
            {
                animateTableToUp();
                isTableTop = true;
            }

            AnimatedDisplayMsec();
            if (title == "PWT")
            {
                foreach (var proc in pList.processList)
                {
                    float PWTPno = proc.StartTime - proc.ArrivalTime;
                    proc.PWT = PWTPno;
                    AverOfWT += proc.PWT;
                }
            }
            else if (title == "PCT")
            {
                foreach (var proc in pList.processList)
                {
                    float PCTPno = proc.CompletionTime - proc.ArrivalTime;
                    proc.PCT = PCTPno;
                    AverOfCT += proc.PCT;
                }
            }
            else
            {
                foreach (var proc in pList.processList)
                {
                    float PATATPno = proc.CompletionTime - proc.ArrivalTime;
                    proc.PTAT = PATATPno;
                    AverTAT += proc.PTAT;
                }
            }

            int currentWidth = 94;
            int AddWidth = 154;
            Invoke((MethodInvoker)(() => {
                ProcessDisplay.Controls.Clear();
                Label TitleProcess = new Label
                {
                    AutoSize = true,
                    Font = new Font("Sans Serif Collection", 8F, FontStyle.Bold, GraphicsUnit.Point, 0),
                    Location = new Point(14, 18),
                    Size = new Size(70, 47),
                    TabIndex = 0,
                    Text = $"{title}:"
                };
                ProcessDisplay.Controls.Add(TitleProcess);

                for (int i = 0; i < pList.processList.Count; i++)
                {
                    var Plist = pList.processList[i];
                    Label Pno = new Label
                    {
                        Font = new Font("Sans Serif Collection", 12F, FontStyle.Bold, GraphicsUnit.Point, 0),
                        Location = new Point(currentWidth, 12),
                        Size = new Size(155, 27),
                        Text = title == "PWT" ? $"{Plist.ProcessID}: {(Plist.PWT % 1 == 0 ? Plist.PWT.ToString("0") : Plist.PWT.ToString("F"))} msec" :
                               title == "PCT" ? $"{Plist.ProcessID}: {(Plist.PCT % 1 == 0 ? Plist.PCT.ToString("0") : Plist.PCT.ToString("F"))} msec" :
                               $"{Plist.ProcessID}: {(Plist.PTAT % 1 == 0 ? Plist.PTAT.ToString("0") : Plist.PTAT.ToString("F"))} msec"
                    };

                    currentWidth += AddWidth;

                    ProcessDisplay.Controls.Add(Pno);
                }
            }));
        }
        private void EnableButtons(bool isEnable,params Krypton.Toolkit.KryptonButton[] buttons) {
            foreach (var butt in buttons) {
                butt.Enabled = isEnable;
            }
        }
        // CLICKABLE BUTTONS METHOD ===================================================================
        private void BackButton_Click(object sender, EventArgs e)
        {
            if (isGranttChartOpen && !isTableTop)
            {
                closeGanttChart();
                animatedCloseTable();
            }
            else if (isTableTop)
            {
                CloseAverDisAndProcDis(true);
                closeGanttChart();
                animatedCloseTable();
            }
            else {
                animatedCloseTable();
            }
         
        }
        private void ShowTablesButt_Click(object sender, EventArgs e)
        {
            if (!isToOpenTable)
            {
                panelTable.Visible = false;
                ShowTablesButt.Text = "Show table";
                isToOpenTable = true;
            }
            else
            {
                panelTable.Visible = true;
                ShowTablesButt.Text = "Hide table";
                isToOpenTable = false;
            }
        }
        private void OpenButton_Click(object sender, EventArgs e)
        {
            isGranttChartOpen = false;
            Invoke((MethodInvoker)(() => {
                ClickedButton(GanttChartButt, AWTButt, PCTButt, ACTButt, PTATButt, ATATButt, PWTButt);
                GanttChartButt.Enabled = true;
                CloseAverDisAndProcDis(true);
            }));
            closeGanttChart();
        }
        private void GanttChart_Click(object sender, EventArgs e)
        {
            EnableButtons(false, PWTButt, AWTButt, PCTButt, ACTButt, PTATButt, ATATButt);
            isGranttChartOpen = true;
            panelPerformFindClose();
        }
        // PWT ========================================================================================
        float AverOfWT = 0;
        bool isOpenPWT = false;
        private void PWTButt_Click(object sender, EventArgs e)
        {
            if (isGranttChartOpen)
            {
                isOpenPWT = false; 
                isOpenPCT = false;
                isOpenPWT = true;
                AverOfWT = AverOfCT = AverTAT = 0; // reset the value
                ClickedButton(PWTButt, AWTButt, PCTButt, ACTButt, PTATButt, ATATButt, GanttChartButt); 
                CloseAverDisAndProcDis(false);
                ReArrangeProcessNo();
                displayMsec("PWT");
            }
            else {
                MessageBox.Show($"Show the Gantt Chart first. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void AWTButt_Click(object sender, EventArgs e)
        {
            if (isGranttChartOpen && isOpenPWT)
            {
                ClickedButton(AWTButt, PWTButt, PCTButt, ACTButt, PTATButt, ATATButt, GanttChartButt);
                float TotalAverWT = AverOfWT / pList.processList.Count();
                AverageDisplay("AWT", TotalAverWT);
                isOpenPWT = false;
            }
            else
            {
                if (!isOpenPWT && isGranttChartOpen)
                {
                    MessageBox.Show($"Open the Process Waiting Time first. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else {
                    MessageBox.Show($"Show the Gantt Chart first. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
             
            }
           
        }

        // PCT ========================================================================================
        float AverOfCT = 0;
        bool isOpenPCT = false;
        private void PCTButt_Click(object sender, EventArgs e)
        {

            if (isGranttChartOpen)
            {
                isOpenPWT = false;
                isOpenPTAT = false;
                isOpenPCT = true;
                AverOfWT = AverOfCT = AverTAT = 0; // reset the value
                ClickedButton(PCTButt, AWTButt, PWTButt, ACTButt, PTATButt, ATATButt, GanttChartButt);
                CloseAverDisAndProcDis(false);
                ReArrangeProcessNo();
                displayMsec("PCT");
            }
            else
            {
                MessageBox.Show($"Show the Gantt Chart first. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            
        }
        private void ACTButt_Click(object sender, EventArgs e)
        {
            if (isGranttChartOpen && isOpenPCT)
            {
                ClickedButton(ACTButt, AWTButt, PCTButt, PWTButt, PTATButt, ATATButt, GanttChartButt);

                float TotalAverCT = AverOfCT / pList.processList.Count();
                AverageDisplay("ACT", TotalAverCT);
                isOpenPCT = false;
            }
            else
            {
                if (!isOpenPCT && isGranttChartOpen)
                {
                    MessageBox.Show($"Open the Process Complete Time first. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else {
                    MessageBox.Show($"Show the Gantt Chart first. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
           
        }

        // PTAT =======================================================================================
        float AverTAT = 0;
        bool isOpenPTAT = false;
        private void PTATButt_Click(object sender, EventArgs e)
        {
            if (isGranttChartOpen)
            {
                isOpenPWT = false;
                isOpenPCT = false;
                isOpenPTAT = true;
                AverOfWT = AverOfCT = AverTAT = 0; // reset the value
                ClickedButton(PTATButt, AWTButt, PCTButt, ACTButt, PWTButt, ATATButt, GanttChartButt);
                CloseAverDisAndProcDis(false);
                ReArrangeProcessNo();
                displayMsec("PTAT");
            }
            else
            {
                MessageBox.Show($"Show the Gantt Chart first. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
           
        }
        private void ATATButt_Click(object sender, EventArgs e)
        {
            if (isGranttChartOpen && isOpenPTAT)
            {
                ClickedButton(ATATButt, AWTButt, PCTButt, ACTButt, PWTButt, PTATButt, GanttChartButt);
                float PATATPno = AverTAT / pList.processList.Count();
                AverageDisplay("ATAT", PATATPno);
                AverOfWT = 0;
                AverOfCT = 0;
                AverTAT = 0;
                isOpenPTAT = false;
            }
            else
            {
                if (!isOpenPTAT && isGranttChartOpen)
                {
                    MessageBox.Show($"Open the Process Turn Around Time first. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show($"Show the Gantt Chart first. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }

        }
        
        // ANIMATED METHOD ============================================================================
        private void displayGanttChart() {
            OpenButton.Enabled = false;
            int WidthGoal = 1222;
            Thread thread = new Thread(() => {
                int CurrentWidth = ganttChartPanel.Width;

                while (CurrentWidth < WidthGoal) {
                    CurrentWidth += 12;
                    Invoke((MethodInvoker)(() => {
                        ganttChartPanel.Width = CurrentWidth;
                    }));
                    Thread.Sleep(2);
                }
                Invoke((MethodInvoker)(() =>
                {
                    OpenButton.Enabled = true;
                    EnableButtons(true, PWTButt, AWTButt, PCTButt, ACTButt, PTATButt, ATATButt);
                }));

            });
            thread.Start();
            
        }
        private void closeGanttChart()
        {
            OpenButton.Enabled = false;
            int WidthGoal = 0;
            Thread thread = new Thread(() => {
                int CurrentWidth = ganttChartPanel.Width ;

                while (CurrentWidth > WidthGoal)
                {
                    CurrentWidth -= 12;
                    Invoke((MethodInvoker)(() => {
                        ganttChartPanel.Width = CurrentWidth;
                    }));

                    Thread.Sleep(2);
                }
               
                
                Invoke((MethodInvoker)(() =>
                {
                    animatePanel4Open();
                    OpenButton.Enabled = true;
                    
                }));
            });
            thread.Start();
          

        }
        private void panelPerformFindClose()
        {
            GanttChartButt.Visible = false;
            int GoalWidthSize = 30;
            Thread thread = new Thread(() =>
            {
                int CurrentWidthSize = GanttchartP.Width;

                while (CurrentWidthSize > GoalWidthSize)
                {
                    CurrentWidthSize -= 6;

                    Invoke((MethodInvoker)(() =>
                    {

                        GanttchartP.Width = CurrentWidthSize;
                    }));
                    Thread.Sleep(10);
                }
                Invoke((MethodInvoker)(() =>
                {
                    animatePanel4();
                }));
            });
            thread.Start();
           
        }
        private void panelPerformFindOPen()
        {   
            int GoalWidthSize = 354;
            Thread thread = new Thread(() =>
            {
                int CurrentSize = 30;
                while (CurrentSize < GoalWidthSize)
                {
                    CurrentSize += 6;

                    Invoke((MethodInvoker)(() =>
                    {
                        GanttchartP.Width = CurrentSize;

                    }));
                    Thread.Sleep(10);
                }
                Invoke((MethodInvoker)(() =>
                {

                    GanttChartButt.Visible = true;
     
                }));
            });
            thread.Start();
        }
        private void AnimatedDisplayMsec() {
            int goalWidth = 849;
            Thread thread = new Thread(() => {
                int currentWidth = 0;

                while (currentWidth < goalWidth)
                {
                    currentWidth += 12;

                    Invoke((MethodInvoker)(() =>
                    {
                        ProcessDisplay.Width = currentWidth;
                    }));

                    Thread.Sleep(6);
                } 
            });
            thread.Start();
        }
        private void AnimatedAverageDisplay()
        {   
            int goalWidth = 849;
            Thread thread = new Thread(() => {
                int currentWidth = 0;

                while (currentWidth < goalWidth)
                {
                    currentWidth += 12;

                    Invoke((MethodInvoker)(() =>
                    {
                        AverageDisplays.Width = currentWidth;
                    }));

                    Thread.Sleep(6);
                }
            });
            thread.Start();
        }
        private void CloseAverDisAndProcDis(bool isFromButtonGanttChart)
        {
            bool checker = false;
            int goalWidth = 0;
            Thread thread = new Thread(() => {
                int currentWidth = 849;

                while (currentWidth > goalWidth)
                {
                    currentWidth -= 12;

                    Invoke((MethodInvoker)(() =>
                    {
                        if (isFromButtonGanttChart && ProcessDisplay.Width != 0)
                        {
                            ProcessDisplay.Width = currentWidth;
                            if (AverageDisplays.Width != 0)
                            {
                                AverageDisplays.Width = currentWidth;
                            }
                            checker = true;
                        }
                        else {
                            if (AverageDisplays.Width != 0) {
                                AverageDisplays.Width = currentWidth;
                            } 
                        }
                    }));

                    Thread.Sleep(6);
                }
                if(isFromButtonGanttChart && checker)
                {
                    Invoke((MethodInvoker)(() => {
                        animateTableToDown();
                        isTableTop = false;
                    }));
                }
            });
            thread.Start();
        }
        private void animatePanel4() {
            int GoalHeight = 0;

            Thread thread = new Thread(() =>
            {
                int CurrentHeight = 177;
                while (CurrentHeight > GoalHeight)
                {
                    CurrentHeight -= 6;

                    Invoke((MethodInvoker)(() =>
                    {
                        panel4.Height = CurrentHeight;
                    }));
         
                    Thread.Sleep(20);
                }
                Invoke((MethodInvoker)(() =>
                {
                    OpenButton.Visible = true;
                    GenerateGanttChart();
                    displayGanttChart();
                }));
            });
            thread.Start();
        }
        private void animatePanel4Open()
        {
            int GoalHeight = 177;

            Thread thread = new Thread(() =>
            {
                int CurrentHeight = 0;
                while (CurrentHeight < GoalHeight)
                {
                    CurrentHeight += 6;

                    Invoke((MethodInvoker)(() =>
                    {
                        panel4.Height = CurrentHeight;
                    }));

                    Thread.Sleep(20);
                }
                Invoke((MethodInvoker)(() =>
                {
                    panelPerformFindOPen();
          
                }));
            });
            thread.Start();
        }
        private void animateTableToUp ()
        {
            int GoalLocation = 9;

            Thread thread = new Thread(() =>
            {
                int CurrentHeight = 72;
                while (CurrentHeight > GoalLocation)
                {
                    CurrentHeight -= 4;

                    Invoke((MethodInvoker)(() =>
                    {
                        panelTable.Location = new Point(202, CurrentHeight);
                    }));

                    Thread.Sleep(20);
                }

                isTableTop = true;
            });
            thread.Start();
        }
        private void animateTableToDown()
        {
            int GoalLocation = 72;

            Thread thread = new Thread(() =>
            {
                int CurrentHeight = 9;
                while (CurrentHeight < GoalLocation)
                {
                    CurrentHeight += 2;

                    Invoke((MethodInvoker)(() =>
                    {
                        panelTable.Location = new Point(202, CurrentHeight);
                    }));

                    Thread.Sleep(20);
                }
            });
            thread.Start();
        }

        public void animatedOpenTable() {
            ShowTablesButt.Enabled = false;
            GanttChartButt.Enabled = false;
            BackButton.Enabled = false;
            int GoalSize = 20;
            int CloseSize = 546;
            Thread thread = new Thread(() => {
                int currentSize = panel6.Width;

                while (currentSize > GoalSize)
                {
                    currentSize -= 5;
                    Invoke((MethodInvoker)(() =>
                    {
                        panel6.Width = currentSize;
                    }));
                    Thread.Sleep(1);
                }
                Invoke((MethodInvoker)(() =>
                {
                    panel6.SendToBack();
                    panel5.SendToBack();
                }));

                while (currentSize < CloseSize)
                {
                    currentSize += 5;
                    Invoke((MethodInvoker)(() =>
                    {
                        panel6.Width = currentSize;
                    }));
                    Thread.Sleep(1);
                }

                ShowTablesButt.Enabled = true;
                GanttChartButt.Enabled = true;
                BackButton.Enabled = true;
            });
            thread.Start();
        }

        public void animatedCloseTable()
        {
            int GoalSize = 20;
            int CloseSize = 546;
            Thread thread = new Thread(() => {
                int currentSize = panel6.Width;

                while (currentSize > GoalSize)
                {
                    currentSize -= 4;
                    Invoke((MethodInvoker)(() =>
                    {
                        panel6.Width = currentSize;
                    }));
                    Thread.Sleep(1);
                }
                Invoke((MethodInvoker)(() =>
                {
                    panel6.BringToFront();
                }));

                while (currentSize < CloseSize)
                {
                    currentSize += 4;
                    Invoke((MethodInvoker)(() =>
                    {
                        panel6.Width = currentSize;
                    }));
                    Thread.Sleep(1);
                }
                Invoke((MethodInvoker)(() =>
                {
                    this.Hide();
                    input.Show();
                    input.ResetProcessNo = true;
                    input.processList.Clear();
                    input.AnimateTableBack(); 

                }));
              
            });
            thread.Start();
        }
    }
    }
