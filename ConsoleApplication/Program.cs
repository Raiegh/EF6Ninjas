﻿using NinjaDomain.DataModel;
using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert Single Item");
            Repository.InsertClan();
            Console.WriteLine("Press Any Key to Continue");
            Console.ReadLine();

            Console.WriteLine("Insert Multiple Items");
            Repository.InsertMultipleNinjas();
            Console.ReadLine();

            Console.WriteLine("Run Simple Query");
            Repository.SimpleNinjaQueries();
            Console.ReadLine();

            Console.WriteLine("Run Query and Update");
            Repository.QueryAndUpdateNinja();
            Console.ReadLine();

            Console.WriteLine("Run Query and Update In Disconnect Mode");
            Repository.QueryAndUpdateNinjaDisconnected();
            Console.ReadLine();

            Console.WriteLine("Run Retrieve Data With Find");
            Repository.RetrieveDataWithFind();
            Console.ReadLine();

            Console.WriteLine("Run Retrieve Data With Stored Procedure");
            Repository.RetrieveDataWithStoredProc();
            Console.ReadLine();

            Console.WriteLine("Run Delete");
            Repository.DeleteNinja();

            Console.WriteLine("Press Any Key to Exit");
            Console.ReadLine();
        }
    }
}
