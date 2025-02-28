using System ; 
abstract class Member{
     private static int NextMemberID = 1 ; 
    private int MemberID  ; 
    private string Name = " " ;
    private int Age ; 

    private double WorkoutFee = 500 ;

    public Member(string Name = "", int Age = 0){
        this.MemberID = NextMemberID++ ; 
        this.Name = Name ; 
        this.Age = Age ; 
    }
    public abstract double CalculateMonthlyFee() ;
    
    public abstract void display() ; 

    public string Get_Name(){
        return Name ; 
    }
    public int Get_Id(){
        return MemberID ;
    }
    public int Get_Age(){
        return Age ; 
    }
    public double Get_Fee(){
        return WorkoutFee ; 
    }
}