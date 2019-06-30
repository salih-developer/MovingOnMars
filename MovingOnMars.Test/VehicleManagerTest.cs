namespace MovingOnMars.Test
{
    using System;

    using FluentAssertions;

    using MovingOnMars.Bussiness;

    using NUnit.Framework;

    public class VehicleManagerTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("22", "1 2 N", "LMLMLMLMM", "1 3 N")]
        public void When_Given_Coordinates_Are_Out_Of_Area_Then_It_Should_Throw_Exception(string area, string position, string commands, string output)
        {
            IVehicleManager maneManager = VehicleManager.Create(area, position, commands);

            Action action = () => maneManager.Operation();

            action.Should().Throw<ArgumentOutOfRangeException>();
        }

        [TestCase("55", "1 2 N", "LMLMLMLMM", "1 3 N")]
        [TestCase("55", "3 3 E", "MMRMMRMRRM", "5 1 E")]
        public void When_VehicleManager_Operation_To_Given_Coordinates_Then_It_Should_Proceed(string area, string position, string commands, string output)
        {
            IVehicleManager maneManager = VehicleManager.Create(area, position, commands);
            var result = maneManager.Operation();
            result.Should().Be(output);
        }
    }
}