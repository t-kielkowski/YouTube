using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace YouTube
{
   class Program
    {
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
        
        static void Main(string[] args)
        {
            User[] Users = new User[10];
            var Channel = new Channel("RS Elektronika", 7);

            for (int i = 0; i < Users.Length; i++)
            {
                Users[i] = new User(RandomString(), i);
                Users[i].SubscribedChannels += Channel.PublishMovie;
                Users[i].SubscribeChannel(Channel);
            }

            Console.WriteLine();
            Console.WriteLine(Channel.View());

        }
    }
}