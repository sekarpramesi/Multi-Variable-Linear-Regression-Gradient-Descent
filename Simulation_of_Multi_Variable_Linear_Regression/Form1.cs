using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

namespace Simulation_of_Multi_Variable_Linear_Regression
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<float> f1;//fixed_acidity;
        List<float> f2;//volatile_acidity;
        List<float> f3;//citric_acid;
        List<float> f4;//residual_sugar;
        List<float> f5;//chlorides_;
        List<float> f6;//free_sulfur_dioxide;
        List<float> f7;//total_sulfur_dioxide;
        List<float> f8;//density_;
        List<float> f9;//ph_;
        List<float> f10;//sulphates_;
        List<float> f11;//alcohol_;
        List<float> y;//quality_;

        string line;
        List<List<float>> points = new List<List<float>>();

        void read()
        {
            FileStream aFile = new FileStream("../" + file.Text + ".csv", FileMode.Open);
            StreamReader sr = new StreamReader(aFile);

            string[] row = new string[12];
            //fixed_acidity
            f1= new List<float>();
            //volatile_acidity
            f2= new List<float>();
            //citric_acid 
            f3= new List<float>();
            //residual_sugar
            f4= new List<float>();
            //chlorides_ =
            f5= new List<float>();
            //free_sulfur_dioxide
            f6= new List<float>();
            //total_sulfur_dioxide
            f7= new List<float>();
            //density_
            f8= new List<float>();
            //ph_
            f9= new List<float>();
            //sulphates_
            f10= new List<float>();
            //alcohol_
            f11= new List<float>();
            //quality_
            y= new List<float>();



            int ctr = 0;
            bool kata = true;
            while ((line = sr.ReadLine()) != null)
            {
                if (kata==false)
                {
                    row = line.Split(';');
                    f1.Add(float.Parse(row[0]));
                    f2.Add(float.Parse(row[1]));
                    f3.Add(float.Parse(row[2]));
                    f4.Add(float.Parse(row[3]));
                    f5.Add(float.Parse(row[4]));
                    f6.Add(float.Parse(row[5]));
                    f7.Add(float.Parse(row[6]));
                    f8.Add(float.Parse(row[7]));
                    f9.Add(float.Parse(row[8]));
                    f10.Add(float.Parse(row[9]));
                    f11.Add(float.Parse(row[10]));
                    y.Add(float.Parse(row[11]));
                    listBox1.Items.Add(f1[ctr]);
                    ctr++;
                }
                kata = false;
            }
            sr.Close();
        }

        private void get_Click(object sender, EventArgs e)
        {

            read();
            initMatrix();
            feature_scaling();
            runner();
            f1.Clear();
            f2.Clear();
            f3.Clear();
            f4.Clear();
            f5.Clear();
            f6.Clear();
            f7.Clear();
            f8.Clear();
            f9.Clear();
            f10.Clear();
            f11.Clear();
            y.Clear();
            points.Clear();
        }

        void initMatrix()
        {
            points.Add(f1);
            points.Add(f2);
            points.Add(f3);
            points.Add(f4);
            points.Add(f5);
            points.Add(f6);
            points.Add(f7);
            points.Add(f8);
            points.Add(f9);
            points.Add(f10);
            points.Add(f11);
            points.Add(y);
        }

        float[] gradient_descent(float[] curTheta, float a, int tC, int dC)
        {
            float[] temp = curTheta;
            float[] newTheta = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            float[] sigma = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            float h = 0;

            for (int j = 0; j < 12; j++)
            {
                for (int i = 0; i < dC; i++)
                {//per dataCount - (row)
                    h = temp[0] + temp[1] * points[0][i] + temp[2] * points[1][i]
                        + temp[3] * points[2][i] + temp[4] * points[3][i] + temp[5] * points[4][i]
                        + temp[6] * points[5][i] + temp[7] * points[6][i] + temp[8] * points[7][i]
                        + temp[9] * points[8][i] + temp[10] * points[9][i] + temp[11] * points[10][i];

                    sigma[j] += h - points[11][i];
                }
            }


            for (int idxTheta = 0; idxTheta < tC; idxTheta++)
            {
                newTheta[idxTheta] = curTheta[idxTheta] - (a * sigma[idxTheta]) / dC;
                //MessageBox.Show("Theta " + idxTheta + " :" + newTheta[idxTheta]);
            }
            return newTheta;
        }

        float hypothesis(int index,float[] diffTheta)
        {
            
            int tC = 12;
            float h = 0;
           
            for (int k = 0; k < tC; k++)
            { //sigma hypothesis-y - (column)
                if (k == 0)
                    h += diffTheta[k];
                else
                    h += diffTheta[k] * points[k][index];
            }
           
            return h;
        }

        float error(float[] temp, int dC)
        {

            float totalError = 0;
            float h = 0;
            for (int i = 0; i < dC; i++)
            {
                h = temp[0] + temp[1] * points[0][i] + temp[2] * points[1][i]
                    + temp[3] * points[2][i] + temp[4] * points[3][i] + temp[5] * points[4][i]
                    + temp[6] * points[5][i] + temp[7] * points[6][i] + temp[8] * points[7][i]
                    + temp[9] * points[8][i] + temp[10] * points[9][i] + temp[11] * points[10][i];

                totalError += ((h-points[11][i]) * (h-points[11][i]));
                //totalError += (h - points[11][i]);
            }
            totalError = totalError / (2 * dC);
            return totalError;
        }

        void runner()
        {
            int iter = Convert.ToInt32(iterUser.Text);
            float alpha = Convert.ToSingle(alphaUser.Text);
            int thetaCount = 12;
            int dataCount = y.Count;

 
            chart1.Series.Clear();
            chart1.Series.Add("CostFunction");
            chart1.Series["CostFunction"].IsXValueIndexed = true;
            chart1.Series["CostFunction"].ChartType = SeriesChartType.Line;
            


            //chart1.Series["Series1"].ChartArea = "ChartArea1";




            float[] theta = {Convert.ToSingle(f1User.Text),Convert.ToSingle(f2User.Text),Convert.ToSingle(f3User.Text),
                                Convert.ToSingle(f4User.Text),Convert.ToSingle(f5User.Text),Convert.ToSingle(f6User.Text),
                                Convert.ToSingle(f7User.Text),Convert.ToSingle(f8User.Text),Convert.ToSingle(f9User.Text),
                                Convert.ToSingle(f10User.Text),Convert.ToSingle(f11User.Text),Convert.ToSingle(f12User.Text)};

            float err = 0;
            for (int i = 0; i < iter; i++)
            {
               theta = gradient_descent(theta, alpha, thetaCount, dataCount);
               err = error(theta, dataCount);
               chart1.Series["CostFunction"].Points.AddXY(i,err);
            }

            chart1.Invalidate();
            MessageBox.Show("Minimum Cost Function : " + err);

        }

        void feature_scaling()//and mean normalization
        {
            listBox1.Items.Clear();
            float[] max = { float.MinValue, float.MinValue, float.MinValue, 
                          float.MinValue,float.MinValue,float.MinValue,
                          float.MinValue,float.MinValue,float.MinValue,
                          float.MinValue,float.MinValue,float.MinValue,};
            float[] min = { float.MaxValue, float.MaxValue, float.MaxValue, 
                          float.MaxValue,float.MaxValue,float.MaxValue,
                          float.MaxValue,float.MaxValue,float.MaxValue,
                          float.MaxValue,float.MaxValue,float.MaxValue};

            float[] range = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            float[] avg = {0,0,0,0,0,0,0,0,0,0,0,0};
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < y.Count; j++)
                {
                    max[i] = Math.Max(points[i][j], max[i]);
                   
                    min[i] = Math.Min(points[i][j], min[i]);
                   
                }
                avg[i] = points[i].Average();
            }


            for (int i = 0; i < 12; i++)
            {
                range[i] = max[i] - min[i];
            }

            //mean normalization
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < y.Count; j++)
                {
                    points[i][j] = ((points[i][j] - avg[i])/range[i]);
                    listBox1.Items.Add(points[i][j]);
                }
            }
        }

        private void predict_Click(object sender, EventArgs e)
        {
            
        }
    }
}
