using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BDEditor
{
    public partial class Form1 : Form
    {
        string FileName = "";
        List<My_Income> MyIncome = new List<My_Income>();
        List<My_Payments> MyPayments = new List<My_Payments>();
        
        public Form1()
        {
            InitializeComponent();
            StatusLabel.Text = "Готов";
            openFileDialog.InitialDirectory = "./";
            openFileDialog.Filter = "Statistic base files (*.idat)|*.idat";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.ReadOnlyChecked = false;

            saveFileDialog.InitialDirectory = "./";
            saveFileDialog.Filter = "Statistic base files (*.idat)|*.idat";
            saveFileDialog.RestoreDirectory = true;
        }

        private void MenuOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Stream fileStream = openFileDialog.OpenFile();
                    MyIncome.Clear();
                    MyPayments.Clear();

                    if (fileStream != null)
                    {
                        BinaryReader br = new BinaryReader(fileStream);
                        FileName = openFileDialog.FileName;
                        int count = br.ReadInt32();
                        for (int i = 0; i < count; i++)
                        {
                            My_Income MyIn = new My_Income();
                            MyIn.date = UnixTimestampToDateTime(br.ReadInt64());
                            MyIn.income = br.ReadDouble();
                            MyIncome.Add(MyIn);
                        }

                        /*count = br.ReadInt32();
                        for (int i = 0; i < count; i++)
                        {
                            My_Payments MyPay = new My_Payments();
                            MyPay.date = UnixTimestampToDateTime(br.ReadInt64());
                            MyPay.amount = br.ReadDouble();
                            MyPayments.Add(MyPay);
                        }*/
                        br.Close();

                        BindingSource IncomeSource = new BindingSource(MyIncome, null);
                        IncomeGridView.DataSource = IncomeSource;
                        BindingSource PaymentsSource = new BindingSource(MyPayments, null);
                        PayGridView.DataSource = PaymentsSource;
                    }
                    fileStream.Close();
                    StatusLabel.Text = "База загружена";
                }
                catch (Exception ex)
                {
                    StatusLabel.Text = "Ошибка";
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
            else
                StatusLabel.Text = "Загрузка отменена";
        }

        void SaveBase(string fn)
        {
            MyIncome.Sort(IncomeCompareTime);
            MyPayments.Sort(PaymentsCompareTime);

            using (FileStream fs = new FileStream(fn, FileMode.OpenOrCreate))
            {

                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(MyIncome.Count);
                for (int i = 0; i < MyIncome.Count; i++)
                {
                    bw.Write((long)DateTimeToUnixTimestamp(MyIncome[i].date));
                    bw.Write(MyIncome[i].income);
                }

                /*bw.Write(MyPayments.Count);
                for (int i = 0; i < MyPayments.Count; i++)
                {
                    bw.Write((long)DateTimeToUnixTimestamp(MyPayments[i].date));
                    bw.Write(MyPayments[i].amount);
                }
                bw.Flush();*/
                bw.Close();
            }
            StatusLabel.Text = "База сохранена";
        }

        public static DateTime UnixTimestampToDateTime(double unixTime)
        {
            DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, 0).ToLocalTime();
            return epoch.AddSeconds(unixTime);
        }

        public static double DateTimeToUnixTimestamp(DateTime dateTime)
        {
            DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, 0).ToLocalTime();
            TimeSpan span = (dateTime - epoch);
            return span.TotalSeconds;
        }

        static private int IncomeCompareTime(My_Income in1, My_Income in2)
        {
            return in1.date.CompareTo(in2.date);
        }
        static private int PaymentsCompareTime(My_Payments in1, My_Payments in2)
        {
            return in1.date.CompareTo(in2.date);
        }

        private void MenuSave_Click(object sender, EventArgs e)
        {
            if (FileName.Length > 0)
                SaveBase(FileName);
        }

        private void MenuSaveAs_Click(object sender, EventArgs e)
        {
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog.FileName.Length > 0)
                    SaveBase(FileName);
            }
            else
                StatusLabel.Text = "Сохранение отменено";
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    class My_Payments
    {
        public double amount { get; set; }  // payments amount
        public DateTime date { get; set; }     // timestamp
    }

    class My_Income
    {
        public DateTime date { get; set; }
        public double income { get; set; }
    }
}
