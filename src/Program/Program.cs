using System;
using Library;
public class Program
{
    public static void Main(string[] args)
    {
        compuertaAnd and1 = new compuertaAnd("AND-1");
        and1.AgregarEntrada("A", 1);
        and1.AgregarEntrada("B", 1);

        compuertaOr or2 = new compuertaOr("OR-2");
        or2.AgregarEntrada("C", 0);
        or2.AgregarEntrada(and1.Nombre, and1.ValorFinal());

        compuertaNot not3 = new compuertaNot("NOT-3");
        not3.AgregarEntrada(or2.Nombre, or2.ValorFinal());
        
        Console.WriteLine(not3.ValorFinal());
    }
}