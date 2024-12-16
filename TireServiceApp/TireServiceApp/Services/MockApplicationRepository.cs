using System.Collections.Generic;

namespace TireServiceApp.Services
{
    public class MockApplicationRepository : IApplicationRepository
    {
        private readonly Dictionary<int, Application> _applications = new();
        private int _idCounter = 1;

        public void Save(Application application)
        {
            application.Id = _idCounter++;
            _applications[application.Id] = application;
        }

        public Application GetById(int id)
        {
            _applications.TryGetValue(id, out var application);
            return application;
        }
    }
}