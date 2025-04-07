namespace PlatechFCFSProdject
{
    partial class TitleGroupName
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
            Header = new Panel();
            TitlePanel = new Panel();
            GroupNo = new Label();
            Title = new Label();
            panel3 = new Panel();
            PanelWall = new Panel();
            OpenButton = new Krypton.Toolkit.KryptonButton();
            MemberPanel = new Panel();
            label1 = new Label();
            panel4 = new Panel();
            LeaderLabel = new Label();
            ContinueButt = new Krypton.Toolkit.KryptonButton();
            panel1 = new Panel();
            DesignPanel2 = new Panel();
            panel6 = new Panel();
            DesignPanel1 = new Panel();
            AdditionalDe = new Panel();
            panel5 = new Panel();
            TitlePanel.SuspendLayout();
            PanelWall.SuspendLayout();
            MemberPanel.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Header
            // 
            Header.BackColor = Color.Black;
            Header.BackgroundImageLayout = ImageLayout.Stretch;
            Header.Dock = DockStyle.Top;
            Header.Location = new Point(0, 0);
            Header.Name = "Header";
            Header.Size = new Size(1286, 59);
            Header.TabIndex = 1;
            // 
            // TitlePanel
            // 
            TitlePanel.BackColor = Color.Silver;
            TitlePanel.BackgroundImage = Properties.Resources.InputBackground;
            TitlePanel.BackgroundImageLayout = ImageLayout.Stretch;
            TitlePanel.Controls.Add(GroupNo);
            TitlePanel.Controls.Add(Title);
            TitlePanel.Controls.Add(panel3);
            TitlePanel.Location = new Point(2, 3);
            TitlePanel.Name = "TitlePanel";
            TitlePanel.Size = new Size(1284, 0);
            TitlePanel.TabIndex = 0;
            // 
            // GroupNo
            // 
            GroupNo.AutoSize = true;
            GroupNo.BackColor = Color.Transparent;
            GroupNo.Font = new Font("Verdana", 45F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GroupNo.Location = new Point(478, 85);
            GroupNo.Name = "GroupNo";
            GroupNo.Size = new Size(336, 73);
            GroupNo.TabIndex = 0;
            GroupNo.Text = "GROUP 3";
            // 
            // Title
            // 
            Title.BackColor = Color.Transparent;
            Title.Font = new Font("Verdana", 50F);
            Title.Location = new Point(115, 158);
            Title.Name = "Title";
            Title.Size = new Size(1066, 170);
            Title.TabIndex = 1;
            Title.Text = "First Come First Serve (FCFS) CPU Scheduling";
            Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(64, 64, 0);
            panel3.BackgroundImage = Properties.Resources.ReverseBackground;
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1284, 82);
            panel3.TabIndex = 0;
            // 
            // PanelWall
            // 
            PanelWall.BackColor = Color.Black;
            PanelWall.BackgroundImageLayout = ImageLayout.Stretch;
            PanelWall.BorderStyle = BorderStyle.FixedSingle;
            PanelWall.Controls.Add(OpenButton);
            PanelWall.Location = new Point(452, 267);
            PanelWall.Name = "PanelWall";
            PanelWall.Size = new Size(395, 81);
            PanelWall.TabIndex = 6;
            // 
            // OpenButton
            // 
            OpenButton.Cursor = Cursors.Hand;
            OpenButton.Location = new Point(22, 16);
            OpenButton.Name = "OpenButton";
            OpenButton.OverrideDefault.Back.Color1 = Color.DimGray;
            OpenButton.OverrideDefault.Back.Color2 = Color.White;
            OpenButton.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Rounding5;
            OpenButton.OverrideDefault.Border.Color1 = Color.White;
            OpenButton.OverrideDefault.Border.Rounding = 10F;
            OpenButton.OverrideDefault.Border.Width = 1;
            OpenButton.Size = new Size(349, 45);
            OpenButton.StateCommon.Back.Color1 = Color.DimGray;
            OpenButton.StateCommon.Back.Color2 = Color.White;
            OpenButton.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Rounding5;
            OpenButton.StateCommon.Border.Color1 = Color.White;
            OpenButton.StateCommon.Border.Rounding = 10F;
            OpenButton.StateCommon.Border.Width = 1;
            OpenButton.StateCommon.Content.ShortText.Color1 = Color.Black;
            OpenButton.StateCommon.Content.ShortText.Font = new Font("Verdana", 18.25F);
            OpenButton.StateNormal.Back.Color1 = Color.DimGray;
            OpenButton.StateNormal.Back.Color2 = Color.White;
            OpenButton.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Rounding5;
            OpenButton.StateNormal.Border.Color1 = Color.White;
            OpenButton.StateNormal.Border.Rounding = 10F;
            OpenButton.StateNormal.Border.Width = 1;
            OpenButton.StatePressed.Back.Color1 = Color.Olive;
            OpenButton.StatePressed.Back.Color2 = Color.Goldenrod;
            OpenButton.StateTracking.Back.Color1 = Color.DarkGray;
            OpenButton.StateTracking.Back.Color2 = Color.White;
            OpenButton.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Rounding5;
            OpenButton.StateTracking.Border.Color1 = Color.Olive;
            OpenButton.StateTracking.Border.Rounding = 10F;
            OpenButton.StateTracking.Border.Width = 1;
            OpenButton.TabIndex = 0;
            OpenButton.Values.DropDownArrowColor = Color.Empty;
            OpenButton.Values.Text = "Open";
            OpenButton.Click += kryptonButton1_Click;
            // 
            // MemberPanel
            // 
            MemberPanel.BackColor = Color.FromArgb(204, 247, 247, 247);
            MemberPanel.Controls.Add(label1);
            MemberPanel.Controls.Add(panel4);
            MemberPanel.Location = new Point(427, 351);
            MemberPanel.Name = "MemberPanel";
            MemberPanel.Size = new Size(441, 0);
            MemberPanel.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Verdana", 20F);
            label1.Location = new Point(3, 123);
            label1.Name = "label1";
            label1.Size = new Size(424, 128);
            label1.TabIndex = 1;
            label1.Text = "Members:\r\n    - Lance Timothy B. Satorre\r\n    - John Lloyd Repolido\r\n    - Lyle Dedumo";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(64, 64, 64);
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
            LeaderLabel.ForeColor = Color.White;
            LeaderLabel.Location = new Point(33, 29);
            LeaderLabel.Name = "LeaderLabel";
            LeaderLabel.Size = new Size(375, 32);
            LeaderLabel.TabIndex = 0;
            LeaderLabel.Text = "Leader: Ninoralf Dela Cruz";
            // 
            // ContinueButt
            // 
            ContinueButt.Cursor = Cursors.Hand;
            ContinueButt.Location = new Point(516, 638);
            ContinueButt.Name = "ContinueButt";
            ContinueButt.Size = new Size(254, 54);
            ContinueButt.StateCommon.Back.Color1 = Color.DimGray;
            ContinueButt.StateCommon.Back.Color2 = Color.White;
            ContinueButt.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Rounding5;
            ContinueButt.StateCommon.Border.Color1 = Color.Black;
            ContinueButt.StateCommon.Border.Rounding = 10F;
            ContinueButt.StateCommon.Border.Width = 1;
            ContinueButt.StateCommon.Content.ShortText.Color1 = Color.Black;
            ContinueButt.StateCommon.Content.ShortText.Font = new Font("Verdana", 20F);
            ContinueButt.StateNormal.Back.Color1 = Color.DimGray;
            ContinueButt.StateNormal.Back.Color2 = Color.White;
            ContinueButt.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Rounding5;
            ContinueButt.StatePressed.Back.Color1 = Color.Olive;
            ContinueButt.StatePressed.Back.Color2 = Color.Goldenrod;
            ContinueButt.StateTracking.Back.Color1 = Color.DarkGray;
            ContinueButt.StateTracking.Back.Color2 = Color.White;
            ContinueButt.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Rounding5;
            ContinueButt.StateTracking.Border.Color1 = Color.Black;
            ContinueButt.StateTracking.Border.Rounding = 10F;
            ContinueButt.StateTracking.Border.Width = 1;
            ContinueButt.TabIndex = 3;
            ContinueButt.Values.DropDownArrowColor = Color.Empty;
            ContinueButt.Values.Text = "Continue";
            ContinueButt.Visible = false;
            ContinueButt.Click += ContinueButt_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.BackgroundImage = Properties.Resources.SideBackground;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(DesignPanel2);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(DesignPanel1);
            panel1.Controls.Add(PanelWall);
            panel1.Controls.Add(AdditionalDe);
            panel1.Controls.Add(ContinueButt);
            panel1.Controls.Add(MemberPanel);
            panel1.Controls.Add(TitlePanel);
            panel1.Controls.Add(panel5);
            panel1.Location = new Point(0, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(1286, 727);
            panel1.TabIndex = 0;
            // 
            // DesignPanel2
            // 
            DesignPanel2.BackColor = Color.Transparent;
            DesignPanel2.Location = new Point(904, 417);
            DesignPanel2.Name = "DesignPanel2";
            DesignPanel2.Size = new Size(312, 275);
            DesignPanel2.TabIndex = 14;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Black;
            panel6.BorderStyle = BorderStyle.Fixed3D;
            panel6.Location = new Point(904, 417);
            panel6.Name = "panel6";
            panel6.Size = new Size(312, 275);
            panel6.TabIndex = 15;
            // 
            // DesignPanel1
            // 
            DesignPanel1.BackColor = Color.Transparent;
            DesignPanel1.Location = new Point(80, 417);
            DesignPanel1.Name = "DesignPanel1";
            DesignPanel1.Size = new Size(312, 275);
            DesignPanel1.TabIndex = 12;
            // 
            // AdditionalDe
            // 
            AdditionalDe.BackColor = Color.Black;
            AdditionalDe.Location = new Point(0, 267);
            AdditionalDe.Name = "AdditionalDe";
            AdditionalDe.Size = new Size(0, 10);
            AdditionalDe.TabIndex = 11;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Black;
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Location = new Point(80, 417);
            panel5.Name = "panel5";
            panel5.Size = new Size(312, 275);
            panel5.TabIndex = 13;
            // 
            // TitleGroupName
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1286, 780);
            Controls.Add(Header);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TitleGroupName";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            TitlePanel.ResumeLayout(false);
            TitlePanel.PerformLayout();
            PanelWall.ResumeLayout(false);
            MemberPanel.ResumeLayout(false);
            MemberPanel.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel Header;
        private Panel TitlePanel;
        private Label Title;
        private Panel panel3;
        private Label GroupNo;
        private Panel MemberPanel;
        private Label label1;
        private Panel panel4;
        private Label LeaderLabel;
        private Krypton.Toolkit.KryptonButton ContinueButt;
        private Panel PanelWall;
        private Krypton.Toolkit.KryptonButton OpenButton;
        private Panel panel1;
        private Panel AdditionalDe;
        private Panel DesignPanel1;
        private Panel panel5;
        private Panel DesignPanel2;
        private Panel panel6;
    }
}
