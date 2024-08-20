using Modbus.Device;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace 智慧大鹏
{
    public partial class Form1 : Form
    {
        // 基于MOdbus通讯的库
        ModbusMaster master;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            serialPort1.PortName = "COM2";
            serialPort1.DataBits = 8;
            serialPort1.BaudRate = 9600;
            serialPort1.StopBits = StopBits.One;
            serialPort1.Parity = Parity.None;
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
            string time = now.ToString("HH:mm:ss");

            if (cb_wd.Checked)
            {
                // 获取设备的信息
                ushort[] values = master.ReadHoldingRegisters(1, 0x0000, 1);

                double tem = values[0] / 10;

                // chart1 图表
                // chart1.Series[0]  显示温度的序列
                AddChartPoint(chart1.Series[0].Points,time,tem);
            }

            // 存储到数据库  时间  温度  湿度  风速  氧气 
            
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

    }
}
