
public class Human
{
	public double Hight;
	public double Weight;
	public string BirthDate;
	public Body GIvenBody;
	public string Nationality;
	public string Name;
	public string Gender;
	public string SystemIllness;

	public Human()
	{
		var rnd = new Random();
		DateTime birthDay = DateTime.Now;
		var Nation = new List<string> { "russian", "american", "french", "german" };
		var SystemIllness = new List<string> { "not yet", "epilepsy", "mnd", "ms", "parkinson", "diabete" };
		var GenderVariants = new List<string> { "male", "female" };
		this.Gender= GenderVariants[rnd.Next(GenderVariants.Count)];

        if (this.Gender == "male")
        {
			var NameMale = new List<string> { "John", "Fedor", "Ivan", "Sergey", "Petr", "Bob", "Kurt", "Donald", "Andrey" };
			this.Name = NameMale[rnd.Next(NameMale.Count)];
        }
        else
        {
			var NameFemale = new List<string> { "Nancy", "Svetlana", "Ivanka", "Sofiya", "Pamela", "Rebecca", "Kelly", "Diana", "Anna" };
			this.Name = NameFemale[rnd.Next(NameFemale.Count)];
		}

		this.BirthDate = birthDay.ToString();
		this.Nationality = Nation[rnd.Next(Nation.Count)];
		this.SystemIllness = SystemIllness[rnd.Next(SystemIllness.Count)];
		this.GIvenBody = new Body();
	}
}

