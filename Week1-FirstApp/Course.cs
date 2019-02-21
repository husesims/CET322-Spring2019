public class Course
{
    public string Code { get; set; }
    public int Credit { get; set; }

    public Course(string code, int credit)
    {
        Code=code;
        Credit=credit;
    }

    public Course(){
        
    }
}