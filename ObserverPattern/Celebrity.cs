public class Celebrity : ICelebrity
{
    public string Name { get; }
    private int flag;
    public int Flag
    {
        get { return flag; }
        set
        {
            flag = value;
            notifier.Notify(new CelebrityFlagChangedEventArgs(this, flag));
        }
    }

    private CelebrityNotifier notifier;

    public Celebrity(string name, CelebrityNotifier notifier)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentException($"'{nameof(name)}' cannot be null or empty.", nameof(name));
        }

        this.Name = name;
        this.notifier = notifier ?? throw new ArgumentNullException(nameof(notifier));
    }
}
