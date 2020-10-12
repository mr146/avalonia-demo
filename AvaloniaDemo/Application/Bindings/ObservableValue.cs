using System;
using System.Collections.Generic;

namespace Application.Bindings
{
    public class ObservableValue<T> : IObservable<T>
    {
        private readonly Func<int, T> myGetNewValue;
        private readonly List<IObserver<T>> observers;

        public ObservableValue(Func<int, T> getNewValue)
        {
            myGetNewValue = getNewValue;
            this.observers = new List<IObserver<T>>();
        }

        public IDisposable Subscribe(IObserver<T> observer)
        {
            observers.Add(observer);
            observer.OnNext(myGetNewValue(cnt));
            return new Unsubscriber<T>(observers, observer);
        }

        public void Increment()
        {
            cnt++;
            var newValue = myGetNewValue(cnt);
            foreach (var observer in observers)
                observer.OnNext(newValue);
        }

        private int cnt = 0;
    }
}