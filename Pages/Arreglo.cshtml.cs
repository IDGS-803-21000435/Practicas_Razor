using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Ejercicios_Razor.Pages
{
    public class ArregloModel : PageModel
    {
        public List<int> RandomNumbers { get;  set; }
        public int Sum { get;  set; }
        public double media { get;  set; }
        public List<int> moda { get; set; }
        public double mediana { get; set; }

        public void GenerarRandom()
        {
            Random rand = new Random();
            RandomNumbers = new List<int>();

            for (int i = 0; i < 20; i++)
            {
                RandomNumbers.Add(rand.Next(0, 101)); // Genera números del 0 al 100
            }
        }

        public double GetMedian(List<int> numbers)
        {
            numbers.Sort();
            int count = numbers.Count;
            if (count % 2 == 0)
            {
                return (numbers[count / 2 - 1] + numbers[count / 2]) / 2.0;
            }
            else
            {
                return numbers[count / 2];
            }
        }
        public void CalcularEtadisticas()
        {
            Sum = RandomNumbers.Sum();
            media = RandomNumbers.Average();
            moda = RandomNumbers.GroupBy(n => n).OrderByDescending(g => g.Count()).First().ToList();
            mediana = GetMedian(RandomNumbers);
        }
        public void OnGet()
        {
            GenerarRandom();
            CalcularEtadisticas();
        }
    }
}
