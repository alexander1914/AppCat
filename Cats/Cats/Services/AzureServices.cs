﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;

namespace Cats.Services
{
    public class AzureServices<T>
    {
        IMobileServiceClient Client;
        IMobileServiceTable<T> Table;

        public AzureServices()
        {
            string MyAppServiceURL = "http://appacats.azurewebsites.net";
            Client = new MobileServiceClient(MyAppServiceURL);
            Table = Client.GetTable<T>();
        }
        public Task<IEnumerable<T>> GetTable()
        {
            return Table.ToEnumerableAsync();
        }
    }
}
