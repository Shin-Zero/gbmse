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
	/// Description of IConfigWindowViewModel.
	/// </summary>
	public interface IConfigWindowViewModel
	{
		string Database {get;set;}
		string Server {get;set;}
		string Username {get; set;}
		string Password {get;set;}
	}
}
