using System;
using System.Text;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Microsoft.Web.Services2;
using System.Web.Services;
using MyWindowsApplication.MyDbProxy;
using System.IO;
using System.Threading;

namespace MyWindowsApplication
{
	/// <summary>
	/// Summary description for frmTungSqlServerClient.
	/// </summary>
	public class frmTungSqlServerClient : System.Windows.Forms.Form
	{
		tungSqlServerProxyWse itsProxy;
		private System.ComponentModel.IContainer components;

		#region Declarations		

		
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Button btnGo;
		internal System.Windows.Forms.TextBox txtQuery;
		internal System.Windows.Forms.ComboBox cboQueryMethod;
		internal System.Windows.Forms.DataGrid dgdData;
		internal System.Windows.Forms.ImageList ImageList1;
		internal System.Windows.Forms.TreeView TreeViewTables;
		#endregion

		#region Constructor

		public frmTungSqlServerClient()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			itsProxy = new tungSqlServerProxyWse();

			priSelectTables();			
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}
		#endregion

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmTungSqlServerClient));
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.btnGo = new System.Windows.Forms.Button();
			this.txtQuery = new System.Windows.Forms.TextBox();
			this.cboQueryMethod = new System.Windows.Forms.ComboBox();
			this.dgdData = new System.Windows.Forms.DataGrid();
			this.TreeViewTables = new System.Windows.Forms.TreeView();
			this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dgdData)).BeginInit();
			this.SuspendLayout();
			// 
			// Label2
			// 
			this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
			this.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.Label2.Location = new System.Drawing.Point(216, 88);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(168, 24);
			this.Label2.TabIndex = 13;
			this.Label2.Text = "Result of SELECT QUERY:";
			// 
			// Label1
			// 
			this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
			this.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.Label1.Location = new System.Drawing.Point(216, 16);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(88, 24);
			this.Label1.TabIndex = 12;
			this.Label1.Text = "Your QUERY:";
			// 
			// btnGo
			// 
			this.btnGo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.btnGo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.btnGo.Location = new System.Drawing.Point(592, 40);
			this.btnGo.Name = "btnGo";
			this.btnGo.Size = new System.Drawing.Size(32, 24);
			this.btnGo.TabIndex = 11;
			this.btnGo.Text = "GO";
			this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
			// 
			// txtQuery
			// 
			this.txtQuery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtQuery.Location = new System.Drawing.Point(304, 40);
			this.txtQuery.Name = "txtQuery";
			this.txtQuery.Size = new System.Drawing.Size(280, 20);
			this.txtQuery.TabIndex = 10;
			this.txtQuery.Text = "";
			// 
			// cboQueryMethod
			// 
			this.cboQueryMethod.ItemHeight = 13;
			this.cboQueryMethod.Location = new System.Drawing.Point(216, 40);
			this.cboQueryMethod.Name = "cboQueryMethod";
			this.cboQueryMethod.Size = new System.Drawing.Size(88, 21);
			this.cboQueryMethod.TabIndex = 9;
			// 
			// dgdData
			// 
			this.dgdData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.dgdData.DataMember = "";
			this.dgdData.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dgdData.Location = new System.Drawing.Point(216, 112);
			this.dgdData.Name = "dgdData";
			this.dgdData.Size = new System.Drawing.Size(408, 192);
			this.dgdData.TabIndex = 8;
			// 
			// TreeViewTables
			// 
			this.TreeViewTables.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TreeViewTables.ImageList = this.ImageList1;
			this.TreeViewTables.Indent = 19;
			this.TreeViewTables.ItemHeight = 16;
			this.TreeViewTables.Location = new System.Drawing.Point(16, 16);
			this.TreeViewTables.Name = "TreeViewTables";
			this.TreeViewTables.Size = new System.Drawing.Size(184, 288);
			this.TreeViewTables.TabIndex = 7;
			this.TreeViewTables.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeViewTables_AfterSelect);
			// 
			// ImageList1
			// 
			this.ImageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
			this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// frmTungSqlServerClient
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.GhostWhite;
			this.ClientSize = new System.Drawing.Size(640, 318);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.btnGo);
			this.Controls.Add(this.txtQuery);
			this.Controls.Add(this.cboQueryMethod);
			this.Controls.Add(this.dgdData);
			this.Controls.Add(this.TreeViewTables);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "frmTungSqlServerClient";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Access Remote SQL Server DB using SOAP protocol";
			this.Load += new System.EventHandler(this.This_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgdData)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region Main
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			try
			{
				Form mainForm = new frmTungSqlServerClient();
				Application.Run(mainForm);				
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);

				Application.Exit();
			}
		}
		#endregion

		private void priSelectTables()
		{
			string qrySelect = "";
			qrySelect = "SELECT name FROM sysobjects where xtype='U'";
			
			DataSet dSet = itsProxy.fSelectAndFillDataSet(qrySelect);

			foreach (DataRow tRow in dSet.Tables[0].Rows)
			{
				TreeNode nd = new TreeNode();
				nd.Text = tRow["name"].ToString();
				nd.ImageIndex = 1;
				nd.Tag = "Table$" + nd.Text;
				TreeViewTables.Nodes.Add(nd);
			}
		}

		private void This_Load(object sender, System.EventArgs e)
		{
			cboQueryMethod.Items.Add("SELECT");
			cboQueryMethod.Items.Add("INSERT");
			cboQueryMethod.Items.Add("UPDATE");
			cboQueryMethod.Items.Add("DELETE");
			cboQueryMethod.SelectedIndex = 0;
		}

		private void btnGo_Click(object sender, System.EventArgs e)
		{
			try
			{
				if (cboQueryMethod.Text == "SELECT")
				{
					DataSet dSet = itsProxy.fSelectAndFillDataSet2(txtQuery.Text, "Result");
					dgdData.SetDataBinding(dSet, "Result");
					dgdData.Refresh();
				}
				else
				{
					itsProxy.fExecuteNonQuery(txtQuery.Text);
				}

				MessageBox.Show("Query execute successfully!");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);
			}
		}

		private void TreeViewTables_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
			if (TreeViewTables.SelectedNode.Tag.ToString() != "")
			{
				string qrySelect = "Select * from \"" + TreeViewTables.SelectedNode.Text + "\"";
				DataSet dSet = itsProxy.fSelectAndFillDataSet2(qrySelect, "Result");
				dgdData.SetDataBinding(dSet, "Result");
				dgdData.Refresh();
			}
		}

	}
}
