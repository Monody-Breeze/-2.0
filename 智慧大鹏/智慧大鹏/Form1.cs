using Modbus.Device;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace 智慧大鹏
{
    public partial class Form1 : Form
    {
        // 基于MOdbus通讯的库
        ModbusMaster master;
        string connStr = "Server = 'PC-202310071457';DataBase = 'TestTemandHum';Uid = 'sa';Pwd='123456'";
        public Form1()
        {
            InitializeComponent();
        }
        public double Sum(double a,double b)
        {
            return a + b;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            serialPort1.PortName = "COM2";
            serialPort1.DataBits = 8;
            serialPort1.BaudRate = 9600;
            serialPort1.StopBits = StopBits.One;
            serialPort1.Parity = Parity.Even;
            serialPort1.Open();
            master = ModbusSerialMaster.CreateRtu(serialPort1);
            //master.ReadHoldingRegisters(1,0x0000,1);
        }

        // 设置间隔
        private void btn_setinterval_Click(object sender, EventArgs e)
        {
            timer1.Interval =Convert.ToInt32(ipt_interval.Text);
        }

        /// <summary>
        /// 开始停止，控制计时器启停
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_StartOrStop_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
            }
            else
            {
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // 获取当前时间
            DateTime now = DateTime.Now;
            string Day = now.ToString("yyyy/MM/dd");
            string time = now.ToString("HH:mm:ss");
            double tem = 0;
            double hum = 0;
            double CO2 = 0;
            double Speed = 0;

            if (cb_wd.Checked)
            {
                // 获取设备的信息
                ushort[] values = master.ReadHoldingRegisters(1, 0x0000, 1);

                tem = values[0] / 10;

                // chart1 图表
                // chart1.Series[0]  显示温度的序列
                AddChartPoint(chart1.Series[0].Points,time,tem);
            }

            if (cb_sd.Checked)
            {
                // 获取设备的信息
                ushort[] values = master.ReadHoldingRegisters(1, 0x0001, 1);

                hum = values[0] / 10;

                // chart1 图表
                // chart1.Series[0]  显示温度的序列
                AddChartPoint(chart1.Series[1].Points, time, hum);
            }

            if (cb_yq.Checked)
            {
                // 获取设备的信息
                ushort[] values = master.ReadHoldingRegisters(1, 0x0002, 1);

                CO2 = values[0] / 10;

                // chart1 图表
                // chart1.Series[0]  显示温度的序列
                AddChartPoint(chart1.Series[2].Points, time, CO2);
            }
            if (cb_fs.Checked)
            {
                // 获取设备的信息
                ushort[] values = master.ReadHoldingRegisters(1, 0x0003, 1);

                Speed = values[0] / 100;

                // chart1 图表
                // chart1.Series[0]  显示温度的序列
                AddChartPoint(chart1.Series[3].Points,time, Speed);
            }

            // 存储到数据库  时间  温度  湿度  风速  氧气 
            InsertData(Day,tem,hum,CO2,Speed);
        }

        // 将数据添加到数据库里面的方法
        private void InsertData(string time,double tem, double hum, double cO2, double speed)
        {
            string sql = $"insert into DataTemAndHumTable(Time,Tem,Hum,CO2,Speed) values('{time}',{tem},{hum},{cO2},{speed})";
            using (SqlConnection conn = new SqlConnection(connStr))
            { 
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql,conn);
                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// 添加点的方法
        /// </summary>
        /// <param name="points">序列集合</param>
        /// <param name="time">时间</param>
        /// <param name="value">值</param>
        private void AddChartPoint(DataPointCollection points,string time,object value)
        {
            points.AddXY(time,value);
            if (points.Count >= 15)
            {
                points.RemoveAt(0);
            }
        }

        private void btn_history_Click(object sender, EventArgs e)
        {
            Select select = new Select();
            select.ShowDialog();
        }

        
    }
}
