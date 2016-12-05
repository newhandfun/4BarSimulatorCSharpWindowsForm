namespace _4BarSimulator_WinForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.txt_R2 = new System.Windows.Forms.TextBox();
            this.txt_R3 = new System.Windows.Forms.TextBox();
            this.txt_R4 = new System.Windows.Forms.TextBox();
            this.SetData = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Angle1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Angle3 = new System.Windows.Forms.TextBox();
            this.txt_Angle4 = new System.Windows.Forms.TextBox();
            this.txt_Angle2 = new System.Windows.Forms.TextBox();
            this.tckb_R4 = new System.Windows.Forms.TrackBar();
            this.tckb_R3 = new System.Windows.Forms.TrackBar();
            this.tckb_R2 = new System.Windows.Forms.TrackBar();
            this.tckb_R1 = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_R1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.angleImageGroup = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.chart_angle = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.animationGroup = new System.Windows.Forms.GroupBox();
            this.btn_animationCtrl = new System.Windows.Forms.Button();
            this.txt_Log = new System.Windows.Forms.TextBox();
            this.pic_animation = new System.Windows.Forms.PictureBox();
            this.SetData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tckb_R4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tckb_R3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tckb_R2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tckb_R1)).BeginInit();
            this.angleImageGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_angle)).BeginInit();
            this.animationGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_animation)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_R2
            // 
            this.txt_R2.Enabled = false;
            this.txt_R2.Location = new System.Drawing.Point(75, 58);
            this.txt_R2.MaxLength = 2;
            this.txt_R2.Name = "txt_R2";
            this.txt_R2.Size = new System.Drawing.Size(30, 22);
            this.txt_R2.TabIndex = 0;
            this.txt_R2.Text = "2";
            this.txt_R2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_R3
            // 
            this.txt_R3.Enabled = false;
            this.txt_R3.Location = new System.Drawing.Point(75, 88);
            this.txt_R3.Name = "txt_R3";
            this.txt_R3.Size = new System.Drawing.Size(30, 22);
            this.txt_R3.TabIndex = 1;
            this.txt_R3.Text = "5";
            this.txt_R3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_R4
            // 
            this.txt_R4.Enabled = false;
            this.txt_R4.Location = new System.Drawing.Point(75, 116);
            this.txt_R4.Name = "txt_R4";
            this.txt_R4.Size = new System.Drawing.Size(30, 22);
            this.txt_R4.TabIndex = 2;
            this.txt_R4.Text = "5";
            this.txt_R4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SetData
            // 
            this.SetData.Controls.Add(this.label5);
            this.SetData.Controls.Add(this.txt_Angle1);
            this.SetData.Controls.Add(this.label6);
            this.SetData.Controls.Add(this.label7);
            this.SetData.Controls.Add(this.label8);
            this.SetData.Controls.Add(this.txt_Angle3);
            this.SetData.Controls.Add(this.txt_Angle4);
            this.SetData.Controls.Add(this.txt_Angle2);
            this.SetData.Controls.Add(this.tckb_R4);
            this.SetData.Controls.Add(this.tckb_R3);
            this.SetData.Controls.Add(this.tckb_R2);
            this.SetData.Controls.Add(this.tckb_R1);
            this.SetData.Controls.Add(this.label4);
            this.SetData.Controls.Add(this.txt_R1);
            this.SetData.Controls.Add(this.label3);
            this.SetData.Controls.Add(this.label2);
            this.SetData.Controls.Add(this.label1);
            this.SetData.Controls.Add(this.txt_R3);
            this.SetData.Controls.Add(this.txt_R4);
            this.SetData.Controls.Add(this.txt_R2);
            this.SetData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SetData.Location = new System.Drawing.Point(12, 262);
            this.SetData.Name = "SetData";
            this.SetData.Size = new System.Drawing.Size(417, 166);
            this.SetData.TabIndex = 3;
            this.SetData.TabStop = false;
            this.SetData.Text = "資料設定";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(208, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 19;
            this.label5.Text = "桿1角度";
            // 
            // txt_Angle1
            // 
            this.txt_Angle1.Enabled = false;
            this.txt_Angle1.Location = new System.Drawing.Point(260, 24);
            this.txt_Angle1.MaxLength = 3;
            this.txt_Angle1.Name = "txt_Angle1";
            this.txt_Angle1.Size = new System.Drawing.Size(45, 22);
            this.txt_Angle1.TabIndex = 18;
            this.txt_Angle1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(208, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 12);
            this.label6.TabIndex = 17;
            this.label6.Text = "桿4角度";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(208, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 12);
            this.label7.TabIndex = 16;
            this.label7.Text = "桿3角度";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(208, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "桿2角度";
            // 
            // txt_Angle3
            // 
            this.txt_Angle3.Enabled = false;
            this.txt_Angle3.Location = new System.Drawing.Point(260, 88);
            this.txt_Angle3.MaxLength = 3;
            this.txt_Angle3.Name = "txt_Angle3";
            this.txt_Angle3.Size = new System.Drawing.Size(45, 22);
            this.txt_Angle3.TabIndex = 13;
            this.txt_Angle3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Angle4
            // 
            this.txt_Angle4.Enabled = false;
            this.txt_Angle4.Location = new System.Drawing.Point(260, 116);
            this.txt_Angle4.MaxLength = 3;
            this.txt_Angle4.Name = "txt_Angle4";
            this.txt_Angle4.Size = new System.Drawing.Size(45, 22);
            this.txt_Angle4.TabIndex = 14;
            this.txt_Angle4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Angle2
            // 
            this.txt_Angle2.Location = new System.Drawing.Point(260, 58);
            this.txt_Angle2.MaxLength = 3;
            this.txt_Angle2.Name = "txt_Angle2";
            this.txt_Angle2.Size = new System.Drawing.Size(45, 22);
            this.txt_Angle2.TabIndex = 12;
            this.txt_Angle2.Text = "0";
            this.txt_Angle2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Angle2.TextChanged += new System.EventHandler(this.txt2Angle_Change);
            this.txt_Angle2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt2Angle_KeyPress);
            // 
            // tckb_R4
            // 
            this.tckb_R4.Location = new System.Drawing.Point(111, 116);
            this.tckb_R4.Maximum = 6;
            this.tckb_R4.Minimum = 1;
            this.tckb_R4.Name = "tckb_R4";
            this.tckb_R4.Size = new System.Drawing.Size(91, 45);
            this.tckb_R4.TabIndex = 11;
            this.tckb_R4.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tckb_R4.Value = 5;
            this.tckb_R4.Scroll += new System.EventHandler(this.tckb_R4_Scroll);
            // 
            // tckb_R3
            // 
            this.tckb_R3.Location = new System.Drawing.Point(111, 86);
            this.tckb_R3.Maximum = 6;
            this.tckb_R3.Minimum = 1;
            this.tckb_R3.Name = "tckb_R3";
            this.tckb_R3.Size = new System.Drawing.Size(91, 45);
            this.tckb_R3.TabIndex = 10;
            this.tckb_R3.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tckb_R3.Value = 5;
            this.tckb_R3.Scroll += new System.EventHandler(this.tckb_R3_Scroll);
            // 
            // tckb_R2
            // 
            this.tckb_R2.Location = new System.Drawing.Point(111, 58);
            this.tckb_R2.Maximum = 6;
            this.tckb_R2.Minimum = 1;
            this.tckb_R2.Name = "tckb_R2";
            this.tckb_R2.Size = new System.Drawing.Size(91, 45);
            this.tckb_R2.TabIndex = 9;
            this.tckb_R2.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tckb_R2.Value = 2;
            this.tckb_R2.Scroll += new System.EventHandler(this.tckb_R2_Scroll);
            // 
            // tckb_R1
            // 
            this.tckb_R1.Location = new System.Drawing.Point(111, 24);
            this.tckb_R1.Maximum = 6;
            this.tckb_R1.Minimum = 1;
            this.tckb_R1.Name = "tckb_R1";
            this.tckb_R1.Size = new System.Drawing.Size(91, 45);
            this.tckb_R1.TabIndex = 8;
            this.tckb_R1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tckb_R1.Value = 6;
            this.tckb_R1.Scroll += new System.EventHandler(this.tckb_R1_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "桿1長度";
            // 
            // txt_R1
            // 
            this.txt_R1.Enabled = false;
            this.txt_R1.Location = new System.Drawing.Point(75, 24);
            this.txt_R1.MaxLength = 2;
            this.txt_R1.Name = "txt_R1";
            this.txt_R1.Size = new System.Drawing.Size(30, 22);
            this.txt_R1.TabIndex = 6;
            this.txt_R1.Text = "6";
            this.txt_R1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "桿4長度";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "桿3長度";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "桿2長度";
            // 
            // angleImageGroup
            // 
            this.angleImageGroup.BackColor = System.Drawing.Color.White;
            this.angleImageGroup.Controls.Add(this.richTextBox1);
            this.angleImageGroup.Controls.Add(this.chart_angle);
            this.angleImageGroup.Controls.Add(this.button1);
            this.angleImageGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.angleImageGroup.Location = new System.Drawing.Point(435, 13);
            this.angleImageGroup.Name = "angleImageGroup";
            this.angleImageGroup.Size = new System.Drawing.Size(389, 415);
            this.angleImageGroup.TabIndex = 4;
            this.angleImageGroup.TabStop = false;
            this.angleImageGroup.Text = "桿件角度圖";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(296, 103);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(93, 312);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "右鍵桿三，左鍵桿四";
            // 
            // chart_angle
            // 
            this.chart_angle.BackColor = System.Drawing.Color.DimGray;
            this.chart_angle.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            chartArea1.Name = "ChartArea1";
            this.chart_angle.ChartAreas.Add(chartArea1);
            this.chart_angle.Cursor = System.Windows.Forms.Cursors.Cross;
            this.chart_angle.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.BackColor = System.Drawing.Color.Gray;
            legend1.Name = "Legend1";
            this.chart_angle.Legends.Add(legend1);
            this.chart_angle.Location = new System.Drawing.Point(3, 18);
            this.chart_angle.Name = "chart_angle";
            this.chart_angle.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "桿三";
            series1.ShadowOffset = 1;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "桿四";
            this.chart_angle.Series.Add(series1);
            this.chart_angle.Series.Add(series2);
            this.chart_angle.Size = new System.Drawing.Size(383, 394);
            this.chart_angle.TabIndex = 1;
            this.chart_angle.Text = "角度圖";
            this.chart_angle.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chart_angle_MouseClick);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Location = new System.Drawing.Point(308, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "輸出";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // animationGroup
            // 
            this.animationGroup.BackColor = System.Drawing.Color.DarkGray;
            this.animationGroup.Controls.Add(this.btn_animationCtrl);
            this.animationGroup.Controls.Add(this.txt_Log);
            this.animationGroup.Controls.Add(this.pic_animation);
            this.animationGroup.Location = new System.Drawing.Point(13, 13);
            this.animationGroup.Name = "animationGroup";
            this.animationGroup.Size = new System.Drawing.Size(416, 243);
            this.animationGroup.TabIndex = 5;
            this.animationGroup.TabStop = false;
            this.animationGroup.Text = "動畫";
            // 
            // btn_animationCtrl
            // 
            this.btn_animationCtrl.Location = new System.Drawing.Point(355, 46);
            this.btn_animationCtrl.Name = "btn_animationCtrl";
            this.btn_animationCtrl.Size = new System.Drawing.Size(55, 191);
            this.btn_animationCtrl.TabIndex = 2;
            this.btn_animationCtrl.Text = "停止";
            this.btn_animationCtrl.UseVisualStyleBackColor = true;
            this.btn_animationCtrl.Click += new System.EventHandler(this.btn_animationCtrl_Click);
            // 
            // txt_Log
            // 
            this.txt_Log.Location = new System.Drawing.Point(6, 18);
            this.txt_Log.Name = "txt_Log";
            this.txt_Log.Size = new System.Drawing.Size(404, 22);
            this.txt_Log.TabIndex = 1;
            // 
            // pic_animation
            // 
            this.pic_animation.BackColor = System.Drawing.Color.Gray;
            this.pic_animation.Location = new System.Drawing.Point(6, 46);
            this.pic_animation.Name = "pic_animation";
            this.pic_animation.Size = new System.Drawing.Size(343, 190);
            this.pic_animation.TabIndex = 0;
            this.pic_animation.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(836, 440);
            this.Controls.Add(this.animationGroup);
            this.Controls.Add(this.angleImageGroup);
            this.Controls.Add(this.SetData);
            this.Name = "Form1";
            this.Text = "四連桿模擬器";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FinishWindow);
            this.SetData.ResumeLayout(false);
            this.SetData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tckb_R4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tckb_R3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tckb_R2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tckb_R1)).EndInit();
            this.angleImageGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_angle)).EndInit();
            this.animationGroup.ResumeLayout(false);
            this.animationGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_animation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_R2;
        private System.Windows.Forms.TextBox txt_R3;
        private System.Windows.Forms.TextBox txt_R4;
        private System.Windows.Forms.GroupBox SetData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox angleImageGroup;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox animationGroup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_R1;
        private System.Windows.Forms.TrackBar tckb_R1;
        private System.Windows.Forms.TrackBar tckb_R4;
        private System.Windows.Forms.TrackBar tckb_R3;
        private System.Windows.Forms.TrackBar tckb_R2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Angle1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Angle3;
        private System.Windows.Forms.TextBox txt_Angle4;
        private System.Windows.Forms.TextBox txt_Angle2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_angle;
        private System.Windows.Forms.PictureBox pic_animation;
        private System.Windows.Forms.Button btn_animationCtrl;
        private System.Windows.Forms.TextBox txt_Log;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

