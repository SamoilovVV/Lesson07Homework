using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson07Homework
{
    class Counter
    {
        public delegate void MessageHandler(int stopCount);
        public event MessageHandler OnCount;
        public void Count(int cnt)
        {
            for (int i = 0; i < 100; i++)
            {
                if (i == cnt)
                {
                    OnCount?.Invoke(cnt);
                }
            }
        }

    }
}
