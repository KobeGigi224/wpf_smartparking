﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows;

namespace Client
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            HttpClient httpClient = new HttpClient();
            var resp = httpClient.GetAsync("http://localhost:5000/WeatherForecast").GetAwaiter().GetResult();
            string values = resp.Content.ReadAsStringAsync().GetAwaiter().GetResult();
        }
    }
}