using System;

namespace YouTube
{
    public class User
    {
        public string Name;
        public int Id;
        public event EventHandler<SubscribedChannelsEventArgs> SubscribedChannels;

        public User(string name, int id)
        {
            Name = name;
            Id = id;
        }

        public void SubscribeChannel(Channel channel)
        {
            SubscribedChannels.Invoke(this, new SubscribedChannelsEventArgs() {UserName = this.Name, Id = this.Id});
        }
    }
}