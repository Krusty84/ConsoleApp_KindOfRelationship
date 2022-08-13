
public class Head
{
	public Eye[] MountedEye;
	public string FaceShape;
	public string ChronicIllness;
	public Head()
	{
		var rnd = new Random();
		var Shape = new List<string> { "oval", "round", "square", "diamond", "heart", "pear", "oblong" };
		this.FaceShape = Shape[rnd.Next(Shape.Count)];
		this.MountedEye = new Eye[0];
	}
}

