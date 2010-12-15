using System;
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
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskBoard.Data;
using TaskBoard.Models;
using TaskBoard.ViewModels;

namespace TaskBoard.Tests
{
    [TestClass]
    public class StoryViewModelTests
    {
        [TestMethod]
        public void MovingAStoryFromBacklogToInProgressShouldSetItsStatusToInProgress()
        {
            var underTest = new MainViewModel(DesignTimeStories.Stories());
            var story = underTest.Backlog.First();
            underTest.Backlog.Remove(story);
            underTest.InProgress.Add(story);
            Assert.AreEqual(ItemStatus.InProgress, story.Status);
        }
    }
}
