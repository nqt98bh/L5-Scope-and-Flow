
using System;

class Lesson5
{
   static void Part1()
    {
        int input1 = int.Parse(Console.ReadLine());
        int input2 = int.Parse(Console.ReadLine());
       
            if (input1 == input2)
            {
                Console.WriteLine("two inputs is equal");
            }
        else
        {
            Console.WriteLine("two inputs is not equal");
        }

    }
   
    static void Part2()
    {
        int input1 = int.Parse(Console.ReadLine());
        int input2 = int.Parse(Console.ReadLine());

        if (input1 > input2)
        {
            Console.WriteLine($"{input1} is greater than {input2}");
        }
        else
        {
            Console.WriteLine($"{input2} is less than {input1}");
        }
    }

    static void Part3()
    {
        int input1 = int.Parse(Console.ReadLine());
        int input2 = int.Parse(Console.ReadLine());

        if (input1 < input2)
        {
            Console.WriteLine($"{input1} is less than {input2}");
        }
        else
        {
            Console.WriteLine($"{input2} is greater than {input1}");
        }
    }

    static void Part4()
    {
        int input1 = int.Parse(Console.ReadLine());
        int input2 = int.Parse(Console.ReadLine());

        if (input1 != input2)
        {
            Console.WriteLine($"{input1} is not equal {input2}");
        }
        else
        {
            Console.WriteLine($"{input2} is equal {input1}");
        }
    }

    static void Part5()
    {
        int input1 = int.Parse(Console.ReadLine());
        int input2 = int.Parse(Console.ReadLine());

        if (input1 >= input2 )
        {
            Console.WriteLine($"{input1} is greater than or equal {input2}");
        }
      
    }

