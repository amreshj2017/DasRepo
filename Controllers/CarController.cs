using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using vega.Models;

namespace vega.Controllers
{
    public class CarController:Controller
    {
        [HttpGet]
        public IEnumerable<CarMake> GetCarMakes()
        {
            return null;
        }
        

    }
}