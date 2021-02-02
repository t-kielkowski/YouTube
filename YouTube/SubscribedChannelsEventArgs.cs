using System;

namespace YouTube
{
    public class SubscribedChannelsEventArgs : EventArgs
    {
        public string UserName { get; set; }
        public int Id { get; set; }
    }
}