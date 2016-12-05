using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Web.UI.DataVisualization.Charting;
using System.Threading;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;

namespace _4BarSimulator_WinForm
{
    public partial class Form1 : Form
    {
        //machine
        FourBarMachine machine = new FourBarMachine();

        //orginAngle2
        double orginAngle2 = 0;

        //animation
        Graphics grahics;
        Thread animator;
        ManualResetEvent _shutdownEvent = new ManualResetEvent(false);
        ManualResetEvent _pauseEvent = new ManualResetEvent(true);
        int freqence = 10;

        //plot element
        Pen OutBar = new Pen(Color.DarkSlateGray, 10f);
        Pen InBar = new Pen(Color.LightGray,4f);
        Point canvasSize = new Point(404,219);
        Point Unit;
        Point O = new Point(0, 0);
        Point A = new Point(0,0);
        Point B = new Point(0, 0);
        Point C = new Point(0,0);
        Point[] points = new Point[2];
        ToolTip tooltip = new ToolTip();
        Point? clickPosition = null;

        //angle use to plot
        double plotAngle2;
        double plotAngle3;
        double plotAngle4;
        double deltaAngle = Math.PI/180;

        //data array
        double[] Bar2Angle = new double[360];
        double[] Bar3Angle = new double[360];
        double[] Bar4Angle = new double[360];

        public Form1()
        {
            InitializeComponent();
            initialGraph();
            AddNewMachine();
            PlayAnimtaion();
        }

        public void AddNewMachine() {
            EventArgs e = new EventArgs();
            machine.R1 = (double)tckb_R1.Value;
            machine.R2 = (double)tckb_R2.Value;
            machine.R3 = (double)tckb_R3.Value;
            machine.R4 = (double)tckb_R4.Value;

            for (int i=0; i<360;i++) {
                Bar2Angle[i] = i;
            }

            txt_Angle2.Text = (0).ToString();
            RecaculateMachine();
            txt2Angle_Change(this,new EventArgs());

        }

