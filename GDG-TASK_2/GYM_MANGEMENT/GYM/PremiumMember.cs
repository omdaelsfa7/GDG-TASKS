using System ; 
class PremiumMember : Member
{

private double PersonalTrainerFee = 500;
private double DietPlanFee = 100;
public PremiumMember(string Name, int Age) : base(Name, Age)
{
    // this.PersonalTrainerFee = PersonalTrainerFee ; 
    // this.DietPlanFee = DietPlanFee ; 
}
public override double CalculateMonthlyFee()
{
    return DietPlanFee + 100 + PersonalTrainerFee;
}
public override void display()
{
    Console.WriteLine("\t\t\tMember ID:" + Get_Id());
    Console.WriteLine("\t\t\tName:" + Get_Name());
    Console.WriteLine("\t\t\tAge:" + Get_Age());
    Console.WriteLine("\t\t\tMonthlyFee: " + CalculateMonthlyFee());
}
}