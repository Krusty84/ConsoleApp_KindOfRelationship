
public class Car : GroundVehicle
{
	public string CarNumber;
	public string Color;
	public string Body;
	public string SteeringWheel;
	public string Brand;
	protected Garage CurrentGarage;
	public Wheel[] UsingWheels;
	public int AssignedVINNumber;
    protected ISwitch UsingEngine;

    public Car(string BrandCar, string ColorCar, VINNumberGenerator VINNumber, Wheel[] mountingWheels, string BodyCar, string SteeringWheelCar)
	{
		Brand = BrandCar;
		SteeringWheel = SteeringWheelCar;
		Color = ColorCar;
		Body = BodyCar;
		this.AssignedVINNumber = VINNumber.GeneratedVIN;
		this.UsingWheels = mountingWheels;
	}

	public Car(string BrandCar, string ColorCar, VINNumberGenerator VINNumber)
	{
		Brand = BrandCar;
		Color = ColorCar;
		Body = "sedan";
		SteeringWheel = "left";
		this.AssignedVINNumber = VINNumber.GeneratedVIN;
	}

	public Car(string BrandCar, string ColorCar, string BodyCar, string SteeringWheelCar)
	{
		Brand = BrandCar;
		SteeringWheel = SteeringWheelCar;
		Color = ColorCar;
		Body = BodyCar;
	}

	public Car(string BrandCar, string ColorCar, string LicensePlate)
	{
		CarNumber = LicensePlate;
		Brand = BrandCar;
		Color = ColorCar;
		Body = "sedan";
		SteeringWheel = "left";
	}

	public ISwitch ControlEngine(/*Type Engine*/bool IsDiesel=false)
	{
		if (IsDiesel == true)
		{
            ISwitch MountedEngine = new CarEngineDiesel();
            return MountedEngine;
		}
		else
		{
            ISwitch MountedEngine = new CarEngineGas();
            return MountedEngine;
        }
    }

	public Garage WhereIsMyCarNow()
	{
		return CurrentGarage;
	}
	public void LeaveCar(Garage curGarage)
	{
		CurrentGarage = curGarage;
	}
}