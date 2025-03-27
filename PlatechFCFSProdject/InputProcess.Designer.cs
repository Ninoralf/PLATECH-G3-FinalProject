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
            label2 = new Label();
            ContinueButt = new Krypton.Toolkit.KryptonButton();
            WhitePanel = new Panel();
            panel1 = new Panel();
            WhitePanel.SuspendLayout();
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
            kryptonTextBox1.Text = "5";
            kryptonTextBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Verdana", 20F, FontStyle.Bold);
            label2.Location = new Point(364, 661);
            label2.Name = "label2";
            label2.Size = new Size(464, 32);
            label2.TabIndex = 2;
            label2.Text = "Minimum of 3 , Maximum of 5";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ContinueButt
            // 
            ContinueButt.Location = new Point(501, 466);
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
            WhitePanel.Controls.Add(panel1);
            WhitePanel.Location = new Point(1, 1);
            WhitePanel.Name = "WhitePanel";
            WhitePanel.Size = new Size(1252, 0);
            WhitePanel.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Location = new Point(344, 182);
            panel1.Name = "panel1";
            panel1.Size = new Size(557, 325);
            panel1.TabIndex = 3;
            panel1.Visible = false;
            // 
            // InputProcess
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.InputBackground;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1254, 702);
            Controls.Add(WhitePanel);
            Controls.Add(ContinueButt);
            Controls.Add(label2);
            Controls.Add(kryptonTextBox1);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "InputProcess";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InputProcess";
            WhitePanel.ResumeLayout(false);
            WhitePanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private Label label2;
        private Krypton.Toolkit.KryptonButton ContinueButt;
        private Panel WhitePanel;
        private Panel panel1;
    }
}