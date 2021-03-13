using System;
using System.Net;
using System.Windows;

namespace CryptoStatistic.Web
{
    public class StandardClient : ClientInterface
    {
        public string Execute(string url)
        {
            var reply = "";
            var client = new WebClient();
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            try
            {
                reply = client.DownloadString(url);
            }
            catch (Exception)
            {
                MessageBox.Show("Внимание. Невозможно подключиться к сервису!");
            }

            client.Dispose();
            return reply;
        }
    }
}