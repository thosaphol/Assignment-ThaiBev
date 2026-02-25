using System;
using Domain1.Entities;

namespace Application1.Interfaces;

public interface IQuestionRepository
{
Task<List<Question>> GetAllAsync();
    Task<Question?> GetByIdAsync(int id);
    Task<Question> AddAsync(Question question);
    Task DeleteAsync(Question question);
}
