using Microsoft.AspNetCore.Mvc;
using System;

namespace HNG12API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InfoController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var response = new
            {
                email = "iamaqim@gmail.com", // Replace with your HNG12 Slack email
                current_datetime = DateTime.UtcNow.ToString("o"), // ISO 8601 format
                github_url = "https://github.com/yourusername/your-repo" // Replace with your GitHub repo URL
            };

            return Ok(response);
        }
    }
}