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
            ContinueButt = new Krypton.Toolkit.KryptonButton();
            panel2 = new Panel();
            label2 = new Label();
            button1 = new Button();
            label1 = new Label();
            panel1 = new Panel();
            ganttChartPanel = new Panel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // ContinueButt
            // 
            ContinueButt.Location = new Point(132, 469);
            ContinueButt.Name = "ContinueButt";
            ContinueButt.OverrideDefault.Back.Color1 = Color.FromArgb(224, 224, 224);
            ContinueButt.OverrideDefault.Back.Color2 = Color.White;
            ContinueButt.Size = new Size(398, 49);
            ContinueButt.StateCommon.Back.Color1 = Color.Gray;
            ContinueButt.StateCommon.Back.Color2 = Color.White;
            ContinueButt.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.ExpertSquareHighlight;
            ContinueButt.StateCommon.Border.Rounding = 15F;
            ContinueButt.StateCommon.Content.ShortText.Color1 = Color.Black;
            ContinueButt.StateCommon.Content.ShortText.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ContinueButt.TabIndex = 4;
            ContinueButt.Values.DropDownArrowColor = Color.Empty;
            ContinueButt.Values.Text = "GANTT CHART";
            ContinueButt.Click += ContinueButt_Click;
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
            panel2.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Verdana", 20F, FontStyle.Bold);
            label2.ForeColor = Color.Olive;
            label2.Location = new Point(293, 4);
            label2.Name = "label2";
            label2.Size = new Size(709, 32);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Verdana", 20F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(41, 415);
            label1.Name = "label1";
            label1.Size = new Size(232, 32);
            label1.TabIndex = 6;
            label1.Text = "Perform/Find:";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Location = new Point(387, 91);
            panel1.Name = "panel1";
            panel1.Size = new Size(486, 325);
            panel1.TabIndex = 7;
            // 
            // ganttChartPanel
            // 
            ganttChartPanel.BackColor = Color.Transparent;
            ganttChartPanel.Location = new Point(112, 541);
            ganttChartPanel.Name = "ganttChartPanel";
            ganttChartPanel.Size = new Size(1052, 108);
            ganttChartPanel.TabIndex = 8;
            // 
            // Perform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.SideBackground;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1254, 702);
            Controls.Add(ganttChartPanel);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(ContinueButt);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Perform";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Perform";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonButton ContinueButt;
        private Panel panel2;
        private Label label2;
        private Button button1;
        private Label label1;
        private Panel panel1;
        private Panel ganttChartPanel;
    }
}