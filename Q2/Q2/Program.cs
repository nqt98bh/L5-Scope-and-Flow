using System;
class Question2
{
    static void Q1()
    {
        int input = int.Parse(Console.ReadLine());
        switch (input)
        {
            case 1:
                Console.WriteLine("One");
                break;
            case 2:
                Console.WriteLine("Two");
                break;
            case 3:
                Console.WriteLine("Three");
                break;
        }
    }

    static void Q2()
    {
        int character = int.Parse(Console.ReadLine());
        switch (character)
        {
            case 1:
                Console.WriteLine("Warrior");
                break;
            case 2:
                Console.WriteLine("Mage");
                break;
            case 3:
                Console.WriteLine("Archer");
                break;
            default:
                Console.WriteLine("choose one of three characters");
                break;
        }
    }
    static void Q3()
    {
        int directions = int.Parse(Console.ReadLine());
        switch (directions)
        {
            case 1:
                Console.WriteLine("North");
                break;
            case 2:
                Console.WriteLine("South");
                break;
            case 3:
                Console.WriteLine("East");
                break;
            case 4:
                Console.WriteLine("West");
                break;
            default:
                Console.WriteLine("Choose 1 to 4");
                break;
        }
    }
    static void Q4()
    {
        int input = int.Parse(Console.ReadLine());

        switch (input)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
            default:
                Console.WriteLine("invalid");
                break;
        }
    }
    static void Q5()
    {
        Console.WriteLine("1 for Sword, 2 for Bow, 3 for Staff, and 4 for Axe");
        int character = int.Parse(Console.ReadLine());
        switch (character)
        {
            case 1:
                Console.WriteLine("Sword");
                break;
            case 2:
                Console.WriteLine("Bow");
                break;
            case 3:
                Console.WriteLine("Staff");
                break;
            case 4:
                Console.WriteLine("Axe");
                break;
            default:
                Console.WriteLine("Invalid");
                break;
        }
    }
    static void Q6()
    {
        Console.WriteLine("1 for Fire, 2 for Water, 3 for Earth, 4 for Air, and 5 for Lightning");
        int input = int.Parse(Console.ReadLine());
        switch (input)
        {
            case 1: Console.WriteLine("Fire");
                break;
            case 2: Console.WriteLine("Water");
                break;
            case 3: Console.WriteLine("Earth");
                break;
            case 4: Console.WriteLine("Air");
                break;
            case 5: Console.WriteLine("Lightning");
                break;
            default: Console.WriteLine("Invalid");
                break;
        }

    }
    static void Q7()
    {
        Console.WriteLine("1 for Start Game, 2 for Options, 3 for Load Game, and 4 for Exit");
        int input = int.Parse(Console.ReadLine());
        switch (input)
        {
            case 1:
                Console.WriteLine("Start Game");
                break;
            case 2:
                Console.WriteLine("Options");
                break;
            case 3:
                Console.WriteLine("Load Game");
                break;
            case 4:
                Console.WriteLine("Exit");
                break;
            default:
                Console.WriteLine("Invalid");
                break;
        }
    }

    static void Q8()
    {
        int input = int.Parse(Console.ReadLine());
        switch (input)
        {
            case 1:
                Console.WriteLine("Talk");
                break;
            case 2:
                Console.WriteLine("Trade");
                break;
            case 3:
                Console.WriteLine("Quest");
                break;
            default:
                Console.WriteLine("Invalid");
                break;
        }
    }
    static void Q9()
    {
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.WriteLine(" first approach!");
                break;
            case 2:
                Console.WriteLine("second approach!");
                break;
            case 3:
                Console.WriteLine("third approach!");
                break;
            case 4:
                Console.WriteLine("fourth approach!");
                break;
            case 5:
                Console.WriteLine("fifth approach!");
                break;
            default:
                Console.WriteLine("Invalid selection! Please choose a number between 1 and 5.");
                break;
        }
    }
    static void Q10()
    {
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.WriteLine(" Hello!");
                break;
            case 2:
                Console.WriteLine("Sorry!");
                break;
            case 3:
                Console.WriteLine("Go ahead!");
                break;
            case 4:
                Console.WriteLine("Unfortunately!");
                break;
            default:
                Console.WriteLine("Invalid selection! Please choose a number between 1 and 5.");
                break;
        }
    }
    static void Q11()
    {
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.WriteLine(" Position");
                break;
            case 2:
                Console.WriteLine("Weapon");
                break;
            case 3:
                Console.WriteLine("Armor");
                break;
            default:
                Console.WriteLine("Invalid selection! Please choose a number between 1 and 5.");
                break;
        }
    }
    static void Q12()
    {
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.WriteLine(" Scene 1");
                break;
            case 2:
                Console.WriteLine("Scene 2");
                break;
            case 3:
                Console.WriteLine("Scene 3");
                break;
            case 4:
                Console.WriteLine("Scene 4");
                break;
            case 5:
                Console.WriteLine("Scene 5");
                break;
            default:
                Console.WriteLine("Invalid selection! Please choose a number between 1 and 5.");
                break;
        }
    }
    static void Q13()
    {
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.WriteLine(" Kill 5 wolves");
                break;
            case 2:
                Console.WriteLine("Help farmer");
                break;
            case 3:
                Console.WriteLine("Go to city center");
                break;
            case 4:
                Console.WriteLine("Kill a Dragon");
                break;
            default:
                Console.WriteLine("Invalid selection! Please choose a number between 1 and 5.");
                break;
        }
    }
    static void Q14()
    {
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.WriteLine(" Health Potion");
                break;
            case 2:
                Console.WriteLine("Mana Potion");
                break;
            case 3:
                Console.WriteLine("Stamina Potion");
                break;
            default:
                Console.WriteLine("Invalid selection! Please choose a number between 1 and 5.");
                break;
        }
    }
    static void Q15()
    {
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.WriteLine("Left");
                break;
            case 2:
                Console.WriteLine("Right");
                break;
            case 3:
                Console.WriteLine("Jump");
                break;
            case 4:
                Console.WriteLine("Crouch");
                break;
            default:
                Console.WriteLine("Invalid selection! Please choose a number between 1 and 5.");
                break;
        }
    }
    static void Q16()
    {
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.WriteLine("Iron");
                break;
            case 2:
                Console.WriteLine("Steel");
                break;
            case 3:
                Console.WriteLine("Gold");
                break;
            case 4:
                Console.WriteLine("Diamond");
                break;
            default:
                Console.WriteLine("Invalid selection! Please choose a number between 1 and 5.");
                break;
        }
    }
    static void Q17()
    {
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.WriteLine("Fire");
                break;
            case 2:
                Console.WriteLine("Water");
                break;
            case 3:
                Console.WriteLine("Earth");
                break;
            case 4:
                Console.WriteLine("Air");
                break;
            default:
                Console.WriteLine("Invalid selection! Please choose a number between 1 and 5.");
                break;
        }
    }
    static void Q18()
    {
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.WriteLine("Strength");
                break;
            case 2:
                Console.WriteLine("Agility");
                break;
            case 3:
                Console.WriteLine("Intelligence");
                break;
            case 4:
                Console.WriteLine("Vitality");
                break;
            default:
                Console.WriteLine("Invalid selection! Please choose a number between 1 and 4.");
                break;
        }
    }
    static void Q19()
    {
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.WriteLine("Solution A");
                break;
            case 2:
                Console.WriteLine("Solution B");
                break;
            case 3:
                Console.WriteLine("Solution C");
                break;
            case 4:
                Console.WriteLine("Solution D");
                break;
            default:
                Console.WriteLine("Invalid selection! Please choose a number between 1 and 4.");
                break;
        }
    }
    static void Q20()
    {
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.WriteLine("Herb");
                break;
            case 2:
                Console.WriteLine("Mushroom");
                break;
            case 3:
                Console.WriteLine("Flower");
                break;
            case 4:
                Console.WriteLine("Solution D");
                break;
            default:
                Console.WriteLine("Invalid selection! Please choose a number between 1 and 4.");
                break;
        }
    }
    static void Q21()
    { 
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.WriteLine("Talk");
                break;
            case 2:
                Console.WriteLine("Trade");
                break;
            case 3:
                Console.WriteLine("Quest");
                break;
            default:
                Console.WriteLine("Invalid selection! Please choose a number between 1 and 3.");
                break;
        }
    }
    static void Q22()
    {
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.WriteLine("Desert");
                break;
            case 2:
                Console.WriteLine("Forest");
                break;
            case 3:
                Console.WriteLine("Mountain");
                break;
            case 4:
                Console.WriteLine("Castle");
                break;
            default:
                Console.WriteLine("Invalid selection! Please choose a number between 1 and 4.");
                break;
        }
    }
    static void Q23()
    {
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.WriteLine("Talk to a wich");
                break;
            case 2:
                Console.WriteLine("Go to castle");
                break;
            case 3:
                Console.WriteLine("Kill 5 pigs");
                break;
            default:
                Console.WriteLine("Invalid selection! Please choose a number between 1 and 3.");
                break;
        }
    }
    static void Q24()
    {
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.WriteLine("Start");
                break;
            case 2:
                Console.WriteLine("Option");
                break;
            case 3:
                Console.WriteLine("Load game");
                break;
            case 4:
                Console.WriteLine("Exit");
                break;
            default:
                Console.WriteLine("Invalid selection! Please choose a number between 1 and 4.");
                break;
        }
    }
    public static void Main()
    {
        //Q1();
        //Q2();
        //Q3();
        //Q4();
        //Q5();
        Q6();
        Q7();
        Q8();
        Q9();
        Q10();
        Q11();
        Q12();
        Q13();
        Q14();
        Q15();
        Q17();
        Q18();
        Q19();
        Q20();
        Q21();
        Q22();
        Q23();
        Q24();
    }
}