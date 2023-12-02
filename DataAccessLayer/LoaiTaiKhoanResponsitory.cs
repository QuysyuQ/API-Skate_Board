using DataAccessLayer.Interface;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
	public partial class LoaiTaiKhoanResponsitory : ILoaiTaiKhoanResponsitory
	{
		public IDatabaseHelper _dbHelper;
		public LoaiTaiKhoanResponsitory(IDatabaseHelper dbHelper)
		{
			_dbHelper = dbHelper;
		}
		public List<LoaiTaiKhoanModel> GetallLoaiTaiKhoan()
		{
			string msgError = "";
			try
			{
				var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_get_all_loaitaikhoan");
				if (!string.IsNullOrEmpty(msgError))
					throw new Exception(msgError);
				return dt.ConvertTo<LoaiTaiKhoanModel>().ToList();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public bool Create(LoaiTaiKhoanModel model)
		{
			string msgError = "";
			try
			{
				string result = "";
				var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_create_loaitaikhoan",
					"@AccountTypeID", model.AccountTypeID,
					"@TypeName", model.TypeName);
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

		public bool Update(LoaiTaiKhoanModel model)
		{
			string msgError = "";
			try
			{
				string result = "";
				var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_update_loaitaikhoan",
					"@AccountTypeID", model.AccountTypeID,
					"@TypeName", model.TypeName);
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

		public bool Delete(int id)
		{
			string msgError = "";
			try
			{
				string result = "";
				var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_delete_loaitaikhoan",
					"@AccountTypeID", id);
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
