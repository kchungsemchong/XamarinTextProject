using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace TestProject
{
	public class ButtonLogger : ContentPage
	{
		StackLayout loggerLayout = new StackLayout();

		public ButtonLogger()
		{
			//Create the Button and attach the Clicked handler.
			Button button = new Button
			{
				Text = "Log the Click Time"
			};
			button.Clicked += OnButtonClicked;

			//this.Padding = new Thickness(5 , switch(Device.RuntimePlatform), 5,0);

			Content = new StackLayout
			{
				Children =
				{
					button,
					new ScrollView
					{
						VerticalOptions = LayoutOptions.FillAndExpand,
						Content = loggerLayout
					}
				}
			};
		}

		void OnButtonClicked(object sender , EventArgs args)
		{
			//Add label to scrollable Stack Layout
			loggerLayout.Children.Add(new Label
			{
				Text = "Button clicked at " + DateTime.Now.ToString("T")
			});
		}
	}
}