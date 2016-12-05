using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;

namespace _4BarSimulator_WinForm
{
    public class FourBarMachine
    {
        #region Lengh
        double[] lenght = new double[4];

        public static int initialLength = 1;

        public double R1{
            get { return lenght[0]; }
            set { lenght[0] = value<=0f? initialLength:value; }
        }
        public double R2
        {
            get { return lenght[1]; }
            set { lenght[1] = value <= 0f ? initialLength : value; }
        }
        public double R3
        {
            get { return lenght[2]; }
            set { lenght[2] = value <= 0f ? initialLength : value; }
        }
        public double R4
        {
            get { return lenght[3]; }
            set { lenght[3] = value <= 0f ? initialLength : value; }
        }
        #endregion
        #region Angle
        double[] angle = new double[4];

        public static double initialAngle = 60f;

        public double angle1
        {
            get { return angle[0]; }
            set {
                /*while (value > 360f) { value -= 360f; }
                while (value < 0f) { value += 360f; }*/
                angle[0] = value;
            }
        }
        public double angle2
        {
            get { return angle[1]; }
            set {
                /*while (value > 360f) { value -= 360f; }
                while (value < 0f) { value += 360f; }*/
                angle[1] = value ;
            }
        }
        public double angle3
        {
            get { return angle[2]; }
            set {
               /* while (value > 360f) { value -= 360f; }
                while (value < 0f) { value += 360f; }*/
                angle[2] = value; }
        }
        public double angle4
        {
            get { return angle[3]; }
            set {
               /* while (value > 360f) { value -= 360f; }
                while (value < 0f) { value += 360f; }*/
                angle[3] = value; }
        }
        #endregion
        #region Velocity
        double[] angleVelocity = new double[4];

        public double W1
        {
            get { return angleVelocity[0]; }
            set { angleVelocity[0] = value; }
        }
        public double W2
        {
            get { return angleVelocity[1]; }
            set { angleVelocity[1] = value; }
        }
        public double W3
        {
            get { return angleVelocity[2]; }
            set { angleVelocity[2] = value ; }
        }
        public double W4
        {
            get { return angleVelocity[3]; }
            set { angleVelocity[3] = value ; }
        }
        public double Velocity(int index) {
            return angleVelocity[index] * lenght[index];
        }
        #endregion

        #region NewtonRaphson
        double baisW3 = 10000;
        double baisW4 = 10000;

        public void RefreshBais() {
            baisW3 = baisW4 = 10000;
        }

        public void NewtonRaphsonGetAngle3Angle4(double assumeAngle3,double assumeAngle4,out double _angle3,out double _angle4) {

            Matrix<double> F = DenseMatrix.OfArray(new double[,] {
                    {R2*Math.Cos(angle2)+R3*Math.Cos(assumeAngle3)-R4*Math.Cos(assumeAngle4)-R1},
                    {R2*Math.Sin(angle2)+R3*Math.Sin(assumeAngle3)-R4*Math.Sin(assumeAngle4)} });


            while (Math.Abs(F[0,0]) > 0.01 || Math.Abs(F[1,0]) > 0.01)
            {

                Matrix<double> J = DenseMatrix.OfArray(new double[,] {
                        {-R3*Math.Sin(assumeAngle3),R4*Math.Sin(assumeAngle4)},
                        {R3*Math.Cos(assumeAngle3),-R4*Math.Cos(assumeAngle4)} });

                var deltaAngle = J.Inverse() * F.Multiply(-1);

                assumeAngle3 += deltaAngle[0, 0];
                assumeAngle4 += deltaAngle[1, 0];

                //
                F = DenseMatrix.OfArray(new double[,] {
                    {R2*Math.Cos(angle2)+R3*Math.Cos(assumeAngle3)-R4*Math.Cos(assumeAngle4)-R1},
                    {R2*Math.Sin(angle2)+R3*Math.Sin(assumeAngle3)-R4*Math.Sin(assumeAngle4)} });

            }
            _angle3 = angle3 = assumeAngle3;
            _angle4 = angle4 = assumeAngle4;


            return;

        }
        #endregion

        #region RelativeSpeed
        public double GetW3ByR2()
        {
            return R2 * W2 * Math.Sin(angle4 - angle2) / (R3 * Math.Sin(angle3 - angle4));
        }
        public double GetW4ByR2()
        {
            return R2 * W2 * Math.Sin(angle2 - angle3) / (R3 * Math.Sin(angle4 - angle3));
        }
        #endregion

        public bool IsBarLenthOK(int index,double value)
        {
            double[] bars = lenght;
            bars[index-1] = value;

            for(int i=0;i<4 ;i++) {
                double otherLenth = 0;
                for (int j = 0; j < 4; j++)
                {
                    if (j != i)
                        otherLenth += bars[j];
                }
                if(otherLenth < bars[i])
                    return false;
            }

            if (bars[2] + bars[3] < bars[0] + bars[1])
                return false;
            return true;
        }
    }
}
