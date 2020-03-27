using System;

namespace PingPong
{
    class Program
    {
        static void Main(string[] args)
        {
            Ping ping = new Ping();

            Pong pong = new Pong();

            ping.FirePing += pong.OnGameMove;
            pong.FirePong += ping.OnGameMove;

            ping.Play();

            Console.ReadLine();
        }


    }
}
