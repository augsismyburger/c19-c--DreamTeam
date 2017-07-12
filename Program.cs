using System;
using System.Collections.Generic;
using System.Linq;

namespace c19_DreamTeam
{
    public interface IclassMate
    {
        string specialty { get; set; }
        string fName { get; set; }
        string lName { get; set; }
        string fullName { get; }
        void work();
    }

    public class AndyPants : IclassMate
    {
        public string specialty { get; set; } = "Managing";
        public string fName { get; set; } = "Andy";
        public string lName { get; set; } = "Rock";

        public string fullName {get => $"{fName} {lName}";}

        public void work()
        {
            Console.WriteLine("Andy be telling people what to do.");
        }
    }

    public class Eliza : IclassMate
    {
        public string specialty { get; set; } = "Knocking shit out";
        public string fName { get; set; } = "Eliza";
        public string lName { get; set; } = "Meeks";

        public string fullName {get => $"{fName} {lName}";}

        public void work()
        {
            Console.WriteLine("Eliza be in the zone.");
        }
    }

    public class Jordan : IclassMate
    {
        public string specialty { get; set; } = "Theoretical Analysis";
        public string fName { get; set; } = "Jordan";
        public string lName { get; set; } = "Dhaenens";

        public string fullName {get => $"{fName} {lName}";}

        public void work()
        {
            Console.WriteLine("Jordan is diggin into some documentaion.");
        }
    }

    public class Chazzer : IclassMate
    {
        public string specialty { get; set; } = "Coding super fast";
        public string fName { get; set; } = "Chaz";
        public string lName { get; set; } = "Rock";

        public string fullName {get => $"{fName} {lName}";}

        public void work()
        {
            Console.WriteLine("Chaz is coding..");
        }
    }

    public class Json : IclassMate
    {
        public string specialty { get; set; } = "Being the \"best\" at everything especailly basketball";
        public string fName { get; set; } = "Jason";
        public string lName { get; set; } = "Smith";

        public string fullName {get => $"{fName} {lName}";}

        public void work()
        {
            Console.WriteLine("Being the \"best\" at everything especailly basketball");
        }
    }
    public class Adam : IclassMate
    {
        public string specialty { get; set; } = "Keeping it cool and stylish";
        public string fName { get; set; } = "Adam";
        public string lName { get; set; } = "Riedelbach";

        public string fullName {get => $"{fName} {lName}";}

        public void work()
        {
            Console.WriteLine("Adam's making everything look soo easy.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AndyPants IncognitoAndy = new AndyPants()
            {
                fName = "Totally not Andy"
            };
            List<IclassMate> clientSide = new List<IclassMate>()
            {
                new Eliza(),
                IncognitoAndy,
                new Chazzer()
            };

            List<IclassMate> serverSide = new List<IclassMate>()
            {
                new Json(),
                new Jordan(),
                new Adam()
            };

            foreach(IclassMate mate in clientSide) 
            {
                mate.work();
                Console.WriteLine(mate.fullName);
            }

            foreach(IclassMate mate in serverSide) 
            {
                mate.work();
            }
        }
    }
}
