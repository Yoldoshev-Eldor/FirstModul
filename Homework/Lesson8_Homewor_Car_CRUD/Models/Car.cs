using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_constructor.Models
{
    public class Car
    {
        public Guid Id { get; set; }
        public string Name {  get; set; }
        public string Colour { get; set; }
        public int Speed { get; set; }
        public int DistanceTraveled { get; set; }
        public int Weight { get; set; }
        public string Factory {  get; set; }
        public DateTime DateTime { get; set; }

    }
}
