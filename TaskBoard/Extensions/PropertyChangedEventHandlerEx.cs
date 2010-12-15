using System;

// ReSharper disable CheckNamespace
namespace System.ComponentModel
// ReSharper restore CheckNamespace
{
    public static class PropertyChangedEventHandlerEx
    {
        public static void Raise(this PropertyChangedEventHandler handler, object sender, string propertyName)
        {
            if (handler != null)
            {
                handler(sender, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
