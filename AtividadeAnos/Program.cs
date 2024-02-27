using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAnos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Informe sua idade em anos: ");
            int anos = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe quantos meses se passaram desde seu aniversario?: ");
            int meses = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe quantos dias se passaram desde seu aniversário?: ");
            int dias = int.Parse(Console.ReadLine());

            anos = anos * 365;
            meses = meses * 30;
            dias = anos + meses + dias;

            Console.WriteLine("Sua idade em dias é: " + dias);
            Console.ReadKey();

        
        }
    }
}
