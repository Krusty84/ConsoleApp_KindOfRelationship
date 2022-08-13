using ConsoleProgressBar;

public class CarEngineDiesel : ISwitch
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
        this.PreHeater(20);
        using (var pb = new ProgressBar())
        {
            using (var p1 = pb.HierarchicalProgress.Fork(0.33, "Starting Diesel Engine"))
            {
                using (var p11 = p1.Fork(0.8))
                {
                    for (int i = 0; i < 50; i++)
                    {
                        p11.Report(i / 50d, $"Start up...Start up: {i}/50");
                        Thread.Sleep(300);
                    }
                }
            }
        }
            return true;
        }

    private bool StopEngine()
    {
        Console.WriteLine("Stopping Engine");
        for (int i = 0; i < 200; i++)
        {
            //Thread.Sleep(100);
        }
        return true;
    }
    private bool PreHeater(int PreHeatTime)
    {
        using (var pb = new ProgressBar())
        {
            using (var p1 = pb.HierarchicalProgress.Fork(0.33, "Starting Preheat"))
            {

                using (var p11 = p1.Fork(0.8))
                {
                    for (int i = 0; i < PreHeatTime; i++)
                    {
                        p11.Report(i / 20d, $"Heating Heating Heating: {i}/{PreHeatTime}");
                        Thread.Sleep(300);
                    }
                }
            }
        }
        return true;
    }
}


