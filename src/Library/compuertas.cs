namespace Library;
public class compuertas

{
    public compuertas(string nombre)
    {
        this.Nombre = nombre;
        this.Entradas = new Dictionary<string, int>();
    }
    public string Nombre { get; set; }
    public Dictionary<string, int> Entradas { get; set; }
   
    public void AgregarEntrada(string nombre, int valor)
    {
        if (valor > 0)
        {
            valor = 1;
        }
        else 
        {
            valor = 0;
        }
        if (!Entradas.ContainsKey(nombre))
        {
            Entradas.Add(nombre, valor);
        }
        else 
        {
            Entradas[nombre] = valor;             
        }        
    }
}