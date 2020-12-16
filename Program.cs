using System;
using System.Collections.Generic;

namespace Lista_de_Objetos_Cartao
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criamos a lista 
            List<Cartao> cartaos = new List<Cartao>();

            //adicionamos os produtos atraves de instancias com construtores
            cartaos.Add(new Cartao("Rafael", 378242354, "MasterCard", 2022, 175));
            cartaos.Add(new Cartao("Fernanda", 728306538, "Visa", 2025, 237));
            cartaos.Add(new Cartao("Ademorci", 632961846, "Visa", 2020, 761));
            cartaos.Add(new Cartao("Josefa", 820518365, "MasterCard", 2023, 907));

            //Usamos o foreach para exibir os cartoes instanciados
            foreach (Cartao item in cartaos)
            {
                Console.WriteLine($"Titular : {item.Titular}, Numero : {item.Numero}, Bandeira : {item.Bandeira}, Vencimento : {item.Vencimento}, Cvv : {item.Cvv}");
            }


        }//main
    }
}
