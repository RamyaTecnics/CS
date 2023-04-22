//csc /r:System.Data.SQLite.dll

using System;
using System.Text;
using System.Data;
using System.Data.SQLite;

class cSQLite
{
	public static void Main(String[] args)
	{
		try
		{
			SQLiteConnection sqlite;
			SQLiteCommand cmd;
			SQLiteDataReader reader;
			sqlite = new SQLiteConnection("Data Source = D:\\Training\\JavaProgram\\BankAccount.db");
			sqlite.Open();
			// cmd = sqlite.CreateCommand();
			string query = "select * from BankAccount";
			cmd = new SQLiteCommand(query, sqlite);
			reader = cmd.ExecuteReader();

			while (reader.Read())
			{
				Console.Write(reader["AccountId"] + " ");
				Console.Write(reader["AccountHolderName"] + " ");
				Console.Write(reader["Balance"] + "\n");
			}
			reader.Close();
			sqlite.Close();
		}
		catch(Exception)
		{

		}

	}

	/*public static void Main(String[] args)
	{
		new cSQLite();
	}*/
}