        public void initialGraph() {
            grahics = pic_animation.CreateGraphics();
            DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        public void PlayAnimtaion() {
            animator = new Thread(Animation);
            animator.IsBackground = true;
            animator.Start();
        }

        private void tckb_R1_Scroll(object sender, EventArgs e)
        {
            ChangeBarLengh(1,e);
        }

        private void tckb_R2_Scroll(object sender, EventArgs e)
        {
            ChangeBarLengh(2,e);
        }

        private void tckb_R3_Scroll(object sender, EventArgs e)
        {
            ChangeBarLengh(3,e);
        }

        private void tckb_R4_Scroll(object sender, EventArgs e)
        {
            ChangeBarLengh(4,e);
        }

        private void txt2Angle_Change(object sender, EventArgs e)
        {

            if (txt_Angle2.Text == "") { txt_Angle2.Text = orginAngle2.ToString(); return; }

            txt_Angle3.Text = Bar3Angle[int.Parse(txt_Angle2.Text)].ToString();
            txt_Angle4.Text = Bar4Angle[int.Parse(txt_Angle2.Text)].ToString();
        }

        private void ChangeBarLengh(int i,EventArgs e) {

            switch (i)
            {
                case 4:
                    if (!machine.IsBarLenthOK(i, (double)tckb_R4.Value))
                    {
                        tckb_R4.Value = (int)machine.R4;
                        tckb_R4.BackColor = Color.DarkRed;
                        txt_Log.Text = "桿件4長度調整造成桿件不成立，保留之前值(已標示紅底)";
                        return;
                    }
                    else
                        tckb_R4.BackColor = Color.Gray;
                    break;
                case 1:
                    if (!machine.IsBarLenthOK(i, (double)tckb_R1.Value))
                    {
                        tckb_R1.Value = (int)machine.R1;
                        tckb_R1.BackColor = Color.DarkRed;
                        txt_Log.Text = "桿件1長度調整造成桿件不成立，保留之前值(已標示紅底)";
                        return;
                    }
                    else
                        tckb_R1.BackColor = Color.Gray;
                    break;
                case 2:
                    if (!machine.IsBarLenthOK(i, (double)tckb_R2.Value)) {
                        tckb_R2.Value = (int)machine.R2;
                        tckb_R2.BackColor = Color.DarkRed;
                        txt_Log.Text = "桿件2長度調整造成桿件不成立，保留之前值(已標示紅底)";
                        return;
                    }
                    else
                        tckb_R2.BackColor = Color.Gray;
                    break;
                case 3:
                    if (!machine.IsBarLenthOK(i, (double)tckb_R3.Value))
                    {
                        tckb_R3.Value = (int)machine.R3;
                        tckb_R3.BackColor = Color.DarkRed;
                        txt_Log.Text = "桿件3長度調整造成桿件不成立，保留之前值(已標示紅底)";
                        return;
                    }
                    else
                        tckb_R3.BackColor = Color.Gray;
                    break;
            }

            switch (i) {
                case 4:
                    txt_R4.Text = tckb_R4.Value.ToString();
                    machine.R4 = (double)tckb_R4.Value;
                    break;
                case 1:
                    txt_R1.Text = tckb_R1.Value.ToString();
                    machine.R1 = (double)tckb_R1.Value;
                    break;
                case 2:
                    txt_R2.Text = tckb_R2.Value.ToString();
                    machine.R2 = (double)tckb_R2.Value;
                    break;
                case 3:
                    txt_R3.Text = tckb_R3.Value.ToString();
                    machine.R3 = (double)tckb_R3.Value;
                    break;
            }
            RecaculateMachine();


        }

        private void RecaculateMachine()
        {
            chart_angle.Series["桿三"].Points.Clear();
            chart_angle.Series["桿四"].Points.Clear();
            chart_angle.MaximumSize = new Size(360, 360);
            chart_angle.MinimumSize = new Size(0, 0);
            


            plotAngle2 = Double.Parse(txt_Angle2.Text) * Math.PI / 180;

            for (int i = 0; i < 360; i++)
            {
                //CaculateAngle
                var esAngle3 = i == 0 ? 60 : Bar3Angle[i - 1];
                var esAngle4 = i == 0 ? 113 : Bar4Angle[i - 1];
                machine.angle2 = (Double)(i) * Math.PI / 180;
                machine.NewtonRaphsonGetAngle3Angle4((esAngle3 * Math.PI / 180), (esAngle4 * Math.PI / 180), out plotAngle3, out plotAngle4);
                Bar3Angle[i] = (machine.angle3 * 180 / Math.PI);
                Bar4Angle[i] = (machine.angle4 * 180 / Math.PI);
                if (i == Double.Parse(txt_Angle2.Text))
                {
                    txt_Angle3.Text = Bar3Angle[i].ToString();
                    txt_Angle4.Text = Bar4Angle[i].ToString();
                    orginAngle2 = machine.angle2;
                }

                //chart
                chart_angle.Series["桿三"].Points.AddXY(Bar2Angle[i], Bar3Angle[i]);
                chart_angle.Series["桿四"].Points.AddXY(Bar2Angle[i], Bar4Angle[i]);

            }
        }

        private void txt2Angle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }


        }

        private void Animation() {
            while (true) {
                for (int i = (int)plotAngle2; i < 360; i++)
                {
                    if (!animator.IsBackground)
                    {
                        break;
                    }
                    //grahics.Clear(pic_animation.BackColor);
                    plotAngle2 = Bar2Angle[i] * Math.PI / 180;
                    plotAngle3 = Bar3Angle[i] * Math.PI / 180;
                    plotAngle4 = Bar4Angle[i] * Math.PI / 180;
                    PlotMachineAnimation();
                    Thread.Sleep(freqence);
                }
            }
        }

        //animator

