using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Test_4.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TrainController : Controller
    {
        public struct Train
        {
            public string Destination;
            public int Number;
            public TimeSpan DepartureTime;
        }

        private static List<Train> trains = new List<Train>
        {
            new Train { Destination = "Москва", Number = 5, DepartureTime = TimeSpan.Parse("17:00") },
            new Train { Destination = "Анапа", Number = 1, DepartureTime = TimeSpan.Parse("11:30") },
            new Train { Destination = "Саратов", Number = 8, DepartureTime = TimeSpan.Parse("09:00") },
            new Train { Destination = "Мурманск", Number = 15, DepartureTime = TimeSpan.Parse("22:20") },
            new Train { Destination = "Екатеринбург", Number = 4, DepartureTime = TimeSpan.Parse("11:00") }
        };

        [HttpGet("GetTrain/{number}")]
        public ActionResult<Train> GetTrain(int number)
        {
            var train = trains.FirstOrDefault(t => t.Number == number);
            return Ok(train);
        }

        [HttpGet("SortTrains")]
        public ActionResult<List<Train>> SortTrains()
        {
            var sortedTrains = trains.OrderBy(t => t.Destination).ThenBy(t => t.DepartureTime).ToList();
            return Ok(sortedTrains);
        }

        [HttpGet("FilterTrains")]
        public ActionResult<List<Train>> FilterTrains()
        {
            var filteredTrains = trains.Where(t => t.DepartureTime > DateTime.Now.TimeOfDay).ToList();
            return Ok(filteredTrains);
        }
    }
}
