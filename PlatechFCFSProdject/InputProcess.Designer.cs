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
            kryptonTextBox1 = new Krypton.Toolkit.KryptonTextBox();
            ContinueButt = new Krypton.Toolkit.KryptonButton();
            WhitePanel = new Panel();
            BackButton = new Krypton.Toolkit.KryptonButton();
            LabelProcessNO = new Label();
            label3 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            button1 = new Button();
            ErrorLabel = new Label();
            ContinueButs = new Krypton.Toolkit.KryptonButton();
            WhitePanel.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Verdana", 40F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(327, 153);
            label1.Name = "label1";
            label1.Size = new Size(593, 130);
            label1.TabIndex = 0;
            label1.Text = "Enter a number of \r\nProcesses";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // kryptonTextBox1
            // 
            kryptonTextBox1.Location = new Point(451, 340);
            kryptonTextBox1.Multiline = true;
            kryptonTextBox1.Name = "kryptonTextBox1";
            kryptonTextBox1.Size = new Size(322, 61);
            kryptonTextBox1.StateCommon.Back.Color1 = Color.White;
            kryptonTextBox1.StateCommon.Border.Rounding = 10F;
            kryptonTextBox1.StateCommon.Content.Font = new Font("Verdana", 30F);
            kryptonTextBox1.TabIndex = 1;
            kryptonTextBox1.TextAlign = HorizontalAlignment.Center;
            kryptonTextBox1.MouseEnter += kryptonTextBox1_MouseEnter;
            // 
            // ContinueButt
            // 
            ContinueButt.Location = new Point(504, 465);
            ContinueButt.Name = "ContinueButt";
            ContinueButt.OverrideDefault.Back.Color1 = Color.FromArgb(224, 224, 224);
            ContinueButt.OverrideDefault.Back.Color2 = Color.White;
            ContinueButt.Size = new Size(207, 55);
            ContinueButt.StateCommon.Back.Color1 = Color.FromArgb(224, 224, 224);
            ContinueButt.StateCommon.Back.Color2 = Color.White;
            ContinueButt.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.ExpertSquareHighlight;
            ContinueButt.StateCommon.Border.Rounding = 10F;
            ContinueButt.StateCommon.Content.ShortText.Color1 = Color.Black;
            ContinueButt.StateCommon.Content.ShortText.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ContinueButt.TabIndex = 3;
            ContinueButt.Values.DropDownArrowColor = Color.Empty;
            ContinueButt.Values.Text = "Continue";
            ContinueButt.Click += ContinueButt_Click;
            // 
            // WhitePanel
            // 
            WhitePanel.BackColor = Color.White;
            WhitePanel.Controls.Add(ContinueButs);
            WhitePanel.Controls.Add(BackButton);
            WhitePanel.Controls.Add(LabelProcessNO);
            WhitePanel.Controls.Add(label3);
            WhitePanel.Controls.Add(panel1);
            WhitePanel.Location = new Point(1, 37);
            WhitePanel.Name = "WhitePanel";
            WhitePanel.Size = new Size(1252, 701);
            WhitePanel.TabIndex = 4;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(464, 566);
            BackButton.Name = "BackButton";
            BackButton.OverrideDefault.Back.Color1 = Color.White;
            BackButton.OverrideDefault.Back.Color2 = Color.Silver;
            BackButton.Size = new Size(118, 44);
            BackButton.StateCommon.Back.Color1 = Color.White;
            BackButton.StateCommon.Back.Color2 = Color.Silver;
            BackButton.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.ExpertSquareHighlight2;
            BackButton.StateCommon.Border.Rounding = 10F;
            BackButton.StateCommon.Content.ShortText.Color1 = Color.Black;
            BackButton.StateCommon.Content.ShortText.Font = new Font("Verdana", 12F);
            BackButton.StateTracking.Back.Color1 = Color.Olive;
            BackButton.StateTracking.Back.Color2 = Color.Silver;
            BackButton.StateTracking.Border.Color1 = Color.Maroon;
            BackButton.StateTracking.Border.Color2 = Color.Maroon;
            BackButton.StateTracking.Content.ShortText.Color1 = Color.Black;
            BackButton.StateTracking.Content.ShortText.Color2 = Color.Black;
            BackButton.TabIndex = 6;
            BackButton.Values.DropDownArrowColor = Color.Empty;
            BackButton.Values.Text = "Back";
            BackButton.Click += BackButton_Click;
            // 
            // LabelProcessNO
            // 
            LabelProcessNO.AutoSize = true;
            LabelProcessNO.BackColor = Color.Transparent;
            LabelProcessNO.Font = new Font("Verdana", 70F, FontStyle.Bold);
            LabelProcessNO.ForeColor = Color.Black;
            LabelProcessNO.Location = new Point(886, 43);
            LabelProcessNO.Name = "LabelProcessNO";
            LabelProcessNO.Size = new Size(115, 114);
            LabelProcessNO.TabIndex = 5;
            LabelProcessNO.Text = "5";
            LabelProcessNO.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Verdana", 35F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(298, 69);
            label3.Name = "label3";
            label3.Size = new Size(582, 57);
            label3.TabIndex = 4;
            label3.Text = "Number of Processes";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Location = new Point(345, 181);
            panel1.Name = "panel1";
            panel1.Size = new Size(557, 324);
            panel1.TabIndex = 3;
            panel1.Visible = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1254, 40);
            panel2.TabIndex = 5;
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
            // ErrorLabel
            // 
            ErrorLabel.AutoSize = true;
            ErrorLabel.BackColor = Color.Transparent;
            ErrorLabel.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ErrorLabel.ForeColor = Color.FromArgb(192, 0, 0);
            ErrorLabel.Location = new Point(451, 404);
            ErrorLabel.Name = "ErrorLabel";
            ErrorLabel.Size = new Size(0, 20);
            ErrorLabel.TabIndex = 6;
            ErrorLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ContinueButs
            // 
            ContinueButs.Location = new Point(632, 566);
            ContinueButs.Name = "ContinueButs";
            ContinueButs.OverrideDefault.Back.Color1 = Color.White;
            ContinueButs.OverrideDefault.Back.Color2 = Color.Silver;
            ContinueButs.Size = new Size(118, 44);
            ContinueButs.StateCommon.Back.Color1 = Color.White;
            ContinueButs.StateCommon.Back.Color2 = Color.Silver;
            ContinueButs.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.ExpertSquareHighlight2;
            ContinueButs.StateCommon.Border.Rounding = 10F;
            ContinueButs.StateCommon.Content.ShortText.Color1 = Color.Black;
            ContinueButs.StateCommon.Content.ShortText.Font = new Font("Verdana", 12F);
            ContinueButs.StateTracking.Back.Color1 = Color.Green;
            ContinueButs.StateTracking.Back.Color2 = Color.Silver;
            ContinueButs.StateTracking.Border.Color1 = Color.Maroon;
            ContinueButs.StateTracking.Border.Color2 = Color.Maroon;
            ContinueButs.StateTracking.Content.ShortText.Color1 = Color.Black;
            ContinueButs.StateTracking.Content.ShortText.Color2 = Color.Black;
            ContinueButs.TabIndex = 7;
            ContinueButs.Values.DropDownArrowColor = Color.Empty;
            ContinueButs.Values.Text = "Continue";
            ContinueButs.Click += ContinueButs_Click;
            // 
            // InputProcess
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.InputBackground;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1254, 702);
            Controls.Add(ErrorLabel);
            Controls.Add(panel2);
            Controls.Add(WhitePanel);
            Controls.Add(ContinueButt);
            Controls.Add(kryptonTextBox1);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "InputProcess";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InputProcess";
            WhitePanel.ResumeLayout(false);
            WhitePanel.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
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
    }
}