    static void Part6()
    {
        int input1 = int.Parse(Console.ReadLine());
        int input2 = int.Parse(Console.ReadLine());

        if (input1 <= input2)
        {
            Console.WriteLine($"{input1} is less than or equal {input2}");
        }
    }
    static void Part7()
    {
        int number1 = 10;
        int number2 = 3;
        int question = number1 * number2;
        int answered = int.Parse(Console.ReadLine());
        if(answered == question)
        {
            Console.WriteLine("the answer is correct");
        }
        else
        {
            Console.WriteLine("the answer is incorrect");
        }
    }
    static void Part8()
    {
        int oldEnoughToVote = 18;
        int userAge = int.Parse(Console.ReadLine());
        if (userAge >= oldEnoughToVote) 
        {
            Console.WriteLine("You can attend the vote");
        }
        else
        {
            Console.WriteLine("your age is not enough");
        }
    }
    static void Part9()
    {
        int enemyHealth = int.Parse(Console.ReadLine());
        if (enemyHealth == 100)
        {
            Console.WriteLine("Enemy has full health");
        }
        else if (enemyHealth  == 50)
        {
            Console.WriteLine("Enemy has half health");
        }
        else if(enemyHealth == 25)
        {
            Console.WriteLine("Enemy has quarter health");
        }
        else if (enemyHealth == 0)
        {
            Console.WriteLine("Enemy is dead");
        }
    }
    static void Part10()
    {
        int userAge = int.Parse(Console.ReadLine());
        if(userAge >= 18)
        {
            Console.WriteLine("User is eligible for a discount");
        }
        else
        {
            Console.WriteLine("User is not eligible for a discount");
        }
    }
    static void Part11()
    {
        for (int i = 1; i <= 20; i++)
        {
            if (i == 5)
            {
                continue;
            }
            Console.WriteLine(i);
        }
    }
    static void Part12()
    {
        for (int i = 1; i <= 10; i++)
        {
            if (i == 7)
            {
                break;
            }
            Console.WriteLine(i);
        }
    }
    static void Part13()
    {
        for (int i = 1; i <= 20; i++)
        {
            if (i % 2 == 0)
            {
               
                if (i == 10)
                {
                    continue;  
                }
                Console.WriteLine(i);
            }
        }
    }
    static void Part14()
    {
        List<string> fruits  = new List<string>() { "apple", "orange", "pine" };
        foreach (var fruit in fruits)
        {
            if(fruit == "apple")
            {
                Console.WriteLine("Aplle found");
                break;
            }
            else
            {
                continue;
            }
        }
    }
    static void Part15()
    {
        for(int i = 1;i <= 100; i++)
        {
            if(i % 10 ==0)
            {
                continue ;
            }
            Console.WriteLine(i);
        }
    }
    static void Part16()
    {
        for(char letter = 'A'; letter <= 'G';  letter++)
        {
            if(letter == 'E')
            {
                continue;
            }
            Console.WriteLine(letter);  
        }
    }
    static void Part17()
    {
        for (int num = 1; num <= 50; num++)
        {
                bool isPrime = true;

                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break; 
                    }
                }
                if (isPrime)
                {
                Console.WriteLine(num);
                }
        }
    }
    static void Part18()
    {
        for( int i = 1; i <=10; i++)
        {
            if (i == 3)
            {
                continue;
            }
            Console.WriteLine(i);

        }
    }
    static void Part19()
    {
        int[] numbers = { 5, 12, 8, 20, 34, 56, 19, 20, 99 };

        for (int i = 0; i < numbers.Length; i++)
        {
            if(numbers[i] == 20)
            {
                Console.WriteLine($" the index of 20 is {i}");
                break;
            }
            else
            {
                continue;
            }
        }
    }
    static void Part20()
    {
        List<string> fruits = new List<string> { "apple", "banana", "mango" };
        foreach (var fruit in fruits)
        {
            if(fruit == "banana")
            {
                continue;
            }
            Console.WriteLine(fruit);
        }
    }
    static void Part21()
    {
        float MonthlySale = int.Parse(Console.ReadLine());
        float commission;
        if (MonthlySale >= 10000)
        {
            commission = MonthlySale * 10 / 100;
            Console.WriteLine($"the commission is {commission}");
        }
        else
        {
            commission = MonthlySale * 0.05f;
            Console.WriteLine($"the commission is {commission:F2}");
        }
    }

    static void Part22()
    {
        Random random = new Random();
        int num1 = random.Next(0, 100);
        int num2 = random.Next(0, 100);
        Console.WriteLine($"Enter the sum of {num1} and {num2} : ");
        int sum = num1 + num2;
        int userAnswer = int.Parse(Console.ReadLine());
        if (userAnswer == sum)
        {
            Console.WriteLine("Correct!");
        }
        else
        {
            Console.WriteLine($"Incorrect!, it is {sum}");
        }

    }
    static void Part23()
    {
        int studentMark = int.Parse(Console.ReadLine());

        int[] marks = new int[] { 85, 80, 75, 70, 65, 60, 55, 50, 0 };
        string[] Grade = new string[] { "A+", "A", "B+", "B", "C+", "C", "D+", "D", "F" };

        for (int i = 0; i < marks.Length; i++)
        {
            if (studentMark >= marks[i])
            {
                Console.WriteLine($"Grade :{Grade[i]}");
                if (marks[i] >= 85)
                {
                    Console.WriteLine("Comment : Excellent !");
                    break;
                }
                else if (marks[i] >= 80 && marks[i] < 85)
                {
                    Console.WriteLine("Comment : Well done.");
                    break;
                }
                else if (marks[i] < 50)
                {

                    Console.WriteLine("Comment : See me.");
                    break;
                }
                else
                {
                    break;
                }
            }

        }
    }

    static void Part24()
    {
        Console.WriteLine("Enter sees_player (true/false):");
        bool sees_player = bool.Parse(Console.ReadLine());

        if (sees_player)
        {
            Console.WriteLine("Enter the distance:");
            int dis_from_player = int.Parse(Console.ReadLine());
            if (dis_from_player <= 1)
            {
                Console.WriteLine("Attack!");
            }
            else if (dis_from_player <= 4 && dis_from_player >= 2)
            {
                Console.WriteLine("the guard will advance");
            }
            else if (dis_from_player >= 5)
            {
                Console.WriteLine("Wait!");
            }
        }
        else
        {
            Console.WriteLine("Wait!");
        }
    }
    public static void Main()
    {
        //Part1();
        //Part2();
        //Part3();
        //Part4();
        //Part5();
        //Part6();
        //Part7();
        //Part8();
        //Part9();
        //Part10();
        //Part11();
        //Part12();
        //Part13();
        //Part14();
        //Part15();
        //Part16();
        //Part17();
        //Part18();
        //Part19();
        Part20();
        Part21();
        Part22();
        Part23();
        Part24();
    }
}