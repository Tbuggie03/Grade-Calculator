namespace Grade_CalcHW
    
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studentName;
            // declaring and inizitalizing array of grades
            int[] grades = [100, 92, 87, 200, -20, 52, 82, 75, 67, 88];

            studentName = "Tommy";
            Console.WriteLine("Hello, " + studentName + "!");
            Console.WriteLine("Here are your grades:");

            // initial start for sum
            int sum = 0;
            // loop within grades

            for (int i = 0; i < grades.Length; i++)
            {
                // checks if grades show up in console
                //Console.WriteLine(grades[i]);

                int grade = grades[i];
                Console.WriteLine(grade);

                // add up the sum of the data
                sum += grade;


                if (grade >= 90 && grade <= 100)
                {
                    Console.WriteLine("This grade is an A!");

                    //nested if statement
                    if (grade == 100)
                    {
                        Console.WriteLine("WOW! A Perfect Score!");
                    }
                }
                else if (grade >= 80 && grade <= 89) {
                    Console.WriteLine("This grade is a B.");
                }
                else if (grade >= 70 && grade <= 79)
                {
                    Console.WriteLine("This grade is a C.");
                }
                else if (grade >= 65 && grade <= 69)
                {
                    Console.WriteLine("This grade is a D.");
                }
                else if (grade >= 0 && grade <= 64)
                {
                    Console.WriteLine("This grade is an F.");
                }
                else
                {
                    Console.WriteLine("This is out of the range of 0-100. How did you get this grade?!");
                }
            }


            // finds average of grades
            double average = (double)sum / grades.Length;

            Console.WriteLine("Your final calculated average is: " + average);
            Console.WriteLine("We have displayed all grades for " + studentName);
        }
    }
}
