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
        //Default settings
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
        private static decimal YScale = 2.0M;

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
            Y_Scale_value.Value = YScale;
        }

        private void Port_value_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Int32.TryParse(Port_value.Text, out Port);
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
            }
        }

        //Test for connection
        private void Try_to_connect_button_Click(object sender, EventArgs e)
        {
            //IP and Port extract
            Int32.TryParse(Port_value.Text, out Port);
            IPAddr = IP_value.Text;
            if (IPAddr.Contains("_"))
            {
                IPAddr = IPAddr.Replace("_", "");
                IPAddr = IPAddr.Replace(",", ".");
            }

            client.Connect(IPAddr, Port);
            stream = client.GetStream();
            SendCommand(stream, "OPEN \"anonymous\"");
            response[0] = GetResponse(stream);
            Response_textArea.Lines = response;
            SendCommand(stream, " ");
            response[1] = GetResponse(stream);
            Response_textArea.Lines = response;
            client.Close();
        }

        //Sending commands
        static public void SendCommand(NetworkStream stream, string command)
        {
            command += "\t\n";
            byte[] data = Encoding.UTF8.GetBytes(command);
            stream.Write(data, 0, data.Length);
        }

        //Recieving response
        static public string GetResponse(NetworkStream stream)
        {
            byte[] data = new byte[1024];
            int bytes = stream.Read(data, 0, data.Length);
            string response = Encoding.UTF8.GetString(data, 0, bytes);
            return response;
        }

        private void Start_button_Click(object sender, EventArgs e)
        {
            //Initiate variables
            decimal CurrentWL = StartWL;
            int RepeatNumber = 5;
            bool flag = false;

            if (Start_button.Text == "Start")
            {
                //Change interface parameters
                Progressbar.Visible = true;
                Progressbar.Value = 0;
                Start_button.Text = "Stop";
                Start_button.BackColor = Color.Red;
                Sweep_settings_groupBox.Enabled = false;

                //Connection
                client.Connect(IPAddr, Port);
                stream = client.GetStream();

                //Authentification
                SendCommand(stream, "open \"anonymus\"");
                Console.WriteLine(GetResponse(stream));
                SendCommand(stream, " ");
                Console.WriteLine(GetResponse(stream));

                //Settings
                SendCommand(stream, $":SENSe:BWIDth:RESolution {Resolution_value}NM");
                SendCommand(stream, $":SENSe:SENSe {SensMod_comboBox.SelectedText}");
                SendCommand(stream, $":DISPlay:WINDow:TRACe:Y1:SCALe:PDIVision {Y_Scale_value}DB");
                SendCommand(stream, ":TRACe:ACTive TRE");
                SendCommand(stream, ":TRACe:STATe:TRE ON");
                SendCommand(stream, ":TRACe:ATTRibute:TRE WRITe");
                SendCommand(stream, ":MMEMory:CDRive EXTernal");

                //Sweep and save
                while (CurrentWL + Step_value.Value <= StopWL_value.Value)
                {
                    for (int i = 1; i <= RepeatNumber; i++)
                    {
                        SendCommand(stream, $"SENSe:WAVelength:STARt {CurrentWL}NM; STOP {CurrentWL + Span_value.Value}NM");
                        SendCommand(stream, $":INITiate:SMODe SINGle; :INITiate");
                        do
                        {
                            SendCommand(stream, ":stat:oper:even?");
                            byte[] stat_reg = new byte[1024];
                            int bytes = stream.Read(stat_reg, 0, stat_reg.Length);
                            int status = BitConverter.ToInt32(stat_reg, 0);
                            if ((status & 1) == 1)
                            {
                                flag = true;
                            }
                        } while (!flag);
                        SendCommand(stream, $":MMEMory:STORe:TRACe TRE, CSV, \"{CurrentWL}NM_Number{i}\", EXTernal");
                        System.Threading.Thread.Sleep(500);
                    }
                    CurrentWL += Step_value.Value;
                    CurrentWL_value.Text = CurrentWL.ToString();
                    Progressbar.Value = decimal.ToInt32((CurrentWL - StartWL) / (StopWL - StartWL) * 100);
                    Time_remain_value.Text = "Don't know";
                }

            }
            else if (Start_button.Text == "Stop")
            {
                //Change interface parameters
                Start_button.Text = "Start";
                Start_button.BackColor = Color.Lime;
                Sweep_settings_groupBox.Enabled = true;

                //Close connection
                client.Close();
            }
        }
    }
}
