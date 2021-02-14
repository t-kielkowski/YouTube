using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace YouTube
{
    class Program
    {
        #region RandomString

        public static string RandomString()
        {
            var size = new Random();
            var chars = "abcdefghijklmnopqrstuwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();

            var randomString = new string(
                Enumerable.Repeat(chars, size.Next(4, 8))
                    .Select(x => x[random.Next(x.Length)])
                    .ToArray());
            return randomString;
        }

        #endregion

        static void Main(string[] args)
        {
            User[] Users = new User[10];
            var channel = new Channel("RS Elektronika", 7);
            
            for (int i = 0; i < Users.Length;  i++)
            {
                Users[i] = new User(RandomString(), i);
                Users[i].SubscribeChannel(channel);
            }
            
            channel.PublishMovie();
            channel.ViewMovie(5);
            channel.ViewMovie(5);

            Console.WriteLine();
            Console.WriteLine(channel.View());
            

        }
    }
}