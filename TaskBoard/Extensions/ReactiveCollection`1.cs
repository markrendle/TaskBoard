using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace TaskBoard.Extensions
{
    public class ReactiveCollection<T> : ObservableCollection<T>
    {
        private readonly IObservable<IEvent<NotifyCollectionChangedEventArgs>> _additions;

        public ReactiveCollection()
        {
            _additions = CollectionChangedEventToObservable();
        }

        public ReactiveCollection(IEnumerable<T> collection) : base(collection)
        {
            _additions = CollectionChangedEventToObservable();
        }

        public IObservable<T> Additions
        {
            get
            {
                return _additions
                    .Where(e => e.EventArgs.Action == NotifyCollectionChangedAction.Add)
                    .SelectMany(e => e.EventArgs.NewItems.OfType<T>());
            }
        }

        private IObservable<IEvent<NotifyCollectionChangedEventArgs>> CollectionChangedEventToObservable()
        {
            return
                Observable.FromEvent<NotifyCollectionChangedEventHandler, NotifyCollectionChangedEventArgs>(
                    h => (o, e) => h(o, e), h => CollectionChanged += h, h => CollectionChanged -= h);
        }
    }
}
