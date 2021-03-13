using System;
using System.Windows.Forms;
using CryptoStatistic.Objects;
using CryptoStatistic.Services;

namespace CryptoStatistic.Forms
{
    public partial class SettingsForm : Form
    {
        private SettingService settingService;

        public SettingsForm(SettingService settingService)
        {
            InitializeComponent();
            this.settingService = settingService;
            LoadSettings();
        }

        void LoadSettings()
        {
            var settings = settingService.GetSettings();
            textBox1.Text = settings.payAddress;
            textBox2.Text = settings.daysInCycle.ToString();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var settings = new SettingObject();
            if (textBox1.TextLength > 0)
            {
                settings.payAddress = textBox1.Text;
            }

            if (textBox2.TextLength > 0)
            {
                var daysInCycle = 0;
                if (!int.TryParse(textBox2.Text, out daysInCycle))
                    MessageBox.Show("Данный параметр принимает только цифры", "Кол-во дней в статистике");
                else
                    settings.daysInCycle = daysInCycle;
            }

            settingService.UpdateSettings(settings);
            ((MainForm) Owner).InitProvider();
            Close();
        }
    }
}