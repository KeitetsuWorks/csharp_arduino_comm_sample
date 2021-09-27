using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace arduino_comm_sample
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            scanCOMPorts();
        }

        private void scanCOMPorts()
        {
            cmbCOMPort.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            foreach (string p in ports)
            {
                cmbCOMPort.Items.Add(p);
            }
        }

        private void sendCommand()
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    String led0 = (radiobtnLED0On.Checked ? "1" : "0");
                    String led1 = (radiobtnLED1On.Checked ? "1" : "0");
                    String led2 = (radiobtnLED2On.Checked ? "1" : "0");
                    serialPort1.Write("L" + led0 + led1 + led2 + "\n");
                }
                catch
                {
                    btnClose_Click(this, null);
                }
            }
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            scanCOMPorts();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = cmbCOMPort.Text; // COM名設定
                serialPort1.Open();                     // ポート接続
                btnOpen.Enabled = false;                // 接続 Off
                btnClose.Enabled = true;                // 切断 On
                btnScan.Enabled = false;                // 更新 Off
                cmbCOMPort.Enabled = false;             // COMリスト Off
                if (!chkboxAutoSend.Checked)
                {
                    btnSend.Enabled = true;             // 手動送信 On
                }
                
            }
            catch
            {
                btnClose_Click(this, null);     // 切断ボタンを押す
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {   
            btnOpen.Enabled = true;             // 接続 On
            btnClose.Enabled = false;           // 切断 Off
            btnScan.Enabled = true;             // 更新 On
            cmbCOMPort.Enabled = true;          // COMリスト On
            btnSend.Enabled = false;            // 送信 Off
            try
            {
                serialPort1.DiscardInBuffer();  // 入力バッファを破棄
                serialPort1.DiscardOutBuffer(); // 出力バッファを破棄
                serialPort1.Close();            // COMポートを閉じる
            }
            catch { };
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            sendCommand();
        }

        private void chkboxAutoSend_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxAutoSend.Checked)
            {
                btnSend.Enabled = false;
            }
            else if (serialPort1.IsOpen)
            {
                btnSend.Enabled = true;
            }
        }

        private void radiobtnLED0On_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxAutoSend.Checked)
            {
                sendCommand();
            }
        }

        private void radiobtnLED0Off_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxAutoSend.Checked)
            {
                sendCommand();
            }
        }

        private void radiobtnLED1On_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxAutoSend.Checked)
            {
                sendCommand();
            }
        }

        private void radiobtnLED1Off_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxAutoSend.Checked)
            {
                sendCommand();
            }
        }

        private void radiobtnLED2On_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxAutoSend.Checked)
            {
                sendCommand();
            }
        }

        private void radiobtnLED2Off_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxAutoSend.Checked)
            {
                sendCommand();
            }
        }
    }
}
