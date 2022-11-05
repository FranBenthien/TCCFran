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
        string userId,
        string Email,
        string City,
        string Country,
        string Phone,
        string password)
    {
        UsuarioDTO user = new UsuarioDTO();
        user.Name = name;
        user.UserId = userId;
        user.Password = password;
        user.Email = Email;
        user.City = City;
        user.Country = Country;
        user.Phone = Phone;

        var result = await client
            .PostAsJsonAsync("user/register", user);
    }

    public async Task<string> Login(
        string email,
        string password
    )
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
}