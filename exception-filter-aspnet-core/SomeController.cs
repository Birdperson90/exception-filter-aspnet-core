using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ExceptionFilterAspNetCore
{
    [Route("api/[controller]")]
    public class SomeController : Controller
    {
        private readonly ISomeService someService;

        public SomeController(ISomeService someService)
        {
            this.someService = someService;
        }

        [HttpGet]
        public IActionResult PrentendingToDoSmth()
        {
            this.someService.DoSomething();
            return Ok();
        }
    }
}
