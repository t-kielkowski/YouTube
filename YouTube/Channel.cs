// Stwórz aplikację inspirowaną działaniem YouTube. Stwórz klasy Użytkownik i Kanał. Do obu klas dodaj pola Nazwa i Id. Do klasy Kanał dodaj pole LicznikWyswietlen, metodę WyswietlFilm(int id), metodę OpublikujFilm i event OpublikowanoFilm. Metoda WyświetlFilm powinna zwiększać ilość wyświetleń o 1.
// Metoda OpublikujFilm powinna publikować event. Do klasy Użytkownik dodaj metodę SubskrybujKanał, która jako parametr przyjmie obiekt typu Kanał. Metoda da powinna podpiąć Event Handler Użytkownika pod Event Kanału. W event handlerze wypisz krótkie potwierdzenie, np. "użytkownik X otrzymał powiadomienie o nowym filmie". Stwórz kolekcję użytkowników i 1 Kanał. Niech wszyscy użytkownicy subskrybują ten kanał. Dodaj także ExtensionMethod dla typu Kanał, która wypisze na konsolę nazwę kanału, jego ilość subskrypcji i wyświetleń. Wywołaj Extension Method.
//     Możesz dowolnie dostosować parametry metod, które nie zostały sprecyzowane, a także dowolnie zaimplementować klasę EventArgs eventu OpublikowanoFilm w taki sposób, aby uzyskać opisany efekt.


using System;

namespace YouTube
{
    public class Channel
    {
        public string Name;
        public int Id;
        public int ViewCounter;
        public int NumberOfSubscriptions = 0;
        public event EventHandler<ReleasedFilmEventArgs> ReleasedFilm;

        public Channel(string name, int id)
        {
            Name = name;
            Id = id;
            ViewCounter = 0;
        }

        public void ViewMovie(int Id)
        {
            ViewCounter++;
        }

        public void PublishMovie()
        {
            OnReleasedFilm(new ReleasedFilmEventArgs());
        }

        public void OnReleasedFilm(ReleasedFilmEventArgs e)
        {
            ReleasedFilm?.Invoke(this,
                new ReleasedFilmEventArgs()
                {
                    _Name = Name, _Id = Id, _ViewCounter = ViewCounter, _NumberOfSubscriptions = NumberOfSubscriptions
                });
        }
    }
}