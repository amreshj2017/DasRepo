namespace vega.Models
{
    public class CarModel
    {
        public int CarModelId { get; set; }
       public CarMake CarMake { get; set; }
       public int CarMakeId { get; set; }
       public string CarModelName { get; set; }
    }
}