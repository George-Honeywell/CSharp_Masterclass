namespace PROJ_QuizApp
{
  internal class Program
  {
    static void Main()
    {
      Questions[] question = new Questions[]
      {
        new Questions("In what year was C# first released?",
        new string[] {"2000", "1993", "1998", "2025" }, 0),

        new Questions("Who develops C#?",
        new string[] {"Google", "Apple", "Microsoft", "Oracle"}, 2),

        new Questions("What is the file extension for C# files?",
        new string[] {".py", ".cs", ".cpp", ".txt"}, 1),

        new Questions("What other language is C# similar to?",
        new string[] {"Java", "C++", "Python", "SQL"}, 0),

        new Questions("Which is the correct syntax for declaring an integer?",
        new string[] {"int x : 0;", "int x = 0;", "x = 0;", "int x = 0"}, 1)
      };

      Quiz quiz = new Quiz(question);
      quiz.StartQuiz();
    }
  }
}
