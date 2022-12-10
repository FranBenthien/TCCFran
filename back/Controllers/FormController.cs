using Microsoft.AspNetCore.Mvc;
using dto;

namespace back.Controllers;

using Services;
using Model;

[ApiController]
[Route("form")]
public class FormController : ControllerBase
{   
    
    [HttpPost("formulario")]
    public IActionResult Formulario(
        [FromBody]FormularioDTO form
        )
    {
        using WebSiteViagemContext context = new WebSiteViagemContext();

        List<string> errors = new List<string>();

        if (form.ArrivalDate == null)
        {
             errors.Add("Data não informada");
        }

        if (form.DepartureDate == null)
        {
             errors.Add("Data não informada");
        }

        

        Formulario formulario = new Formulario();   
        formulario.ArrivalDate = form.ArrivalDate.Value;
        formulario.DepartureDate = form.DepartureDate.Value;
        formulario.TypeHosting = form.TypeHosting;
        formulario.HostingAmount = form.HostingAmount;
        formulario.Accommodation = form.Accommodation;
        formulario.Link = form.Link;
        formulario.HostingComments = form.HostingComments;
        formulario.Food = form.Food;
        formulario.FoodAmount = form.FoodAmount;
        formulario.TypeFood = form.TypeFood;
        formulario.FoodPlaceName = form.FoodPlaceName;
        formulario.LinkFood = form.LinkFood;
        formulario.FoodComments = form.FoodComments;
        formulario.TypeAttraction = form.TypeAttraction;
        formulario.AttractionAmount = form.AttractionAmount;
        formulario.TypeTransport = form.TypeTransport;
        formulario.AttractionComments = form.AttractionComments;
   
                     
        context.Add(formulario);
        context.SaveChanges();

        return Ok();
        
    }

}
