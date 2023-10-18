class Mazo
{
    public List<Carta> Cartas= new List<Carta>();
    public List<string> Pinta = new List<string> { "Corazones", "Diamantes", "Treboles", "Picas" };

    public Mazo(){
        Reset();
    }

    public List<Carta> Reset()
    {
        Cartas.Clear();
        string nombre;
        foreach (var pinta in Pinta)
        {
            for (int i = 1; i <= 13; i++)
            {
                if(i == 1){
                    nombre = "AS";
                }else if(i == 11){
                    nombre = "Sota";
                }else if(i == 12){
                    nombre = "Reina";
                }else if(i == 13){
                    nombre = "Rey";
                }else{
                    nombre = i.ToString();
                }
                Cartas.Add(new Carta(nombre, pinta, i));
            }
            
        }
        return Cartas;
    }

    public Carta Reparto()
    {
        var carta = Cartas[Cartas.Count - 1];
        Cartas.RemoveAt(Cartas.Count - 1);
        return carta;
    }

    public void Barajar()
    {
        List<Carta> sinBarajar = Cartas;
        List<Carta> barajada = new List<Carta>();
        Random rand = new Random();
        while (sinBarajar.Count > 0)
        {
            int posicion = rand.Next(0, sinBarajar.Count);
            barajada.Add(sinBarajar[posicion]);
            sinBarajar.RemoveAt(posicion);

        }
        Cartas = barajada;
    }


}