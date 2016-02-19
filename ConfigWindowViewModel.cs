/*
 * Created by SharpDevelop.
 * User: locbrag
 * Date: 19.02.2016
 * Time: 12:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data.SqlClient;

namespace Zero_DB_Explorer
{
	/// <summary>
	/// Description of ConfigWindowViewModel.
	/// </summary>
	public class ConfigWindowViewModel
	{
		public ConfigWindowViewModel()
		{
		}
		
		private string _database;
		public string Database {get { return _database; } set {_database = value;}}
		
		private string _server;
		public string Server {get {return _server;} set {_server = value;}}
		
		private string _userName;
		public string UserName {get {return _userName;} set{_userName = value;}}
		
		private string _password;
		public string Password {get {return _password;} set {_password = value;}}
		
		private void Connect()
		{
			
		}
	}
}
