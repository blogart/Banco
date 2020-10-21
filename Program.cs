using System;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta_bancaria cuenta = new Cuenta_bancaria(3026789059131600, 34457, 5, "Manolo");
            
            Console.WriteLine(cuenta.status());
           
        }
    }
}
