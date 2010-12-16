using System;
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
    public class AcceptanceCriterion
    {
        public AcceptanceCriterion(string text, AcceptanceCriteriaPath path)
        {
            Text = text;
            Path = path;
        }

        public string Text { get; set; }
        public AcceptanceCriteriaPath Path { get; set; }
    }
}
