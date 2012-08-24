using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace EventFlare
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class FlareInFlames : EventFlare.Common.LayoutAwarePage
    {
        public User CurrentUser { get; set; }

        public FlareInFlames()
        {
            this.InitializeComponent();
            CurrentUser = new User("Frodo", "Frodo", "Baggins", "@frodolives", "frodo@TheShire.net");
        }

        /// <summary>
        /// Populates the page with content passed during navigation.  Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="navigationParameter">The parameter value passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested.
        /// </param>
        /// <param name="pageState">A dictionary of state preserved by this page during an earlier
        /// session.  This will be null the first time a page is visited.</param>
        protected override void LoadState(Object navigationParameter, Dictionary<String, Object> pageState)
        {
            // navigation parameter is a selected item from the list of flares.
            if (navigationParameter != null)
            {
                string flareName = navigationParameter as string;

                if (flareName != null)
                {
                    this.pageTitle.Text = flareName;

                    // start with some hard-coded messages until service is ready
                    ChatEntries.Items.Add("[SteveB]    Don't you think we should have error messages like C++ templates do?");
                    ChatEntries.Items.Add("[BobL]      Dude, are you out of your mind?!");
                }
            }
        }

        /// <summary>
        /// Preserves state associated with this page in case the application is suspended or the
        /// page is discarded from the navigation cache.  Values must conform to the serialization
        /// requirements of <see cref="SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="pageState">An empty dictionary to be populated with serializable state.</param>
        protected override void SaveState(Dictionary<String, Object> pageState)
        {
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // add a new Flare
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (NewMessage.Text.Trim().Length > 0)
            {
                string message = string.Format("[{0}]\t{1}", CurrentUser.Handle, NewMessage.Text);
                ChatEntries.Items.Add(message);
            }
        }
    }
}
