using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CryptoStatistic.Helpers;
using CryptoStatistic.Managers;
using CryptoStatistic.Objects;
using CryptoStatistic.Objects.Data;
using CryptoStatistic.Provider;
using CryptoStatistic.Services;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;

namespace CryptoStatistic.Forms
{
    public partial class MainForm : Form
    {
        private IncomeService incomeService;
        private SettingService settingService;

        public MainForm()
        {
            InitializeComponent();
            settingService = new SettingService();
            incomeService = new IncomeService(new Dummy());
            InitProvider();
            UpdateData();
        }

        public void InitProvider()
        {
            var settings = settingService.GetSettings();
            if (settings.payAddress.Any())
            {
                var dataProvider = new NiceHash(settings.payAddress);
                incomeService.ChangeProvider(dataProvider);
            }
        }

        private void UpdateData()
        {
            incomeService.refreshData();
            var dayManager = incomeService.GetDayIncomeManager();
            var paymentManager = incomeService.GetPaymentManager();
            var rawManager = incomeService.GetRawIncomeManager();
            UpdatePlot(dayManager, paymentManager);
            UpdateStatistic(new StatisticObject(dayManager, rawManager));
            UpdatePrediction(new PredictionObject(dayManager, rawManager));
            incomeService.SaveIncomes(dayManager.GetAll());
            incomeService.SavePayments(paymentManager.GetAll());
        }

        void UpdateStatistic(StatisticObject obj)
        {
            obj.Update();
            ////Day Start////
            Label_Day_Income.Text = obj.GetDayIncome().ToString("F8") + " btc";
            Label_Day_Trend.Text = obj.getDayTrend().ToString("P1");
            Label_Day_Aver.Text = obj.getDayAver().ToString("F8") + " btc";
            Label_Day_Expected.Text = obj.getDayExpected().ToString("F8") + " btc";
            ////Day End////

            ////Week Start////
            Label_Week_Income.Text = obj.getWeekIncome().ToString("F8") + " btc";
            Label_Week_Trend.Text = obj.getWeekTrend().ToString("P1");
            Label_Week_Aver.Text = obj.getWeekAver().ToString("F8") + " btc";
            Label_Week_Expected.Text = obj.getWeekExpected().ToString("F8") + " btc";
            ////Week End////

            ////All Start////
            Label_All_Income.Text = obj.getTotalIncome().ToString("F8") + " btc";
            Label_All_Trend.Text = obj.getTotalTrend().ToString("P1");
            ////All End////
        }

        void UpdatePrediction(PredictionObject obj)
        {
            obj.Update();
            ////Day Start////
            Label_Full_Day_Average.Text = obj.GetFullDayAverage().ToString("F8") + " btc";
            Label_Full_Day_Median.Text = obj.GetFullDayMedian().ToString("F8") + " btc";
            Label_Hour_Day_Average.Text = obj.GetHourDayAverage().ToString("F8") + " btc";
            Label_Hour_Day_Median.Text = obj.GetHourDayMedian().ToString("F8") + " btc";
            ////Day End////

            ////Week Start////
            Label_Full_Week_Average.Text = obj.GetFullWeekAverage().ToString("F8") + " btc";
            Label_Full_Week_Median.Text = obj.GetFullWeekMedian().ToString("F8") + " btc";
            Label_Hour_Week_Average.Text = obj.GetHourWeekAverage().ToString("F8") + " btc";
            Label_Hour_Week_Median.Text = obj.GetHourWeekMedian().ToString("F8") + " btc";
            ////Week End////

            ////Month Start////
            Label_Full_Month_Average.Text = obj.GetFullMonthAverage().ToString("F8") + " btc";
            Label_Full_Month_Median.Text = obj.GetFullMonthMedian().ToString("F8") + " btc";
            Label_Hour_Month_Average.Text = obj.GetHourMonthAverage().ToString("F8") + " btc";
            Label_Hour_Month_Median.Text = obj.GetHourMonthMedian().ToString("F8") + " btc";
            ////Month End////
        }

        private void UpdatePlot(DayIncomeManager dayIncomeManager, PaymentManager paymentManager)
        {
            UpdateDayIncomePlot(dayIncomeManager.GetAll());
            UpdatePaymentPlot(dayIncomeManager, paymentManager.GetAll());
            BasePlot.UpdatePlot();
        }

        private void UpdateDayIncomePlot(IEnumerable<DayIncomeObject> incomes)
        {
            var points = new List<DataPoint>();
            foreach (var income in incomes)
            {
                var dp = new DataPoint(DateTimeAxis.ToDouble(UnixTimeHelper.UnixTimeToDateTime(income.time)), income.value);
                points.Add(dp);
            }

            BasePlot.LoadIncome(points.ToArray());
        }

        private void UpdatePaymentPlot(DayIncomeManager dayIncomeManager, IEnumerable<PaymentObject> payments)
        {
            var points = new List<ScatterPoint>();
            foreach (var payment in payments)
            {
                var Date = UnixTimeHelper.UnixTimeToDateTime(payment.time);
                var dayIncomeValue = dayIncomeManager.GetRow((long) UnixTimeHelper.Convert(Date)).value;
                if (dayIncomeValue > 0)
                {
                    var sp = new ScatterPoint(DateTimeAxis.ToDouble(Date), dayIncomeValue);
                    points.Add(sp);
                }
            }

            BasePlot.LoadPayment(points.ToArray());
        }

        private void UpdateButtonClick(object sender, EventArgs e)
        {
            UpdateButton.Text = "Обработка..";
            UpdateButton.Enabled = false;

            UpdateData();

            UpdateButton.Text = "Обновить";
            UpdateButton.Enabled = true;
        }

        private void loadJsonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* StreamReader StrRead;
             string jsonstring = "";
             OpenFileDialog openFileDialog1 = new OpenFileDialog();
 
             openFileDialog1.InitialDirectory = "./DebugString";
             openFileDialog1.Filter = "Json debug string files (*.jds)|*.jds";
             openFileDialog1.FilterIndex = 2;
             openFileDialog1.RestoreDirectory = true;
             openFileDialog1.ReadOnlyChecked = false;
 
             if (openFileDialog1.ShowDialog() == DialogResult.OK)
             {
                 try
                 {
                     FileStream fileStream = new FileStream(@openFileDialog1.FileName, FileMode.Open);
 
                     if (fileStream != null)
                     {
                         StrRead = new StreamReader(fileStream);
                         jsonstring = StrRead.ReadToEnd();
                         WebJson.ManualLoad(jsonstring);
                     }
 
                     fileStream.Close();
                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                 }
             }
 
 
             openFileDialog1.Dispose();
 
             //MergerIncomeData();
             CollectData();*/
        }

        int UpdateButtonCount = 0;

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            if (UpdateButtonCount > 4)
            {
                UpdateButton.Text = "";
                UpdateButtonCount = 0;
            }

            UpdateButton.Text += ".";
            UpdateButtonCount++;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var settingsForm = new SettingsForm(settingService);
            settingsForm.Owner = this;
            settingsForm.Show();
        }
    }
}