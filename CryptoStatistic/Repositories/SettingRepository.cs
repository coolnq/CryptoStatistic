using System.IO;
using CryptoStatistic.Objects;

namespace CryptoStatistic.Repositories
{
    public class SettingRepository
    {
        public SettingObject GetSettings()
        {
            var settings = new SettingObject();
            using (var fs = new FileStream("./settings.sdat", FileMode.OpenOrCreate))
            {
                if (fs.Length > 0)
                {
                    var br = new BinaryReader(fs);
                    settings.payAddress = br.ReadString();
                    settings.daysInCycle = br.ReadInt32();
                }
            }

            return settings;
        }

        public void SaveSettings(SettingObject settings)
        {
            using (var fs = new FileStream("./settings.sdat", FileMode.OpenOrCreate))
            {
                var bw = new BinaryWriter(fs);
                bw.Write(settings.payAddress);
                bw.Write(settings.daysInCycle);
                bw.Flush();
            }
        }
    }
}