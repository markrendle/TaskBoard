﻿using System;
using System.Collections.Generic;
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
    public static class ReactiveCollection
    {
        public static ReactiveCollection<T> Create<T>(IEnumerable<T> source)
        {
            return new ReactiveCollection<T>(source);
        }
    }
}
