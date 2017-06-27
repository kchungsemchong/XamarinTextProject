using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestProject
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CreatePage : ContentPage
	{
		public List<ToDoItem> toDoItems;
		private CreatePageViewModel vm;

		public CreatePage()
		{
			vm = new CreatePageViewModel();
			toDoItems = new List<ToDoItem>();
			BindingContext = vm;
			InitializeComponent();
		}

		public void OnSave(object o , EventArgs e)
		{
			toDoItems.Add(
				new ToDoItem(
						ToDoEntry.Text,
						Priority.Text,
						SetDueDate(
								Date.Date,
								Time.Time.Hours,
								Time.Time.Minutes,
								Time.Time.Seconds
							),
						false

					));
			Clear();
		}

		private void Clear()
		{
			ToDoEntry.Text = Priority.Text = string.Empty;
			Date.Date = DateTime.Now;
			Time.Time = new TimeSpan(
					DateTime.Now.Hour,
					DateTime.Now.Minute,
					DateTime.Now.Second		
				);
		}

		private DateTime SetDueDate(DateTime date, int hours, int minutes, int seconds)
		{
			DateTime retVal = new DateTime(
					date.Year,
					date.Month,
					date.Day,
					hours,
					minutes,
					seconds
				);

			return retVal;
		}

		public void OnCancel(object o, EventArgs e)
		{

		}

		public void OnReview(object o, EventArgs e)
		{
			Clear();
			Navigation.PushAsync(new ListTasksPage(toDoItems));
		}
	}
}