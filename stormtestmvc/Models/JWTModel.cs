﻿namespace stormtestmvc.Models
{
    public class JWTModel
    {
        public int Id { get; set; }
        public string Auth_Token { get; set; }
        public int Expires_In { get; set; }
    }
}
