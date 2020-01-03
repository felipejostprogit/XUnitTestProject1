using Application;
using Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest
    {
        private readonly IAppClass appClass;
        private readonly ServiceProvider serviceProvider;

        public UnitTest()
        {
            serviceProvider = new IOC.IOC().Startup();
            appClass = serviceProvider.GetRequiredService<IAppClass>();
        }        

        [Fact]
        public async void Test1()
        {
            var bestHotelName1 = this.appClass.FindBestHotel("Regular", new System.DateTime[] { new System.DateTime(2009, 3, 16), new System.DateTime(2009, 3, 17), new System.DateTime(2009, 3, 18) });

            Assert.Equal("Lakewood", bestHotelName1);

            var bestHotelName2 = this.appClass.FindBestHotel("Regular", new System.DateTime[] { new System.DateTime(2009, 3, 20), new System.DateTime(2009, 3, 21), new System.DateTime(2009, 3, 22) });

            Assert.Equal("Bridgewood", bestHotelName2);
        }
    }
}
