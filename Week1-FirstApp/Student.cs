using System;
using System.Collections.Generic;

public class Student
{
    public static float MiniumumGPA { get; set; }
    public string StudentNo { get; set; }
    public string FullName { get; set; }

    public List<StudentCourse> Courses { get; set; }

    public Student()
    {
        Courses = new List<StudentCourse>();
    }

    public float CalculateGPA()
    {


        float totalCredit = 0;
        float totalCreditGrade = 0;
        foreach (var course in Courses)
        {
            totalCredit += course.TakenCourse.Credit;
            totalCreditGrade += (course.TakenCourse.Credit * course.GradeValue);
        }
        return totalCreditGrade / totalCredit;
    }

    public virtual bool CanGradute()
    {
        if (CalculateGPA() >= MiniumumGPA && HasNoFailedCourse())
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private bool HasNoFailedCourse()
    {
        foreach (var course in Courses)
        {
            if (course.StudentGrade == Grade.F)
            {
                return false;
            }
        }
        return true;
    }
}