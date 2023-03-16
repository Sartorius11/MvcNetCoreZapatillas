using Microsoft.AspNetCore.Mvc;
using MvcNetCoreZapatillas.Repositories;

namespace MvcNetCoreZapatillas.ViewComponents
{
    public class MenuZapatillasComponents : Controller
    {
        private RepositoryZapatillas repo;
        
        public MenuZapatillasComponents(RepositoryZapatillas)
        {
            this.repo = repo;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Zapatilla> zapatillas = this.repo.GetZapatilla();
            return View(zapatillas);
        }


    }
}
