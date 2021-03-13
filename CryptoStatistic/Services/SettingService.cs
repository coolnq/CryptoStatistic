using CryptoStatistic.Objects;
using CryptoStatistic.Repositories;

namespace CryptoStatistic.Services
{
    public class SettingService
    {
        private SettingRepository settingRepository;

        public SettingService()
        {
            settingRepository = new SettingRepository();
        }

        public SettingObject GetSettings()
        {
            return settingRepository.GetSettings();
        }

        public void UpdateSettings(SettingObject settings)
        {
            settingRepository.SaveSettings(settings);
        }
    }
}