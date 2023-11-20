using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Utilidades
{
    public class TokenManager
    {
        public static TokenManager _instance;
        public string _token;
        public string _refresh;

        public TokenManager()
        {
        }

        public static TokenManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new TokenManager();
                }
                return _instance;
            }
        }
    }
}
