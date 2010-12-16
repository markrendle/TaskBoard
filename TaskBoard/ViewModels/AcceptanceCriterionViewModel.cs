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
    public class AcceptanceCriterionViewModel : INotifyPropertyChanged
    {
        private readonly AcceptanceCriterion _criterion;

        public AcceptanceCriterionViewModel(AcceptanceCriterion criterion)
        {
            _criterion = criterion;
        }

        public string Text
        {
            get { return _criterion.Text; }
            set
            {
                if (_criterion.Text != value)
                {
                    _criterion.Text = value;
                    PropertyChanged.Raise(this, "Text");
                }
            }
        }

        public AcceptanceCriteriaPath Path
        {
            get { return _criterion.Path; }
            set
            {
                if (_criterion.Path != value)
                {
                    _criterion.Path = value;
                    PropertyChanged.Raise(this, "Path");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
