using System;
using System.Collections.Generic;
public class GYM : IGymManagement
{

    private List<Member> Members = new List<Member>();
    private int MemberCounter = 0;
    public GYM(){
        Member omar = new RegularMember("Omar Shoulkamy" , 19 );
        Member wessam = new PremiumMember("Ahmad Wessam" , 19 );
        Members.Add(omar) ; 
        Members.Add(wessam) ; 
    }
    public void AddMember(int choice, string name, int age)
    {
        Member newMember;
        if (choice == 1)
            newMember = new RegularMember(name, age);
        else
            newMember = new PremiumMember(name, age);

        Members.Add(newMember);
        MemberCounter++;
    }
    public void DisplayAllMembers()
    {
        if (MemberCounter == 0)
        {
            Console.WriteLine("\n\n\n\n No Members Found...");
            return;
        }
        for (int i = 0; i < MemberCounter; i++)
        {
            Members[i].display();
            Console.WriteLine("---------------------------------------------------------");
        }
    }
    public void GetFee()
    {
        double TotalFee = 0 ; 
        if (MemberCounter == 0)
        {
            Console.WriteLine("\n\n\n\n No Fees...");
            return;
        }
        for (int i = 0; i < MemberCounter; i++)
        {
            TotalFee+=Members[i].CalculateMonthlyFee();
        }
        Console.WriteLine("\t\t\tTotalfees: " + TotalFee) ;  
    }
}
