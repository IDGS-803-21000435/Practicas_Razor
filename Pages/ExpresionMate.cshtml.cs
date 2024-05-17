using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Ejercicios_Razor.Pages
{
    public class ExpresionMateModel : PageModel
    {
        [BindProperty]
        public double a { get; set; }
        [BindProperty]
        public double b { get; set; }
        [BindProperty]
        public double x { get; set; }
        [BindProperty]
        public double y { get; set; }
        [BindProperty]
        public double n { get; set; }
        public double resultado1 { get; set; }
        public string resultado2 { get; set; }

        public static double CalcularFactorial(double n)
        {
            double resultado = 1;
            for (int i = 1; i <= n; i++)
            {
                resultado *= i;
            }
            return resultado;
        }
        public static double CalcularCoeficienteBinomial(double n, double k)
        {
            // n! / (k! * (n - k)!)
            double factorialN = CalcularFactorial(n);
            double factorialK = CalcularFactorial(k);
            double factorialNmenosK = CalcularFactorial(n - k);

            return factorialN / (factorialK * factorialNmenosK);
        }
        public void OnPost()
        {
            double num1 = 0;
            double num2 = 0;
            double num3 = 0;
            double resultAux = 0;
            for (int k = 0; k <= n; k++)
            {
                double aux = Convert.ToDouble(k);
                num1 = CalcularCoeficienteBinomial(n, aux);

                num2 = Math.Pow(a * x, n-k);

                num3 = Math.Pow(b * y, k);

                resultAux += num1 * num2 * num3;
                resultado2 += $"<p>k = {k} -> {resultAux}</p><br />";
            }

            double aux2 = (a * x) + (b * y);
            resultado1 = Math.Pow(aux2, 2);
        }
    }
}
