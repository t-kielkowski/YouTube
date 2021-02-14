using System;
using System.Threading.Channels;

namespace YouTube
{
    public class User
    {
        public string Name;
        public int Id;

        public User(string name, int id)
        {
            Name = name;
            Id = id;
        }

        public void SubscribeChannel(Channel channel)
        {
            channel.ReleasedFilm += OnReleasedFilm;
            channel.ViewMovie(5);
            ++channel.NumberOfSubscriptions;
        }

        public void OnReleasedFilm(object? sender, ReleasedFilmEventArgs e)
        {
            Console.WriteLine(
                $"Użytkownik {Name} otrzymał powiadomienie o nowym filmie {e._Name}");
        }
    }
}