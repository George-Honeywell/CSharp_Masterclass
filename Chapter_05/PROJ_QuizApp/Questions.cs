namespace PROJ_QuizApp
{
  internal class Questions
  {
    public string Question { get; set; }
    public string[] Answers { get; set; }
    public int AnswerIndex { get; set; }

    public Questions(string question, string[] answers, int answerIndex)
    {
      Question = question;
      Answers = answers;
      AnswerIndex = answerIndex;
    }

    public bool IsCorrect(int choice)
    {
      return AnswerIndex == choice;
    }
  }
}
