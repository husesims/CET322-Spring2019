public class StudentCourse
{
    public Course TakenCourse { get; set; }
    public Grade StudentGrade { get; set; }

    public float GradeValue {
        get {

            return ((int)StudentGrade)/2f;
        }
     }
    public StudentCourse()
    {

    }
    public StudentCourse(Course course, Grade grade)
    {
        TakenCourse = course;
        StudentGrade = grade;
    }
}

public enum Grade
{
    F=0,
    DD=2,
    DC=3,
    CC,
    CB,
    BB,
    BA,
    AA
}