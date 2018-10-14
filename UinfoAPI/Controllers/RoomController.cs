using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UinfoAPI.Controllers
{
    public class SearchKey
    {
        public string RoomNum { get; set; }
        public string CourseName { get; set; }
        public string TeacherName { get; set; }
        public string CourseTime { get; set; }
        public string CourseNum { get; set; }
    }
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        // POST: api/Room
        [HttpPost]
        public string Post([FromBody] SearchKey value)
        {
            return "{\"RoomsNum\": [\"6A-101\",\"6A-102\",\"6A-103\",\"6A-104\",\"6A-105\",\"6A-106\",\"6A-107\",\"6A-108\",\"6A-109\",\"6A-110\"]}";
        }
    }
}
