using System.Text.Json.Nodes;
using System.Text;
using System;
using WebAPITutorial.Interfaces;
using WebAPITutorial.Models;
using Newtonsoft.Json;

namespace WebAPITutorial.Services
{
    public class BulletinService : IBulletinService
    {
        string _url;
        public BulletinService()
        {
            _url = "https://seffaflik.epias.com.tr/transparency/service/bulletin/monthly"; 
        }
        public IEnumerable<Bulletin> GetAll()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var endpoint = new Uri(_url);
                    var result = client.GetAsync(endpoint).Result;
                    var response = result.Content.ReadAsStringAsync().Result;
                    if (response != null)
                        #pragma warning disable CS8602 // Dereference of a possibly null reference.
                        return JsonConvert.DeserializeObject<Response>(response).body.bulletins;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return null;
        }
    }
}
