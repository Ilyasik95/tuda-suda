namespace TireServiceApp.Services
{
    public class ApplicationService
    {
        private readonly IApplicationRepository _repository;

        // Конструктор принимает репозиторий
        public ApplicationService(IApplicationRepository repository)
        {
            _repository = repository;
        }
        // Моковый метод для сохранения заявки
        public bool SaveApplication(Application application)
        {
            if (application == null)
                throw new ArgumentNullException(nameof(application), "Заявка не может быть null");

            if (string.IsNullOrWhiteSpace(application.PhoneNumber) || application.PhoneNumber.Length < 10)
                throw new ArgumentException("Неверный номер телефона");

            _repository.Save(application);
            return true;
        }

    }

    // Класс модели заявки
    public class Application
    {
        public int Id { get; set; }
        public string Name { get; set; }             // ФИО клиента
        public string PhoneNumber { get; set; }     // Номер телефона
        public string VehicleNumber { get; set; }   // Регистрационный номер авто
        public string ProblemDescription { get; set; } // Описание проблемы
    }
}