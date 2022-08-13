
public class Eye
{
	
	public string ColorEye;
	public string ChronicIllness;

	public Eye()
	{
		var rnd = new Random();
		var Color = new List<string> { "black", "grey", "green", "blue" };
		var EyeIllness = new List<string>{ "myopia", "not yet", "astigmatism"};
		this.ColorEye = Color[rnd.Next(Color.Count)];
		this.ChronicIllness = EyeIllness[rnd.Next(EyeIllness.Count)];
	}
}

