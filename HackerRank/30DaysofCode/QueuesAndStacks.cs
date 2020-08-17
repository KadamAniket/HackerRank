using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank._30DaysofCode
{
    public class QueuesAndStacks
    {
        char[] stack;
        char[] queue;

        int top = -1, back = -1, front = -1;

        public void pushCharacter(char c)
        {
            top++;
            stack[top] = c;
        }

        public void enqueueCharacter(char c)
        {
            back++;
            queue[back] = c;
        }

        public char popCharacter()
        {
            char returnValue = stack[top];
            top--;
            return returnValue;
        }

        public char dequeueCharacter()
        {
            front++;
            return queue[front];
        }

        public void calculate()
        {
            string str = "racecar";
            stack = new char[str.Length];
            queue = new char[str.Length];
            foreach (char c in str)
            {
                pushCharacter(c);
                enqueueCharacter(c);
            }

            while (top >= 0 && front < back)
            {
                // Console.WriteLine(popCharacter());
                Console.WriteLine(dequeueCharacter());

            }
        }

    }
}
