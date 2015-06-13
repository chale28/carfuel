using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using CarFuel.Models;
using CarFuel.Utils;

namespace CarFuel.Facts
{
    public class FillUpFacts
    {
        public class GeneralUsage
        {
            [Fact]
            public void Basic()
            {
                // Arrange
                var f1 = new FillUp();
                f1.Odometer = 1000;
                f1.IsFull = true;
                f1.Liters = 50.0;

                // Act

                // Assert
                Assert.Equal(1000, f1.Odometer);
                Assert.Equal(true, f1.IsFull);
                Assert.Equal(50.0, f1.Liters);
            }

            [Fact]
            public void DefaultDateShouldBeNow()
            {
                // a
                var now = DateTime.Now;
                SystemTime.SetDateTime(now);

                var f = new FillUp();
                f.Odometer = 1000;
                f.IsFull = true;
                f.Liters = 50.0;

                // a
                DateTime dt = f.Date;

                // a
                Assert.Equal(expected: now, actual: dt);

                SystemTime.ResetDateTime();
            }
        }
    }
}
