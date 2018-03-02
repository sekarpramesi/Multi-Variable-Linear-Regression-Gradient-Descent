namespace Simulation_of_Multi_Variable_Linear_Regression
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.get = new System.Windows.Forms.Button();
            this.file = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.iterUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.f1User = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.f3User = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.f2User = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.f5User = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.f4User = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.f7User = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.f6User = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.f9User = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.f8User = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.f11User = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.f10User = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.f12User = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.alphaUser = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(510, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Simulation Of Multi Variable Linear Regression";
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(496, 170);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(448, 224);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // get
            // 
            this.get.Location = new System.Drawing.Point(329, 66);
            this.get.Margin = new System.Windows.Forms.Padding(2);
            this.get.Name = "get";
            this.get.Size = new System.Drawing.Size(138, 82);
            this.get.TabIndex = 27;
            this.get.Text = "Catch";
            this.get.UseVisualStyleBackColor = true;
            this.get.Click += new System.EventHandler(this.get_Click);
            // 
            // file
            // 
            this.file.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.file.Location = new System.Drawing.Point(110, 67);
            this.file.Margin = new System.Windows.Forms.Padding(2);
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(184, 28);
            this.file.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 74);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "File Name :";
            // 
            // iterUser
            // 
            this.iterUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iterUser.Location = new System.Drawing.Point(615, 63);
            this.iterUser.Margin = new System.Windows.Forms.Padding(2);
            this.iterUser.Name = "iterUser";
            this.iterUser.Size = new System.Drawing.Size(184, 28);
            this.iterUser.TabIndex = 29;
            this.iterUser.Text = "1000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(544, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Iteration : ";
            // 
            // f1User
            // 
            this.f1User.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f1User.Location = new System.Drawing.Point(152, 18);
            this.f1User.Margin = new System.Windows.Forms.Padding(2);
            this.f1User.Name = "f1User";
            this.f1User.Size = new System.Drawing.Size(254, 28);
            this.f1User.TabIndex = 31;
            this.f1User.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "Fixed Acidity :";
            // 
            // f3User
            // 
            this.f3User.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f3User.Location = new System.Drawing.Point(152, 105);
            this.f3User.Margin = new System.Windows.Forms.Padding(2);
            this.f3User.Name = "f3User";
            this.f3User.Size = new System.Drawing.Size(254, 28);
            this.f3User.TabIndex = 36;
            this.f3User.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(69, 105);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 35;
            this.label5.Text = "Citric Acid : ";
            // 
            // f2User
            // 
            this.f2User.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f2User.Location = new System.Drawing.Point(152, 63);
            this.f2User.Margin = new System.Windows.Forms.Padding(2);
            this.f2User.Name = "f2User";
            this.f2User.Size = new System.Drawing.Size(254, 28);
            this.f2User.TabIndex = 34;
            this.f2User.Text = "1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 70);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 17);
            this.label7.TabIndex = 33;
            this.label7.Text = "Volatile Acidity :";
            // 
            // f5User
            // 
            this.f5User.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f5User.Location = new System.Drawing.Point(152, 196);
            this.f5User.Margin = new System.Windows.Forms.Padding(2);
            this.f5User.Name = "f5User";
            this.f5User.Size = new System.Drawing.Size(254, 28);
            this.f5User.TabIndex = 40;
            this.f5User.Text = "1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(69, 196);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 17);
            this.label8.TabIndex = 39;
            this.label8.Text = "Chlorides : ";
            // 
            // f4User
            // 
            this.f4User.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f4User.Location = new System.Drawing.Point(152, 154);
            this.f4User.Margin = new System.Windows.Forms.Padding(2);
            this.f4User.Name = "f4User";
            this.f4User.Size = new System.Drawing.Size(254, 28);
            this.f4User.TabIndex = 38;
            this.f4User.Text = "1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(35, 154);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 17);
            this.label9.TabIndex = 37;
            this.label9.Text = "Residual Sugar :";
            // 
            // f7User
            // 
            this.f7User.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f7User.Location = new System.Drawing.Point(152, 286);
            this.f7User.Margin = new System.Windows.Forms.Padding(2);
            this.f7User.Name = "f7User";
            this.f7User.Size = new System.Drawing.Size(254, 28);
            this.f7User.TabIndex = 44;
            this.f7User.Text = "1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 293);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 17);
            this.label10.TabIndex = 43;
            this.label10.Text = "Total Sulfur Dioxide :";
            // 
            // f6User
            // 
            this.f6User.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f6User.Location = new System.Drawing.Point(152, 241);
            this.f6User.Margin = new System.Windows.Forms.Padding(2);
            this.f6User.Name = "f6User";
            this.f6User.Size = new System.Drawing.Size(254, 28);
            this.f6User.TabIndex = 42;
            this.f6User.Text = "1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 241);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 17);
            this.label11.TabIndex = 41;
            this.label11.Text = "Free Sulfur Dioxide : ";
            // 
            // f9User
            // 
            this.f9User.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f9User.Location = new System.Drawing.Point(152, 372);
            this.f9User.Margin = new System.Windows.Forms.Padding(2);
            this.f9User.Name = "f9User";
            this.f9User.Size = new System.Drawing.Size(254, 28);
            this.f9User.TabIndex = 48;
            this.f9User.Text = "1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(114, 379);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 17);
            this.label12.TabIndex = 47;
            this.label12.Text = "pH :";
            // 
            // f8User
            // 
            this.f8User.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f8User.Location = new System.Drawing.Point(152, 330);
            this.f8User.Margin = new System.Windows.Forms.Padding(2);
            this.f8User.Name = "f8User";
            this.f8User.Size = new System.Drawing.Size(254, 28);
            this.f8User.TabIndex = 46;
            this.f8User.Text = "1";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(85, 337);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 17);
            this.label13.TabIndex = 45;
            this.label13.Text = "Density :";
            // 
            // f11User
            // 
            this.f11User.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f11User.Location = new System.Drawing.Point(152, 463);
            this.f11User.Margin = new System.Windows.Forms.Padding(2);
            this.f11User.Name = "f11User";
            this.f11User.Size = new System.Drawing.Size(254, 28);
            this.f11User.TabIndex = 52;
            this.f11User.Text = "1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(86, 470);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 17);
            this.label14.TabIndex = 51;
            this.label14.Text = "Alcohol :";
            // 
            // f10User
            // 
            this.f10User.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f10User.Location = new System.Drawing.Point(152, 414);
            this.f10User.Margin = new System.Windows.Forms.Padding(2);
            this.f10User.Name = "f10User";
            this.f10User.Size = new System.Drawing.Size(254, 28);
            this.f10User.TabIndex = 50;
            this.f10User.Text = "1";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(69, 421);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 17);
            this.label15.TabIndex = 49;
            this.label15.Text = "Sulphates :";
            // 
            // f12User
            // 
            this.f12User.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f12User.Location = new System.Drawing.Point(152, 510);
            this.f12User.Margin = new System.Windows.Forms.Padding(2);
            this.f12User.Name = "f12User";
            this.f12User.Size = new System.Drawing.Size(254, 28);
            this.f12User.TabIndex = 54;
            this.f12User.Text = "1";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(88, 519);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 17);
            this.label16.TabIndex = 53;
            this.label16.Text = "Quality :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.f12User);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.f11User);
            this.groupBox1.Controls.Add(this.f1User);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.f10User);
            this.groupBox1.Controls.Add(this.f2User);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.f9User);
            this.groupBox1.Controls.Add(this.f3User);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.f8User);
            this.groupBox1.Controls.Add(this.f4User);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.f7User);
            this.groupBox1.Controls.Add(this.f5User);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.f6User);
            this.groupBox1.Location = new System.Drawing.Point(30, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 606);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Theta ";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(496, 411);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(448, 368);
            this.listBox1.TabIndex = 56;
            // 
            // alphaUser
            // 
            this.alphaUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alphaUser.Location = new System.Drawing.Point(615, 111);
            this.alphaUser.Margin = new System.Windows.Forms.Padding(2);
            this.alphaUser.Name = "alphaUser";
            this.alphaUser.Size = new System.Drawing.Size(184, 28);
            this.alphaUser.TabIndex = 60;
            this.alphaUser.Text = "0.01";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(509, 118);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 17);
            this.label6.TabIndex = 59;
            this.label6.Text = "Manual Alpha :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(820, 53);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 82);
            this.button1.TabIndex = 61;
            this.button1.Text = "Process";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.get_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 741);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.alphaUser);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.iterUser);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.get);
            this.Controls.Add(this.file);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button get;
        private System.Windows.Forms.TextBox file;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox iterUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox f1User;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox f3User;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox f2User;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox f5User;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox f4User;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox f7User;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox f6User;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox f9User;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox f8User;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox f11User;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox f10User;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox f12User;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox alphaUser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}

