using System;
using System.Collections.Generic;
using System.Text;

namespace EventoTec.Libary.Model
{
    public class TokenRequest
    {
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
        public DateTime ExpirationLocal => Expiration.ToLocalTime();

    }
}
