using System;
using System.Windows;
using CryptoStatistic.Web.Bypasses;

namespace CryptoStatistic.Web
{
    public class BypassedClient : ClientInterface
    {
        public string Execute(string url)
        {
            var reply = "";
            var client = CloudflareEvader.CreateBypassedWebClient(url);
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