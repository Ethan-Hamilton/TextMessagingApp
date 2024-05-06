using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace TextMessageApp_G9
{
    public partial class Form1 : Form
    {
        private TcpClient client;
        public StreamReader STR;
        public StreamWriter STW;
        public string receive;
        public string TextToSend;

        public Form1()
        {
            InitializeComponent();

            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());

            foreach(IPAddress address in localIP)
            {
                if(address.AddressFamily == AddressFamily.InterNetwork)
                {
                    ServerIPtxt.Text = address.ToString();
                }
            }
        }

        private void Startbtn_Click(object sender, EventArgs e)
        {
            TcpListener listener = new TcpListener(IPAddress.Any, int.Parse(ServerPorttxt.Text));
            listener.Start();
            client = listener.AcceptTcpClient();
            STR = new StreamReader(client.GetStream());
            STW = new StreamWriter(client.GetStream());
            STW.AutoFlush = true;
            backgroundWorker1.RunWorkerAsync();
            backgroundWorker2.WorkerSupportsCancellation = true;
        }

        private void Connectbtn_Click(object sender, EventArgs e)
        {
            client = new TcpClient();
            IPEndPoint iPEnd = new IPEndPoint(IPAddress.Parse(ClientIPtxt.Text), int.Parse(ClientPorttxt.Text));

            try
            {
                client.Connect(iPEnd);
                ChatScreentxt.AppendText("Connected to Server" + "\n");
                STW = new StreamWriter(client.GetStream()) { AutoFlush = true };
                STR = new StreamReader(client.GetStream());
                backgroundWorker1.RunWorkerAsync();
                backgroundWorker2.WorkerSupportsCancellation = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }


        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (client.Connected)
            {
                try
                {
                    receive = STR.ReadLine();
                    this.ChatScreentxt.Invoke(new MethodInvoker(delegate()
                        {
                            ChatScreentxt.AppendText("You: " + receive + "\n");
                        }));
                    receive = "";
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            if (client.Connected)
            {
                STW.WriteLine(TextToSend);
                this.ChatScreentxt.Invoke(new MethodInvoker(delegate ()
                    {
                        ChatScreentxt.AppendText("ME: " + TextToSend + "\n");
                    }));
            }
            else
            {
                MessageBox.Show("Sending Failed!");
            }

            backgroundWorker2.CancelAsync();
        }

        private void Sendbtn_Click(object sender, EventArgs e)
        {
            if (MessageBoxtxt.Text != "")
            {
                TextToSend = MessageBoxtxt.Text;
                backgroundWorker2.RunWorkerAsync();
            }
            MessageBoxtxt.Text = "";
        }
    }
}
