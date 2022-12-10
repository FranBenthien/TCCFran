using System;

namespace back.Services;

using Model;

public class FormService
{
    public int Formulario {get; private set; }
    public FormService(int Formulario) 
    {
        this.Formulario = Formulario; 

    }  
    public async Task<Formulario> includeFormulario (Formulario user)
    {
        Formulario formulario = new Formulario();

        formulario.UserId = user.Id;
        
        using WebSiteViagemContext context = new WebSiteViagemContext();
        context.Formularios.Add(formulario);
        await context.SaveChangesAsync();

        return formulario;
    }  

}