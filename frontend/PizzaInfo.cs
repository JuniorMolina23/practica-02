using System;

namespace frontend
{
    public class PizzaInfo
    {
        //public int? id {get; set; }

        public DateTime Date { get; set; }

        public double? TemperatureC { get; set; }

        public double? TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }
}