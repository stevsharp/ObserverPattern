
public class CelebrityObserver : IObserver<CelebrityFlagChangedEventArgs>
{
    private string _name;

    public CelebrityObserver(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException($"'{nameof(name)}' cannot be null or whitespace.", nameof(name));
        }

        _name = name;
    }

    public void OnNext(CelebrityFlagChangedEventArgs value)
    {
        Console.WriteLine($"Observer {_name}: Celebrity {value.Celebrity.Name} flag changed to {value.NewFlag}");
    }

    public void OnError(Exception error)
    {
        Console.WriteLine($"Observer {_name}: Error occurred: {error.Message}");
    }

    public void OnCompleted()
    {
        Console.WriteLine($"Observer {_name}: Completed");
    }
}
