using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace vega.Models
{
    public class CarMake
    {
        public CarMake()
        {
            Models = new Collection<CarModel>();
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<CarModel> Models { get; set; }
        
    }
}