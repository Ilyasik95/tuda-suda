using Xunit;
using static System.Net.Mime.MediaTypeNames;
using System;

public class ApplicationServiceTests
{
    //[Fact]
    //public void Should_SaveApplication_When_ValidDataProvided()
    //{
    //    // Arrange
    //    var applicationService = new ApplicationService();
    //    var application = new Application
    //    {
    //        Name = "Иван Иванов",
    //        PhoneNumber = "1234567890",
    //        VehicleNumber = "A123BC77",
    //        ProblemDescription = "Не заводится двигатель"
    //    };

    //    // Act
    //    var result = applicationService.SaveApplication(application);

    //    // Assert
    //    Assert.True(result, "Заявка должна успешно сохраняться");
    //}

    //[Fact]
    //public void Should_ThrowException_When_InvalidPhoneNumber()
    //{
    //    // Arrange
    //    var applicationService = new ApplicationService();
    //    var application = new Application
    //    {
    //        Name = "Иван Иванов",
    //        PhoneNumber = "123", // Некорректный номер
    //        VehicleNumber = "A123BC77",
    //        ProblemDescription = "Не заводится двигатель"
    //    };

    //    // Act & Assert
    //    Assert.Throws<ArgumentException>(() => applicationService.SaveApplication(application));
    //}
}