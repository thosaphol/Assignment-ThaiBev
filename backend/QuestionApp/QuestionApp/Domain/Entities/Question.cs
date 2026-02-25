using System;

namespace QuestionApp.Domain.Entities;

public class Question
{
public int Id { get; private set; }
    public string Title { get; private set; }
    public string Choice1 { get; private set; }
    public string Choice2 { get; private set; }
    public string Choice3 { get; private set; }
    public string Choice4 { get; private set; }

    public Question(
        string title,
        string choice1,
        string choice2,
        string choice3,
        string choice4)
    {
        Title = title;
        Choice1 = choice1;
        Choice2 = choice2;
        Choice3 = choice3;
        Choice4 = choice4;
    }
}
