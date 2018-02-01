using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using SpringBoot;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace SpringBootXUnitTest
{
    public class UnitTest1
    {
        private HttpClient Client;
        private TestServer Server;

        public UnitTest1()
        {
            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = Server.CreateClient();
        }

        [Fact]
        public async Task AudiShouldReturnOkStatus()
        {
            var response = await Client.GetAsync("/api/search/audi");
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task FiatShouldReturnOkStatus()
        {
            var response = await Client.GetAsync("/api/search/fiat");
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
