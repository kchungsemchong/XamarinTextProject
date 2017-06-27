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
	public partial class ListTasksPage : ContentPage
	{
		public string MyName { get; set; }

		public  ListTasksPage(List<ToDoItem> items)
		{
			MyName = "Patrick";
			BindingContext = this;
			InitializeComponent();
		}

		public ListTasksPage()
		{
			InitializeComponent();
		}
	}
}