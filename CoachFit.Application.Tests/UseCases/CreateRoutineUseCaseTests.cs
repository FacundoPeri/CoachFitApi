using CoachFit.Application.DTOs;
using CoachFit.Application.Tests.Fakes;
using CoachFit.Application.UseCases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoachFit.Application.Tests.UseCases
{
    public class CreateRoutineUseCaseTests
    {
        [Fact]
        public async Task ExecuteAsync_ShouldCreateRoutine_WhenDataIsValid()
        {
            // Arrange
            var fakeRepository = new FakeRoutineRepository();
            var useCase = new CreateRoutineUseCase(fakeRepository);

            var request = new CreateRoutineRequest
            {
                Name = "Rutina Push",
                Description = "Pecho, hombros y tríceps",
                CoachId = Guid.NewGuid()
            };

            // Act
            var result = await useCase.ExecuteAsync(request);

            // Assert
            Assert.True(result.IsSuccess);
            Assert.NotNull(fakeRepository.SavedRoutine);
            Assert.Equal("Rutina Push", fakeRepository.SavedRoutine.Name);
        }

        [Fact]
        public async Task ExecuteAsync_ShouldFail_WhenNameIsEmpty()
        {
            // Arrange
            var fakeRepository = new FakeRoutineRepository();
            var useCase = new CreateRoutineUseCase(fakeRepository);

            var request = new CreateRoutineRequest
            {
                Name = "",
                Description = "Descripción inválida",
                CoachId = Guid.NewGuid()
            };

            // Act
            var result = await useCase.ExecuteAsync(request);

            // Assert
            Assert.False(result.IsSuccess);
            Assert.NotNull(result.Error);
            Assert.Null(fakeRepository.SavedRoutine);
        }
    }
}
