﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace Eshopping_MVC.Repoistory
{
    public class ServiceRepository
    {
        HttpClient client;
        public ServiceRepository()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(ConfigurationManager.AppSettings["apiBaseURL"].ToString());
        }
        public HttpResponseMessage GetResponse(string url)
        {
            return client.GetAsync(url).Result;
        }
        public HttpResponseMessage PostResponse(string url, object content)
        {
            return client.PostAsJsonAsync(url, content).Result;
        }
    }
}
    
    
