namespace PlatechFCFSProdject
{
    partial class InputProcess
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
            label1 = new Label();
            TextBoxInputPross = new Krypton.Toolkit.KryptonTextBox();
            ContinueButt = new Krypton.Toolkit.KryptonButton();
            WhitePanel = new Panel();
            panel1 = new Panel();
            panelSlide = new Panel();
            Pbar = new Krypton.Toolkit.KryptonProgressBar();
            PleaseWaitLabel = new Label();
            panel3 = new Panel();
            ContinueButs = new Krypton.Toolkit.KryptonButton();
            BackButton = new Krypton.Toolkit.KryptonButton();
            label3 = new Label();
            LabelProcessNO = new Label();
            panel2 = new Panel();
            label2 = new Label();
            button1 = new Button();
            ErrorLabel = new Label();
            HandlePanel = new Panel();
            panel4 = new Panel();
            marqueeLabel = new Label();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            WhitePanel.SuspendLayout();
            panelSlide.SuspendLayout();
            panel2.SuspendLayout();
            HandlePanel.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Verdana", 40F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 78);
            label1.Name = "label1";
            label1.Size = new Size(656, 130);
            label1.TabIndex = 0;
            label1.Text = "Enter the number of \r\nProcesses";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TextBoxInputPross
            // 
            TextBoxInputPross.Location = new Point(176, 34);
            TextBoxInputPross.Name = "TextBoxInputPross";
            TextBoxInputPross.Size = new Size(322, 60);
            TextBoxInputPross.StateCommon.Back.Color1 = Color.Black;
            TextBoxInputPross.StateCommon.Border.Color1 = Color.White;
            TextBoxInputPross.StateCommon.Border.Color2 = Color.Transparent;
            TextBoxInputPross.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            TextBoxInputPross.StateCommon.Border.Rounding = 10F;
            TextBoxInputPross.StateCommon.Border.Width = 3;
            TextBoxInputPross.StateCommon.Content.Color1 = Color.FromArgb(192, 192, 0);
            TextBoxInputPross.StateCommon.Content.Font = new Font("Verdana", 30F);
            TextBoxInputPross.TabIndex = 1;
            TextBoxInputPross.TextAlign = HorizontalAlignment.Center;
            TextBoxInputPross.KeyDown += TextBoxInputPross_KeyDown;
            TextBoxInputPross.MouseEnter += kryptonTextBox1_MouseEnter;
            // 
            // ContinueButt
            // 
            ContinueButt.Location = new Point(233, 177);
            ContinueButt.Name = "ContinueButt";
            ContinueButt.OverrideDefault.Back.Color1 = Color.DimGray;
            ContinueButt.OverrideDefault.Back.Color2 = Color.DarkGray;
            ContinueButt.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Rounding5;
            ContinueButt.OverrideDefault.Border.Color1 = Color.Black;
            ContinueButt.OverrideDefault.Border.Rounding = 10F;
            ContinueButt.OverrideDefault.Border.Width = 1;
            ContinueButt.Size = new Size(207, 55);
            ContinueButt.StateCommon.Back.Color1 = Color.DimGray;
            ContinueButt.StateCommon.Back.Color2 = Color.DarkGray;
            ContinueButt.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Rounding5;
            ContinueButt.StateCommon.Border.Color1 = Color.Black;
            ContinueButt.StateCommon.Border.Rounding = 10F;
            ContinueButt.StateCommon.Content.ShortText.Color1 = Color.Black;
            ContinueButt.StateCommon.Content.ShortText.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ContinueButt.TabIndex = 2;
            ContinueButt.Values.DropDownArrowColor = Color.Empty;
            ContinueButt.Values.Text = "Continue";
            ContinueButt.Click += ContinueButt_Click;
            // 
            // WhitePanel
            // 
            WhitePanel.BackColor = Color.White;
            WhitePanel.BackgroundImage = Properties.Resources.SideBackground;
            WhitePanel.BackgroundImageLayout = ImageLayout.Stretch;
            WhitePanel.Controls.Add(panel1);
            WhitePanel.Controls.Add(panelSlide);
            WhitePanel.Controls.Add(panel3);
            WhitePanel.Controls.Add(ContinueButs);
            WhitePanel.Controls.Add(BackButton);
            WhitePanel.Controls.Add(label3);
            WhitePanel.Controls.Add(LabelProcessNO);
            WhitePanel.Location = new Point(-2, 39);
            WhitePanel.Name = "WhitePanel";
            WhitePanel.Size = new Size(0, 665);
            WhitePanel.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.Gray;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Location = new Point(348, 172);
            panel1.Name = "panel1";
            panel1.Size = new Size(557, 324);
            panel1.TabIndex = 3;
            panel1.Visible = false;
            // 
            // panelSlide
            // 
            panelSlide.BackColor = Color.Silver;
            panelSlide.BackgroundImage = Properties.Resources.SideBackground;
            panelSlide.BackgroundImageLayout = ImageLayout.Stretch;
            panelSlide.BorderStyle = BorderStyle.Fixed3D;
            panelSlide.Controls.Add(Pbar);
            panelSlide.Controls.Add(PleaseWaitLabel);
            panelSlide.Location = new Point(319, 150);
            panelSlide.Name = "panelSlide";
            panelSlide.Size = new Size(630, 381);
            panelSlide.TabIndex = 0;
            // 
            // Pbar
            // 
            Pbar.Location = new Point(56, 192);
            Pbar.Name = "Pbar";
            Pbar.Size = new Size(518, 37);
            Pbar.StateCommon.Back.Color1 = Color.FromArgb(192, 192, 0);
            Pbar.StateCommon.Back.Color2 = Color.Black;
            Pbar.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Rounding5;
            Pbar.StateCommon.Border.Color1 = Color.Black;
            Pbar.StateCommon.Border.Color2 = Color.Black;
            Pbar.StateCommon.Border.Rounding = 1F;
            Pbar.StateCommon.Border.Width = 2;
            Pbar.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.OneNote;
            Pbar.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.OneNote;
            Pbar.TabIndex = 0;
            Pbar.Values.Text = "";
            // 
            // PleaseWaitLabel
            // 
            PleaseWaitLabel.AutoSize = true;
            PleaseWaitLabel.BackColor = Color.Transparent;
            PleaseWaitLabel.Font = new Font("Verdana", 20F, FontStyle.Bold);
            PleaseWaitLabel.ForeColor = Color.Black;
            PleaseWaitLabel.Location = new Point(118, 133);
            PleaseWaitLabel.Name = "PleaseWaitLabel";
            PleaseWaitLabel.Size = new Size(400, 32);
            PleaseWaitLabel.TabIndex = 5;
            PleaseWaitLabel.Text = "Processing, please wait...";
            PleaseWaitLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Location = new Point(319, 150);
            panel3.Name = "panel3";
            panel3.Size = new Size(630, 381);
            panel3.TabIndex = 8;
            // 
            // ContinueButs
            // 
            ContinueButs.Location = new Point(625, 552);
            ContinueButs.Name = "ContinueButs";
            ContinueButs.OverrideDefault.Back.Color1 = Color.DimGray;
            ContinueButs.OverrideDefault.Back.Color2 = Color.DarkGray;
            ContinueButs.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Rounding5;
            ContinueButs.OverrideDefault.Border.Color1 = Color.Black;
            ContinueButs.OverrideDefault.Border.Rounding = 10F;
            ContinueButs.OverrideDefault.Border.Width = 1;
            ContinueButs.Size = new Size(277, 44);
            ContinueButs.StateCommon.Back.Color1 = Color.DimGray;
            ContinueButs.StateCommon.Back.Color2 = Color.DarkGray;
            ContinueButs.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Rounding5;
            ContinueButs.StateCommon.Border.Color1 = Color.Black;
            ContinueButs.StateCommon.Border.Rounding = 10F;
            ContinueButs.StateCommon.Border.Width = 1;
            ContinueButs.StateCommon.Content.ShortText.Color1 = Color.Black;
            ContinueButs.StateCommon.Content.ShortText.Font = new Font("Verdana", 12F);
            ContinueButs.StateTracking.Back.Color1 = Color.White;
            ContinueButs.StateTracking.Back.Color2 = Color.DarkGray;
            ContinueButs.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Rounding5;
            ContinueButs.StateTracking.Border.Color1 = Color.Olive;
            ContinueButs.StateTracking.Border.Color2 = Color.Black;
            ContinueButs.StateTracking.Border.Rounding = 10F;
            ContinueButs.StateTracking.Border.Width = 1;
            ContinueButs.StateTracking.Content.ShortText.Color1 = Color.Black;
            ContinueButs.StateTracking.Content.ShortText.Color2 = Color.Black;
            ContinueButs.TabIndex = 7;
            ContinueButs.Values.DropDownArrowColor = Color.Empty;
            ContinueButs.Values.Text = "Continue";
            ContinueButs.Click += ContinueButs_Click;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(349, 552);
            BackButton.Name = "BackButton";
            BackButton.OverrideDefault.Back.Color1 = Color.DimGray;
            BackButton.OverrideDefault.Back.Color2 = Color.DarkGray;
            BackButton.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Rounding5;
            BackButton.OverrideDefault.Border.Color1 = Color.Black;
            BackButton.OverrideDefault.Border.Rounding = 10F;
            BackButton.OverrideDefault.Border.Width = 1;
            BackButton.Size = new Size(270, 44);
            BackButton.StateCommon.Back.Color1 = Color.DimGray;
            BackButton.StateCommon.Back.Color2 = Color.DarkGray;
            BackButton.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Rounding5;
            BackButton.StateCommon.Border.Color1 = Color.Black;
            BackButton.StateCommon.Border.Rounding = 10F;
            BackButton.StateCommon.Border.Width = 1;
            BackButton.StateCommon.Content.ShortText.Color1 = Color.Black;
            BackButton.StateCommon.Content.ShortText.Font = new Font("Verdana", 12F);
            BackButton.StateTracking.Back.Color1 = Color.White;
            BackButton.StateTracking.Back.Color2 = Color.DarkGray;
            BackButton.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Rounding5;
            BackButton.StateTracking.Border.Color1 = Color.Maroon;
            BackButton.StateTracking.Border.Color2 = Color.Black;
            BackButton.StateTracking.Border.Rounding = 10F;
            BackButton.StateTracking.Border.Width = 1;
            BackButton.StateTracking.Content.ShortText.Color1 = Color.Black;
            BackButton.StateTracking.Content.ShortText.Color2 = Color.Black;
            BackButton.TabIndex = 6;
            BackButton.Values.DropDownArrowColor = Color.Empty;
            BackButton.Values.Text = "Back";
            BackButton.Click += BackButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Verdana", 50F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(154, 42);
            label3.Name = "label3";
            label3.Size = new Size(832, 80);
            label3.TabIndex = 4;
            label3.Text = "Number of Processes";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // LabelProcessNO
            // 
            LabelProcessNO.AutoSize = true;
            LabelProcessNO.BackColor = Color.Transparent;
            LabelProcessNO.Font = new Font("Stencil", 130.75F, FontStyle.Bold);
            LabelProcessNO.ForeColor = Color.Black;
            LabelProcessNO.Location = new Point(959, -15);
            LabelProcessNO.Name = "LabelProcessNO";
            LabelProcessNO.Size = new Size(189, 207);
            LabelProcessNO.TabIndex = 5;
            LabelProcessNO.Text = "5";
            LabelProcessNO.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1254, 40);
            panel2.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Verdana", 15F, FontStyle.Bold);
            label2.ForeColor = Color.Olive;
            label2.Location = new Point(363, 7);
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
            button1.TabIndex = 3;
            button1.TabStop = false;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ErrorLabel
            // 
            ErrorLabel.AutoSize = true;
            ErrorLabel.BackColor = Color.Transparent;
            ErrorLabel.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ErrorLabel.ForeColor = Color.FromArgb(192, 0, 0);
            ErrorLabel.Location = new Point(174, 98);
            ErrorLabel.Name = "ErrorLabel";
            ErrorLabel.Size = new Size(0, 20);
            ErrorLabel.TabIndex = 6;
            ErrorLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // HandlePanel
            // 
            HandlePanel.BackColor = Color.LightGray;
            HandlePanel.BorderStyle = BorderStyle.Fixed3D;
            HandlePanel.Controls.Add(panel4);
            HandlePanel.Controls.Add(kryptonPanel1);
            HandlePanel.Controls.Add(label1);
            HandlePanel.Location = new Point(291, 71);
            HandlePanel.Name = "HandlePanel";
            HandlePanel.Size = new Size(682, 589);
            HandlePanel.TabIndex = 10;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(marqueeLabel);
            panel4.Location = new Point(104, 8);
            panel4.Name = "panel4";
            panel4.Size = new Size(481, 50);
            panel4.TabIndex = 8;
            // 
            // marqueeLabel
            // 
            marqueeLabel.AutoSize = true;
            marqueeLabel.Font = new Font("Verdana", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            marqueeLabel.ForeColor = Color.FromArgb(192, 0, 0);
            marqueeLabel.Location = new Point(10, 6);
            marqueeLabel.Name = "marqueeLabel";
            marqueeLabel.Size = new Size(455, 32);
            marqueeLabel.TabIndex = 0;
            marqueeLabel.Text = "Minimum of 2, Maximum of 5";
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(ErrorLabel);
            kryptonPanel1.Controls.Add(ContinueButt);
            kryptonPanel1.Controls.Add(TextBoxInputPross);
            kryptonPanel1.Location = new Point(0, 239);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(682, 348);
            kryptonPanel1.StateCommon.Color1 = Color.Transparent;
            kryptonPanel1.StateCommon.Color2 = Color.FromArgb(64, 64, 64);
            kryptonPanel1.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Rounded;
            kryptonPanel1.TabIndex = 7;
            // 
            // InputProcess
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            BackgroundImage = Properties.Resources.SideBackground;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1254, 702);
            Controls.Add(WhitePanel);
            Controls.Add(HandlePanel);
            Controls.Add(panel2);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "InputProcess";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InputProcess";
            WhitePanel.ResumeLayout(false);
            WhitePanel.PerformLayout();
            panelSlide.ResumeLayout(false);
            panelSlide.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            HandlePanel.ResumeLayout(false);
            HandlePanel.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            kryptonPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Krypton.Toolkit.KryptonTextBox TextBoxInputPross;
        private Krypton.Toolkit.KryptonButton ContinueButt;
        private Panel WhitePanel;
        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private Label ErrorLabel;
        private Label LabelProcessNO;
        private Label label3;
        private Krypton.Toolkit.KryptonButton BackButton;
        private Krypton.Toolkit.KryptonButton ContinueButs;
        private Label label2;
        private Panel HandlePanel;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Panel panelSlide;
        private Panel panel3;
        private Krypton.Toolkit.KryptonProgressBar Pbar;
        private Label PleaseWaitLabel;
        private Panel panel4;
        private Label marqueeLabel;
    }
}