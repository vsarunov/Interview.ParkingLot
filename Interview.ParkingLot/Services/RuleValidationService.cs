using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.ParkingLot.Services
{
    public class RuleValidationService : IRuleValidationService
    {
        public bool ValidateFloorSpace(int currentFloorSpace, int spaceNeeded)
        {
            return currentFloorSpace >= spaceNeeded;
        }

    }
}
