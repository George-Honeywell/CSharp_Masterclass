namespace PROJ_QuizApp
{
  internal class Quiz
  {
    private Questions[] _questions;

    public Quiz(Questions[] questions)
    {
      // The 'this' keyword refers to the current instance of a class
      // 'this.questions' explicitly refers to the instance field, while 'questions' alone refers to the methods parameter.
      // Without using 'this', the compiler assumes the parameter is being used, not the field
      this._questions = questions;
    }

    public void StartQuiz()
    {
      Console.WriteLine("Welcome to the C# Quiz!");
      Console.WriteLine("Written in... well... C#!\n");

      int questionNumber = 1;

      foreach (Questions question in _questions)
      {
        Console.Write($"Question {questionNumber++} - ");
        DisplayQuestion(question);

        int userChoice = GetUserChoice();
        if (question.IsCorrect(userChoice))
        {
          Console.WriteLine("Correct!");
          _score++;
        }
        else
          Console.WriteLine("Incorrect :(");
      }
    }
    

    private void DisplayQuestion(Questions question)
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

    private int GetUserChoice()
    {
      Console.Write("Input a number as your answer: ");
      string answer = Console.ReadLine();
      int choice = 0;
      while(!int.TryParse(answer, out choice) || choice < 1 || choice > 4)
      {
        Console.WriteLine("Enter a valid choice! Your answer must be between 1, 2, 3, or 4!");
        answer = Console.ReadLine();
      }

      return choice - 1;
    }
  }
}
