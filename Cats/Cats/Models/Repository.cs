﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cats.Models
{
  public class Repository
    {
        public async Task<List<Cat>> GetCats()
        {
            // Utilizando Meu RestFull Azure
            var Service = new Services.AzureServices<Cat>();
            var Items = await Service.GetTable();
            return Items.ToList();
            
            
            // Utilizando o RestFull da Maratona Xamarin

            //List<Cat> Cats;
            //var URLWebAPI = "http://demos.ticapacitacion.com/cats";

            //using (var Client = new System.Net.Http.HttpClient())
            //{
            //   var JSON = await Client.GetStringAsync(URLWebAPI);
            //   Cats = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Cat>>(JSON);
            //}
            //return Cats;
        }
    }
}
