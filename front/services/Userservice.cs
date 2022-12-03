using dto;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace front.Services;

public class UserService
{
    HttpClient client;

    public UserService(string server)
    {
        client = new HttpClient();
        client.BaseAddress = new Uri(server); 
    }

    public async Task Register(
        string name,
        string Email,               
        string password)

    {
        UsuarioDTO user = new UsuarioDTO();
        user.Name = name;
        user.Email = Email;
        user.Password = password;
    
        
        var result = await client
            .PostAsJsonAsync("user/register", user);
    }

    public async Task<string> Login(
        string email,
        string password)

    {
        UsuarioDTO user = new UsuarioDTO();
        user.Email = email;
        user.Password = password;

        var result = await client
            .PostAsJsonAsync("user/login", user);
        
        if (result.StatusCode != HttpStatusCode.OK)
            return null;

        var content = await result.Content.ReadFromJsonAsync<RequestMessage<string>>();

        if (content.Status != "Success")
            return null;

        return content.Content;
        
    }
    public async Task Formulario(        
        DateTime ArrivalDate,            
        DateTime DepartureDate,     
        string TypeHosting,
        string HostingAmount,
        string Accommodation,
        string Link,
        string HostingComments,
        string Food,
        string FoodAmount,
        string TypeFood,
        string FoodPlaceName,
        string LinkFood,
        string FoodComments,
        string TypeAttraction,
        string AttractionAmount,
        string TypeTransport,
        string AttractionComments)
        
    {
        FormularioDTO form = new FormularioDTO();        
        form.ArrivalDate = ArrivalDate;        
        form.DepartureDate = DepartureDate;
        form.TypeHosting = TypeHosting;
        form.HostingAmount = HostingAmount;
        form.Accommodation = Accommodation;
        form.Link = Link;
        form.HostingComments = HostingComments;
        form.Food = Food;
        form.FoodAmount = FoodAmount;
        form.TypeFood = TypeFood;
        form.FoodPlaceName = FoodPlaceName;
        form.LinkFood = LinkFood;
        form.FoodComments = FoodComments;
        form.TypeAttraction = TypeAttraction;
        form.AttractionAmount = AttractionAmount;
        form.TypeTransport = TypeTransport;
        form.AttractionComments = AttractionComments;
        

        var result = await client
            .PostAsJsonAsync("form/formulario", form);
    }
}