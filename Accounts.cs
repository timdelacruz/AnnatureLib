using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnatureLib
{
    class Accounts
    {
        public string AuthId { get; set; }
        public string AuthKey { get; set; }
        public string BaseUrl { get; set; }

        public Essentials essen;
        public string getList()
        {
            string responseString = essen.sendRequest("GET", AuthId, AuthKey, BaseUrl + "/v1/accounts");
            
            return responseString;
        }
    }
}
