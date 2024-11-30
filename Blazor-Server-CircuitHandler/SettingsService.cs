namespace Blazor_Server_CircuitHandler;

public class SettingsService
{

    public SettingsService()
    {
        MyName = "Christophe";
    }

    public void Initialization()
    {
        MyName = "Nicolas";
    }
    public string MyName { get; set; }
    public string GetName()
    {
        return "toto";
    }
}
