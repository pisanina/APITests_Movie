using System;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;
using MovieDomain;

namespace Breaking
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, 8)]
        [InlineData(2, 13)]
        [InlineData(3, 13)]
        [InlineData(4, 13)]
        [InlineData(5, 16)]

        public async Task TestSeason1(int SeasonNumber, int EpisodeNumber)
        {

            HttpClient client = new HttpClient();
            var response = await client.GetAsync("https://api.themoviedb.org/3/tv/1396/season/" + SeasonNumber + "?api_key="+ Config.APIKey);
            if (response.IsSuccessStatusCode)
            {
                var r = await response.Content.ReadAsAsync<Season>();

                Assert.True(r.Episodes.Count == EpisodeNumber, "Wrong number of episodes");
            }

            else
            {
                Assert.True(false, "Non success Conection");
            }
        }
    }
}
