﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace API_Gateway.HttpClients
{
    public class CustomersHttpClient : BaseMicroservicesHttpClient
    {
        public CustomersHttpClient()
        {
            this.BaseAddress = new Uri("http://localhost.fiddler:5001/api/customers");
        }
    }
}
