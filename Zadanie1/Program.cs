List<Product> products = new List<Product>();

while (true)
{
    Console.WriteLine("Akcje:");
    Console.WriteLine("- 1: Dodaj produkt");
    Console.WriteLine("- 2: Usun produkt");
    Console.WriteLine("- 3: Wyswietl listę produktów");
    Console.WriteLine("- 4: Aktualizuj produkt");
    Console.WriteLine("- 5: Oblicz wartość magazynu");
    Console.WriteLine("- 6: Wyjdź");
    Console.Write("Wybierz liczbę: ");
    int liczba = int.Parse(Console.ReadLine());

    switch (liczba)
    {
        case 1:
            Console.Write("Podaj nazwe produktu do dodania: ");
            string nazwa = Console.ReadLine();

            Console.Write("Podaj ilość produktu: ");
            int ilosc = int.Parse(Console.ReadLine());

            Console.Write("Podaj cenę produktu: ");
            double cena = double.Parse(Console.ReadLine());

            products.Add(new Product(nazwa, ilosc, cena));

            Console.WriteLine("Naciśnij cokolwiek, aby kontynuuować");
            Console.ReadKey();
            Console.Clear();
            break;
        case 2:
            Console.Write("Podaj nazwe produktu do usunięcia: ");
            string nazwaUsun = Console.ReadLine();

            Product productDoUsuniecia = products.FirstOrDefault(x => x.Nazwa == nazwaUsun);
            if (productDoUsuniecia != null)
            {
                products.Remove(productDoUsuniecia);
            }
            else
            {
                Console.WriteLine("Produkt nie istnieje");
            }

            Console.WriteLine("Naciśnij cokolwiek, aby kontynuuować");
            Console.ReadKey();
            Console.Clear();
            break;
        case 3:
            if (products.Count == 0)
            {
                Console.WriteLine("Brak produktów");
            }

            foreach (var product in products)
            {
                Console.WriteLine($"Nazwa: {product.Nazwa}, Ilość: {product.Ilosc}, Cena: {product.Cena}");
            }

            Console.WriteLine("Naciśnij cokolwiek, aby kontynuuować");
            Console.ReadKey();
            Console.Clear();
            break;
        case 4:
            Console.Write("Podaj nazwe produktu do aktualizacji: ");
            string nazwaDoAktualizacji = Console.ReadLine();

            Product productDoAktualizacji = products.FirstOrDefault(x => x.Nazwa == nazwaDoAktualizacji);
            if (productDoAktualizacji != null)
            {
                Console.WriteLine("Co chcesz zaktualizowac?");
                Console.WriteLine("1: Ilość");
                Console.WriteLine("2: Cena");
                Console.WriteLine("3: Ilość i Cena");
                int wybor = int.Parse(Console.ReadLine());

                switch (wybor)
                {
                    case 1:
                        Console.Write("Podaj nową ilość produktu: ");
                        int iloscAktualizacja = int.Parse(Console.ReadLine());

                        productDoAktualizacji.Ilosc = iloscAktualizacja;
                        break;
                    case 2:
                        Console.Write("Podaj nową cenę produktu: ");
                        double cenaAktualizacja = double.Parse(Console.ReadLine());

                        productDoAktualizacji.Cena = cenaAktualizacja;
                        break;
                    case 3:
                        Console.Write("Podaj nową ilość produktu: ");
                        int iloscAktualizacjaPodwojna = int.Parse(Console.ReadLine());

                        productDoAktualizacji.Ilosc = iloscAktualizacjaPodwojna;

                        Console.Write("Podaj nową cenę produktu: ");
                        double cenaAktualizacjaPodwojna = double.Parse(Console.ReadLine());

                        productDoAktualizacji.Cena = cenaAktualizacjaPodwojna;
                        break;
                }
            }
            else
            {
                Console.WriteLine("Produkt nie istnieje");
            }

            Console.WriteLine("Naciśnij cokolwiek, aby kontynuuować");
            Console.ReadKey();
            Console.Clear();
            break;
        case 5:
            double suma = 0;
            foreach (var product in products)
            {
                suma += product.Ilosc * product.Cena;
            }
            Console.WriteLine("Suma: " + suma);

            Console.WriteLine("Naciśnij cokolwiek, aby kontynuuować");
            Console.ReadKey();
            Console.Clear();
            break;
        case 6:
            return;
    }
}