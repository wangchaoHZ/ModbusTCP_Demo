using System;
using System.Windows.Forms;
using HslCommunication;
using HslCommunication.ModBus;

namespace ModbusTCP_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private ModBusTcpClient busTcpClient = null;

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            busTcpClient?.ConnectClose();
            busTcpClient = new ModBusTcpClient("127.0.0.1", 502, 1);

            try
            {
                OperateResult connect = busTcpClient.ConnectServer();
                if (connect.IsSuccess)
                {
                    MessageBox.Show("连接成功！");
                }
                else
                {
                    MessageBox.Show("连接失败！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
