

VINNumberGenerator NewVIN = new VINNumberGenerator();
Car Mercedes = new Car("Mercedes", "Red", NewVIN);
Console.WriteLine($"Was created {Mercedes.Brand}\n");
Console.WriteLine($"And this Car starts\n");
Mercedes.ControlEngine(false).SwitchOn();
Console.WriteLine($"The {Mercedes.Brand} was started\n");

