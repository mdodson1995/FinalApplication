using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using System.Xml.Serialization;
using System.Xml;


namespace Bowling
{
    public enum BowlingOptions
    {
        AddPlayer,
        RemovePlayer,
        UpdatePlayer,
        ViewList
    }
    class Program
    {
        private static List<BowlingPlayer> _productList;

        static void Main(string[] args)

        {

            StringBuilder bowlingList = new StringBuilder();
            _productList = new List<BowlingPlayer>();
            _productList.Add(new BowlingPlayer { Name = "Mathew", Average = 123 });
            Menu();
            
        }



    private static void InstantiateBowlingList()
        {
            List<BowlingPlayer> _productList = new List<BowlingPlayer>();
            _productList.Add(new BowlingPlayer { Name = "Mathew", Average = 123 });
    }
        private static void Menu()
        {
        
            Console.WriteLine();
            Console.WriteLine("Welcome to the bowling manager.");
            Console.WriteLine("1. View List");
            Console.WriteLine("2. Add Player");
            Console.WriteLine("3. Remove Player.");
            Console.WriteLine("4. Update Player.");
            Console.WriteLine("5. Exit.");
            Console.WriteLine("Please select an option to continue.");
            var option = Console.ReadLine();
            if (option == "1")
            {
                ViewPlayer();
            }
            if (option == "2")
            {
                AddPlayer();
            }
            if (option == "3")
            {
                
                RemovePlayer();
            }
            if (option == "4")
            {
                UpdatePlayer();
            }
            if (option == "5")
            {
                ClosingScreen();
            }
        }
        public static void ClosingScreen()
        {
            Console.WriteLine();
            Console.WriteLine("Goodbye.");
            Environment.Exit(25);
        }
        public static void WriteToHistory(string dataFile)
        {
            {
                try
                {
                    //
                    // initialize a StreamWriter object for writing to a file
                    //
                    StreamWriter sWriter = new StreamWriter(dataFile, true);

                    //
                    // read all data from the data file
                    //
                    using (sWriter)
                    {
                        sWriter.WriteLine(_productList);
                    }
                }
                //
                // an I/O error was encountered
                //
                catch (Exception)
                {
                    throw;
                }
            }
        }
        public  static void AddPlayer()
        {
            Console.Clear();
            string path = "data\\PlayerData.csv";
            Console.WriteLine("Enter Name: ");
            var name = Console.ReadLine();
            Console.WriteLine("Enter Game Average: ");
            var average = Console.ReadLine();
            int realnumber;
            realnumber = int.Parse(average);

                _productList.Add(new BowlingPlayer(name, realnumber));
                Console.WriteLine("Added to List.");
                StringBuilder bowlingList = new StringBuilder();
                bowlingList.AppendLine(name);
                bowlingList.AppendLine(average);
                File.AppendAllText(path, bowlingList.ToString());
                Console.WriteLine(bowlingList);
                Console.ReadLine();

            Console.WriteLine("Would you like to go back to menu? y or n");
            var option2 = Console.ReadLine();
                if (option2 == "y")
            {
                Menu();
            }
                else
            {
                ClosingScreen();
               
            }
  
        }
        public static void RemovePlayer()
        {
            
            Console.Clear();
            string path = "data\\PlayerData.csv";
            Console.WriteLine("Would you like to remove the file? y/n ");
            var userResponse = Console.ReadLine();
            try {
                if (userResponse == "y")
                {
                    File.Delete(path);
                    Console.WriteLine("File Removed.");
                    Console.WriteLine(_productList);
                    Console.ReadLine();
                }
               
            }
            catch (DirectoryNotFoundException)
            {
                var message = "file not found.";
                Console.WriteLine(message);
            }
            if (userResponse == "n")
            {

            }
            else
            {

            }
        }
        public static void ViewPlayer()
        {
            Console.Clear();
            Console.WriteLine("View Player");
            Console.WriteLine();
            foreach (var bowlingList in _productList)
            {
                //
                // note use of C# 6.0 string interpolation
                //
                Console.WriteLine($"{bowlingList.Name} - {bowlingList.Average}");
                Console.WriteLine();
                Console.ReadLine();
            }
        }
        private static void UpdatePlayer()
        {

        }
        private static void XMLReader()
        {

        }
    }

}
