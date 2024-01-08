using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProcessManagement
{
    public partial class dataGrid2 : Form
    {
        private static DataTable dt = new DataTable();
        private static Process[] processes;
        public int counter = 0;
        public dataGrid2()
        {
            InitializeComponent();
            DataColumn idColumn = new DataColumn("Id", Type.GetType("System.Int32"));
            DataColumn nameColumn = new DataColumn("Name", Type.GetType("System.String"));
            DataColumn timeStart = new DataColumn("TimeStart", Type.GetType("System.String"));
            DataColumn processTime = new DataColumn("ProcessTime", Type.GetType("System.String"));
            DataColumn countThread = new DataColumn("CountThread", Type.GetType("System.Int32"));
            
            dt.Columns.Add(idColumn);
            dt.Columns.Add(nameColumn);
            dt.Columns.Add(timeStart);
            dt.Columns.Add(processTime);
            dt.Columns.Add(countThread);
           
            dataGridView2.DataSource = dt;
            textBoxname2.Text = Form1.nameProcess;

            dataGridViewFill(dataGridView2, (string)textBoxname2.Text);
        }
        public void dataGridViewFill(object sender, string processName)
        {
            processes = Process.GetProcessesByName(processName);

            foreach (Process process in processes)
            {
                if (process.ProcessName == processName) { counter++; labelCount.Text = counter.ToString() + " копии"; }

                string s, t, c;
                try { s = process.StartTime.ToString(); } catch { s = ""; }
                try { t = process.TotalProcessorTime.ToString(); } catch { t = ""; }
                try { c = process.Threads.Count.ToString(); } catch { c = ""; }
               
                try
                {
                    dt.Rows.Add(new object[] { process.Id, process.ProcessName, s, t, c });
                    dataGridView2.DataSource = dt;
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
        public bool FindAndKillProcess(string name)
        {
            try
            {
                foreach (Process clsProcess in
                                  Process.GetProcesses())
                {
                    if (clsProcess.ProcessName.StartsWith(name))
                    {
                        clsProcess.Kill();
                        clsProcess.WaitForExit();
                        //Выполняем проверку если работающий системный процесс,
                        //на который ссылается компонент
                        //System.Diagnostics.Process, был завершен возвращаем true;
                        //в противном случае — значение false.                        
                        if (clsProcess.HasExited)
                            return true;
                        else
                            return false;
                    }
                }
                //Если процесс не был найден
                //возвращаем false.
                return false;
            }
            catch (Exception)
            {
                //При получении ошибок
                //возвращаем false.
                return false;
            }
        }
        private void buttonAbort_Click(object sender, EventArgs e)
        {
            //Вызываем метод поиска и завершения выбранного процесса.
            if (FindAndKillProcess(textBoxname2.Text))
            {
                MessageBox.Show("Процесс успешно завершён!", "Завершение процесса",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Очищаем поле ввода.
                textBoxname2.Text = "";
                
            }
            else
                MessageBox.Show("Ошибка при завершении процесса.", "Завершение процесса",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
