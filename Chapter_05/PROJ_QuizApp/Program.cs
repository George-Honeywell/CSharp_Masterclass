namespace PROJ_QuizApp
{
  internal class Program
  {
    static void Main()
    {
      Questions[] question = new Questions[]
      {
        new Questions("What is the capital of the United Kingdom?",
        new string[] {"Paris", "London", "Berlin", "Sydney" }, 1)
      };

      Quiz quiz = new Quiz(question);
      quiz.DisplayQuestion(question[0]);      
    }
  }
}
