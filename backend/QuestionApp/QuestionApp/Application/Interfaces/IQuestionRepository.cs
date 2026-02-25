using System;
using QuestionApp.Domain.Entities;

namespace QuestionApp.Application.Interfaces;

public interface IQuestionRepository
{
Task<List<Question>> GetAllAsync();
    Task<Question?> GetByIdAsync(int id);
    Task<Question> AddAsync(Question question);
    Task DeleteAsync(Question question);
}
