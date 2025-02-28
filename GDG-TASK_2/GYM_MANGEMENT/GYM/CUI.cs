public class CUI{   
    GYM GYM1 = new GYM() ; 
    private string choice = "";
    private string memberchoice = "";

    public void WelcomeScreen()
    {
        Console.Clear();
        Console.WriteLine("\n\n\n\n                                                                          Welcome to Omda's GYM!        ");
        Console.WriteLine("\n\n\n\n\n\n\n\nPress any key to continue...");
        Console.ReadKey();
        System.Threading.Thread.Sleep(50);
        Console.Clear();
    }

    public void adminPage()
    {
    while (true)
    {
        Console.Clear();
        Console.WriteLine("\n\n                                                                           1 - Display All Members");
        Console.WriteLine("\n\n                                                                           2 - Show Total Fees");
        Console.WriteLine("\n\n                                                                           3 - Back to Main Menu");
        Console.Write("\n\n\n\nEnter your choice: ");

        string adminChoice = Console.ReadLine();

        switch (adminChoice)
        {
            case "1":
                Console.Clear();
                Console.WriteLine("\n\n                                                                          List of Members:");
                GYM1.DisplayAllMembers();
                Console.WriteLine("\nPress any key to return...");
                Console.ReadKey();
                break;
                
            case "2":
                Console.Clear();
                Console.WriteLine("\n\n                                                                          Total Membership Fees:");
                GYM1.GetFee();
                Console.WriteLine("\nPress any key to return...");
                Console.ReadKey();
                break;

            case "3":
                return;

            default:
                Console.WriteLine("Invalid choice. Please try again.");
                System.Threading.Thread.Sleep(1000);
                break;
        }
    }
}


    public void PremiumMemberPage()
{
    Console.Clear();
    Console.WriteLine("\n\n\n\n                                                                          Premium Member Registration");

    Console.Write("\n\nEnter your Name: ");
    string name = Console.ReadLine();

    int age;
    while (true)
    {
        Console.Write("Enter your Age: ");
        if (int.TryParse(Console.ReadLine(), out age) && age > 0)
        {
            break;
        }
        Console.WriteLine("Invalid age. Please enter a valid number.");
    }

    GYM1.AddMember(2, name, age);
    Console.WriteLine($"\n\nThank you, {name}. You have been registered as a Premium Member at age {age}. Please proceed to payment at the reception.");
    Console.WriteLine("\nPress any key to return to the main menu...");
    Console.ReadKey();
}


    public void RegularMemberPage()
    {
        Console.Clear();
        Console.WriteLine("\n\n\n\n                                                                          Regular Member Registration");

        Console.Write("\n\nEnter your Name: ");
        string name = Console.ReadLine();

        int age;
        while (true)
        {
            Console.Write("Enter your Age: ");
            if (int.TryParse(Console.ReadLine(), out age) && age > 0)
            {
                break;
            }
            Console.WriteLine("Invalid age. Please enter a valid number.");
        }
            GYM1.AddMember(1 , name , age) ;
        Console.WriteLine($"\n\nThank you, {name}. You have been registered as a Regular Member at age {age} , pay to your reception:");
        Console.WriteLine("\nPress any key to return to the main menu...");
        Console.ReadKey();
    }

    public void memberPage()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("\n\n\n\n                                                                          Select Membership Type       ");
            Console.WriteLine("\n\n                                                                           1 - Premium Member");
            Console.WriteLine("\n\n\n                                                                           2 - Regular Member");
            Console.WriteLine("\n\n\n                                                                           3 - Back to main menu");
            Console.Write("\n\n\n\nEnter your choice: ");

            memberchoice = Console.ReadLine();

            switch (memberchoice)
            {
                case "1":
                    PremiumMemberPage();
                    break;
                case "2":
                    RegularMemberPage();
                    break;
                case "3":
                    return; 
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    System.Threading.Thread.Sleep(1000);
                    break;
            }
        }
    }

    public void ShowOptions()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("\n\n                                                                           1 -   Admin");
            Console.WriteLine("\n\n\n                                                                           2 - New Member");
            Console.WriteLine("\n\n\n                                                                           3 - Exit");
            Console.Write("\n\n\n\nEnter your choice: ");

            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    adminPage();
                    break ; 
                case "2":
                    memberPage();
                    break ;  
                case "3":
                    return ; 
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    System.Threading.Thread.Sleep(1000);
                    break;
            }
        }
    }
}
