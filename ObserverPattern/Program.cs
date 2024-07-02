

var notifier = new CelebrityNotifier();

var observer1 = new CelebrityObserver("Observer 1");

var observer2 = new CelebrityObserver("Observer 2");

using (notifier.Subscribe(observer1))
using (notifier.Subscribe(observer2))
{
    var celebrity = new Celebrity("Dave Mustaine", notifier)
    {
        Flag = 1  // Notify observers
    };
    celebrity.Flag = 2;  // Notify observers again
}