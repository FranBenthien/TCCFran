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
        string Accommodation,
        string Link,
        string Food,
        string FoodAmount,
        string TypeFood,
        string TypeAttraction,
        string AttractionAmount,
        string TypeTransport,
        string Comments)
        
    {
        FormularioDTO form = new FormularioDTO();        
        form.ArrivalDate = ArrivalDate;        
        form.DepartureDate = DepartureDate;
        form.TypeHosting = TypeHosting;
        form.Accommodation = Accommodation;
        form.Link = Link;
        form.Food = Food;
        form.FoodAmount = FoodAmount;
        form.TypeFood = TypeFood;
        form.TypeAttraction = TypeAttraction;
        form.AttractionAmount = AttractionAmount;
        form.TypeTransport = TypeTransport;
        form.Comments = Comments;
        

        var result = await client
            .PostAsJsonAsync("form/formulario", form);
    }
}