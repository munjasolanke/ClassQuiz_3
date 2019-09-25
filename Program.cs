using System;

namespace ClassQuiz_3
{
    public class Program
    {
        public string firstName;
        public string lastName;

        // static variables
        public static string salutationMr = "Mr";
        string getName()
        {
            return firstName + " " + lastName;
        }
        public Program()
        {
            firstName = "Munja";
            lastName = "Solanke";
        }
        public Program(string lname)
        {
            lastName = lname;
        }
        static void Main(string[] args)
        {
            Program Class2 = new Program();
        }

    }

}