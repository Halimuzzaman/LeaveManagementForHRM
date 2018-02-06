using System;
using System.Data;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Leave.Modules;
using Leave.Supplements;
using Leave.DataClients;

namespace Config_with_Gui	{
	/// <summary>
	/// Interaction logic for EntitlementsViewer.xaml
	/// </summary>
	public partial class EntitlementsViewer : Page
	{
		private DataManager dataManager;

		public EntitlementsViewer(double height, double width)	{
			InitializeComponent();
			this.Height = height;
			this.Width = width;
			dataManager = new DataManager();
		}

		private void ComboBox_Employee_Selected(object sender, EventArgs e)	{
			dataManager.Data = Employees.GetSpecificEmployeeInfo("Name");
			ViewMatches((ComboBox)sender, dataManager, "Name", 0);
		}

		private void ComboBox_Employee_TextChanged(object sender, TextChangedEventArgs e)	{
			ViewMatches((ComboBox)sender, dataManager, "Name", 0);
		}

		private void ComboBox_LeaveType_Selected(object sender, EventArgs e)	{
			dataManager.Data = LeaveTypes.GetLeaveTypes();
			ViewMatches((ComboBox)sender, dataManager, "LeaveType", 0);
		}

		private void ComboBox_LeaveType_TextChanged(object sender, TextChangedEventArgs e)	{
			ViewMatches((ComboBox)sender, dataManager, "LeaveType", 0);
		}

		private void ComboBox_EntitlementType_Selected(object sender, EventArgs e)	{
		
		}

		private void ComboBox_EntitlementType_TextChanged(object sender, TextChangedEventArgs e)	{
			
		}

		private void ComboBox_LeavePeriodStartingDate_Selected(object sender, EventArgs e)	{
			dataManager.Data = LeavePeriods.GetLeavePeriods();
			ViewMatches((ComboBox)sender, dataManager, "startingdate", 0);
		}

		private void ComboBox_LeavePeriodStartingDate_TextChanged(object sender, TextChangedEventArgs e)	{
			ViewMatches((ComboBox)sender, dataManager, "startingdate", 0);
		}

		private void ComboBox_LeavePeriodEndingDate_Selected(object sender, EventArgs e)	{
			dataManager.Data = LeavePeriods.GetLeavePeriods();
			ViewMatches((ComboBox)sender, dataManager, "endingdate", 1);
		}

		private void ComboBox_LeavePeriodEndingDate_TextChanged(object sender, TextChangedEventArgs e)	{
			ViewMatches((ComboBox)sender, dataManager, "endingdate", 1);
		}

		private static void ViewMatches(ComboBox comboBox, DataManager dm, string field, int position)	{
			DataRow[] rows = dm.Data.Select(field + " like '%" + comboBox.Text + "%'");
			string text = comboBox.Text;
			comboBox.Items.Clear();
			ComboBoxItem item = null;
			foreach(DataRow row in rows)	{
				item = new ComboBoxItem();
				item.Content = row[position];
				comboBox.Items.Add(item);
			}
			if(rows.Length > 0 && comboBox.Text.Length > 0 && comboBox.IsDropDownOpen == false)	{
				comboBox.IsDropDownOpen = true;
				TextBox textbox = (TextBox)comboBox.Template.FindName("PART_EditableTextBox", comboBox);
				textbox.Select(comboBox.Text.Length, 0);
			}
			comboBox.Text = text;
		}
	}
}
