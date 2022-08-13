using ConsoleProgressBar;

public class CarEngineGas : ISwitch
{
	public string EngineStatus;
    public bool SwitchOn()
    {
        this.StartEngine();
        return true;
    }
    public bool SwitchOff()
    {
        this.StopEngine();
        return true;
    }
    private bool StartEngine()
    {
        using (var pb = new ProgressBar())
        {
            using (var p1 = pb.HierarchicalProgress.Fork(0.33, "Starting Gasoline Engine"))
            {
                using (var p11 = p1.Fork(0.8))
                {
                    for (int i = 0; i < 30; i++)
                    {
                        p11.Report(i / 30d, $"Start up...Start up: {i}/30");
                        Thread.Sleep(300);
                    }
                }
            }
            return true;
        }
    }
    private bool StopEngine()
    {
        Console.WriteLine("Stopping Gasoline Engine");
        for (int i = 0; i < 200; i++)
        {
           
        }
        return true;
    }
}
