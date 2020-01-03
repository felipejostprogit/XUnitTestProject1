using Domain;
using System;

namespace Application
{
    public class AppClass : IAppClass
    {
        private readonly IDomainClass domainClass;
        public AppClass(IDomainClass domainClass)
        {
            this.domainClass = domainClass;
        }

        public string FindBestHotel(string clientType, DateTime[] dates)
        {
            throw new Ar

            return this.domainClass.FindBestHotel(clientType, dates)?.Name;
        }

        public bool isNullOrEmpty(string str)
        {
            return this.domainClass.isNullOrEmpty(str);
        }
    }
}
