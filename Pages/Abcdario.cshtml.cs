using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Text;

namespace Ejercicios_Razor.Pages
{
    public class AbcdarioModel : PageModel
    {
        public static string Cifrar(string mensaje, int n)
        {
            StringBuilder cifrado = new StringBuilder();

            foreach (char letra in mensaje)
            {
                if (char.IsLetter(letra))
                {
                    char letraCifrada = (char)(letra + n);
                    if ((char.IsUpper(letra) && letraCifrada > 'Z') || (char.IsLower(letra) && letraCifrada > 'z'))
                    {
                        letraCifrada = (char)(letraCifrada - 26);
                    }
                    cifrado.Append(letraCifrada);
                }
                else
                {
                    cifrado.Append(letra);
                }
            }
            return cifrado.ToString();
        }

        public static string Descifrar(string mensajeCifrado, int n)
        {
            return Cifrar(mensajeCifrado, -n);
        }

        [BindProperty]
        public string mensaje {  get; set; }
        [BindProperty]
        public int n { get; set; }
        [BindProperty]
        public string accion { get; set; }
        public string resultado1 { get; set; }
        public string resultado2 { get; set; }
        public void OnPost()
        {
            int num = Convert.ToInt32(n);
            if (accion == "Cifrar")
            {
                resultado1 = Cifrar(mensaje, num);
            }
            else if (accion == "Descifrar")
            {
                resultado2 = Descifrar(mensaje, num);
            }
            Console.WriteLine("Mensaje: " + mensaje);
            Console.WriteLine("N: " + n);
            Console.WriteLine("Accion: " + accion);
            Console.WriteLine("Resultado: " + resultado1);
        }

        public void OnGet()
        {
        }
    }
}
