using System;
using FixmensApp.Views;
using Xamarin.Forms;

namespace FixmensApp
{
    public class MainPage : TabbedPage
    {
        public MainPage()
        {
            Page itemsPage, aboutPage, loginPage = null;

            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    loginPage = new NavigationPage(new Login())
                    {
                        Title = "Login"
                    };
                    itemsPage = new NavigationPage(new ItemsPage())
                    {
                        Title = "Browse"
                    };

                    aboutPage = new NavigationPage(new AboutPage())
                    {
                        Title = "About"
                    };

                    itemsPage.Icon = "tab_feed.png";
                    aboutPage.Icon = "tab_about.png";
                    loginPage.Icon = "tab_about.png";
                    break;
                default:
                    loginPage = new Login()
                    {
                        Title = "Login"
                    };
                    itemsPage = new ItemsPage()
                    {
                        Title = "Orden"
                    };

                    aboutPage = new AboutPage()
                    {
                        Title = "About"
                    };
                    break;
            }
            Children.Add(loginPage);
            Children.Add(itemsPage);
            Children.Add(aboutPage);

            Title = Children[0].Title;
        }

        protected override void OnCurrentPageChanged()
        {
            base.OnCurrentPageChanged();
            Title = CurrentPage?.Title ?? string.Empty;
        }
    }
}
