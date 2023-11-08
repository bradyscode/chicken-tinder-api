using chicken_tinder_api.Models;

namespace chicken_tinder_api.Interfaces.Location_Service
{
    public interface ILocationServices
    {
        public IpInfo GetLocation(string ip);
    }
}
