
Carta carta1 = new Carta("Reina","Corazones", 12);

carta1.Print();

Mazo mazo1 = new Mazo();


foreach (var carta in mazo1.Cartas)
{
    carta.Print();
}
Console.WriteLine($"Total de cartas: {mazo1.Cartas.Count}");


mazo1.eliminarCarta();