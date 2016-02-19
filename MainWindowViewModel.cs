/*
 * Created by SharpDevelop.
 * User: locbrag
 * Date: 16.02.2016
 * Time: 9:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.ObjectModel;

namespace Zero_DB_Explorer
{
	/// <summary>
	/// Description of MainWindowViewModel.
	/// </summary>
	public class MainWindowViewModel: IMainWindowViewModel
	{
		public MainWindowViewModel()
		{
		}
		
		ObservableCollection<object> _dbContent;
		public ObservableCollection<object> DbContent 
		{ 
			get { 
				return _dbContent; 
			} 
			set { 
				_dbContent = value; 
			} 
		}
		
		ObservableCollection<string> _tables;
		public ObservableCollection<string> Tables 
		{ 
			get { 
				return _tables; 
			} 
			set { 
				_tables = value; 
			} 
		}
		
		string _fieldFilter;
		public string FieldFilter 
		{ 
			get { 
				return _fieldFilter; 
			} 
			set { 
				_fieldFilter = value; 
			} 
		}
		
		string _valueFilter;
		public string ValueFilter 
		{ 
			get { 
				return _valueFilter; 
			} 
			set { 
				_valueFilter = value; 
			} 
		}
		
		bool _specifiedTable;
		public bool SpecifiedTable 
		{ 
			get { 
				return _specifiedTable; 
			} 
			set { 
				_specifiedTable = value; 
			} 
		}
	}
}
