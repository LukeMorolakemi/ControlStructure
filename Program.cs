namespace ControlStructure;
public class ControlStructure
{ 
    public static void Main(string[] args)
    {
        //Control structure

        // For Loop
        Console.WriteLine("For Loop:");
        for (int z = 0; z < 30; z++)
        {
            Console.WriteLine(z);
        }

        // While Loop
        Console.WriteLine("\nWhile Loop:");
        int j = 0;
        while (j < 10)
        {
            Console.WriteLine(j);
            j++;
        }

        // Do-While Loop
        Console.WriteLine("\nDo-While Loop:");
        int k = 0;
        do
        {
            Console.WriteLine(k);
            k++;
        } while (k < 6);

        // Foreach Loop
        Console.WriteLine("\nForeach Loop:");
        int[] age = { 47, 69, 73, 74, 65 };
        foreach (int num in age)
        {
            Console.WriteLine(num);
        }


        // If Statement
        Console.WriteLine("\nIf Statement:");
        int number = 90;
        if (number % 2 == 0)
        {
            Console.WriteLine("The number is even.");
        }
        else
        {
            Console.WriteLine("The number is odd.");
        }


        // Switch Statement
        Console.WriteLine("\nSwitch Statement:");
        char grade = 'B';
        switch (grade)
        {
            case 'A':
                Console.WriteLine("Excellent!");
                break;
            case 'B':
                Console.WriteLine("Good job!");
                break;
            case 'C':
                Console.WriteLine("Satisfactory.");
                break;
            default:
                Console.WriteLine("Need improvement.");
                break;
        }

    }
}