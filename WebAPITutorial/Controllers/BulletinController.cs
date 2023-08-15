using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebAPITutorial.Interfaces;
using WebAPITutorial.Models;
using WebAPITutorial.Services;

namespace WebAPITutorial.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BulletinController
    {
        IBulletinService bulletinService;

        public BulletinController(IBulletinService bulletinService)
        {
            this.bulletinService = bulletinService;
        }

        [HttpGet(Name = "GetBulletin")]
        public IEnumerable<Bulletin> GetAll()
        {
            var data = bulletinService.GetAll();
            return data;
        }
    }
}
