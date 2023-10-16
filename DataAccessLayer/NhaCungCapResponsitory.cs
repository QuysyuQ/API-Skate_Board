using DataAccessLayer.Interface;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
	public partial class NhaCungCapResponsitory : INhaCungCapResponsitory
	{
		public IDatabaseHelper _dbHelper;
		public NhaCungCapResponsitory(IDatabaseHelper databaseHelper)
		{
			_dbHelper = databaseHelper;
		}

		public List<NhaCungCapModel> GetallNhaCungCap()
		{
			string msgError = "";
			try
			{
				var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "getallnhacungcap");
				if (!string.IsNullOrEmpty(msgError))
					throw new Exception(msgError);
				return dt.ConvertTo<NhaCungCapModel>().ToList();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public bool Create(NhaCungCapModel model)
		{
			string msgError = "";
			try
			{
				string result = "";
				var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_create_nhacungcap",
					"@SupplierID", model.SupplierID,
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

		public bool Update(NhaCungCapModel model)
		{
			string msgError = "";
			try
			{
				string result = "";
				var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_update_nhacungcap",
					"@SupplierID", model.SupplierID,
					"@SupplierName", model.SupplierName,
					"@Address", model.Address,
					"@phone", model.Phone,
					"@Email", model.Email);
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
				var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_delele_nhacungcap",
					"@SupplierID", id);
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
