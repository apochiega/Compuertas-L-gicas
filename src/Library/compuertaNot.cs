namespace Library;
public class compuertaNot : compuertas
{
    public compuertaNot(string nombre) : base(nombre)
    {  
    }
    public int ValorFinal()
    {
        int valor = 0;
        foreach (var i in Entradas)
        {   
            if (i.Value == 1)
            {
                valor = 0;
            }
            else if (i.Value == 0)
            {
                valor = 1;
            }
        }
        return valor;
    }
}