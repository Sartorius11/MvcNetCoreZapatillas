using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MvcNetCoreZapatillas.Data;
using MvcNetCoreZapatillas.Models;

#region SQL SERVER
//VUESTRO PROCEDIMIENTO DE PAGINACION DE IMAGENES DE ZAPATILLAS



#endregion

namespace MvcNetCoreZapatillas.Repositories
{
    public class RepositoryZapatillas
    {
        private ZapatillasContext context;

    
        public RepositoryZapatillas(ZapatillasContext context)
        {
            this.context = context;
        }

        //Hola Paco, lo siento por no sacarte este ejercicio, me fastidia bastante tener muy poca idea de como
        //se hacen estos parciales, Intento entenderlo pero hay unos conceptos basicos de POO que todavia no 
        //los comprendo o los comprendo y se me olvidan.. No me voy a excusar, me tengo que poner a ello.
       


    }
}
