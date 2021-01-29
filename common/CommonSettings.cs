using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace working_jwt.common
{
    public class CommonSettings
    {
        public static string private_key { get; set; }
        public static string issuer { get; set; }
        static CommonSettings()
        {
            //private_key = "my_secret_key_12345";
            private_key = "my_secret_key_DhaneshKumarKushwaha";
            issuer = "http://sgcms.in";
        }

    }
}