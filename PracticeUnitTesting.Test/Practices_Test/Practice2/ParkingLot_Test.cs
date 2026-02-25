
using Xunit;
public class ParkingLot_Test
{
	[Fact]
	public void TotalSpots_Should_ThrowException_When_TotalSpots_Invalid()
	{ 
        Assert.Throws<ArgumentException>(() =>  new ParkingLot(0));
		Assert.Throws<ArgumentException>(() =>  new ParkingLot(-10));
	}

	[Fact]
	public void Total_Spots_Must_Be_100_When_Contructor_Initiate_With_100()
	{
		ParkingLot parkingLot = new ParkingLot(100);
		Assert.Equal(100, parkingLot.TotalSpots);
	}


	[Fact]
	public void ParkVehicle_Should_Increase_OccupiedSpots()
	{
		ParkingLot parkingLot = new ParkingLot(10);
		parkingLot.ParkVehicle();
		Assert.Equal(1, parkingLot.OccupiedSpots);
	}

	[Fact]
	public void RemoveVehicle_Should_Decrease_OccupiedSpots()
	{
		ParkingLot parkingLot = new ParkingLot(10);
		parkingLot.ParkVehicle();
		parkingLot.ParkVehicle();

		Assert.Equal(2, parkingLot.OccupiedSpots);
		parkingLot.RemoveVehicle();
		Assert.Equal(1, parkingLot.OccupiedSpots);
	}


	[Fact]
	public void ParkVehicle_Should_ThrowException_When_ParkingLotIsFull()
	{
		ParkingLot parkingLot = new ParkingLot(1);
		parkingLot.ParkVehicle();
		Assert.Throws<InvalidOperationException>(() => parkingLot.ParkVehicle());
	}

	[Fact]
	public void RemoveVehicle_Should_ThrowException_When_ParkingLotIsAlreadyEmpty()
	{
		ParkingLot parkingLot = new ParkingLot(1);
		Assert.Throws<InvalidOperationException>(() => parkingLot.RemoveVehicle());
	}
}