using System;
using System.Collections.Generic;

namespace ImportDataWebApp.Data.Models;

public partial class Crimes2023
{
    public int Id { get; set; }

    public string? CaseNumber { get; set; }

    public DateTime? Date { get; set; }

    public string? Block { get; set; }

    public string? Iucr { get; set; }

    public string? PrimaryType { get; set; }

    public string? Description { get; set; }

    public string? LocationDescription { get; set; }

    public int? Arrest { get; set; } 

    public int? Domestic { get; set; } 

    public int? Beat { get; set; }

    public int? District { get; set; }

    public int? Ward { get; set; }

    public int? CommunityArea { get; set; }

    public int? Fbicode { get; set; }

    public int? Xcoordinate { get; set; }

    public int? Ycoordinate { get; set; }

    public int? Year { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public double? Latitude { get; set; }

    public double? Longitude { get; set; }

    public double? Location { get; set; }
}
