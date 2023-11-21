using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.CompilerServices;
using webapiproject.Controllers;
using webapiproject2;

namespace WebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        //http://localhost:5000/WeatherForecast/post
        [HttpPost("post")]
        public IActionResult post([FromForm]string firstName)
        {
            Console.WriteLine("aaaaaaaaaaaaaaaaa");
            Console.WriteLine(firstName);
            string h = "hello";
            if (firstName.CompareTo(h) == 0)
            {
                string s = "seikou";
                var result = new
                {
                    Value = s.ToString()
                };

                return new CustomJsonResult(HttpStatusCode.OK, result);
                
            }
                return new CustomJsonResult(HttpStatusCode.BadRequest, new
                {
                    Type = this.GetType().FullName,
                    Title = "The Access code is expired or invalid.",
                    Instance = Request?.Path.Value
                });
            

            

            

            
        }

        [HttpGet("get")]
        public void get()
        {
            Console.WriteLine("bbbbbbbbbbbbb");
        }
    }


}