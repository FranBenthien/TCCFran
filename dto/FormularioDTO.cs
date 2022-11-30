namespace dto;

public class FormularioDTO   
{
    public DateTime? ArrivalDate { get; set; }
    public DateTime? DepartureDate { get; set; }
    public int Id { get; set; }
    public string? TypeHosting { get; set; } = null!;
    public string? HostingAmount { get; set; } = null!;
    public string? Accommodation { get; set; } = null!;
    public string? Link { get; set; }
    public string? Food { get; set; } = null!;
    public string? FoodAmount { get; set; } = null!;
    public string? TypeFood { get; set; } = null!;
    public string? TypeAttraction { get; set; } = null!;
    public string? AttractionAmount { get; set; } = null!;
    public string? TypeTransport { get; set; } = null!;
    public string? Comments { get; set; } = null!;
        
}
