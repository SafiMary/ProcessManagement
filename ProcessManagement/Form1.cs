using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Threading;

namespace ProcessManagement
{
    public partial class Form1 : Form
    {
        private static DataTable dt = new DataTable();
        private static Process[] processes;
        public static int reloadTime;
        System.Windows.Forms.Timer timer1;
        Form dataGridView2 = null;
        public static string nameProcess;
        public Form1()
        {
            InitializeComponent();
            DataColumn idColumn = new DataColumn("Id", Type.GetType("System.Int32"));
            DataColumn nameColumn = new DataColumn("Name", Type.GetType("System.String"));
            
            dt.Columns.Add(idColumn);
            dt.Columns.Add(nameColumn);
            
            dataGridView1.DataSource = dt;

            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 500;
            timer1.Tick += new System.EventHandler(timer1_Tick);
            timer1.Enabled = true;

        }
        public void dataGridViewFill(object sender)
        {
            dt.Rows.Clear();
            processes = Process.GetProcesses();
            foreach (Process process in processes)
            {
                try
                {

                    dt.Rows.Add(new object[] { process.Id, process.ProcessName });
                    dataGridView1.DataSource = dt;
                 
                }
                catch { }

            }
            try
            {
                Invoke((MethodInvoker)delegate
                {
                    (sender as DataGridView).DataSource = dt;
                    (sender as DataGridView).AutoResizeColumns(
                DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);

                }
                      );
            }
            catch { }


        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (dataGridView2 == null)
            {
                dataGridView2 = new dataGrid2();
                dataGridView2.Show();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            nameProcess = (string)textBoxname.Text;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Interval = (int)numericTimer.Value * 1000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dataGridViewFill(dataGridView1);
        }

    }
}
