﻿namespace chicken_tinder_api.Models
{
    public class UserDTO
    {
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public IpInfo ipInformation { get; set; }
    }
}
