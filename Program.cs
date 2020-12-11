using System;
using Polimorfismo_Sobrecarga_Metodo_POO.classes;

namespace Polimorfismo_Sobrecarga_Metodo_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instaciamento da classe 
            Funcionario fun = new Funcionario();
            fun.Mostrar();
            fun.Mostrar(2);
            fun.Mostrar("Tsuka");

            Console.Beep();
        }
    }
}
