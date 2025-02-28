using System; 
    class RegularMember : Member{
    
    private double WorkoutPlanFee = 175 ;
    public RegularMember(string Name , int Age ) : base(Name , Age){
        // this.WorkoutPlanFee = WorkoutPlanFee ; 
    }
    public override double CalculateMonthlyFee(){
        return  WorkoutPlanFee + 50 ;
    }
    public override void display(){
        Console.WriteLine("\t\t\tMember ID:" + Get_Id()) ; 
        Console.WriteLine("\t\t\tName:" + Get_Name()) ;
        Console.WriteLine("\t\t\tAge:" + Get_Age()) ;
        Console.WriteLine("\t\t\tMonthlyFee: " + CalculateMonthlyFee()) ; 
    }
    public void Set_WorkoutPlanFee(double fee){
        WorkoutPlanFee = fee ; 
    }
}