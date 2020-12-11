using System;

namespace Polimorfismo_Sobrecarga_Metodo_POO.classes
{
    public class Funcionario
    {
        public string[] lista = {"Paulo", "Tsuka", "Priscila", "Fernanda"};


        public void Mostrar(){
            foreach (var item in lista)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(item);
                Console.ResetColor();
            }
        }

        public void Mostrar(int indice){
            Console.ForegroundColor = ConsoleColor.Blue;
            if (indice <= lista.Length)
            {
                Console.WriteLine(lista[indice]);
            }
            Console.ResetColor();
        }


        public void Mostrar(string busca){
        foreach (var item in lista)
            {
                
                if (item == busca)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"Resultados da Busca: {item}");
                    Console.ResetColor();
                }
                
            }
        }
    }
}