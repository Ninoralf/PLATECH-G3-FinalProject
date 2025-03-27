namespace PlatechFCFSProdject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            PanelWall = new Panel();
            OpenButton = new Krypton.Toolkit.KryptonButton();
            RopePanel2 = new Panel();
            RopePanel1 = new Panel();
            ContinueButt = new Krypton.Toolkit.KryptonButton();
            MemberPanel = new Panel();
            label1 = new Label();
            panel4 = new Panel();
            LeaderLabel = new Label();
            TitlePanel = new Panel();
            Title = new Label();
            panel3 = new Panel();
            GroupNo = new Label();
            Header = new Panel();
            panel8 = new Panel();
            panel7 = new Panel();
            panel6 = new Panel();
            panel5 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            PanelWall.SuspendLayout();
            MemberPanel.SuspendLayout();
            panel4.SuspendLayout();
            TitlePanel.SuspendLayout();
            panel3.SuspendLayout();
            Header.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.background;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(PanelWall);
            panel1.Controls.Add(RopePanel2);
            panel1.Controls.Add(RopePanel1);
            panel1.Controls.Add(ContinueButt);
            panel1.Controls.Add(MemberPanel);
            panel1.Controls.Add(TitlePanel);
            panel1.Location = new Point(0, 57);
            panel1.Name = "panel1";
            panel1.Size = new Size(1286, 726);
            panel1.TabIndex = 0;
            // 
            // PanelWall
            // 
            PanelWall.BackColor = Color.FromArgb(72, 72, 13);
            PanelWall.BorderStyle = BorderStyle.FixedSingle;
            PanelWall.Controls.Add(OpenButton);
            PanelWall.Location = new Point(448, 286);
            PanelWall.Name = "PanelWall";
            PanelWall.Size = new Size(395, 81);
            PanelWall.TabIndex = 6;
            // 
            // OpenButton
            // 
            OpenButton.Cursor = Cursors.Hand;
            OpenButton.Location = new Point(23, 17);
            OpenButton.Name = "OpenButton";
            OpenButton.OverrideDefault.Back.Color1 = Color.Olive;
            OpenButton.OverrideDefault.Back.Color2 = Color.Gold;
            OpenButton.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.ExpertSquareHighlight;
            OpenButton.Size = new Size(349, 45);
            OpenButton.StateCommon.Back.Color1 = Color.Transparent;
            OpenButton.StateCommon.Back.Color2 = Color.Transparent;
            OpenButton.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.ExpertSquareHighlight;
            OpenButton.StateCommon.Border.Rounding = 10F;
            OpenButton.StateCommon.Content.ShortText.Color1 = Color.Black;
            OpenButton.StateCommon.Content.ShortText.Font = new Font("Verdana", 18.25F);
            OpenButton.StateNormal.Back.Color1 = Color.Olive;
            OpenButton.StateNormal.Back.Color2 = Color.Gold;
            OpenButton.StatePressed.Back.Color1 = Color.Olive;
            OpenButton.StatePressed.Back.Color2 = Color.Goldenrod;
            OpenButton.StateTracking.Back.Color1 = Color.Olive;
            OpenButton.StateTracking.Back.Color2 = Color.FromArgb(224, 224, 224);
            OpenButton.TabIndex = 0;
            OpenButton.Values.DropDownArrowColor = Color.Empty;
            OpenButton.Values.Text = "Open";
            OpenButton.Click += kryptonButton1_Click;
            // 
            // RopePanel2
            // 
            RopePanel2.BackColor = Color.Black;
            RopePanel2.Location = new Point(789, 3);
            RopePanel2.Name = "RopePanel2";
            RopePanel2.Size = new Size(12, 286);
            RopePanel2.TabIndex = 5;
            // 
            // RopePanel1
            // 
            RopePanel1.BackColor = Color.Black;
            RopePanel1.Location = new Point(493, 3);
            RopePanel1.Name = "RopePanel1";
            RopePanel1.Size = new Size(12, 286);
            RopePanel1.TabIndex = 4;
            // 
            // ContinueButt
            // 
            ContinueButt.Cursor = Cursors.Hand;
            ContinueButt.Location = new Point(831, 600);
            ContinueButt.Name = "ContinueButt";
            ContinueButt.Size = new Size(254, 54);
            ContinueButt.StateCommon.Back.Color1 = Color.Transparent;
            ContinueButt.StateCommon.Back.Color2 = Color.Transparent;
            ContinueButt.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.ExpertSquareHighlight;
            ContinueButt.StateCommon.Border.Rounding = 10F;
            ContinueButt.StateCommon.Content.ShortText.Color1 = Color.Black;
            ContinueButt.StateCommon.Content.ShortText.Font = new Font("Verdana", 20F);
            ContinueButt.StateNormal.Back.Color1 = Color.Olive;
            ContinueButt.StateNormal.Back.Color2 = Color.Gold;
            ContinueButt.StatePressed.Back.Color1 = Color.Olive;
            ContinueButt.StatePressed.Back.Color2 = Color.Goldenrod;
            ContinueButt.StateTracking.Back.Color1 = Color.Olive;
            ContinueButt.StateTracking.Back.Color2 = Color.FromArgb(224, 224, 224);
            ContinueButt.TabIndex = 3;
            ContinueButt.Values.DropDownArrowColor = Color.Empty;
            ContinueButt.Values.Text = "Continue";
            ContinueButt.Visible = false;
            ContinueButt.Click += ContinueButt_Click;
            // 
            // MemberPanel
            // 
            MemberPanel.BackColor = Color.FromArgb(204, 247, 247, 247);
            MemberPanel.Controls.Add(label1);
            MemberPanel.Controls.Add(panel4);
            MemberPanel.Location = new Point(731, 120);
            MemberPanel.Name = "MemberPanel";
            MemberPanel.Size = new Size(441, 0);
            MemberPanel.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Verdana", 20F);
            label1.Location = new Point(8, 186);
            label1.Name = "label1";
            label1.Size = new Size(424, 128);
            label1.TabIndex = 1;
            label1.Text = "Members:\r\n    - Lance Timothy B. Satorre\r\n    - John Lloyd Repolido\r\n    - Lyle Dedumo";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(204, 72, 72, 13);
            panel4.Controls.Add(LeaderLabel);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(441, 102);
            panel4.TabIndex = 2;
            // 
            // LeaderLabel
            // 
            LeaderLabel.AutoSize = true;
            LeaderLabel.BackColor = Color.Transparent;
            LeaderLabel.Font = new Font("Verdana", 20F);
            LeaderLabel.Location = new Point(33, 29);
            LeaderLabel.Name = "LeaderLabel";
            LeaderLabel.Size = new Size(375, 32);
            LeaderLabel.TabIndex = 0;
            LeaderLabel.Text = "Leader: Ninoralf Dela Cruz";
            // 
            // TitlePanel
            // 
            TitlePanel.BackColor = Color.FromArgb(204, 247, 247, 247);
            TitlePanel.Controls.Add(Title);
            TitlePanel.Controls.Add(panel3);
            TitlePanel.Location = new Point(2, 3);
            TitlePanel.Name = "TitlePanel";
            TitlePanel.Size = new Size(611, 0);
            TitlePanel.TabIndex = 0;
            // 
            // Title
            // 
            Title.BackColor = Color.Transparent;
            Title.Font = new Font("Verdana", 50F);
            Title.Location = new Point(19, 218);
            Title.Name = "Title";
            Title.Size = new Size(576, 373);
            Title.TabIndex = 1;
            Title.Text = "First Come First Serve (FCFS)\nCPU Scheduling";
            Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(204, 72, 72, 13);
            panel3.Controls.Add(GroupNo);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(611, 141);
            panel3.TabIndex = 0;
            // 
            // GroupNo
            // 
            GroupNo.AutoSize = true;
            GroupNo.BackColor = Color.Transparent;
            GroupNo.Font = new Font("Verdana", 45F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GroupNo.Location = new Point(69, 34);
            GroupNo.Name = "GroupNo";
            GroupNo.Size = new Size(336, 73);
            GroupNo.TabIndex = 0;
            GroupNo.Text = "GROUP 3";
            // 
            // Header
            // 
            Header.BackColor = Color.FromArgb(72, 72, 13);
            Header.Controls.Add(panel8);
            Header.Controls.Add(panel7);
            Header.Controls.Add(panel6);
            Header.Controls.Add(panel5);
            Header.Controls.Add(panel2);
            Header.Dock = DockStyle.Top;
            Header.Location = new Point(0, 0);
            Header.Name = "Header";
            Header.Size = new Size(1286, 63);
            Header.TabIndex = 1;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Black;
            panel8.Location = new Point(465, 53);
            panel8.Name = "panel8";
            panel8.Size = new Size(356, 10);
            panel8.TabIndex = 3;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Black;
            panel7.Location = new Point(859, 37);
            panel7.Name = "panel7";
            panel7.Size = new Size(356, 10);
            panel7.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Black;
            panel6.Location = new Point(71, 37);
            panel6.Name = "panel6";
            panel6.Size = new Size(356, 10);
            panel6.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Black;
            panel5.Location = new Point(896, 21);
            panel5.Name = "panel5";
            panel5.Size = new Size(356, 10);
            panel5.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(34, 21);
            panel2.Name = "panel2";
            panel2.Size = new Size(356, 10);
            panel2.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1286, 780);
            Controls.Add(Header);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            PanelWall.ResumeLayout(false);
            MemberPanel.ResumeLayout(false);
            MemberPanel.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            TitlePanel.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            Header.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel Header;
        private Krypton.Toolkit.KryptonButton OpenButton;
        private Panel TitlePanel;
        private Label Title;
        private Panel panel3;
        private Label GroupNo;
        private Panel MemberPanel;
        private Label LeaderLabel;
        private Label label1;
        private Panel panel4;
        private Panel panel5;
        private Panel panel2;
        private Panel panel7;
        private Panel panel6;
        private Krypton.Toolkit.KryptonButton ContinueButt;
        private Panel PanelWall;
        private Panel RopePanel2;
        private Panel RopePanel1;
        private Panel panel8;
    }
}
