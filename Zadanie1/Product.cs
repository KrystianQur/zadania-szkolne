public class Product
{
    public string Nazwa { get; set; }
    public int Ilosc { get; set; }
    public double Cena { get; set; }

    public Product(string nazwa, int ilosc, double cena)
    {
        Nazwa = nazwa;
        Ilosc = ilosc;
        Cena = cena;
    }
}