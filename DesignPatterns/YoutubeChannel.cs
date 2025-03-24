using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class YoutubeChannel
    {
        private List<IObserver> subscribers = new List<IObserver>();
        public void Subscribe(IObserver subsriber)
        {
            subscribers.Add(subsriber);
        }
        public void Notify(string message)
        {
            foreach (var sub in subscribers)
            {
                sub.Update(message);
            }
        }
    }
}
