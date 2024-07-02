public class CelebrityNotifier : IObservable<CelebrityFlagChangedEventArgs>
{
    private readonly List<IObserver<CelebrityFlagChangedEventArgs>> observers;

    public CelebrityNotifier()
    {
        observers = [];
    }

    public IDisposable Subscribe(IObserver<CelebrityFlagChangedEventArgs> observer)
    {
        if (!observers.Contains(observer))
        {
            observers.Add(observer);
        }

        return new Unsubscriber(observers, observer);
    }

    public void Notify(CelebrityFlagChangedEventArgs eventArgs)
    {
        foreach (var observer in observers)
        {
            observer.OnNext(eventArgs);
        }
    }

    private class Unsubscriber : IDisposable
    {
        private List<IObserver<CelebrityFlagChangedEventArgs>> _observers;

        private IObserver<CelebrityFlagChangedEventArgs> _observer;

        public Unsubscriber(List<IObserver<CelebrityFlagChangedEventArgs>> observers, 
            IObserver<CelebrityFlagChangedEventArgs> observer)
        {
            _observers = observers;
            _observer = observer;
        }

        public void Dispose()
        {
            if (_observer != null && _observers.Contains(_observer))
            {
                _observers.Remove(_observer);
            }
        }
    }
}
