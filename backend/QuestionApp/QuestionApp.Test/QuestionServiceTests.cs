using System;
using FluentAssertions;
using Moq;
using QuestionApp.Application.DTOs;
using QuestionApp.Application.Interfaces;
using QuestionApp.Application.Services;
using QuestionApp.Domain.Entities;

namespace QuestionApp.Test;

public class QuestionServiceTests
{
    private readonly Mock<IQuestionRepository> _repoMock;
        private readonly QuestionService _service;

        public QuestionServiceTests()
        {
            _repoMock = new Mock<IQuestionRepository>();
            _service = new QuestionService(_repoMock.Object);
        }

        [Fact]
        public async Task GetAllAsync_Should_Return_List_Of_Dto()
        {
            // Arrange
            var questions = new List<Question>
            {
                new Question("Q1", "A", "B", "C", "D")
            };

            _repoMock.Setup(r => r.GetAllAsync())
                     .ReturnsAsync(questions);

            // Act
            var result = await _service.GetAllAsync();

            // Assert
            result.Should().HaveCount(1);
            result[0].Title.Should().Be("Q1");
            result[0].Choice1.Should().Be("A");
            result[0].Choice2.Should().Be("B");
            result[0].Choice3.Should().Be("C");
            result[0].Choice4.Should().Be("D");
        }

        [Fact]
        public async Task CreateAsync_Should_Call_AddAsync_And_Return_Dto_With_Id()
        {
            // Arrange
            var dto = new QuestionDto
            {
                Title = "New Q",
                Choice1 = "A",
                Choice2 = "B",
                Choice3 = "C",
                Choice4 = "D"
            };

            var createdEntity = new Question("New Q", "A", "B", "C", "D");

            // Simulate DB assigning Id
            typeof(Question)
                .GetProperty("Id")!
                .SetValue(createdEntity, 10);

            _repoMock.Setup(r => r.AddAsync(It.IsAny<Question>()))
                     .ReturnsAsync(createdEntity);

            // Act
            var result = await _service.CreateAsync(dto);

            // Assert
            result.Id.Should().Be(10);
            _repoMock.Verify(r => r.AddAsync(It.IsAny<Question>()), Times.Once);
        }

        [Fact]
        public async Task DeleteAsync_Should_Call_Delete_When_Found()
        {
            // Arrange
            var question = new Question("Q1", "A", "B", "C", "D");

            _repoMock.Setup(r => r.GetByIdAsync(1))
                     .ReturnsAsync(question);

            // Act
            await _service.DeleteAsync(1);

            // Assert
            _repoMock.Verify(r => r.DeleteAsync(question), Times.Once);
        }

        [Fact]
        public async Task DeleteAsync_Should_Throw_When_Not_Found()
        {
            // Arrange
            _repoMock.Setup(r => r.GetByIdAsync(1))
                     .ReturnsAsync((Question?)null);

            // Act
            Func<Task> act = async () => await _service.DeleteAsync(1);

            // Assert
            await act.Should()
                     .ThrowAsync<Exception>()
                     .WithMessage("Question not found");
        }
}
