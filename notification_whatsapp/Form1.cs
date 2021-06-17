using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WhatsAppApi.Account;
using WhatsAppApi;
using System.Threading;
using System.IO.Ports;
using System.Data.SqlClient;

namespace notification_whatsapp
{
    public partial class Form1 : Form
    {


        SerialPort sp = new SerialPort();
        public void updateDatatextbox(TextBox textbox, string value)
        {
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {

        }

        private void buttonsend_Click(object sender, EventArgs e)
        {
            string numero = "";

            if (Program.sql_con.State == ConnectionState.Closed) Program.sql_con.Open();
            Program.sql_cmd = new SqlCommand("SELECT * from NUMS ", Program.sql_con);

            Program.db = Program.sql_cmd.ExecuteReader();
            if (Program.db.HasRows)
            {
                while (Program.db.Read())
                {
                    numero = Program.db["numero"].ToString();

                    sp.PortName = "COM5";
                    sp.ReadTimeout = 2000;
                    sp.Open();
                    sp.Write("AT\r");
                    sp.Write("AT+CMGF=1\r");
                    System.Threading.Thread.Sleep(1500);
                    sp.Write("AT+CMGS=\"" + numero + "\"\r\n");
                    System.Threading.Thread.Sleep(1500);
                    sp.Write(textMesssage.Text + "\x1A");
                    //MessageBox.Show("message sent  success ! ", "Message", MessageBoxButtons.OK);
                    sp.Close();

                }



               
            }
        }
    




        //sp.PortName = "COM5";
        //sp.ReadTimeout = 2000;
        //sp.Open();
        //sp.Write("AT\r");
        //sp.Write("AT+CMGF=1\r");
        //System.Threading.Thread.Sleep(1500);
        //sp.Write("AT+CMGS=\"" + textto.Text + "\"\r\n");
        //System.Threading.Thread.Sleep(1500);
        //sp.Write(textMesssage.Text + "\x1A");
        //MessageBox.Show("message sent  success ! ", "Message", MessageBoxButtons.OK);
        //sp.Close();

    }
    
}
