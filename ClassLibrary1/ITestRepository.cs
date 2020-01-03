using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public interface ITestRepository
    {
        Hotel FindBestHotel(string clientType, DateTime[] dates);
    }
}
