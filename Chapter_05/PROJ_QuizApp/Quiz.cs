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

    public void DisplayQuestion(Questions question)
    {
      Console.WriteLine(question.Question);

      for(int i = 0; i < question.Answers.Length; i++)
      {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("   ");
        Console.Write(i+1);
        Console.ResetColor();
        Console.WriteLine($". {question.Answers[i]}");
      }
    }
  }
}
