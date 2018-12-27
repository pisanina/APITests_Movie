using System;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;
using System.Linq;
using MovieDomain;

namespace Thrones
{
    public class UnitTest1
    {


        [Fact]
        public async Task Season6()

        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync("https://api.themoviedb.org/3/tv/1399/season/6/episode/1/credits?api_key="+ Config.APIKey);
            if (response.IsSuccessStatusCode)
            {
                var r = await response.Content.ReadAsAsync<Credits>();

     
                Assert.False(r.Cast.Any(p => p.Character == "Myrcella Baratheon"), "Myrcella found in Main Cast");
                Assert.False(r.Guest_Stars.Any(p => p.Character == "Myrcella Baratheon"), "Myrcella found in Guest Stars");
            }

            else
            {
                Assert.True(false, "Non success Conection");
            }

        }


        [Fact]
        public async Task Season5ep1()
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync("https://api.themoviedb.org/3/tv/1399/season/5/episode/1/credits?api_key="+ Config.APIKey);
            if (response.IsSuccessStatusCode)
            {
                var r = await response.Content.ReadAsAsync<Credits>();

                Assert.True(r.Cast.Any(p => p.Character == "Myrcella Baratheon"), "Myrcella  not found in Main Cast");

                Assert.False(r.Guest_Stars.Any(p => p.Character == "Myrcella Baratheon"), "Myrcella found in Guest Stars");
            }

            else
            {
                Assert.True(false, "Non success Conection");
            }

        }

        [Fact]
        public async Task Season5ep2()
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync("https://api.themoviedb.org/3/tv/1399/season/5/episode/2/credits?api_key="+ Config.APIKey);
            if (response.IsSuccessStatusCode)
            {
                var r = await response.Content.ReadAsAsync<Credits>();

                Assert.True(r.Cast.Any(p => p.Character == "Myrcella Baratheon"), "Myrcella  not found in Main Cast");
                Assert.True(r.Guest_Stars.Any(p => p.Character == "Myrcella Baratheon"), "Myrcella not found in Guest Stars");
            }

            else
            {
                Assert.True(false, "Non success Conection");
            }

        }

    }

}

