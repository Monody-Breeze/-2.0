namespace 智慧大鹏
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series41 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series42 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series43 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series44 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cb_fs = new System.Windows.Forms.CheckBox();
            this.cb_yq = new System.Windows.Forms.CheckBox();
            this.cb_sd = new System.Windows.Forms.CheckBox();
            this.cb_wd = new System.Windows.Forms.CheckBox();
            this.btn_history = new System.Windows.Forms.Button();
            this.btn_StartOrStop = new System.Windows.Forms.Button();
            this.btn_setinterval = new System.Windows.Forms.Button();
            this.ipt_interval = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_sendEmail = new System.Windows.Forms.Button();
            this.ipt_email = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_fs
            // 
            this.cb_fs.AutoSize = true;
            this.cb_fs.Checked = true;
            this.cb_fs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_fs.Location = new System.Drawing.Point(223, 55);
            this.cb_fs.Name = "cb_fs";
            this.cb_fs.Size = new System.Drawing.Size(48, 16);
            this.cb_fs.TabIndex = 23;
            this.cb_fs.Text = "风速";
            this.cb_fs.UseVisualStyleBackColor = true;
            // 
            // cb_yq
            // 
            this.cb_yq.AutoSize = true;
            this.cb_yq.Checked = true;
            this.cb_yq.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_yq.Location = new System.Drawing.Point(151, 55);
            this.cb_yq.Name = "cb_yq";
            this.cb_yq.Size = new System.Drawing.Size(48, 16);
            this.cb_yq.TabIndex = 22;
            this.cb_yq.Text = "氧气";
            this.cb_yq.UseVisualStyleBackColor = true;
            // 
            // cb_sd
            // 
            this.cb_sd.AutoSize = true;
            this.cb_sd.Checked = true;
            this.cb_sd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_sd.Location = new System.Drawing.Point(82, 55);
            this.cb_sd.Name = "cb_sd";
            this.cb_sd.Size = new System.Drawing.Size(48, 16);
            this.cb_sd.TabIndex = 21;
            this.cb_sd.Text = "湿度";
            this.cb_sd.UseVisualStyleBackColor = true;
            // 
            // cb_wd
            // 
            this.cb_wd.AutoSize = true;
            this.cb_wd.Checked = true;
            this.cb_wd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_wd.Location = new System.Drawing.Point(13, 55);
            this.cb_wd.Name = "cb_wd";
            this.cb_wd.Size = new System.Drawing.Size(48, 16);
            this.cb_wd.TabIndex = 20;
            this.cb_wd.Text = "温度";
            this.cb_wd.UseVisualStyleBackColor = true;
            // 
            // btn_history
            // 
            this.btn_history.Location = new System.Drawing.Point(704, 12);
            this.btn_history.Name = "btn_history";
            this.btn_history.Size = new System.Drawing.Size(82, 23);
            this.btn_history.TabIndex = 19;
            this.btn_history.Text = "历史查询";
            this.btn_history.UseVisualStyleBackColor = true;
            this.btn_history.Click += new System.EventHandler(this.btn_history_Click);
            // 
            // btn_StartOrStop
            // 
            this.btn_StartOrStop.Location = new System.Drawing.Point(574, 12);
            this.btn_StartOrStop.Name = "btn_StartOrStop";
            this.btn_StartOrStop.Size = new System.Drawing.Size(124, 23);
            this.btn_StartOrStop.TabIndex = 18;
            this.btn_StartOrStop.Text = "开始/停止";
            this.btn_StartOrStop.UseVisualStyleBackColor = true;
            this.btn_StartOrStop.Click += new System.EventHandler(this.btn_StartOrStop_Click);
            // 
            // btn_setinterval
            // 
            this.btn_setinterval.Location = new System.Drawing.Point(136, 12);
            this.btn_setinterval.Name = "btn_setinterval";
            this.btn_setinterval.Size = new System.Drawing.Size(135, 23);
            this.btn_setinterval.TabIndex = 17;
            this.btn_setinterval.Text = "设置时间间隔";
            this.btn_setinterval.UseVisualStyleBackColor = true;
            this.btn_setinterval.Click += new System.EventHandler(this.btn_setinterval_Click);
            // 
            // ipt_interval
            // 
            this.ipt_interval.Location = new System.Drawing.Point(13, 14);
            this.ipt_interval.Name = "ipt_interval";
            this.ipt_interval.Size = new System.Drawing.Size(117, 21);
            this.ipt_interval.TabIndex = 16;
            this.ipt_interval.Text = "500";
            // 
            // chart1
            // 
            chartArea11.AxisX.Title = "时间";
            chartArea11.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Stacked;
            chartArea11.AxisY.Title = "温度/湿度/氧气/风速";
            chartArea11.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea11);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend11.Name = "Legend1";
            this.chart1.Legends.Add(legend11);
            this.chart1.Location = new System.Drawing.Point(0, 93);
            this.chart1.Name = "chart1";
            series41.BorderWidth = 5;
            series41.ChartArea = "ChartArea1";
            series41.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series41.Color = System.Drawing.Color.Red;
            series41.Legend = "Legend1";
            series41.Name = "温度";
            series42.BorderWidth = 5;
            series42.ChartArea = "ChartArea1";
            series42.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series42.Color = System.Drawing.Color.Lime;
            series42.Legend = "Legend1";
            series42.Name = "湿度";
            series43.BorderWidth = 5;
            series43.ChartArea = "ChartArea1";
            series43.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series43.Color = System.Drawing.Color.Blue;
            series43.Legend = "Legend1";
            series43.Name = "氧气";
            series44.BorderWidth = 5;
            series44.ChartArea = "ChartArea1";
            series44.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series44.Color = System.Drawing.Color.Fuchsia;
            series44.Legend = "Legend1";
            series44.Name = "风速";
            this.chart1.Series.Add(series41);
            this.chart1.Series.Add(series42);
            this.chart1.Series.Add(series43);
            this.chart1.Series.Add(series44);
            this.chart1.Size = new System.Drawing.Size(800, 357);
            this.chart1.TabIndex = 24;
            this.chart1.Text = "chart1";
            // 
            // btn_sendEmail
            // 
            this.btn_sendEmail.Location = new System.Drawing.Point(704, 51);
            this.btn_sendEmail.Name = "btn_sendEmail";
            this.btn_sendEmail.Size = new System.Drawing.Size(82, 23);
            this.btn_sendEmail.TabIndex = 26;
            this.btn_sendEmail.Text = "发邮件测试";
            this.btn_sendEmail.UseVisualStyleBackColor = true;
            // 
            // ipt_email
            // 
            this.ipt_email.Location = new System.Drawing.Point(470, 53);
            this.ipt_email.Name = "ipt_email";
            this.ipt_email.Size = new System.Drawing.Size(228, 21);
            this.ipt_email.TabIndex = 25;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_sendEmail);
            this.Controls.Add(this.ipt_email);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.cb_fs);
            this.Controls.Add(this.cb_yq);
            this.Controls.Add(this.cb_sd);
            this.Controls.Add(this.cb_wd);
            this.Controls.Add(this.btn_history);
            this.Controls.Add(this.btn_StartOrStop);
            this.Controls.Add(this.btn_setinterval);
            this.Controls.Add(this.ipt_interval);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cb_fs;
        private System.Windows.Forms.CheckBox cb_yq;
        private System.Windows.Forms.CheckBox cb_sd;
        private System.Windows.Forms.CheckBox cb_wd;
        private System.Windows.Forms.Button btn_history;
        private System.Windows.Forms.Button btn_StartOrStop;
        private System.Windows.Forms.Button btn_setinterval;
        private System.Windows.Forms.TextBox ipt_interval;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btn_sendEmail;
        private System.Windows.Forms.TextBox ipt_email;
        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

