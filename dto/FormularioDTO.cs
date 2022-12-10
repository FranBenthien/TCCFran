namespace dto;

public class FormularioDTO   
{
    public DateTime? ArrivalDate { get; set; }
    public DateTime? DepartureDate { get; set; }
    public int? Id { get; set; }
    public string? TypeHosting { get; set; } 
    public string? HostingAmount { get; set; } 
    public string? Accommodation { get; set; } 
    public string? Link { get; set; }
    public string? HostingComments { get; set; }
    public string? Food { get; set; }
    public string? FoodAmount { get; set; }
    public string? TypeFood { get; set; }
    public string? FoodPlaceName { get; set; }
    public string? LinkFood { get; set; }
    public string? FoodComments { get; set; } 
    public string? TypeAttraction { get; set; } 
    public string? AttractionAmount { get; set; } 
    public string? TypeTransport { get; set; } 
    public string? AttractionComments { get; set; } 
    public string? Token { get; set; }
        
}
