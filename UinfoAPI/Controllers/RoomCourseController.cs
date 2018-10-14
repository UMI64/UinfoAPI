using System.IO;
using System.Text;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;

namespace UinfoAPI.Controllers
{
    public class RoomsFormat
    {
        public string RoomNum { get; set; }
    }
    [Route("api/[controller]")]
    [ApiController]
    public class RoomCourseController : ControllerBase
    {
        private readonly IHostingEnvironment _hostingEnvironment;
        public RoomCourseController(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
        // POST: api/RoomCourse
        [HttpPost]
        public string Post([FromBody] RoomsFormat value)
        {
            string[] RoomNum= value.RoomNum.Split('/');
            string filepath = _hostingEnvironment.WebRootPath+ "//RoomCourse.json";
            string json = GetFileJson(filepath);
            return json;
        }     
        public string GetFileJson(string filepath)
        {
            string json = string.Empty;
            using (FileStream fs = new FileStream(filepath, FileMode.Open, System.IO.FileAccess.Read, FileShare.ReadWrite))
            {
                using (StreamReader sr = new StreamReader(fs, Encoding.GetEncoding("UTF-8")))
                {
                    json = sr.ReadToEnd().ToString();
                }
            }
            return json;
        }
    }
}
