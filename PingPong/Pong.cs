using System;
using System.Collections.Generic;
using System.Text;

namespace PingPong
{
    class Pong
    {
        public event EventHandler FirePong;

        public void Play()
        {
            FirePong?.Invoke(this, EventArgs.Empty);
        }

        public void OnGameMove(object sender, EventArgs e)
        {
            Console.WriteLine("Pong recieved Ping");

            Random rnd = new Random();
            int magicNumber = rnd.Next(0, 20);
            if (magicNumber > 3)
            {
                Play();
            }
            else
            {
                Console.WriteLine($"Pong failed! {sender?.GetType().Name} wins!");
            }
        }
    }
}
