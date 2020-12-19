using System;
using System.Text;
using System.IO;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Web;
using System.Web.Services;

using Microsoft.Web.Services2.Dime;
using Microsoft.Web.Services2;
using System.Net;
using System.Configuration;

namespace MyService
{
	/// <summary>
	/// Summary description for SqlServerProxy.
	/// </summary>
	public class tungSqlServerProxy : System.Web.Services.WebService
	{
		private tungComponents.tungDbDriver.DriverSqlServer itsDriver;

		#region Constructor
		public tungSqlServerProxy()
		{
			InitializeComponent();
		}
		~tungSqlServerProxy()
		{
		}
		#endregion

		#region Component Designer generated code
		
		//Required by the Web Services Designer 
		private IContainer components = null;
				
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if(disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);		
		}
		
		#endregion

		private void priConnect()
		{
			itsDriver = new tungComponents.tungDbDriver.DriverSqlServer(ConfigurationSettings.AppSettings["SQLSERVER_SERVER"],
				ConfigurationSettings.AppSettings["SQLSERVER_USER"],
				ConfigurationSettings.AppSettings["SQLSERVER_PASSWORD"],
				ConfigurationSettings.AppSettings["SQLSERVER_DB"]
				);
		}
		private void priDisconnect()
		{
			itsDriver.fClose();
		}

		/*
		/// <summary>
		/// return result of a DB query as a datatable
		/// </summary>
		[WebMethod]
		public int fSelectAndFillDataTable(string query, System.Data.DataTable dataTable)
		{
			priConnect();
			int tempResult = itsDriver.fSelectAndFillDataTable(query, dataTable);
			priDisconnect();

			return tempResult;
		}
		*/
		/// <summary>
		/// return result of a DB query as a dataset
		/// </summary>
		[WebMethod]
		public System.Data.DataSet fSelectAndFillDataSet(string query)
		{
			priConnect();
			System.Data.DataSet dataset = new System.Data.DataSet();
			int tempResult = itsDriver.fSelectAndFillDataSet(query, dataset);
			priDisconnect();

			return dataset;
		}
		/// <summary>
		/// return result of a DB query as a dataset
		/// </summary>
		[WebMethod]
		public System.Data.DataSet fSelectAndFillDataSet2(string query, string srcTable)
		{
			priConnect();
			System.Data.DataSet dataset = new System.Data.DataSet();
			int tempResult = itsDriver.fSelectAndFillDataSet(query, dataset, srcTable);
			priDisconnect();

			return dataset;
		}		
		/// <summary>
		/// return result of a DB query as a dataset
		/// </summary>
		[WebMethod]
		public System.Data.DataSet fSelectAndFillDataSet3(string query, int startRecord, int maxRecords, string srcTable)
		{
			priConnect();
			System.Data.DataSet dataset = new System.Data.DataSet();
			int tempResult = itsDriver.fSelectAndFillDataSet(query, dataset, startRecord, maxRecords, srcTable);
			priDisconnect();

			return dataset;
		}

		/// <summary>
		/// execute a query
		/// </summary>
		[WebMethod]
		public int fExecuteNonQuery(string query)
		{
			priConnect();
			int tempResult = itsDriver.fExecuteNonQuery(query);
			priDisconnect();

			return tempResult;
		}
		/*
		/// <summary>
		/// execute a query
		/// </summary>
		[WebMethod]
		public System.Data.SqlClient.SqlDataReader fExecuteReader(string query)
		{
			priConnect();
			System.Data.SqlClient.SqlDataReader tempResult = itsDriver.fExecuteReader(query);
			priDisconnect();

			return tempResult;
		}
		*/
		/// <summary>
		/// execute a query
		/// </summary>
		[WebMethod]
		public object fExecuteScalar(string query)
		{
			priConnect();
			object tempResult = itsDriver.fExecuteScalar(query);
			priDisconnect();

			return tempResult;
		}
		/// <summary>
		/// execute a query
		/// </summary>
		[WebMethod]
		public System.Xml.XmlReader fExecuteXmlReader(string query)
		{
			priConnect();
			System.Xml.XmlReader tempResult = itsDriver.fExecuteXmlReader(query);
			priDisconnect();

			return tempResult;
		}

		/*
		/// <summary>
		/// execute a query
		/// </summary>
		[WebMethod]
		public int fExecuteNonQuery2(System.Data.SqlClient.SqlCommand sqlCommand)
		{
			priConnect();
			int tempResult = itsDriver.fExecuteNonQuery(sqlCommand);
			priDisconnect();

			return tempResult;
		}
		/// <summary>
		/// execute a query
		/// </summary>
		[WebMethod]
		public System.Data.SqlClient.SqlDataReader fExecuteReader2(System.Data.SqlClient.SqlCommand sqlCommand)
		{
			priConnect();
			System.Data.SqlClient.SqlDataReader tempResult = itsDriver.fExecuteReader(sqlCommand);
			priDisconnect();

			return tempResult;
		}
		/// <summary>
		/// execute a query
		/// </summary>
		[WebMethod]
		public object fExecuteScalar2(System.Data.SqlClient.SqlCommand sqlCommand)
		{
			priConnect();
			object tempResult = itsDriver.fExecuteScalar(sqlCommand);
			priDisconnect();

			return tempResult;
		}
		/// <summary>
		/// execute a query
		/// </summary>
		[WebMethod]
		public System.Xml.XmlReader fExecuteXmlReader2(System.Data.SqlClient.SqlCommand sqlCommand)
		{
			priConnect();
			System.Xml.XmlReader tempResult = itsDriver.fExecuteXmlReader(sqlCommand);
			priDisconnect();

			return tempResult;
		}
		*/

	}
}