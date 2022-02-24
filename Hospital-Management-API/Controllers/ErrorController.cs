﻿using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital_Management_API.Controllers
{
    
    [ApiController]
    public class ErrorController : ControllerBase
    {
        [Route("Error")]
        public IActionResult Error()
        {
            var exceptionHandlerFeature = HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            var exceptionPath = exceptionHandlerFeature.Path;
            var exceptionMessage = exceptionHandlerFeature.Error.Message;
            var exceptionDetails = exceptionHandlerFeature.Error.StackTrace;

            // Logic code for logging the above exception details.


            return StatusCode(500, new { Error = "Something went wrong!!! Please contact admin." });
        }

    }
}
