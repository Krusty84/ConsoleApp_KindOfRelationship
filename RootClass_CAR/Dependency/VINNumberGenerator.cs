
public class VINNumberGenerator
{
	public int GeneratedVIN;
	public VINNumberGenerator()
	{
		Random RngGenerator = new Random();
		GeneratedVIN = RngGenerator.Next();
	}
}

