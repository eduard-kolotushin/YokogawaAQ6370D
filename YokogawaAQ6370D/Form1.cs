using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;

namespace YokogawaAQ6370D
{
    public partial class Form1 : Form
    {

        private static string[] SensMods = new string[] {"HIGH1", "HIGH2", "MID"};
        private static int Port = 10001;
        private static string IPAddr = "127.0.0.1";
        private static decimal StartWL = 800.0M;
        private static decimal StopWL = 1500.0M;
        private static decimal Span = 20.0M;
        private static decimal Step = 7.0M;
        private static decimal Resolution = 0.05M;
        private static TcpClient client = new TcpClient();
        private static NetworkStream stream;
        private static string[] response = new string[10];
        private static int k = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SensMod_comboBox.Items.AddRange(SensMods);
            SensMod_comboBox.SelectedIndex = 0;
            Port_value.Text = Port.ToString();
            StartWL_value.Value = StartWL;
            StopWL_value.Value = StopWL;
            Span_value.Value = Span;
            Step_value.Value = Step;
            Resolution_value.Value = Resolution;
        }

        private void Port_value_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Int32.TryParse(Port_value.Text, out Port);
                MessageBox.Show(Port.ToString());
            }
        }

        private void IP_value_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                IPAddr = IP_value.Text;
                if (IPAddr.Contains("_"))
                {
                    IPAddr = IPAddr.Replace("_", "");
                    IPAddr = IPAddr.Replace(",", ".");
                }
                MessageBox.Show(IPAddr);
            }
        }

        private void Try_to_connect_button_Click(object sender, EventArgs e)
        {
            client.Connect(IPAddr, Port);
            stream = client.GetStream();
            SendCommand(stream, "OPEN \"anonymous\"");
            response[0] = GetResponse(stream);
            Response_textArea.Lines = response;
            k++;
            SendCommand(stream, " ");
            response[1] = GetResponse(stream);
            Response_textArea.Lines = response;
        }

        private string GetResponse(NetworkStream stream)
        {
            if (k == 0)
            {
                return "Sanya, hui sosi!!!";
            }
            else
            {
                return "Ebaniy pidoras!!!";
            }
        }

        private void SendCommand(NetworkStream stream, string command)
        {
            return;
        }
    }
}
