using System;
using System.Collections.Generic;
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

namespace TaskBoard.Models
{
    public class Story
    {
        public Story(string text, int points, IEnumerable<Task> tasks) : this(text, points, tasks, Enumerable.Empty<AcceptanceCriterion>())
        {
        }

        public Story(string text, int points, IEnumerable<Task> tasks, IEnumerable<AcceptanceCriterion> acceptanceCriteria) : this(text, points, ItemStatus.Backlog, tasks, acceptanceCriteria)
        {
        }

        public Story(string text, int points, ItemStatus status, IEnumerable<Task> tasks, IEnumerable<AcceptanceCriterion> acceptanceCriteria)
        {
            Text = text;
            Points = points;
            Status = status;
            Tasks = tasks;
            AcceptanceCriteria = acceptanceCriteria;
        }

        public string Text { get; set; }
        public int Points { get; set; }
        public ItemStatus Status { get; set; }
        public IEnumerable<Task> Tasks { get; set; }
        public IEnumerable<AcceptanceCriterion> AcceptanceCriteria { get; set; }
    }
}
