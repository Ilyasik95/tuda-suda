namespace TireServiceApp.Services
{
    public interface IApplicationRepository
    {
        void Save(Application application); // Метод для сохранения заявки
        Application GetById(int id);        // Метод для получения заявки по ID
    }
}