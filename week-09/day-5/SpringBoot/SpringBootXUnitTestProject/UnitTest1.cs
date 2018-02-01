using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using SpringBoot;
using SpringBoot.Models;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace SpringBootXUnitTestProject
{
    public class UnitTest1
    {
        private  TestServer Server;
        private  HttpClient Client;

        public UnitTest1()
        {
            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = Server.CreateClient();
        }

        [Fact]
        public async Task LicencePlateOk()
        {
            var response = await Client.GetAsync("/api/search/audi");
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
