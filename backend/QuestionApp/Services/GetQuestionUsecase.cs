using System;

namespace QuestionApp.Services;

public class GetQuestionUsecase
{
    public class Question
    {
        public int Id { get; set; }
        public string Text { get; set; }
    }

    public Question[] Execute()
    {
        // Sample data for demonstration
        return new Question[]
        {
            new Question { Id = 1, Text = "What is your favorite color?" },
            new Question { Id = 2, Text = "What is your favorite food?" }
        };
    }
}
