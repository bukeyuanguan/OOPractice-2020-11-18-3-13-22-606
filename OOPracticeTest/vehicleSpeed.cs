namespace OOPracticeTest
{
    using OOPractice;
    using Xunit;

    public class VehicleSpeed
    {
        [Fact]
        public void CarSpeedUpMessaageTest()
        {
            //given
            Car car = new Car("Cool Car", new ElectricalEngine());
            //when
            string actual = car.SpeedUp();

            //
            string expected = "Cool Car: speed up 25 km/h";
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void TruckSpeedUpMessaageTest()
        {
            //given
            Truck truck = new Truck("Big Truck", new ElectricalEngine());
            //when
            string actual = truck.SpeedUp();

            //
            string expected = "Big Truck: speed up 10 km/h";
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void DriverSpeedUpMessaageTest()
        {
            //given
            Car car = new Car("Cool Car", new GasEngine());
            Driver driver = new Driver(car);
            //when
            string actual = driver.SpeedUp();

            //
            string expected = "Big Truck: speed up 10 km/h";
            Assert.Equal(actual, expected);
        }
    }
}
