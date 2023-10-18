
Carta carta1 = new Carta("Reina","Corazones", 12);

carta1.Print();

Mazo mazo1 = new Mazo();


foreach (var carta in mazo1.Cartas)
{
    carta.Print();
}
Console.WriteLine($"Total de cartas: {mazo1.Cartas.Count}");

mazo1.Barajar();

foreach (var carta in mazo1.Cartas)
{
    carta.Print();
}
mazo1.Reparto();

Console.WriteLine($"Total de cartas: {mazo1.Cartas.Count}");


Jugador jugador1 = new Jugador("Carlos");

Console.WriteLine(jugador1._Nombre);

jugador1.Tomar(mazo1);
jugador1.Tomar(mazo1);
jugador1.Tomar(mazo1);

Console.WriteLine($"Total de cartas: {mazo1.Cartas.Count}");
