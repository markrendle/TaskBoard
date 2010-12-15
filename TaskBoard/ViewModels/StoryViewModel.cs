using System;
using System.Collections.ObjectModel;
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
using TaskBoard.Extensions;
using TaskBoard.Models;
using System.Linq;

namespace TaskBoard.ViewModels
{
    public class StoryViewModel : INotifyPropertyChanged
    {
        private readonly Story _story;
        private readonly ReactiveCollection<TaskViewModel> _backlog;
        private readonly ReactiveCollection<TaskViewModel> _inProgress;
        private readonly ReactiveCollection<TaskViewModel> _done;

        public StoryViewModel(Story story)
        {
            _story = story;
            _backlog = new ReactiveCollection<TaskViewModel>(_story.Tasks.Where(task => task.Status == ItemStatus.Backlog).Select(task => new TaskViewModel(task)));
            _inProgress = new ReactiveCollection<TaskViewModel>(_story.Tasks.Where(task => task.Status == ItemStatus.InProgress).Select(task => new TaskViewModel(task)));
            _done = new ReactiveCollection<TaskViewModel>(_story.Tasks.Where(task => task.Status == ItemStatus.Done).Select(task => new TaskViewModel(task)));
        }

        public ReactiveCollection<TaskViewModel> Done
        {
            get { return _done; }
        }

        public ReactiveCollection<TaskViewModel> InProgress
        {
            get { return _inProgress; }
        }

        public ReactiveCollection<TaskViewModel> Backlog
        {
            get { return _backlog; }
        }

        public string Text
        {
            get { return _story.Text; }
            set
            {
                if (_story.Text == value) return;
                _story.Text = value;
                PropertyChanged.Raise(this, "Text");
            }
        }

        public int Points
        {
            get { return _story.Points; }
            set
            {
                if (_story.Points == value) return;
                _story.Points = value;
                PropertyChanged.Raise(this, "Points");
            }
        }

        public ItemStatus Status
        {
            get { return _story.Status; }
            set
            {
                if (_story.Status == value) return;
                _story.Status = value;
                PropertyChanged.Raise(this, "Status");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
