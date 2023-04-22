//Printing data using data table using DataReader and .
// csc /r:MySql.Data.dll DataTable.cs

using System;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

class dbCRUD
{
	String ConnectionString = null;
	MySqlConnection Connection;
	public dbCRUD()
	{

		ConnectionString = "server = 138.68.140.83; database = dbRamya; uid = Ramya; pwd = Ramya123$";
		Connection = new MySqlConnection(ConnectionString);
		try
		{
			Connection.Open();
			Console.WriteLine("Connection Open!");
		}
		catch (Exception)
		{
			Console.WriteLine("Can not open connection !");
		}
	}

	public void ShowAccounts()
	{
		try
		{
			string query = "select * from BankAccount;";

			MySqlDataAdapter adr = new MySqlDataAdapter(query, Connection);
			adr.SelectCommand.CommandType = CommandType.Text;
			DataTable dt = new DataTable();
			adr.Fill(dt);
			foreach (DataRow dr in dt.Rows)
			{
				Console.Write(string.Format("AccountId = {0}", dr["AccountId"].ToString()) + "  ");
				Console.Write(string.Format("AccountHolderName = {0}", dr["AccountHolderName"].ToString()) + "  ");
				Console.Write(string.Format("Balance = {0}", Convert.ToInt32(dr["Balance"].ToString())) + "\n");
			}
		}
		catch (Exception)
		{

		}
	}

	public static void Main(String[] args)
	{
		dbCRUD oCRUD = new dbCRUD();
		oCRUD.ShowAccounts();
	}
}


// ***********Printing data using datatable, datareader***********
// public void ShowAccounts()
// 	{
// 		try
// 		{
// 			string query = "select * from BankAccount;";
// 			MySqlCommand cmd = new MySqlCommand(query, Connection);
// 			MySqlDataReader dataReader = cmd.ExecuteReader();
// 			int numRows = 0;
// 			DataTable dt = new DataTable();
// 			dt.Load(dataReader);
// 			dataReader.Close();
// 			numRows = dt.Rows.Count;
// 			for (int index = 0; index <numRows; index++)
// 			{
// 				Console.Write(dt.Rows[index]["AccountId"] + " ");
// 				Console.Write(dt.Rows[index]["AccountHolderName"] + " ");
// 				Console.Write(dt.Rows[index]["Balance"] + "\n");
// 			}
// 		}
// 		catch (Exception)
// 		{

// 		}
// 	}