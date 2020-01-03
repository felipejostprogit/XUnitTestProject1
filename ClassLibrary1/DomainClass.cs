using System;
using Domain.Entities;

namespace Domain
{
    public class DomainClass : IDomainClass
    {
        private readonly ITestRepository testRepository;

        public DomainClass(ITestRepository repository)
        {
            this.testRepository = repository;
        }

        public Hotel FindBestHotel(string clientType, DateTime[] dates)
        {
            return this.testRepository.FindBestHotel(clientType, dates);
        }

        public bool isNullOrEmpty(string str)
        {
            return string.IsNullOrEmpty(str);
        }
    }
}
