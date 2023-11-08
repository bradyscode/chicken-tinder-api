using chicken_tinder_api.Models;
using Newtonsoft.Json;

using System.Net;

namespace chicken_tinder_api.Interfaces.Location_Service
{
    public class LocationServices : ILocationServices
    {
        public IpInfo GetLocation(string ip)
        {
            IpInfo ipInfo = new IpInfo();
            try
            {
                string info = new WebClient().DownloadString("http://ipinfo.io/" + ip);
                ipInfo = JsonConvert.DeserializeObject<IpInfo>(info);
            }
            catch (Exception)
            {
                throw new Exception("Could not get public IP Address.");
            }

            return ipInfo;
        }

        public void SetLocation(string location)
        {
            IpInfo ipInfo = new IpInfo(location);
        }
    }
}
