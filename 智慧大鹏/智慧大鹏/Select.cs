using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace 智慧大鹏
{
    public partial class Select : Form
    {
        public Select()
        {
            InitializeComponent();
        }
        string connStr = "Server = 'PC-202310071457';DataBase = 'TestTemandHum';Uid = 'sa';Pwd='123456'";
        List<TestTemAndHum> LoadList = new List<TestTemAndHum>();

        private void Select_Load(object sender, EventArgs e)
        {
            string sql = "select * from DataTemAndHumTable";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    TestTemAndHum test = new TestTemAndHum()
                    {
                        Time = reader["Time"].ToString(),
                        Tem = Convert.ToDouble(reader["Tem"]),
                        Hum = Convert.ToDouble(reader["Hum"]),
                        CO2 = Convert.ToDouble(reader["CO2"]),
                        Speed = Convert.ToDouble(reader["Speed"])
                    };
                    AddChartPoint(chart1.Series[0].Points, test.Time, test.Tem);
                    AddChartPoint(chart1.Series[1].Points, test.Time, test.Hum);
                    AddChartPoint(chart1.Series[2].Points, test.Time, test.CO2);
                    AddChartPoint(chart1.Series[3].Points, test.Time, test.Speed);
                    LoadList.Add(test);
                }
            }
            dgv.DataSource = LoadList;
        }

        List<TestTemAndHum> SelectList = new List<TestTemAndHum>();
        private void btn_select_Click(object sender, EventArgs e)
        {
            string Start = DataTimeStart.Value.ToString();
            //string End = DataTimeOver.Value.ToString();
            //string EndTime = null;
            string StartTime = null;
            for (int i = 0; i < 9; i++)
            {
                StartTime += Start[i].ToString();
                //EndTime += End[i].ToString();
            }
            if (10 > Convert.ToInt32(StartTime[5].ToString()))
            {
                StartTime = StartTime.Insert(5,"0");
            }
            string sql = $"select * from DataTemAndHumTable where Time = '{StartTime}'";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    TestTemAndHum test = new TestTemAndHum()
                    {
                        Time = reader["Time"].ToString(),
                        Tem = Convert.ToDouble(reader["Tem"]),
                        Hum = Convert.ToDouble(reader["Hum"]),
                        CO2 = Convert.ToDouble(reader["CO2"]),
                        Speed = Convert.ToDouble(reader["Speed"])
                    };
                    AddChartPoint(chart1.Series[0].Points,test.Time,test.Tem);
                    AddChartPoint(chart1.Series[1].Points,test.Time,test.Hum);
                    AddChartPoint(chart1.Series[2].Points,test.Time,test.CO2);
                    AddChartPoint(chart1.Series[3].Points,test.Time,test.Speed);
                    SelectList.Add(test);
                }
            }
            dgv.DataSource = SelectList;
        }

        /// <summary>
        /// 添加点的方法
        /// </summary>
        /// <param name="points">序列集合</param>
        /// <param name="time">时间</param>
        /// <param name="value">值</param>
        private void AddChartPoint(DataPointCollection points, string time, object value)
        {
            points.AddXY(time, value);
            if (points.Count >= 15)
            {
                points.RemoveAt(0);
            }
        }
    }
}
