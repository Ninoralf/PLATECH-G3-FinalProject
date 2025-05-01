using System.Windows.Forms;

namespace PlatechFCFSProdject
{
    public partial class TitleGroupName : Form
    {
        bool isOpen = false;
        private Image[] imagePaths;
        private int currentIndex = 0;
        public TitleGroupName()
        {
            InitializeComponent();
        }

        private void LoadImages()
        {
            FlowChartPanel.Visible = true;
            imagePaths = new Image[]
            {
                Properties.Resources.Image1,
                Properties.Resources.Image2,
                Properties.Resources.Image3,
                Properties.Resources.Image4,
                Properties.Resources.Image5,
                Properties.Resources.image6,
                Properties.Resources.image7,
                Properties.Resources.image8
            };

            ShowImage();
        }

        private void ShowImage()
        {

            if (imagePaths.Length > 0 && currentIndex >= 0 && currentIndex < imagePaths.Length)
            {
                FlowChartPanel.BackgroundImage = imagePaths[currentIndex];
                FlowChartPanel.BackgroundImageLayout = ImageLayout.Stretch;
                Pageno.Text = $"Page {currentIndex + 1}";
            }

            PrevButt.Enabled = currentIndex > 0;
            NextButt.Enabled = currentIndex < imagePaths.Length - 1;

        }

