using System;
using System.Collections.Generic;
using System.Text;

namespace Application
{
    public interface IAppClass
    {
        bool isNullOrEmpty(string str);

        string FindBestHotel(string clientType, DateTime[] dates);
    }
}
