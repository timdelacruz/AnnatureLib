using AnnatureLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnatureLib
{
    class Accounts
    {
        public string getList()
        {
            Headers headers = new Headers();
            Essentials essen = new Essentials();

            string responseString = essen.sendRequest("GET", headers.BaseUrl + "/v1/accounts");
            
            return responseString;
        }
    }
}
