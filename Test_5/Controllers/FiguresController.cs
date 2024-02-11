using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Test_5.Controllers
{
    public class FiguresController : ControllerBase
    {
        private static Random random = new Random();

        [HttpGet("GetFigures/{type}/{count}")]
        public ActionResult<List<Figure>> GetFigures(string type, int count)
        {
            List<Figure> figures = new List<Figure>();

            for (int i = 0; i < count; i++)
            {
                switch (type)
                {
                    case "Rectangle":
                        figures.Add(new Rectangle { Width = random.Next(1, 10), Height = random.Next(1, 10) });
                        break;
                    case "Circle":
                        figures.Add(new Circle { Radius = random.Next(1, 10) });
                        break;
                    case "Triangle":
                        figures.Add(new Triangle { SideA = random.Next(1, 10), SideB = random.Next(1, 10), SideC = random.Next(1, 10) });
                        break;
                }
            }

            return Ok(figures.Select(f => new { Info = f.GetInfo(), Area = f.GetArea(), Perimeter = f.GetPerimeter() }));
        }
    }
}

