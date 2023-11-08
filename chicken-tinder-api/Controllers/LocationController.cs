using chicken_tinder_api.Interfaces.Location_Service;
using chicken_tinder_api.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Globalization;
using System.Net;
using System.Net.Sockets;

namespace chicken_tinder_api.Controllers
{
    public class LocationController : Controller
    {
        private ILocationServices _locationServices;

        public LocationController(ILocationServices locationServices)
        {
            _locationServices = locationServices;
        }

        //on the front end well have the pass in the ip using https://geolocation-db.com/
        //https://stackoverflow.com/questions/44553323/how-to-get-the-client-ip-address-from-browser-in-angular-typescript
        [HttpGet("/GetLocation")]
        public IpInfo GetLocation(string ip)
        {
            return _locationServices.GetLocation(ip);
        }

        [HttpGet("/CustomLocation/{location}")]
        public void SetLocation(string location)
        {
            _locationServices.SetLocation(location);
        }
    }
}
