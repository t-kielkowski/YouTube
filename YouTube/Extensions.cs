using System;

namespace YouTube
{
    public static class Extensions
    {
        public static string View(this Channel channel)
        {
            return
                $"Nazwał kanału {channel.Name}, {nameof(channel.Id)}: {channel.Id}, liczba wyświetleń {channel.ViewCounter}, liczba subskrypcji {channel.NumberOfSubscriptions}";
        }
     
        
    }
}