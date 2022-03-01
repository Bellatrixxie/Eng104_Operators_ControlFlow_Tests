using System.Collections.Generic;

namespace Op_CtrlFlow
{
    public class Exercises
    {
        public static bool MyMethod(int num1, int num2)
        {
            return num1 != num2;
        }

        // returns the average of the array nums
        public static double Average(List<int> nums)
        {
            double accumulator = 0.0;
            for (int i = 0; i < nums.Count; i++)
            {
                accumulator += nums[i];
            }
            return accumulator / nums.Count;
        }

        // returns the type of ticket a customer is eligible for based on their age
        // "Standard" if they are between 18 and 59 inclusive
        // "OAP" if they are 60 or over
        // "Student" if they are 13-17 inclusive
        // "Child" if they are 5-12
        // "Free" if they are under 5
        public static string TicketType(int age)
        {
            string ticketType = string.Empty;

            _=age >= 60 ? ticketType = "OAP" :
            age >= 18 ? ticketType = "Standard" :
            age >= 13 ? ticketType = "Student" :
            age >= 5 ? ticketType = "Child" : ticketType = "Free";

            return ticketType;
        }

        public static string Grade(int mark)
        {
            var grade = "";

            if (mark > 100 || mark < 0)
            {
                grade = "Invalid input";
            }
            else if (mark >= 75)
            {
                grade = "Pass with Distinction";
            }
            else if (mark >= 60)
            {
                grade = "Pass with Merit";
            }
            else if (mark >= 40)
            {
                grade = "Pass";
            }
            else
            {
                grade = "Fail";
            }
            return grade;
        }

        public static int GetScottishMaxWeddingNumbers(int covidLevel)
        {
            int max = 0;

            switch(covidLevel)
            {
                case 4: max = 20;
                    break;
                case 3:
                case 2: max = 50;
                    break;
                case 1: max = 100;
                    break;
                case 0: max = 200;
                    break;
                default: throw new ScottishWeddingMaxException("Invalid input. Allowed covidLevels: 4, 3, 2, 1, 0");
                
            }
            return max;
        }
    }
}
