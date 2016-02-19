/*
 * Created by SharpDevelop.
 * User: locbrag
 * Date: 16.02.2016
 * Time: 9:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.ObjectModel;

namespace Zero_DB_Explorer
{
	/// <summary>
	/// Description of IMainWindowViewModel.
	/// </summary>
	public interface IMainWindowViewModel
	{
		ObservableCollection<object> DbContent { get; set; }
		ObservableCollection<string> Tables {get; set; }
		string FieldFilter { get; set; }
		string ValueFilter { get; set; }
		bool SpecifiedTable {get; set; }
	}
}
