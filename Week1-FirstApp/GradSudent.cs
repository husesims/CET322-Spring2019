public class GradStudent: Student{
    
    public string ThesisTopic { get; set; }
    public bool IsThesisCompleted {get;set;}

    public override bool CanGradute() {
          return  base.CanGradute()&& IsThesisCompleted;
    }
}