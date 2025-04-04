namespace PlatechFCFSProdject
{
    public partial class TitleGroupName : Form
    {
        bool isOpen = false;
        public TitleGroupName()
        {
            InitializeComponent();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {


            if (!isOpen)
            {
                AdditionalDesignAnimatedO();
            }
            else
            {
                CloseTitleAnimated();
            }
        }

        //public void TitleAnimated()
        //{
        //    OpenButton.Enabled = false;
        //    isOpen = true;
        //    int GoalHeight = 721;
        //    int MemberPanelGoal = 427;
        //    int RegHeightOfRope = 0;
        //    Thread thread = new Thread(() =>
        //    {
        //        int currentTitleHeight = 0;
        //        int currentMemberHeight = 0;
        //        int RegSizeOfRope = 286;

        //        while (RegSizeOfRope > RegHeightOfRope)
        //        {
        //            RegSizeOfRope -= 10;
        //            Invoke((MethodInvoker)(() =>
        //            {
        //                RopePanel1.Height = RegSizeOfRope;
        //                RopePanel2.Height = RegSizeOfRope;
        //                PanelWall.Location = new Point(448, RegSizeOfRope);
        //            }));
        //            Thread.Sleep(25);
        //        }

        //        //===================================================
        //        while (currentTitleHeight < GoalHeight)
        //        {

        //            currentTitleHeight += 12;
        //            Invoke((MethodInvoker)(() =>
        //            {
        //                TitlePanel.Height = currentTitleHeight;
        //            }));
        //            Thread.Sleep(2);

        //        }
        //        //=================================================
        //        while (currentMemberHeight < MemberPanelGoal)
        //        {

        //            currentMemberHeight += 12;
        //            Invoke((MethodInvoker)(() =>
        //            {
        //                MemberPanel.Height = currentMemberHeight;
        //            }));
        //            Thread.Sleep(2);
        //        }

        //        Invoke((MethodInvoker)(() =>
        //        {
        //            ContinueButt.Visible = true;
        //            OpenButton.Values.Text = "Close";
        //            OpenButton.Enabled = true;
        //        }));
        //    });
        //    thread.Start();

        //}
        private void OpenTitleAnimated() {
            isOpen = true;
            int GoalTitleHeight = 346;
            int GoalMemberHeight = 267;
            Thread thread = new Thread(() =>
            {
                int CurrentTitleHeight = 0;
                int CUrrentMemberHeight = 0;

                while (CurrentTitleHeight < GoalTitleHeight) {
                    CurrentTitleHeight += 6;
                    Invoke((MethodInvoker)(() => {
                        TitlePanel.Height = CurrentTitleHeight;
                    }));
                    Thread.Sleep(10);
                }



                while (CUrrentMemberHeight < GoalMemberHeight)
                {
                    CUrrentMemberHeight += 6;
                    Invoke((MethodInvoker)(() => {
                        MemberPanel.Height = CUrrentMemberHeight;
                    }));
                    Thread.Sleep(10);
                }

                Invoke((MethodInvoker)(() =>
                {
                    ContinueButt.Visible = true;
                    OpenButton.Values.Text = "Close";
                    OpenButton.Enabled = true;
                }));

            });
            thread.Start();
        }


        private void CloseTitleAnimated()
        {
            OpenButton.Enabled = false;
            isOpen = false;
            ContinueButt.Visible = false;
            int GoalTitleHeight = 0;
            int GoalMemberHeight = 0;
            Thread thread = new Thread(() =>
            {
                int CurrentTitleHeight = 346;
                int CUrrentMemberHeight = 267;

                while (CUrrentMemberHeight > GoalMemberHeight)
                {
                    CUrrentMemberHeight -= 6;
                    Invoke((MethodInvoker)(() => {
                        MemberPanel.Height = CUrrentMemberHeight;
                    }));
                    Thread.Sleep(10);
                }

                while (CurrentTitleHeight > GoalTitleHeight)
                {
                    CurrentTitleHeight -= 6;
                    Invoke((MethodInvoker)(() => {
                        TitlePanel.Height = CurrentTitleHeight;
                    }));
                    Thread.Sleep(10);
                }
                Invoke((MethodInvoker)(() => {

                    AdditionalDesignAnimatedC();
                }));
            });
            thread.Start();
        }

        private void AdditionalDesignAnimatedO()
        {
            PanelDesign1Open();
            OpenButton.Enabled = false;
            isOpen = false;
            ContinueButt.Visible = false;
            int GoalWidth = 1287;
            int GoalLocation = 9;
            int GoalButton = 9;
            Thread thread = new Thread(() =>
            {
                int CurrentGoalWidth = 0;
                int CUrrentGoalLocation = 267;
                int CurrentGoalButton = 267;
                while (CurrentGoalWidth < GoalWidth)
                {
                    CurrentGoalWidth += 14;
                    Invoke((MethodInvoker)(() => {
                        AdditionalDe.Width = CurrentGoalWidth;

                    }));
                    Thread.Sleep(2);
                }

                while (CUrrentGoalLocation > GoalLocation)
                {
                    CUrrentGoalLocation -= 6;
                    CurrentGoalButton -= 6;
                    Invoke((MethodInvoker)(() => {
                        AdditionalDe.Location = new Point(0, CUrrentGoalLocation);
                        PanelWall.Location = new Point(452, CurrentGoalButton);
                    }));
                    Thread.Sleep(2);
                }
                Invoke((MethodInvoker)(() => {
                    OpenTitleAnimated();
                }));

            });
            thread.Start();
        }

        private void AdditionalDesignAnimatedC()
        {
            ContinueButt.Visible = false;
            isOpen = false;
            PanelDesign1Close();
            int GoalWidth = 0;
            int GoalLocation = 267;
            int GoalButton = 267;
            Thread thread = new Thread(() =>
            {
                int CurrentGoalWidth = 1287;
                int CUrrentGoalLocation = 9;
                int CurrentGoalButton = 9;

                while (CUrrentGoalLocation < GoalLocation)
                {
                    CUrrentGoalLocation += 6;
                    CurrentGoalButton += 6;
                    Invoke((MethodInvoker)(() =>
                    {
                        AdditionalDe.Location = new Point(0, CUrrentGoalLocation);
                        PanelWall.Location = new Point(452, CurrentGoalButton);
                    }));
                    Thread.Sleep(2);
                }

                while (CurrentGoalWidth > GoalWidth)
                {
                    CurrentGoalWidth -= 14;
                    Invoke((MethodInvoker)(() =>
                    {
                        AdditionalDe.Width = CurrentGoalWidth;

                    }));
                    Thread.Sleep(2);
                }
                OpenButton.Values.Text = "Open";
                OpenButton.Enabled = true;
            });
         
            thread.Start();
        }


        //public void TitleCloseAnimated()
        //{
        //    ContinueButt.Visible = false;
        //    OpenButton.Enabled = false;
        //    isOpen = false;
        //    int GoalHeight = 0;
        //    int MemberPanelGoal = 0;
        //    int RegHeightOfRope = 286;
        //    //=================================================
        //    Thread thread = new Thread(() =>
        //    {
        //        int currentMemberHeight = MemberPanel.Height;
        //        int currentTitleHeight = TitlePanel.Height;
        //        int RegSizeOfRope = 0;


        //        //=================================================

        //        while (currentMemberHeight > MemberPanelGoal)
        //        {
        //            currentMemberHeight -= 10;
        //            if (currentMemberHeight < MemberPanelGoal) currentMemberHeight = MemberPanelGoal;

        //            Invoke((MethodInvoker)(() =>
        //            {
        //                MemberPanel.Height = currentMemberHeight;
        //            }));

        //            Thread.Sleep(2);
        //        }

        //        //=================================================

        //        while (currentTitleHeight > GoalHeight)
        //        {
        //            currentTitleHeight -= 10;
        //            if (currentTitleHeight < GoalHeight) currentTitleHeight = GoalHeight;

        //            Invoke((MethodInvoker)(() =>
        //            {
        //                TitlePanel.Height = currentTitleHeight;
        //            }));

        //            Thread.Sleep(2);
        //        }


        //        while (RegSizeOfRope < RegHeightOfRope)
        //        {
        //            RegSizeOfRope += 10;
        //            Invoke((MethodInvoker)(() =>
        //            {

        //                PanelWall.Location = new Point(448, RegSizeOfRope);
        //            }));
        //            Thread.Sleep(25);
        //        }
        //        OpenButton.Values.Text = "Open";
        //        OpenButton.Enabled = true;
       //    });
       //    thread.Start();777777
        //}

        private void PanelDesign1Open()
        {
            DesignPanel1.BorderStyle = BorderStyle.Fixed3D;
            DesignPanel2.BorderStyle = BorderStyle.Fixed3D;
            int GoalLocationToUp = 391;
            int GoalLocationToLeft = 51;
            Thread thread = new Thread(() =>
            {
                int currentLocation = 417;
                while (currentLocation > GoalLocationToUp) {

                    currentLocation -= 1;
                    Invoke((MethodInvoker)(() =>
                    {
                        DesignPanel1.Location = new Point(80, currentLocation);
                        DesignPanel2.Location = new Point(904, currentLocation);
                    }));

                    Thread.Sleep(30);

                }

                int currentPosition = 80;
                int currentPositionPanel2 = 904;
                while (currentPosition > GoalLocationToLeft)
                {

                    currentPosition -= 1;
                    currentPositionPanel2 += 1;
                    Invoke((MethodInvoker)(() =>
                    {
                        DesignPanel1.Location = new Point(currentPosition, currentLocation);
                        DesignPanel2.Location = new Point(currentPositionPanel2, currentLocation);
                    }));

                    Thread.Sleep(30);
                }
              
            });
            thread.Start();

        }


        private void PanelDesign1Close()
        {
            DesignPanel1.BorderStyle = BorderStyle.Fixed3D;
            DesignPanel2.BorderStyle = BorderStyle.Fixed3D;
            int GoalLocationToUp = 417;
            int GoalLocationToLeft = 80;
            Thread thread = new Thread(() =>
            {

                int currentLocation = 391;
                int currentPosition = 51; 
                int currentPositionPanel2 = 936;
                while (currentPosition < GoalLocationToLeft)
                {

                    currentPosition += 1;
                    currentPositionPanel2 -= 1;
                    Invoke((MethodInvoker)(() =>
                    {
                        DesignPanel1.Location = new Point(currentPosition, currentLocation);
                        DesignPanel2.Location = new Point(currentPositionPanel2, currentLocation);
                    }));

                    Thread.Sleep(30);
                }

             
                while (currentLocation < GoalLocationToUp)
                {

                    currentLocation += 1;
                    Invoke((MethodInvoker)(() =>
                    {
                        DesignPanel1.Location = new Point(80, currentLocation);
                        DesignPanel2.Location = new Point(904, currentLocation);
                    }));

                    Thread.Sleep(30);

                }

                Invoke((MethodInvoker)(() =>
                {
                    DesignPanel1.BorderStyle = BorderStyle.None;
                    DesignPanel2.BorderStyle = BorderStyle.None;
                }));
            });
            thread.Start();

        }

        private void ContinueButt_Click(object sender, EventArgs e)
        {
            this.Hide();
            InputProcess InputProcess = new InputProcess();
            InputProcess.Show();
        }
    }
}
