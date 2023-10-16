using System.ComponentModel.DataAnnotations;

namespace SampleWebApi.Models;

public class Temperatura
{
    [Key]
    public Int32? Id {get; set; }

    public DateTime? Date { get; set; }

    public double? TemperatureC { get; set; }

    public double? TemperatureF { get; set; }

    public string? Summary { get; set; }
}