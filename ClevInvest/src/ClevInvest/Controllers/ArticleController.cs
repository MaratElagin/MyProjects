using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using ClevInvest.Services.Database;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace ClevInvest.Controllers
{
    [Route("api/article")]
    public class ArticleController : Controller
    {
        private ApplicationContext _db;
        [HttpPost]
        public async Task<object> Post()
        {
            try
            {
                string body = "";
                using (var reader = new StreamReader(HttpContext.Request.Body))
                {
                    body = await reader.ReadToEndAsync();
                }

                var req = JObject.Parse(body);
                var sReq = $"id={req["Id"]} Description={req["Description"]}";
                return Json(new {result = "ok", message = sReq});
            }
            catch (Exception ex)
            {
                return Json(new {result = "error", message = ex.Message});
            }
        }
        
        
    }
}