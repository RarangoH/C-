﻿namespace StarWarsApiAssignment.UserInteraction
{
    public class ConsoleUserInteractor : IUserInteractor
    {
        public string? ReadFromUser()
        {
            return Console.ReadLine();
        }

        public void ShowMessage(string message)
        {
            Console.Write(message);
        }
        public void PrintTable<T>(IEnumerable<T> items)
        {
            TablePrinter.Print(items);
        }
    }
}
