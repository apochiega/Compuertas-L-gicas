namespace Library;
public class compuertaOr : compuertas
{
    public compuertaOr(string nombre) : base(nombre)
    { 
    }
    
    public int ValorFinal()
    {
        int valorFinal = 0;
        foreach (var element in Entradas)
        {   
            if (element.Value == 1)
            {
                valorFinal = 1;
            }
            
        }
        return 0;
    }
}