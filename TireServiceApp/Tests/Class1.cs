using Xunit;
using System;
using TireServiceApp.Services;

public class ApplicationServiceTests
{
    public ApplicationServiceTests()
    {
    }
    [Fact]
    public void Should_SaveApplication_When_ValidDataProvided()
    {
        var repository = new MockApplicationRepository();
        // Arrange
        var applicationService = new ApplicationService(repository);
        var application = new Application
        {
            Name = "Иван Иванов",
            PhoneNumber = "1234567890",
            VehicleNumber = "A123BC77",
            ProblemDescription = "Не заводится двигатель"
        };

        // Act
        var result = applicationService.SaveApplication(application);
        var expected = true;
        // Assert
        Assert.Equal(result, expected);
    }

    [Fact]
    public void Should_ThrowException_When_InvalidPhoneNumber()
    {
        var repository = new MockApplicationRepository();
        // Arrange
        var applicationService = new ApplicationService(repository);
        var application = new Application
        {
            Name = "Иван Иванов",
            PhoneNumber = "123", // Некорректный номер
            VehicleNumber = "A123BC77",
            ProblemDescription = "Не заводится двигатель"
        };

        // Act & Assert
        Assert.Throws<ArgumentException>(() => applicationService.SaveApplication(application));
    }

    [Fact]
    public void Should_ThrowException_When_NullApplicationProvided()
    {
        var repository = new MockApplicationRepository();
        // Arrange
        var applicationService = new ApplicationService(repository);
        Application application = null; // Передаем null вместо объекта заявки

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => applicationService.SaveApplication(application));
    }

    //накидать структуру приложения, закинуть в гит, классы из 6 лабы, расписать, закинуть в гит
}

