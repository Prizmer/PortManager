using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PollingLibraries.LibPorts;

namespace PortManager
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnAppendCRC_Click(object sender, EventArgs e)
        {
            string tmp = "";
            ctlCrcCalc1.CalcCRCAndAppend(out tmp);
            rtbCmd.Text = tmp;
        }

        private void rtbCmd_TextChanged(object sender, EventArgs e)
        {
            ctlCrcCalc1.InputByteString = rtbCmd.Text;
        }

        private void rtbCmd_DoubleClick(object sender, EventArgs e)
        {
            rtbCmd.Clear();
        }

        private void rtbLog_DoubleClick(object sender, EventArgs e)
        {
            rtbLog.Clear();
        }

        private void btnSendCmd_Click(object sender, EventArgs e)
        {
            VirtualPort vp = ctlConnectionSettings1.VirtualPort;

            if (vp == null)
            {
                rtbLog.Text += "Виртуальный порт не создан\n";
                return;
            }

            byte[] receivedBytes = null;
            byte[] outData = null;

            ctlCrcCalc1.LibConvertStringToBytesArr(rtbCmd.Text, ref outData);
            rtbLog.Text += "<< " + BitConverter.ToString(outData) + "\n";

            int res = vp.WriteReadData(FindPacketSignature, outData, ref receivedBytes, outData.Length, -1);
            if (res > 0)
            {
                rtbLog.Text += ">> " + BitConverter.ToString(receivedBytes) + "\n";
            } else
            {
                rtbLog.Text += ">> ответа нет \n";
            }
        }

        public int FindPacketSignature(Queue<byte> queue)
        {
            return -1;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
