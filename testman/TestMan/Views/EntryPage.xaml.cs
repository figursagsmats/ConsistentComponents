using System;
using TestMan.ViewModels;
using Xamarin.Forms;

namespace TestMan.Views
{
    public partial class EntryPage : ContentPage
    {
        private EntryPageViewModel _viewModel;
        public EntryPage()
        {

            InitializeComponent();
            _viewModel = (EntryPageViewModel)BindingContext;
        }

        private void OnWidthRequestToggled(object sender, EventArgs e)
        {
            ToggleBinding(((ToggledEventArgs)e).Value, ((SwitchWithTag)sender).Tag, Entry.WidthRequestProperty, "WidthRequest");
        }
        private void OnHeigtRequestToggled(object sender, EventArgs e)
        {
            ToggleBinding(((ToggledEventArgs)e).Value, ((SwitchWithTag)sender).Tag, Entry.HeightRequestProperty, "HeightRequest");
        }
        private void OnFontSizeToggled(object sender, EventArgs e)
        {
            ToggleBinding(((ToggledEventArgs)e).Value, ((SwitchWithTag)sender).Tag, Entry.FontSizeProperty, "FontSize");
        }


        private void ToggleBinding(bool value, string targetObjectName, BindableProperty bindableProperty, string propertyName)
        {
            Entry targetObject = this.FindByName<Entry>(targetObjectName);
            propertyName = "Target" + propertyName;
            if (value)
            {
                targetObject.SetBinding(bindableProperty, propertyName);
            }
            else
            {
                targetObject.RemoveBinding(bindableProperty);
            }
        }
    }
}
