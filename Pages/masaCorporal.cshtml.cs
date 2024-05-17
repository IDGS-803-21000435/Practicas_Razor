using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Ejercicios_Razor.Pages
{
    public class masaCorporalModel : PageModel
    {
        // DEFINIR ATRIBUTOS A USAR
        public double resultado {  get; set; }
        [BindProperty]
        public string peso { get; set; }
        [BindProperty]
        public string altura { get; set; }
        public void OnPost()
        {
            double alturaDob = 0;
            double pesoDob = 0;
            alturaDob = Convert.ToDouble(altura);
            pesoDob = Convert.ToDouble(peso);
            resultado = pesoDob / Math.Pow(alturaDob, 2);
        }

        public void OnGet()
        {
        }
    }
}
