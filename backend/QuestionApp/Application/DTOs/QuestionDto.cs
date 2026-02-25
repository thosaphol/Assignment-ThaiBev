using System;

namespace QuestionApp.Application.DTOs;

public class QuestionDto
{
public int Id { get; set; }
    public required string Title { get; set; }
    public required string Choice1 { get; set; }
    public required string Choice2 { get; set; }
    public required string Choice3 { get; set; }
    public required string Choice4 { get; set; }
}
