using System;
using System.ComponentModel;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using TaskBoard.Models;

namespace TaskBoard.ViewModels
{
    public class TaskViewModel : INotifyPropertyChanged
    {
        private readonly Task _task;

        public string Text
        {
            get { return _task.Text; }
            set
            {
                if (_task.Text != value)
                {
                    _task.Text = value;
                    PropertyChanged.Raise(this, "Text");
                }
            }
        }

        public ItemStatus Status
        {
            get { return _task.Status; }
            set
            {
                if (_task.Status != value)
                {
                    _task.Status = value;
                    PropertyChanged.Raise(this, "Status");
                }
            }
        }

        public TaskViewModel(Task task)
        {
            _task = task;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
