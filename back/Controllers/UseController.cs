using Microsoft.AspNetCore.Mvc;
using dto;

namespace back.Controllers;

using Model;

[ApiController]
[Route("user")]
public class UserController : ControllerBase
{   
    [HttpPost("login")]   //tags com [] controlam sem que precise colocar classes
    public IActionResult Login(
        [FromBody]UsuarioDTO user
    )
    {
        using WebSiteViagemContext context 
            = new WebSiteViagemContext();
        
        var possibleUser = context.Usuarios
            .FirstOrDefault(
                u => u.UserId == user.UserId);
        
        if (possibleUser == null)
            return BadRequest("Nome de usuário inválido");

        if (possibleUser.Userpass != user.Password)
            return BadRequest("Senha inválida!");
        
        return Ok();
    }

    [HttpPost("register")]
    public IActionResult Register(
        [FromBody]UsuariosDTO user
        )
    {
        using WebSiteViagem Context = new WebSiteViagemContext();

        List<string> errors = new List<string>();

        if (user.Email == null)
        {
            errors.Add("Email não foi informado");
        }

        if (user.City == null)
        {
            errors.Add("Cidade não foi informado");
        }

        if (user.Country == null)
        {
            errors.Add("País não foi informado");
        }

        if (user.Phone == null)
        {
            errors.Add("Número de telefone não foi informado");
        }
        
        if(usuarios.Name.Length < 5)
        {
            //return BadRequest();
            errors.Add("O nome do usuário precisa conter ao menos 5 letras.");
        }

        if (context.Usuarios
            .Any(u => u.UserId == user.UserId))
            {
                errors.Add("Seu nome de usuário já está em uso!");
            }

        if (errors.Count > 0)
        {
            return this.BadRequest(errors);
        }

        Usuario usuarios = new Usuarios();
        usuarios.Name = user.Name;
        usuarios.Email = user.Email;
        usuarios.City = user.City;
        usuarios.Country = user.Country;
        usuarios.Phone = user.Phone;
        usuarios.UserId = user.UserId;
        usuarios.Userpass = user.Password;                  

        context.Add(usuarios);
        context.SaveChanges();
        
        return Ok();
    }


    [HttpPost("update")]
    public IActionResult UpdateName()
    {
        throw new NotImplementedException();
    }

}
