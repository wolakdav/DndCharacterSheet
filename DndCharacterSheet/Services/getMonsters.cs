using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using DndCharacterSheet.Data;

namespace DndCharacterSheet.Services
{

    public static class getMonsters
    {
        private static readonly HttpClient client = new HttpClient();
        private static string baseUrl = "http://www.dnd5eapi.co/api/";
        public static async Task<ListOfAll> GetAllMonsters()
        {
            try
            {
                var url = baseUrl + "monsters/";
                var listOfMonsterString = await client.GetStringAsync(url);
                return Services.JsonConverter.FromJson<ListOfAll>(listOfMonsterString);
            }
            catch (Exception)
            {
                return new ListOfAll();
            }    
        }
        public static async Task<Monster> GetMonsterFromIndex(int monsterId)
        {
            try
            {
                var url = baseUrl + "monsters/" + monsterId.ToString();
                var monsterString = await client.GetStringAsync(url);
                return Services.JsonConverter.FromJson<Monster>(monsterString);
            }
            catch (Exception)
            {
                return new Monster();
            }
        }
        public static async Task<Monster> GetMonsterFromURL(string monsterURL)
        {
            try
            {
                var monsterString = await client.GetStringAsync(monsterURL);
                return Services.JsonConverter.FromJson<Monster>(monsterString);
            }
            catch (Exception)
            {
                return new Monster();
            }
        }
    }
}
