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
                TitleAnimated();

            }
            else
            {
                TitleCloseAnimated();
            }
        }

        public void TitleAnimated()
        {
            OpenButton.Enabled = false;
            isOpen = true;
            int GoalHeight = 721;
            int MemberPanelGoal = 427;
            int RegHeightOfRope = 0;
            Thread thread = new Thread(() =>
            {
                int currentTitleHeight = 0;
                int currentMemberHeight = 0;
                int RegSizeOfRope = 286;

                while (RegSizeOfRope > RegHeightOfRope)
                {
                    RegSizeOfRope -= 10;
                    Invoke((MethodInvoker)(() =>
                    {
                        RopePanel1.Height = RegSizeOfRope;
                        RopePanel2.Height = RegSizeOfRope;
                        PanelWall.Location = new Point(448, RegSizeOfRope);
                    }));
                    Thread.Sleep(25);
                }

                //===================================================
                while (currentTitleHeight < GoalHeight)
                {

                    currentTitleHeight += 12;
                    Invoke((MethodInvoker)(() =>
                    {
                        TitlePanel.Height = currentTitleHeight;
                    }));
                    Thread.Sleep(2);

                }
                //=================================================
                while (currentMemberHeight < MemberPanelGoal)
                {

                    currentMemberHeight += 12;
                    Invoke((MethodInvoker)(() =>
                    {
                        MemberPanel.Height = currentMemberHeight;
                    }));
                    Thread.Sleep(2);
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

        public void TitleCloseAnimated()
        {
            ContinueButt.Visible = false;
            OpenButton.Enabled = false;
            isOpen = false;
            int GoalHeight = 0;
            int MemberPanelGoal = 0;
            int RegHeightOfRope = 286;
            //=================================================
            Thread thread = new Thread(() =>
            {
                int currentMemberHeight = MemberPanel.Height;
                int currentTitleHeight = TitlePanel.Height;
                int RegSizeOfRope = 0;

               
                //=================================================

                while (currentMemberHeight > MemberPanelGoal)
                {
                    currentMemberHeight -= 10;
                    if (currentMemberHeight < MemberPanelGoal) currentMemberHeight = MemberPanelGoal;

                    Invoke((MethodInvoker)(() =>
                    {
                        MemberPanel.Height = currentMemberHeight;
                    }));

                    Thread.Sleep(2);
                }

                //=================================================

                while (currentTitleHeight > GoalHeight)
                {
                    currentTitleHeight -= 10;
                    if (currentTitleHeight < GoalHeight) currentTitleHeight = GoalHeight;

                    Invoke((MethodInvoker)(() =>
                    {
                        TitlePanel.Height = currentTitleHeight;
                    }));

                    Thread.Sleep(2);
                }


                while (RegSizeOfRope < RegHeightOfRope)
                {
                    RegSizeOfRope += 10;
                    Invoke((MethodInvoker)(() =>
                    {
                        RopePanel1.Height = RegSizeOfRope;
                        RopePanel2.Height = RegSizeOfRope;
                        PanelWall.Location = new Point(448, RegSizeOfRope);
                    }));
                    Thread.Sleep(25);
                }


                OpenButton.Values.Text = "Open";
                OpenButton.Enabled = true;


            });

            thread.IsBackground = true;
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
