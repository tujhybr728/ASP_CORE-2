﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace WebStore.Clients
{
    public abstract class BaseClient
    {
        protected HttpClient Client { get; set; }

        protected string ServiceAddress { get; set; }

        protected BaseClient(IConfiguration configuration)
        {
            Client = new HttpClient()
            {
                BaseAddress = new Uri(configuration["ClientAddress"])
            };
            Client.DefaultRequestHeaders.Accept.Clear();
            Client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
