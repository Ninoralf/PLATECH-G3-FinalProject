namespace PlatechFCFSProdject
{
    partial class Perform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel2 = new Panel();
            label2 = new Label();
            button1 = new Button();
            BackButton = new Button();
            panel1 = new Panel();
            ganttChartPanel = new Panel();
            ShowTablesButt = new Krypton.Toolkit.KryptonButton();
            panelTable = new Panel();
            panelPerformFind = new Panel();
            ATATButt = new Krypton.Toolkit.KryptonButton();
            PTATButt = new Krypton.Toolkit.KryptonButton();
            ACTButt = new Krypton.Toolkit.KryptonButton();
            PCTButt = new Krypton.Toolkit.KryptonButton();
            AWTButt = new Krypton.Toolkit.KryptonButton();
            PWTButt = new Krypton.Toolkit.KryptonButton();
            GanttChartButt = new Krypton.Toolkit.KryptonButton();
            OpenButton = new Button();
            GanttchartP = new Panel();
            label3 = new Label();
            panel3 = new Panel();
            panel6 = new Panel();
            AverageDisplays = new Panel();
            ProcessDisplay = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            label4 = new Label();
            label1 = new Label();
            panel2.SuspendLayout();
            panelTable.SuspendLayout();
            panelPerformFind.SuspendLayout();
            GanttchartP.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(BackButton);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1254, 40);
            panel2.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Verdana", 15F, FontStyle.Bold);
            label2.ForeColor = Color.Olive;
            label2.Location = new Point(379, 6);
            label2.Name = "label2";
            label2.Size = new Size(525, 25);
            label2.TabIndex = 5;
            label2.Text = "First Come First Serve (FCFS) CPU Scheduling";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources.exit_logo;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(1206, 5);
            button1.Name = "button1";
            button1.Size = new Size(36, 31);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.Transparent;
            BackButton.BackgroundImage = Properties.Resources.BackToProcess1;
            BackButton.BackgroundImageLayout = ImageLayout.Stretch;
            BackButton.FlatAppearance.BorderSize = 0;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Location = new Point(12, 6);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(43, 28);
            BackButton.TabIndex = 12;
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Location = new Point(9, 16);
            panel1.Name = "panel1";
            panel1.Size = new Size(486, 0);
            panel1.TabIndex = 7;
            // 
            // ganttChartPanel
            // 
            ganttChartPanel.BackColor = Color.Gainsboro;
            ganttChartPanel.BackgroundImage = Properties.Resources.SideBackground;
            ganttChartPanel.BackgroundImageLayout = ImageLayout.Stretch;
            ganttChartPanel.Location = new Point(29, 543);
            ganttChartPanel.Name = "ganttChartPanel";
            ganttChartPanel.Size = new Size(0, 161);
            ganttChartPanel.TabIndex = 8;
            // 
            // ShowTablesButt
            // 
            ShowTablesButt.Location = new Point(745, 222);
            ShowTablesButt.Name = "ShowTablesButt";
            ShowTablesButt.OverrideDefault.Back.Color1 = Color.FromArgb(224, 224, 224);
            ShowTablesButt.OverrideDefault.Back.Color2 = Color.White;
            ShowTablesButt.Size = new Size(98, 37);
            ShowTablesButt.StateCommon.Back.Color1 = Color.Gainsboro;
            ShowTablesButt.StateCommon.Back.Color2 = Color.White;
            ShowTablesButt.StateCommon.Border.Color1 = Color.Black;
            ShowTablesButt.StateCommon.Border.Rounding = 10F;
            ShowTablesButt.StateCommon.Content.ShortText.Color1 = Color.Black;
            ShowTablesButt.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ShowTablesButt.TabIndex = 9;
            ShowTablesButt.Values.DropDownArrowColor = Color.Empty;
            ShowTablesButt.Values.Text = "Hide table";
            ShowTablesButt.Click += ShowTablesButt_Click;
            // 
            // panelTable
            // 
            panelTable.BackColor = Color.FromArgb(64, 64, 64);
            panelTable.BorderStyle = BorderStyle.Fixed3D;
            panelTable.Controls.Add(panel1);
            panelTable.Location = new Point(202, 65);
            panelTable.Name = "panelTable";
            panelTable.Size = new Size(503, 300);
            panelTable.TabIndex = 10;
            // 
            // panelPerformFind
            // 
            panelPerformFind.BackColor = Color.Gainsboro;
            panelPerformFind.BackgroundImage = Properties.Resources.ReverseBackground;
            panelPerformFind.BackgroundImageLayout = ImageLayout.Stretch;
            panelPerformFind.Controls.Add(ATATButt);
            panelPerformFind.Controls.Add(PTATButt);
            panelPerformFind.Controls.Add(ACTButt);
            panelPerformFind.Controls.Add(PCTButt);
            panelPerformFind.Controls.Add(AWTButt);
            panelPerformFind.Controls.Add(PWTButt);
            panelPerformFind.Location = new Point(-1, 40);
            panelPerformFind.Name = "panelPerformFind";
            panelPerformFind.Size = new Size(353, 497);
            panelPerformFind.TabIndex = 11;
            // 
            // ATATButt
            // 
            ATATButt.Location = new Point(8, 435);
            ATATButt.Name = "ATATButt";
            ATATButt.OverrideDefault.Back.Color1 = Color.Gray;
            ATATButt.OverrideDefault.Back.Color2 = Color.Transparent;
            ATATButt.OverrideDefault.Back.ColorAngle = 5F;
            ATATButt.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.ExpertSquareHighlight2;
            ATATButt.OverrideDefault.Border.Color1 = Color.Black;
            ATATButt.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ATATButt.OverrideDefault.Border.Width = 1;
            ATATButt.OverrideFocus.Back.Color1 = Color.Transparent;
            ATATButt.Size = new Size(338, 49);
            ATATButt.StateCommon.Back.Color1 = Color.Gray;
            ATATButt.StateCommon.Back.Color2 = Color.Transparent;
            ATATButt.StateCommon.Back.ColorAngle = 5F;
            ATATButt.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.ExpertSquareHighlight2;
            ATATButt.StateCommon.Border.Color1 = Color.Black;
            ATATButt.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ATATButt.StateCommon.Border.Rounding = 10F;
            ATATButt.StateCommon.Border.Width = 1;
            ATATButt.StateCommon.Content.ShortText.Color1 = Color.Black;
            ATATButt.StateCommon.Content.ShortText.Color2 = Color.Transparent;
            ATATButt.StateCommon.Content.ShortText.Font = new Font("Verdana", 15F, FontStyle.Bold);
            ATATButt.StateDisabled.Back.Color1 = Color.White;
            ATATButt.StateDisabled.Back.Color2 = Color.DimGray;
            ATATButt.StateDisabled.Back.ColorAngle = 5F;
            ATATButt.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Rounding5;
            ATATButt.StateDisabled.Border.Color1 = Color.Black;
            ATATButt.StateDisabled.Border.Color2 = Color.White;
            ATATButt.StateDisabled.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Sigma;
            ATATButt.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Right;
            ATATButt.StateDisabled.Border.Rounding = 0F;
            ATATButt.StateDisabled.Border.Width = 15;
            ATATButt.StatePressed.Back.Color1 = Color.Transparent;
            ATATButt.StatePressed.Back.Color2 = Color.FromArgb(64, 64, 64);
            ATATButt.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Rounding5;
            ATATButt.StatePressed.Border.Color1 = Color.Black;
            ATATButt.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Right;
            ATATButt.StatePressed.Border.Width = 15;
            ATATButt.StateTracking.Back.Color1 = Color.White;
            ATATButt.StateTracking.Back.Color2 = Color.DimGray;
            ATATButt.StateTracking.Back.ColorAngle = 5F;
            ATATButt.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Rounding5;
            ATATButt.StateTracking.Border.Color1 = Color.Black;
            ATATButt.StateTracking.Border.Color2 = Color.White;
            ATATButt.StateTracking.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Sigma;
            ATATButt.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Right;
            ATATButt.StateTracking.Border.Rounding = 0F;
            ATATButt.StateTracking.Border.Width = 15;
            ATATButt.TabIndex = 12;
            ATATButt.Values.DropDownArrowColor = Color.Empty;
            ATATButt.Values.Text = "Average Turn Around Time";
            ATATButt.Click += ATATButt_Click;
            // 
            // PTATButt
            // 
            PTATButt.Location = new Point(8, 355);
            PTATButt.Name = "PTATButt";
            PTATButt.OverrideDefault.Back.Color1 = Color.Gray;
            PTATButt.OverrideDefault.Back.Color2 = Color.Transparent;
            PTATButt.OverrideDefault.Back.ColorAngle = 5F;
            PTATButt.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.ExpertSquareHighlight2;
            PTATButt.OverrideDefault.Border.Color1 = Color.Black;
            PTATButt.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            PTATButt.OverrideDefault.Border.Width = 1;
            PTATButt.OverrideFocus.Back.Color1 = Color.Transparent;
            PTATButt.Size = new Size(338, 49);
            PTATButt.StateCommon.Back.Color1 = Color.Gray;
            PTATButt.StateCommon.Back.Color2 = Color.Transparent;
            PTATButt.StateCommon.Back.ColorAngle = 5F;
            PTATButt.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.ExpertSquareHighlight2;
            PTATButt.StateCommon.Border.Color1 = Color.Black;
            PTATButt.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            PTATButt.StateCommon.Border.Rounding = 10F;
            PTATButt.StateCommon.Border.Width = 1;
            PTATButt.StateCommon.Content.ShortText.Color1 = Color.Black;
            PTATButt.StateCommon.Content.ShortText.Color2 = Color.Transparent;
            PTATButt.StateCommon.Content.ShortText.Font = new Font("Verdana", 15F, FontStyle.Bold);
            PTATButt.StateDisabled.Back.Color1 = Color.White;
            PTATButt.StateDisabled.Back.Color2 = Color.DimGray;
            PTATButt.StateDisabled.Back.ColorAngle = 5F;
            PTATButt.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Rounding5;
            PTATButt.StateDisabled.Border.Color1 = Color.Black;
            PTATButt.StateDisabled.Border.Color2 = Color.White;
            PTATButt.StateDisabled.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Sigma;
            PTATButt.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Right;
            PTATButt.StateDisabled.Border.Rounding = 0F;
            PTATButt.StateDisabled.Border.Width = 15;
            PTATButt.StatePressed.Back.Color1 = Color.Transparent;
            PTATButt.StatePressed.Back.Color2 = Color.FromArgb(64, 64, 64);
            PTATButt.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Rounding5;
            PTATButt.StatePressed.Border.Color1 = Color.Black;
            PTATButt.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Right;
            PTATButt.StatePressed.Border.Width = 15;
            PTATButt.StateTracking.Back.Color1 = Color.White;
            PTATButt.StateTracking.Back.Color2 = Color.DimGray;
            PTATButt.StateTracking.Back.ColorAngle = 5F;
            PTATButt.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Rounding5;
            PTATButt.StateTracking.Border.Color1 = Color.Black;
            PTATButt.StateTracking.Border.Color2 = Color.White;
            PTATButt.StateTracking.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Sigma;
            PTATButt.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Right;
            PTATButt.StateTracking.Border.Rounding = 0F;
            PTATButt.StateTracking.Border.Width = 15;
            PTATButt.TabIndex = 11;
            PTATButt.Values.DropDownArrowColor = Color.Empty;
            PTATButt.Values.Text = "Process Turn Around Time";
            PTATButt.Click += PTATButt_Click;
            // 
            // ACTButt
            // 
            ACTButt.Location = new Point(8, 274);
            ACTButt.Name = "ACTButt";
            ACTButt.OverrideDefault.Back.Color1 = Color.Gray;
            ACTButt.OverrideDefault.Back.Color2 = Color.Transparent;
            ACTButt.OverrideDefault.Back.ColorAngle = 5F;
            ACTButt.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.ExpertSquareHighlight2;
            ACTButt.OverrideDefault.Border.Color1 = Color.Black;
            ACTButt.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ACTButt.OverrideDefault.Border.Width = 1;
            ACTButt.OverrideFocus.Back.Color1 = Color.Transparent;
            ACTButt.Size = new Size(338, 49);
            ACTButt.StateCommon.Back.Color1 = Color.Gray;
            ACTButt.StateCommon.Back.Color2 = Color.Transparent;
            ACTButt.StateCommon.Back.ColorAngle = 5F;
            ACTButt.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.ExpertSquareHighlight2;
            ACTButt.StateCommon.Border.Color1 = Color.Black;
            ACTButt.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ACTButt.StateCommon.Border.Rounding = 10F;
            ACTButt.StateCommon.Border.Width = 1;
            ACTButt.StateCommon.Content.ShortText.Color1 = Color.Black;
            ACTButt.StateCommon.Content.ShortText.Color2 = Color.Transparent;
            ACTButt.StateCommon.Content.ShortText.Font = new Font("Verdana", 15F, FontStyle.Bold);
            ACTButt.StateDisabled.Back.Color1 = Color.White;
            ACTButt.StateDisabled.Back.Color2 = Color.DimGray;
            ACTButt.StateDisabled.Back.ColorAngle = 5F;
            ACTButt.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Rounding5;
            ACTButt.StateDisabled.Border.Color1 = Color.Black;
            ACTButt.StateDisabled.Border.Color2 = Color.White;
            ACTButt.StateDisabled.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Sigma;
            ACTButt.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Right;
            ACTButt.StateDisabled.Border.Rounding = 0F;
            ACTButt.StateDisabled.Border.Width = 15;
            ACTButt.StatePressed.Back.Color1 = Color.Transparent;
            ACTButt.StatePressed.Back.Color2 = Color.FromArgb(64, 64, 64);
            ACTButt.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Rounding5;
            ACTButt.StatePressed.Border.Color1 = Color.Black;
            ACTButt.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Right;
            ACTButt.StatePressed.Border.Width = 15;
            ACTButt.StateTracking.Back.Color1 = Color.White;
            ACTButt.StateTracking.Back.Color2 = Color.DimGray;
            ACTButt.StateTracking.Back.ColorAngle = 5F;
            ACTButt.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Rounding5;
            ACTButt.StateTracking.Border.Color1 = Color.Black;
            ACTButt.StateTracking.Border.Color2 = Color.White;
            ACTButt.StateTracking.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Sigma;
            ACTButt.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Right;
            ACTButt.StateTracking.Border.Rounding = 0F;
            ACTButt.StateTracking.Border.Width = 15;
            ACTButt.TabIndex = 10;
            ACTButt.Values.DropDownArrowColor = Color.Empty;
            ACTButt.Values.Text = "Average Completion Time";
            ACTButt.Click += ACTButt_Click;
            // 
            // PCTButt
            // 
            PCTButt.Location = new Point(8, 191);
            PCTButt.Name = "PCTButt";
            PCTButt.OverrideDefault.Back.Color1 = Color.Gray;
            PCTButt.OverrideDefault.Back.Color2 = Color.Transparent;
            PCTButt.OverrideDefault.Back.ColorAngle = 5F;
            PCTButt.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.ExpertSquareHighlight2;
            PCTButt.OverrideDefault.Border.Color1 = Color.Black;
            PCTButt.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            PCTButt.OverrideDefault.Border.Width = 1;
            PCTButt.OverrideFocus.Back.Color1 = Color.Transparent;
            PCTButt.Size = new Size(338, 49);
            PCTButt.StateCommon.Back.Color1 = Color.Gray;
            PCTButt.StateCommon.Back.Color2 = Color.Transparent;
            PCTButt.StateCommon.Back.ColorAngle = 5F;
            PCTButt.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.ExpertSquareHighlight2;
            PCTButt.StateCommon.Border.Color1 = Color.Black;
            PCTButt.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            PCTButt.StateCommon.Border.Rounding = 10F;
            PCTButt.StateCommon.Border.Width = 1;
            PCTButt.StateCommon.Content.ShortText.Color1 = Color.Black;
            PCTButt.StateCommon.Content.ShortText.Color2 = Color.Transparent;
            PCTButt.StateCommon.Content.ShortText.Font = new Font("Verdana", 15F, FontStyle.Bold);
            PCTButt.StateDisabled.Back.Color1 = Color.White;
            PCTButt.StateDisabled.Back.Color2 = Color.DimGray;
            PCTButt.StateDisabled.Back.ColorAngle = 5F;
            PCTButt.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Rounding5;
            PCTButt.StateDisabled.Border.Color1 = Color.Black;
            PCTButt.StateDisabled.Border.Color2 = Color.White;
            PCTButt.StateDisabled.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Sigma;
            PCTButt.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Right;
            PCTButt.StateDisabled.Border.Rounding = 0F;
            PCTButt.StateDisabled.Border.Width = 15;
            PCTButt.StatePressed.Back.Color1 = Color.Transparent;
            PCTButt.StatePressed.Back.Color2 = Color.FromArgb(64, 64, 64);
            PCTButt.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Rounding5;
            PCTButt.StatePressed.Border.Color1 = Color.Black;
            PCTButt.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Right;
            PCTButt.StatePressed.Border.Width = 15;
            PCTButt.StateTracking.Back.Color1 = Color.White;
            PCTButt.StateTracking.Back.Color2 = Color.DimGray;
            PCTButt.StateTracking.Back.ColorAngle = 5F;
            PCTButt.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Rounding5;
            PCTButt.StateTracking.Border.Color1 = Color.Black;
            PCTButt.StateTracking.Border.Color2 = Color.White;
            PCTButt.StateTracking.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Sigma;
            PCTButt.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Right;
            PCTButt.StateTracking.Border.Rounding = 0F;
            PCTButt.StateTracking.Border.Width = 15;
            PCTButt.TabIndex = 9;
            PCTButt.Values.DropDownArrowColor = Color.Empty;
            PCTButt.Values.Text = "Process Completion Time";
            PCTButt.Click += PCTButt_Click;
            // 
            // AWTButt
            // 
            AWTButt.Location = new Point(8, 106);
            AWTButt.Name = "AWTButt";
            AWTButt.OverrideDefault.Back.Color1 = Color.Gray;
            AWTButt.OverrideDefault.Back.Color2 = Color.Transparent;
            AWTButt.OverrideDefault.Back.ColorAngle = 5F;
            AWTButt.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.ExpertSquareHighlight2;
            AWTButt.OverrideDefault.Border.Color1 = Color.Black;
            AWTButt.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            AWTButt.OverrideDefault.Border.Rounding = 10F;
            AWTButt.OverrideDefault.Border.Width = 1;
            AWTButt.OverrideFocus.Back.Color1 = Color.Transparent;
            AWTButt.Size = new Size(338, 49);
            AWTButt.StateCommon.Back.Color1 = Color.Gray;
            AWTButt.StateCommon.Back.Color2 = Color.Transparent;
            AWTButt.StateCommon.Back.ColorAngle = 5F;
            AWTButt.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.ExpertSquareHighlight2;
            AWTButt.StateCommon.Border.Color1 = Color.Black;
            AWTButt.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            AWTButt.StateCommon.Border.Rounding = 10F;
            AWTButt.StateCommon.Border.Width = 1;
            AWTButt.StateCommon.Content.ShortText.Color1 = Color.Black;
            AWTButt.StateCommon.Content.ShortText.Color2 = Color.Transparent;
            AWTButt.StateCommon.Content.ShortText.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AWTButt.StateDisabled.Back.Color1 = Color.White;
            AWTButt.StateDisabled.Back.Color2 = Color.DimGray;
            AWTButt.StateDisabled.Back.ColorAngle = 5F;
            AWTButt.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Rounding5;
            AWTButt.StateDisabled.Border.Color1 = Color.Black;
            AWTButt.StateDisabled.Border.Color2 = Color.White;
            AWTButt.StateDisabled.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Sigma;
            AWTButt.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Right;
            AWTButt.StateDisabled.Border.Rounding = 0F;
            AWTButt.StateDisabled.Border.Width = 15;
            AWTButt.StatePressed.Back.Color1 = Color.Transparent;
            AWTButt.StatePressed.Back.Color2 = Color.FromArgb(64, 64, 64);
            AWTButt.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Rounding5;
            AWTButt.StatePressed.Border.Color1 = Color.Black;
            AWTButt.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Right;
            AWTButt.StatePressed.Border.Width = 15;
            AWTButt.StateTracking.Back.Color1 = Color.White;
            AWTButt.StateTracking.Back.Color2 = Color.DimGray;
            AWTButt.StateTracking.Back.ColorAngle = 5F;
            AWTButt.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Rounding5;
            AWTButt.StateTracking.Border.Color1 = Color.Black;
            AWTButt.StateTracking.Border.Color2 = Color.White;
            AWTButt.StateTracking.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Sigma;
            AWTButt.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Right;
            AWTButt.StateTracking.Border.Rounding = 0F;
            AWTButt.StateTracking.Border.Width = 15;
            AWTButt.TabIndex = 8;
            AWTButt.Values.DropDownArrowColor = Color.Empty;
            AWTButt.Values.Text = "Average Waiting Time";
            AWTButt.Click += AWTButt_Click;
            // 
            // PWTButt
            // 
            PWTButt.Location = new Point(9, 22);
            PWTButt.Name = "PWTButt";
            PWTButt.OverrideDefault.Back.Color1 = Color.Gray;
            PWTButt.OverrideDefault.Back.Color2 = Color.Transparent;
            PWTButt.OverrideDefault.Back.ColorAngle = 5F;
            PWTButt.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.ExpertSquareHighlight2;
            PWTButt.OverrideDefault.Border.Color1 = Color.Black;
            PWTButt.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            PWTButt.OverrideDefault.Border.Rounding = 10F;
            PWTButt.OverrideDefault.Border.Width = 1;
            PWTButt.OverrideFocus.Back.Color1 = Color.Transparent;
            PWTButt.Size = new Size(338, 49);
            PWTButt.StateCommon.Back.Color1 = Color.Gray;
            PWTButt.StateCommon.Back.Color2 = Color.Transparent;
            PWTButt.StateCommon.Back.ColorAngle = 5F;
            PWTButt.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.ExpertSquareHighlight2;
            PWTButt.StateCommon.Border.Color1 = Color.Black;
            PWTButt.StateCommon.Border.Color2 = Color.Transparent;
            PWTButt.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            PWTButt.StateCommon.Border.Rounding = 10F;
            PWTButt.StateCommon.Border.Width = 1;
            PWTButt.StateCommon.Content.ShortText.Color1 = Color.Black;
            PWTButt.StateCommon.Content.ShortText.Color2 = Color.Transparent;
            PWTButt.StateCommon.Content.ShortText.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PWTButt.StateDisabled.Back.Color1 = Color.White;
            PWTButt.StateDisabled.Back.Color2 = Color.DimGray;
            PWTButt.StateDisabled.Back.ColorAngle = 5F;
            PWTButt.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Rounding5;
            PWTButt.StateDisabled.Border.Color1 = Color.Black;
            PWTButt.StateDisabled.Border.Color2 = Color.White;
            PWTButt.StateDisabled.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Sigma;
            PWTButt.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Right;
            PWTButt.StateDisabled.Border.Rounding = 0F;
            PWTButt.StateDisabled.Border.Width = 15;
            PWTButt.StatePressed.Back.Color1 = Color.Transparent;
            PWTButt.StatePressed.Back.Color2 = Color.FromArgb(64, 64, 64);
            PWTButt.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Rounding5;
            PWTButt.StatePressed.Border.Color1 = Color.Black;
            PWTButt.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Right;
            PWTButt.StatePressed.Border.Width = 15;
            PWTButt.StateTracking.Back.Color1 = Color.White;
            PWTButt.StateTracking.Back.Color2 = Color.DimGray;
            PWTButt.StateTracking.Back.ColorAngle = 5F;
            PWTButt.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Rounding5;
            PWTButt.StateTracking.Border.Color1 = Color.Black;
            PWTButt.StateTracking.Border.Color2 = Color.White;
            PWTButt.StateTracking.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Sigma;
            PWTButt.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Right;
            PWTButt.StateTracking.Border.Rounding = 0F;
            PWTButt.StateTracking.Border.Width = 15;
            PWTButt.TabIndex = 7;
            PWTButt.Values.DropDownArrowColor = Color.Empty;
            PWTButt.Values.Text = "Process Waiting Time";
            PWTButt.Click += PWTButt_Click;
            // 
            // GanttChartButt
            // 
            GanttChartButt.Location = new Point(9, 22);
            GanttChartButt.Name = "GanttChartButt";
            GanttChartButt.OverrideDefault.Back.Color1 = Color.Gray;
            GanttChartButt.OverrideDefault.Back.Color2 = Color.Transparent;
            GanttChartButt.OverrideDefault.Back.ColorAngle = 5F;
            GanttChartButt.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.ExpertSquareHighlight2;
            GanttChartButt.OverrideDefault.Border.Color1 = Color.Black;
            GanttChartButt.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            GanttChartButt.OverrideDefault.Border.Rounding = 10F;
            GanttChartButt.OverrideDefault.Border.Width = 1;
            GanttChartButt.OverrideFocus.Back.Color1 = Color.Transparent;
            GanttChartButt.Size = new Size(338, 49);
            GanttChartButt.StateCommon.Back.Color1 = Color.Gray;
            GanttChartButt.StateCommon.Back.Color2 = Color.Transparent;
            GanttChartButt.StateCommon.Back.ColorAngle = 5F;
            GanttChartButt.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.ExpertSquareHighlight2;
            GanttChartButt.StateCommon.Border.Color1 = Color.Black;
            GanttChartButt.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            GanttChartButt.StateCommon.Border.Rounding = 10F;
            GanttChartButt.StateCommon.Border.Width = 1;
            GanttChartButt.StateCommon.Content.ShortText.Color1 = Color.Black;
            GanttChartButt.StateCommon.Content.ShortText.Color2 = Color.Transparent;
            GanttChartButt.StateCommon.Content.ShortText.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GanttChartButt.StateDisabled.Back.Color1 = Color.White;
            GanttChartButt.StateDisabled.Back.Color2 = Color.DimGray;
            GanttChartButt.StateDisabled.Back.ColorAngle = 5F;
            GanttChartButt.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Rounding5;
            GanttChartButt.StateDisabled.Border.Color1 = Color.Black;
            GanttChartButt.StateDisabled.Border.Color2 = Color.White;
            GanttChartButt.StateDisabled.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Sigma;
            GanttChartButt.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Right;
            GanttChartButt.StateDisabled.Border.Rounding = 0F;
            GanttChartButt.StateDisabled.Border.Width = 15;
            GanttChartButt.StatePressed.Back.Color1 = Color.Transparent;
            GanttChartButt.StatePressed.Back.Color2 = Color.FromArgb(64, 64, 64);
            GanttChartButt.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Rounding5;
            GanttChartButt.StatePressed.Border.Color1 = Color.Black;
            GanttChartButt.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Right;
            GanttChartButt.StatePressed.Border.Width = 15;
            GanttChartButt.StateTracking.Back.Color1 = Color.White;
            GanttChartButt.StateTracking.Back.Color2 = Color.DimGray;
            GanttChartButt.StateTracking.Back.ColorAngle = 5F;
            GanttChartButt.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Rounding5;
            GanttChartButt.StateTracking.Border.Color1 = Color.Black;
            GanttChartButt.StateTracking.Border.Color2 = Color.White;
            GanttChartButt.StateTracking.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Sigma;
            GanttChartButt.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Right;
            GanttChartButt.StateTracking.Border.Rounding = 0F;
            GanttChartButt.StateTracking.Border.Width = 15;
            GanttChartButt.TabIndex = 4;
            GanttChartButt.Values.DropDownArrowColor = Color.Empty;
            GanttChartButt.Values.Text = "GANTT CHART";
            GanttChartButt.Click += GanttChart_Click;
            // 
            // OpenButton
            // 
            OpenButton.BackColor = Color.Transparent;
            OpenButton.BackgroundImage = Properties.Resources.ToRideSide1;
            OpenButton.BackgroundImageLayout = ImageLayout.Stretch;
            OpenButton.FlatAppearance.BorderSize = 0;
            OpenButton.FlatStyle = FlatStyle.Flat;
            OpenButton.Location = new Point(29, 675);
            OpenButton.Name = "OpenButton";
            OpenButton.Size = new Size(24, 22);
            OpenButton.TabIndex = 14;
            OpenButton.UseVisualStyleBackColor = false;
            OpenButton.Visible = false;
            OpenButton.Click += OpenButton_Click;
            // 
            // GanttchartP
            // 
            GanttchartP.BackColor = Color.WhiteSmoke;
            GanttchartP.BackgroundImage = Properties.Resources.SideBackground;
            GanttchartP.BackgroundImageLayout = ImageLayout.Stretch;
            GanttchartP.Controls.Add(label3);
            GanttchartP.Controls.Add(GanttChartButt);
            GanttchartP.Location = new Point(-2, 536);
            GanttchartP.Name = "GanttchartP";
            GanttchartP.Size = new Size(354, 171);
            GanttchartP.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Verdana", 20F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(66, 111);
            label3.Name = "label3";
            label3.Size = new Size(221, 32);
            label3.TabIndex = 6;
            label3.Text = "Perform/Find";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.SideBackground;
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panelTable);
            panel3.Controls.Add(AverageDisplays);
            panel3.Controls.Add(ProcessDisplay);
            panel3.Controls.Add(ShowTablesButt);
            panel3.Controls.Add(panel5);
            panel3.Font = new Font("Segoe UI", 12F);
            panel3.Location = new Point(351, 39);
            panel3.Name = "panel3";
            panel3.Size = new Size(903, 498);
            panel3.TabIndex = 15;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Silver;
            panel6.BackgroundImageLayout = ImageLayout.Stretch;
            panel6.BorderStyle = BorderStyle.Fixed3D;
            panel6.Location = new Point(182, 48);
            panel6.Name = "panel6";
            panel6.Size = new Size(541, 348);
            panel6.TabIndex = 17;
            // 
            // AverageDisplays
            // 
            AverageDisplays.BackColor = Color.Transparent;
            AverageDisplays.BackgroundImage = Properties.Resources.SideBackground;
            AverageDisplays.BackgroundImageLayout = ImageLayout.Stretch;
            AverageDisplays.Location = new Point(28, 423);
            AverageDisplays.Name = "AverageDisplays";
            AverageDisplays.Size = new Size(0, 59);
            AverageDisplays.TabIndex = 12;
            // 
            // ProcessDisplay
            // 
            ProcessDisplay.BackColor = Color.Transparent;
            ProcessDisplay.BackgroundImage = Properties.Resources.SideBackground;
            ProcessDisplay.BackgroundImageLayout = ImageLayout.Stretch;
            ProcessDisplay.Location = new Point(27, 358);
            ProcessDisplay.Name = "ProcessDisplay";
            ProcessDisplay.Size = new Size(0, 59);
            ProcessDisplay.TabIndex = 11;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Black;
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Location = new Point(182, 48);
            panel5.Name = "panel5";
            panel5.Size = new Size(541, 348);
            panel5.TabIndex = 16;
            // 
            // panel4
            // 
            panel4.BackgroundImage = Properties.Resources.SideBackground;
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label1);
            panel4.Location = new Point(351, 527);
            panel4.Name = "panel4";
            panel4.Size = new Size(903, 177);
            panel4.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Stencil", 50.75F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(479, 39);
            label4.Name = "label4";
            label4.Padding = new Padding(15);
            label4.Size = new Size(107, 113);
            label4.TabIndex = 14;
            label4.Text = "3";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Verdana", 25F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(309, 59);
            label1.Name = "label1";
            label1.Padding = new Padding(15);
            label1.Size = new Size(187, 73);
            label1.TabIndex = 13;
            label1.Text = "GROUP";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // Perform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1254, 702);
            Controls.Add(panelPerformFind);
            Controls.Add(GanttchartP);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(OpenButton);
            Controls.Add(ganttChartPanel);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Perform";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Perform";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelTable.ResumeLayout(false);
            panelPerformFind.ResumeLayout(false);
            GanttchartP.ResumeLayout(false);
            GanttchartP.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Label label2;
        private Button button1;
        private Panel panel1;
        private Panel ganttChartPanel;
        private Krypton.Toolkit.KryptonButton ShowTablesButt;
        private Panel panelTable;
        private Panel panelPerformFind;
        private Button BackButton;
        private Krypton.Toolkit.KryptonButton GanttChartButt;
        private Krypton.Toolkit.KryptonButton ATATButt;
        private Krypton.Toolkit.KryptonButton PTATButt;
        private Krypton.Toolkit.KryptonButton ACTButt;
        private Krypton.Toolkit.KryptonButton PCTButt;
        private Krypton.Toolkit.KryptonButton AWTButt;
        private Krypton.Toolkit.KryptonButton PWTButt;
        private Button OpenButton;
        private Panel GanttchartP;
        private Label label3;
        private Panel panel3;
        private Panel AverageDisplays;
        private Panel ProcessDisplay;
        private Label label1;
        private Label label4;
        private Panel panel4;
        private Panel panel6;
        private Panel panel5;
    }
}