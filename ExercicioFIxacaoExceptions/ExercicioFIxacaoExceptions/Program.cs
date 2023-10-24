using ExercicioFIxacaoExceptions.Entities;
using ExercicioFIxacaoExceptions.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ExercicioFIxacaoExceptions
{
    public class Program
    {
        public static void Main(string[] args)
        {
			try
			{
                Console.WriteLine("Enter account data:");
                Console.Write("Number: "); int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: "); string holder = Console.ReadLine();
                Console.Write("Initial balance: $"); double balance = double.Parse(Console.ReadLine());
                Console.Write("Withdraw limit: $"); double wl = double.Parse(Console.ReadLine());
                Account account = new Account(number, holder, balance, wl);

                Console.Write("Enter amount for withdraw: $"); account.Withdraw(double.Parse(Console.ReadLine()));
                Console.WriteLine($"New balance: ${account.Balance.ToString("F2")}");
            }
            catch(AccountException e)
            {
                Console.WriteLine(e.Message);
            }
			catch (Exception e)
			{
                Console.WriteLine($"An error has been caught: {e.Message}");
            }

        }
    }
}
