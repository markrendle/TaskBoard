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
using TaskBoard.Extensions;
using TaskBoard.Models;

namespace TaskBoard.ViewModels
{
    public class MainViewModel
    {
        private readonly ReactiveCollection<StoryViewModel> _backlog;
        private readonly ReactiveCollection<StoryViewModel> _inProgress;
        private readonly ReactiveCollection<StoryViewModel> _done;

        public MainViewModel(IEnumerable<Story> stories)
        {
            _backlog = new ReactiveCollection<StoryViewModel>(StoriesToViewModels(stories, ItemStatus.Backlog));
            _backlog.Additions.Subscribe(story => story.Status = ItemStatus.Backlog);

            _inProgress = new ReactiveCollection<StoryViewModel>(StoriesToViewModels(stories, ItemStatus.InProgress));
            _inProgress.Additions.Subscribe(story => story.Status = ItemStatus.InProgress);

            _done = new ReactiveCollection<StoryViewModel>(StoriesToViewModels(stories, ItemStatus.Done));
            _done.Additions.Subscribe(story => story.Status = ItemStatus.Done);
        }

        public ReactiveCollection<StoryViewModel> Backlog
        {
            get { return _backlog; }
        }

        public ReactiveCollection<StoryViewModel> InProgress
        {
            get { return _inProgress; }
        }

        public ReactiveCollection<StoryViewModel> Done
        {
            get { return _done; }
        }

        private static IEnumerable<StoryViewModel> StoriesToViewModels(IEnumerable<Story> stories, ItemStatus status)
        {
            return stories.Where(story => story.Status == status).Select(story => new StoryViewModel(story));
        }
    }
}
