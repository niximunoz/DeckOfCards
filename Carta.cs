class Carta
{
    public string Nombre;
    public string Pinta;
    public int Val;

    public Carta(string nombre, string pinta,int val){
        Nombre = nombre;
        Pinta = pinta;
        Val = val;
    }

    public void Print(){
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Pinta: {Pinta}");
        Console.WriteLine($"Valor: {Val}");
        Console.WriteLine("-------------");
    }

}