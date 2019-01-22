using Interview.ParkingLot.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Interview.ParkingLot.Tests
{
    public class ParkingServiceTests
    {
        private readonly ParkingService _classUnderTest;
        private readonly RuleValidationService _validationService;
        public ParkingServiceTests()
        {
            _classUnderTest = new ParkingService();
            _validationService = new RuleValidationService();
        }

        [Fact]
        public void GetFloor_One_Valid_Floors_Expected_One_Valid()
        {
            var floor = new Dictionary<int, int>()
            {
                {-2,5 },
                {-1,0 },
                {0,0 },
                {1,3 },
                {2,1 },
            };

            var result = _classUnderTest.GetFloor(floor, -1, _validationService.ValidateFloorSpace);

            Assert.NotNull(result);
            Assert.Equal(-2, result.Value);
        }

        [Fact]
        public void GetFloor_Two_Valid_Floors_Expected_The_Lowest()
        {
            var floor = new Dictionary<int, int>()
            {
                {-2,5 },
                {-1,0 },
                {0,1 },
                {1,3 },
                {2,1 },
            };

            var result = _classUnderTest.GetFloor(floor, -1, _validationService.ValidateFloorSpace);

            Assert.NotNull(result);
            Assert.Equal(-2, result.Value);
        }

        [Fact]
        public void GetFloor_Rule_Is_Null_Expected_Null()
        {
            var floor = new Dictionary<int, int>()
            {
                {-2,5 },
                {-1,0 },
                {0,1 },
                {1,3 },
                {2,1 },
            };

            var result = _classUnderTest.GetFloor(floor, -1, null);

            Assert.Null(result);
        }

        [Fact]
        public void GetFloor_Boom_Barrier_At_Non_Specified_Floor()
        {
            var floor = new Dictionary<int, int>()
            {
                {-2,5 },
                {-1,0 },
                {0,1 },
                {1,3 },
                {2,1 },
            };

            var result = _classUnderTest.GetFloor(floor, 3, _validationService.ValidateFloorSpace);

            Assert.NotNull(result);
            Assert.Equal(2, result.Value);
        }

        [Fact]
        public void GetFloor_Empty_Floor_Values()
        {
            var floor = new Dictionary<int, int>()
            {
            };

            var result = _classUnderTest.GetFloor(floor, 3, _validationService.ValidateFloorSpace);

            Assert.Null(result);
        }


        [Fact]
        public void GetFloor_No_empty_Spaces()
        {
            var floor = new Dictionary<int, int>()
            {
                {-2,0 },
                {-1,0 },
                {0,0 },
                {1,0 },
                {2,0 },
            };

            var result = _classUnderTest.GetFloor(floor, 3, _validationService.ValidateFloorSpace);

            Assert.Null(result);
        }
    }
}
