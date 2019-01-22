namespace Interview.ParkingLot.Services
{
    public interface IRuleValidationService
    {
        bool ValidateFloorSpace(int currentFloorSpace, int spaceNeede);
    }
}