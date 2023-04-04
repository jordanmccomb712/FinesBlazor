public class StateContainer
{
    public static string testID {get; set;}

    private string? savedFineID;

    public string Property
    {
        get => savedFineID ?? string.Empty;
        set
        {
            savedFineID = value;
            NotifyStateChanged();
        }
    }

    public event Action? OnChange;

    private void NotifyStateChanged() => OnChange?.Invoke();
}