using System;
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
using TaskBoard.Models;

namespace TaskBoard.Data
{
    public static class DesignTimeStories
    {
        public static IEnumerable<Story> Stories()
        {
            yield return
                new Story("Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", 5,
                    new[]
                        {
                            new Task("Maecenas sit amet erat ligula, ac posuere libero."),
                            new Task("Donec in eros nisi."),
                            new Task("Quisque facilisis lacus nec urna rhoncus gravida.")
                        });

            yield return
                new Story(
                    "Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", 21,
                    new[]
                        {
                            new Task("Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos."),
                            new Task("Nullam at arcu eget augue tincidunt luctus ullamcorper id sapien."),
                            new Task("Donec id velit non arcu ornare gravida in at dolor.")
                        });

            yield return
                new Story(
                    "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.", 3,
                    new[]
                        {
                            new Task("Morbi a orci ac justo tristique bibendum a vel odio."),
                            new Task("Proin eu urna turpis, vitae blandit mauris."),
                            new Task("Fusce consequat dolor at turpis pellentesque non luctus quam dapibus.")
                        });
        }
    }
}
