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
using TaskBoard.Extensions;
using TaskBoard.Models;

namespace TaskBoard.ViewModels
{
    public class AcceptanceCriteriaViewModel
    {
        private readonly ReactiveCollection<AcceptanceCriterionViewModel> _happyPath;
        private readonly ReactiveCollection<AcceptanceCriterionViewModel> _sadPath;

        public AcceptanceCriteriaViewModel(IEnumerable<AcceptanceCriterion> criteria)
        {
            _happyPath = ReactiveCollection.Create(CreateCriterionViewModels(criteria, AcceptanceCriteriaPath.Happy));
            _sadPath = ReactiveCollection.Create(CreateCriterionViewModels(criteria, AcceptanceCriteriaPath.Happy));
        }

        public ReactiveCollection<AcceptanceCriterionViewModel> SadPath
        {
            get { return _sadPath; }
        }

        public ReactiveCollection<AcceptanceCriterionViewModel> HappyPath
        {
            get { return _happyPath; }
        }

        private static IEnumerable<AcceptanceCriterionViewModel> CreateCriterionViewModels(IEnumerable<AcceptanceCriterion> criteria, AcceptanceCriteriaPath path)
        {
            return
                criteria.Where(c => c.Path == path).Select(c => new AcceptanceCriterionViewModel(c));
        }
    }
}
