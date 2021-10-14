using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
// add this for MessageBox
using System.Windows.Forms;


// add data function classes
using System.Data;

namespace LoginApp
{
	public class Config
	{
		string connectionString = ""; // save connection string
		public MySqlConnection connection = null;
		public string server = "localhost"; // MySQL host / ip 
		public string user = "root"; // MySQL user
		public string password = "root"; // MySQL password
		DataSet ds;
		DataTable dt;
		public string table = "user_info"; // initialize db table
		public string connectionType = "";
		string recordSource = "";

		DataGridView tempdata;

		public Config() { }

		// function to connect to the database
		public void Connect(string database_name)
		{
			try
			{
				connectionString = $"SERVER={server};DATABASE={database_name};UID={user};PASSWORD={password};SSL Mode=None;"; 

				connection = new MySqlConnection(connectionString);
			}
			catch (Exception E)
			{
				MessageBox.Show(E.Message);
			}
		}

		// function to execute select statements
		public void ExecuteSql(string Sql_command)
		{
			Nowquiee(Sql_command);
		}

		// creates connection to MySQL before execution
		public void Nowquiee(string sql_comm)
		{
			try
			{
				MySqlConnection cs = new MySqlConnection(connectionString);
				cs.Open();
				MySqlCommand myc = new MySqlCommand(sql_comm, cs);
				myc.ExecuteNonQuery();

				cs.Close();

			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}

		// function to execute delete, insert, and update
		public void Execute(string Sql_command)
		{
			recordSource = Sql_command;
			connectionType = table;
			dt = new DataTable(connectionType);
			try
			{
				string command = recordSource.ToUpper();

				//=====================if sql contains select=============================
				MySqlDataAdapter da2 = new MySqlDataAdapter(recordSource, connection);

				DataSet tempds = new DataSet();
				da2.Fill(tempds, connectionType);

				//========================================================================


			}
			catch (Exception err) { MessageBox.Show(err.Message); }
		}

		// function to bring selected results based on column name and row index
		public string Results(int ROW, String COLUMN_NAME)
		{
			try
			{
				return dt.Rows[ROW][COLUMN_NAME].ToString();
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
				return "";
			}
		}

		// execute select statement
		public void ExecuteSelect(string Sql_command)
		{
			recordSource = Sql_command;
			connectionType = table;

			dt = new DataTable(connectionType);
			try
			{
				string command = recordSource.ToUpper();
				MySqlDataAdapter da = new MySqlDataAdapter(recordSource, connection);
				ds = new DataSet();
				da.Fill(ds, connectionType);
				da.Fill(dt);
				tempdata = new DataGridView();
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}

		}

		public int Count()
		{
			return dt.Rows.Count;
		}

	}

}

