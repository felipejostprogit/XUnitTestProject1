using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public interface IDomainClass
    {
        bool isNullOrEmpty(string str);

        Hotel FindBestHotel(string clientType, DateTime[] dates);
    }
}
