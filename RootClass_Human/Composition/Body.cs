
public class Body
{

	public string Color;
	public string BodyType;
	public Head MountedHead;
	public Heart MountedHeart;
	public Belly MountedBelly;
	public string ChronicIllness;
	
	public Body()
	{
		var rnd = new Random();
		
		var Body = new List<string> { "fat", "slim", "regular", "stretch" };
		var Color = new List<string> { "white", "black" };
		this.BodyType = Body[rnd.Next(Body.Count)];
		this.Color = Color[rnd.Next(Color.Count)];
		this.MountedHead = new Head();
		this.MountedHeart = new Heart();
		this.MountedBelly = new Belly();
	}
}

