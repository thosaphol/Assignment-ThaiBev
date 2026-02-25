using System;
using QuestionApp.Application1.DTOs;
using QuestionApp.Application1.Interfaces;
using QuestionApp.Domain1.Entities;
// using Application1.DTOs;
// using Application1.Interfaces;
// using Domain1.Entities;

namespace QuestionApp.Application1.Services;

public class QuestionService
{
    private readonly IQuestionRepository _repo;
    public QuestionService(IQuestionRepository repo)
    {
        _repo = repo;
    }

    public async Task<List<QuestionDto>> GetAllAsync()
    {
        var questions = await _repo.GetAllAsync();

        return questions.Select(q => new QuestionDto
        {
            Id = q.Id,
            Title = q.Title,
            Choice1 = q.Choice1,
            Choice2 = q.Choice2,
            Choice3 = q.Choice3,
            Choice4 = q.Choice4
        }).ToList();
    }

    public async Task<QuestionDto> CreateAsync(QuestionDto dto)
    {
        var question = new Question(
            dto.Title,
            dto.Choice1,
            dto.Choice2,
            dto.Choice3,
            dto.Choice4);

        var created = await _repo.AddAsync(question);

        dto.Id = created.Id;
        return dto;
    }

    public async Task DeleteAsync(int id)
    {
        var question = await _repo.GetByIdAsync(id);
        if (question == null)
            throw new Exception("Question not found");

        await _repo.DeleteAsync(question);
    }
}
