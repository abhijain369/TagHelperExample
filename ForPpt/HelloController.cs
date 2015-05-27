using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace Abhi1.Controllers
{
    public class HelloController : Controller
    {
        public string Index()
        {
            return "Hello World";
        }
    }
}