        // CLICKABLE BUTTONS METHOD ================================================
        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            if (!isOpen)
            {
                FlowChartButt.Visible = false;
                AdditionalDesignAnimatedO();
            }
            else
            {
                CloseTitleAnimated();
                FlowChartButt.Visible = true;
            }
        }
        private void ContinueButt_Click(object sender, EventArgs e)
        {
            this.Hide(); // HIDE FORM
            InputProcess InputProcess = new InputProcess(); // OPEN INPUT PROCESS FORM
            InputProcess.Show();
        }
        private void ExampleButt_Click(object sender, EventArgs e)
        {
            ExamplePanelShown();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ExamplePanel.Visible = false;
        }
        private void ExitDescription_Click(object sender, EventArgs e)
        {
            DescriptionPanel.Visible = false;
        }
        private void DescriptionButt_Click(object sender, EventArgs e)
        {
            DescriptionPanelShown();
        }
        // ANIMATED METHOD =========================================================
        // OPEN
        private void OpenTitleAnimated()
        {
            isOpen = true;
            int GoalTitleHeight = 346; // GOAL HEIGHT / THE TITLE PANEL WILL STOP HERE.
            int GoalMemberHeight = 267; // GOAL HEIGHT / THE MEMBER PANEL WILL STOP HERE.
            Thread thread = new Thread(() =>
            {
                int CurrentTitleHeight = 0;
                int CUrrentMemberHeight = 0;

                while (CurrentTitleHeight < GoalTitleHeight)
                {
                    CurrentTitleHeight += 6;
                    Invoke((MethodInvoker)(() =>
                    {
                        TitlePanel.Height = CurrentTitleHeight; // CHANGE HEIGHT OF TITLE PANEL BASE ON CurrentTitleHeight
                    }));
                    Thread.Sleep(10); // sleep 
                }


                // AFTER TITLE PANEL SHOWN, THE MEMBER PANEL CODE ANIMATE HERE.
                while (CUrrentMemberHeight < GoalMemberHeight)
                {
                    CUrrentMemberHeight += 6;
                    Invoke((MethodInvoker)(() =>
                    {
                        MemberPanel.Height = CUrrentMemberHeight;
                    }));
                    Thread.Sleep(10);
                }

                // AFTER ALL PANEL ARE SHOWN, APPLY THE ASSIGN BUTTONS.
                Invoke((MethodInvoker)(() =>
                {
                    ContinueButt.Visible = true;
                    OpenButton.Values.Text = "Close";
                    OpenButton.Enabled = true;
                }));

            });
            thread.Start();
        }
        // CLOSE
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
                    Invoke((MethodInvoker)(() =>
                    {
                        MemberPanel.Height = CUrrentMemberHeight;
                    }));
                    Thread.Sleep(10);
                }

                while (CurrentTitleHeight > GoalTitleHeight)
                {
                    CurrentTitleHeight -= 6;
                    Invoke((MethodInvoker)(() =>
                    {
                        TitlePanel.Height = CurrentTitleHeight;
                    }));
                    Thread.Sleep(10);
                }
                Invoke((MethodInvoker)(() =>
                {

                    AdditionalDesignAnimatedC();
                }));
            });
            thread.Start();
        }
        //==========================================================================
        // OPEN
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
                    Invoke((MethodInvoker)(() =>
                    {
                        AdditionalDe.Width = CurrentGoalWidth;

                    }));
                    Thread.Sleep(2);
                }

                while (CUrrentGoalLocation > GoalLocation)
                {
                    CUrrentGoalLocation -= 6;
                    CurrentGoalButton -= 6;
                    Invoke((MethodInvoker)(() =>
                    {
                        AdditionalDe.Location = new Point(0, CUrrentGoalLocation);
                        PanelWall.Location = new Point(452, CurrentGoalButton);
                    }));
                    Thread.Sleep(2);
                }
                Invoke((MethodInvoker)(() =>
                {
                    OpenTitleAnimated();
                }));
            });
            thread.Start();
        }
        // CLOSE
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
        //==========================================================================
        // OPEN
        private void PanelDesign1Open()
        {
            DesignPanel1.BorderStyle = BorderStyle.Fixed3D;
            DesignPanel2.BorderStyle = BorderStyle.Fixed3D;
            int GoalLocationToUp = 391;
            int GoalLocationToLeft = 51;
            Thread thread = new Thread(() =>
            {
                int currentLocation = 417;
                while (currentLocation > GoalLocationToUp)
                {

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
                Invoke((MethodInvoker)(() =>
                {
                    DescriptionButt.Visible = true;
                    ExampleButt.Visible = true;
                }));
            });
            thread.Start();

        }
        // CLOSE
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
                    DescriptionButt.Visible = false;
                    ExampleButt.Visible = false;
                }));
            });
            thread.Start();

        }
        private void ExamplePanelShown()
        {
            ExampleButt.Enabled = false;
            DescriptionButt.Enabled = false;
            ExamplePanel.Visible = true;
            int GoalLocationToLeft = 6;
            Thread thread = new Thread(() =>
            {

                int currentPosition = 1340;

                while (currentPosition > GoalLocationToLeft)
                {

                    currentPosition -= 10;

                    Invoke((MethodInvoker)(() =>
                    {
                        ExamplePanel.Location = new Point(currentPosition, 3);
                    }));

                    Thread.Sleep(2);
                }

                ExampleButt.Enabled = true;
                DescriptionButt.Enabled = true;
            });
            thread.Start();


        }
        private void DescriptionPanelShown()
        {
            ExampleButt.Enabled = false;
            DescriptionButt.Enabled = false;
            DescriptionPanel.Visible = true;
            int GoalLocationToLeft = 0;
            Thread thread = new Thread(() =>
            {

                int currentPosition = -1340;

                while (currentPosition < GoalLocationToLeft)
                {

                    currentPosition += 10;

                    Invoke((MethodInvoker)(() =>
                    {
                        DescriptionPanel.Location = new Point(currentPosition, 3);
                    }));

                    Thread.Sleep(2);
                }

                ExampleButt.Enabled = true;
                DescriptionButt.Enabled = true;
            });
            thread.Start();


        }

        private void PrevButt_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                ShowImage();
            }
        }

        private void NextButt_Click(object sender, EventArgs e)
        {
            if (currentIndex < imagePaths.Length - 1)
            {
                currentIndex++;
                ShowImage();
            }
        }

        private void FlowChartButt_Click(object sender, EventArgs e)
        {
            LoadImages();
        }

        private void ExitFlowButt_Click(object sender, EventArgs e)
        {
            FlowChartPanel.Visible = false;
            currentIndex = 0;
        }
    }
}
