using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using TvMees.Models;

namespace TvMees.Scraper
{
    class Program
    {
        private static readonly HttpClient client = new HttpClient();

        static async Task Main(string[] args)
        {
            var tvShows = await GetAllTvShows();
            var castMembers = await GetCastMembersForShow(1);

            foreach (var show in tvShows) Console.WriteLine(show.Name);
            foreach (var member in castMembers) Console.WriteLine(member.Name);

        }

        private static async Task<List<TvShow>> GetAllTvShows()
        {
            var streamTask = client.GetStreamAsync("http://api.tvmaze.com/shows");
            var tvShows = await JsonSerializer.DeserializeAsync<List<TvShow>>(await streamTask);
            return tvShows;
        }

        private static async Task<List<CastMember>> GetCastMembersForShow(int id)
        {
            var streamTask = client.GetStreamAsync($"http://api.tvmaze.com/shows/{id}/cast");
            var castMembers = await JsonSerializer.DeserializeAsync<List<CastMember>>(await streamTask);

            Console.WriteLine(castMembers.First().Name);

            return castMembers;
        }
    }
}
