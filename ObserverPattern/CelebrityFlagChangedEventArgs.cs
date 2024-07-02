public class CelebrityFlagChangedEventArgs
{
    public ICelebrity Celebrity { get; }
    public int NewFlag { get; }

    public CelebrityFlagChangedEventArgs(ICelebrity celebrity, int newFlag)
    {
        Celebrity = celebrity ?? throw new ArgumentNullException(nameof(celebrity));

        NewFlag = newFlag;
    }
}