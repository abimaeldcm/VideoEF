using System;
using VideoEF;

public class Program
{
    public static void Main()
    {
        using(var baseDeDados = new MinhaDbContext())
        {
            var cliente = new Cliente { nome = "Milton" };
            baseDeDados.Clientes.Add(cliente);

            baseDeDados.Clientes.Add(new Cliente { nome = "Maria" });
            baseDeDados.Clientes.Add(new Cliente { nome = "Marcos" });
            baseDeDados.Clientes.Add(new Cliente { nome = "Pedro" });

            Console.WriteLine("Adição de nomes realizada com sucesso!");

            baseDeDados.SaveChanges();
        }

    }
    static void ConsultaClientes (MinhaDbContext context)
    {

    }
}