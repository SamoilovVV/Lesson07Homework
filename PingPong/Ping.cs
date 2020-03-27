using System;
using System.Collections.Generic;
using System.Text;

namespace PingPong
{
    class Ping
    {
        public EventHandler FirePing;
        public void Play()
        {
            FirePing?.Invoke(this, EventArgs.Empty);            
        }

        public void OnGameMove(object sender, EventArgs e)
        {
            Console.WriteLine("Ping recieved Pong");

            Random rnd = new Random();
            int magicNumber = rnd.Next(0, 10);
            if (magicNumber > 2)
            {
                Play();
            }
            else
            {
                Console.WriteLine($"Ping failed! {sender?.GetType().Name} wins!");
            }
            
        }
    }
}
