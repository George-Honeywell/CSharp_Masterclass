namespace PROJ_QuizApp
{
  internal class Quiz
  {
    private Questions[] questions;

    public Quiz(Questions[] questions)
    {
      // The 'this' keyword refers to the current instance of a class
      // 'this.questions' explicitly refers to the instance field, while 'questions' alone refers to the methods parameter.
      // Without using 'this', the compiler assumes the parameter is being used, not the field
      this.questions = questions;
    }
  }
}
