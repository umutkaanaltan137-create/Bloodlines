using StardewModdingAPI;
using StardewModdingAPI.Events;

namespace Bloodlines;

public class ModEntry : Mod
{
    public override void Entry(IModHelper helper)
    {
        helper.Events.GameLoop.DayStarted += this.OnDayStarted;
        this.Monitor.Log("Bloodlines v0.1 yuklendi.", LogLevel.Info);
    }

    private void OnDayStarted(object? sender, DayStartedEventArgs e)
    {
        this.Monitor.Log("Gun basladi - Bloodlines calisiyor.", LogLevel.Debug);
    }
}
