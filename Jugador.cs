class Jugador
{
    private string Nombre;
    private List<Carta> mano;
    public Jugador(string nombre)
    {
        Nombre = nombre;
        mano = new List<Carta>();
    }

    public string _Nombre
    {
        get { return Nombre; }
    }

    public Carta Tomar(Mazo carta)
    {
        Carta cartaTomada = carta.Reparto();
        mano.Add(cartaTomada);
        return cartaTomada;
    }
}