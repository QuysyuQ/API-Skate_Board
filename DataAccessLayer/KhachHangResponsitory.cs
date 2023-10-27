using DataAccessLayer.Interface;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
	public partial class KhachHangResponsitory : IKhachHangResponsitory
	{
		public IDatabaseHelper _dbHelper;
		public KhachHangResponsitory(IDatabaseHelper databaseHelper)
		{
			_dbHelper = databaseHelper;
		}
		public List<KhachHangModel> GetallKhachHang()
		{
			string msgError = "";
			try
			{
				var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "getallkhachhang");
				if (!string.IsNullOrEmpty(msgError))
					throw new Exception(msgError);
				return dt.ConvertTo<KhachHangModel>().ToList();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}


		public bool create(KhachHangModel model)
		{
			string msgError = "";
			try
			{
				string result = "";
				var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_create_khachhang",
					"@Customerid",model.CustomerID,
					"@FirstName", model.FirstName,
					"@LastName", model.LastName,
					"@Email", model.Email,
					"phone", model.Phone,
					"@Address", model.Address);
				if ((result != null && !string.IsNullOrEmpty(result.ToString())) || !string.IsNullOrEmpty(msgError))
				{
					throw new Exception(Convert.ToString(result) + msgError);
				}
				return true;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public bool update(KhachHangModel model)
		{
			string msgError = "";
			try
			{
				string result = "";
				var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_update_khachang",
					"@CustomerID", model.CustomerID,
					"@FirstName", model.FirstName,
					"@LastName", model.LastName,
					"@Email", model.Email,
					"phone", model.Phone,
					"@Address", model.Address);
				if ((result != null && !string.IsNullOrEmpty(result.ToString())) || !string.IsNullOrEmpty(msgError))
				{
					throw new Exception(Convert.ToString(result) + msgError);
				}
				return true;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public bool delete(int id)
		{
			string msgError = "";
			try
			{
				string result = "";
				var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_delele_khachhang",
					"@CustomerID", id);
				if ((result != null && !string.IsNullOrEmpty(result.ToString())) || !string.IsNullOrEmpty(msgError))
				{
					throw new Exception(Convert.ToString(result) + msgError);
				}
				return true;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

	}
}