        private void PlotMachineAnimation() {
            grahics.Clear(pic_animation.BackColor);
            //pic_animation.Refresh();
            Unit = new Point(pic_animation.Height / 12, pic_animation.Height / 12);

            O.X = Unit.X * 10;
            O.Y = C.Y = pic_animation.Size.Height*3/5;
            A.X = O.X + (int)(machine.R2 * (double)Unit.X * Math.Cos(plotAngle2));
            A.Y = O.Y + (int)(machine.R2 * (double)Unit.Y * Math.Sin(-plotAngle2));
            B.X = A.X + (int)(machine.R3 * (double)Unit.X * Math.Cos(plotAngle3));
            B.Y = A.Y + (int)(machine.R3 * (double)Unit.Y * Math.Sin(-plotAngle3));
            C.X = O.X + (int)(machine.R1 * (double)Unit.Y);

            points[0] = C;
            points[1] = O;
            grahics.DrawLines(OutBar, points);
            grahics.DrawLines(InBar, points);
            grahics.DrawEllipse(OutBar, points[0].X - Unit.X/2, points[0].Y - Unit.X/2, Unit.X,Unit.Y);
            grahics.DrawEllipse(InBar, points[0].X - Unit.X / 3, points[0].Y - Unit.X / 3, Unit.X*2/3, Unit.X * 2 / 3);
            points[0] = O;
            points[1] = A;
            grahics.DrawLines(OutBar, points);
            grahics.DrawLines(InBar, points);
            grahics.DrawEllipse(OutBar, points[0].X - Unit.X / 2, points[0].Y - Unit.X / 2, Unit.X, Unit.Y);
            grahics.DrawEllipse(InBar, points[0].X - Unit.X / 3, points[0].Y - Unit.X / 3, Unit.X * 2 / 3, Unit.X * 2 / 3);
            points[0] = A;
            points[1] = B;
            grahics.DrawLines(OutBar, points);
            grahics.DrawLines(InBar, points);
            grahics.DrawEllipse(OutBar, points[0].X - Unit.X / 2, points[0].Y - Unit.X / 2, Unit.X, Unit.Y);
            grahics.DrawEllipse(InBar, points[0].X - Unit.X / 3, points[0].Y - Unit.X / 3, Unit.X * 2 / 3, Unit.X * 2 / 3);
            points[0] = B;
            points[1] = C;
            grahics.DrawLines(OutBar, points);
            grahics.DrawLines(InBar, points);
            grahics.DrawEllipse(OutBar, points[0].X - Unit.X / 2, points[0].Y - Unit.X / 2, Unit.X, Unit.Y);
            grahics.DrawEllipse(InBar, points[0].X - Unit.X / 3, points[0].Y - Unit.X / 3, Unit.X * 2 / 3, Unit.X * 2 / 3);

        }

        private void btn_animationCtrl_Click(object sender, EventArgs e)
        {

            if (animator.IsBackground)
            {
                //txt_Log.Text = plotAngle2.ToString();
                animator.IsBackground = false;
                _pauseEvent.Reset();
                btn_animationCtrl.Text = "繼續";
            }
            else {
                //txt_Log.Text = plotAngle2.ToString();
                animator.IsBackground = true;
                _pauseEvent.Set();
                btn_animationCtrl.Text = "停止";
            }
        }

        private void FinishWindow(object sender, EventArgs e)
        {
            animator.Abort();
        }

        private void chart_angle_MouseClick(object sender, MouseEventArgs e)
        {
            ChartArea angleArea = chart_angle.ChartAreas[0];
            var xv = angleArea.AxisX.PixelPositionToValue(e.X);
            var yv = angleArea.AxisY.PixelPositionToValue(e.Y);
            // txt_Log.Text = "x = " + xv + "   y =" + yv;

            if (xv >= 0 && xv < 360)
            {
                txt_Angle2.Text = ((int)xv).ToString();
                angleArea.CursorX.SetCursorPosition(xv);
                if(e.Button == MouseButtons.Left)
                    angleArea.CursorY.SetCursorPosition(Bar3Angle[(int)xv]);
                else
                    angleArea.CursorY.SetCursorPosition(Bar4Angle[(int)xv]);

            }
        }

        private void tckb_speed_Scroll(object sender, EventArgs e)
        {
            /*switch (tckb_speed.Value) {
                case 0:
                    freqence = 0;
                    break;
                default:
                    freqence = (int)((double)(tckb_speed.Value)*(1/360));
                    break;
            }*/
        }
    }
}
