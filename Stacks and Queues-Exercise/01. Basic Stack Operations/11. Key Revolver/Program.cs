using System;
using System.Linq;
using System.Collections.Generic;
namespace _11._Key_Revolver
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int priceBullet=int.Parse(Console.ReadLine());
           int sizeGunBullet=int.Parse(Console.ReadLine());
            int[] arrayOfBullets = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();
            int[]arrayOfLocks=Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int valueOfIntelligence=int.Parse(Console.ReadLine());
            Stack<int> bullets = new Stack<int>();
            Queue<int>locks=new Queue<int>();
            PutBulletsAndLocks(arrayOfBullets,arrayOfLocks,bullets,locks);
            int money = 0;
            int count = 0;
            while (bullets.Count!=0 && locks.Count!=0)
            {
                int currentBullet = bullets.Peek();
                int currentLock=locks.Peek();
                if (currentBullet <= currentLock)
                {
                    bullets.Pop();
                    locks.Dequeue();
                    Console.WriteLine("Bang!");
                    ++count;
                    money += priceBullet;
                }
                else
                {
                    bullets.Pop();
                    Console.WriteLine("Ping!");
                    money += priceBullet;
                    ++count;
                }
                if (count == sizeGunBullet && bullets.Count>0)
                {
                    Console.WriteLine("Reloading!");
                    count = 0;
                }
            }
            if(locks.Count==0) 
            {
                Console.WriteLine($"{bullets.Count} bullets left. Earned " +
                    $"${Math.Abs(valueOfIntelligence-money)}");
            }
            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }

        }
        static void PutBulletsAndLocks(int[] arrayOfBullets, int[] arrayOfLocks,
            Stack<int> bullets, Queue<int> locks)
        {
            foreach (int currentBullet in arrayOfBullets)
            {
                bullets.Push(currentBullet);
            }
            foreach (int currentLock in arrayOfLocks)
            {
                locks.Enqueue(currentLock);
            }
        }
    }
}