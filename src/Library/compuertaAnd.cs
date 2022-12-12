namespace Library;
public class compuertaAnd : compuertas
{
    public compuertaAnd (string nombre) : base(nombre)
    {
    }
    public int ValorFinal()
    {
        int valor = 1;
        foreach (var i in Entradas)
        {
            valor = (valor * i.Value); 
        

        }
        return valor;
    }
}