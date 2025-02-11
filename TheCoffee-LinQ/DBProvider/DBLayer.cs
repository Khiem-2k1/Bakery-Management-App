using System;
using System.Data;
using System.Data.SqlClient;

namespace DBProvider
{
	public class DBLayer
	{
		SqlConnection cnn;
		SqlCommand cmd;
		SqlDataAdapter adp;

		///Thông tin local database để kết nối
		string strConnect = @"Data Source=KHIEM;Initial Catalog=DIEPFAMILY;Integrated Security=True";

		/*public DBLayer()
		{
			///constructor
			cnn = new SqlConnection(strConnect);
			cmd = cnn.CreateCommand();
		}*/
		/*public DataSet ExecuteQueryDataSet(string strSQL, CommandType ct, params SqlParameter[] param)
		{
            ///strSQL: LỆNH truy vấn 
            ///ct: KIỂU truy vấn
            ///param: DANH SÁCH THAM SỐ truyền vào (id, ... )
			///thực hiện:  Thực thi câu lệnh SQL, và trả về 1 data table
			///trả về: 1 data table
            Console.WriteLine(strSQL);
			cmd.Parameters.Clear();
			cmd.CommandText = strSQL;
			cmd.CommandType = ct;

			if (param != null)
			{
				foreach (SqlParameter p in param)
					cmd.Parameters.Add(p);
			}

			adp = new SqlDataAdapter(cmd);
			DataSet ds = new DataSet();
			adp.Fill(ds);
			return ds;
		}*/


		 
	}
}
