using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App1
{
	public partial class MainPage : ContentPage
	{
        Label label;
        Entry MyEntry;
        Label lblResult;
        int clickTotal = 0;

        public MainPage()
		{
			InitializeComponent();

            Button botonSaludo = new Button
            {
                Text = "Calcula Impuesto",
                TextColor = Color.Red,
                Font = Font.BoldSystemFontOfSize(20),
                BackgroundColor = Color.Blue,
            };                       

            Label header = new Label
            {
                Text = "Button",
                Font = Font.BoldSystemFontOfSize(50),
                HorizontalOptions = LayoutOptions.Center
            };

            Button button = new Button
            {
                Text = "Click Me!",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                BorderWidth = 1,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            button.Clicked += OnButtonClicked;

            label = new Label
            {
                Text = "0 button clicks",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            MyEntry = new Entry
            {
                Placeholder = "I am an Entry",
                BackgroundColor = Color.White,
                TextColor = Color.Black                            
            };

            lblResult = new Label
            {
                Text = "Impuesto",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                BackgroundColor = Color.FromHex("#fafafa")
            };

            // Accomodate iPhone status bar.
            this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);

            // Build the page.
            this.Content = new StackLayout
            {
                Children =
                {
                    botonSaludo,
                    header,     
                    MyEntry,                                                
                    button,
                    lblResult,
                    label
                }
            };
        }
        
        void OnButtonClicked(object sender, EventArgs e)
        {
            clickTotal += 1;
            label.Text = String.Format("{0} button click{1}", clickTotal, clickTotal == 1 ? "" : "s");
            DisplayAlert("Xamarin", "Hola " + "Edson", "Ok");
            double a=Convert.ToDouble(MyEntry.Text);
            if (a > 0)
            {
                a = a * 0.16;
                lblResult.Text = Convert.ToString(a);
            }
        }        

    }
}
