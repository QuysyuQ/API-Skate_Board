using DataAccessLayer.Interface;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
	public partial class HoaDonResponsitory : IHoaDonResponsitory
	{
		private IDatabaseHelper _dbHelper;
		public HoaDonResponsitory(IDatabaseHelper _dbHelper)
		{
			_dbHelper = dbHelper;
		}

		public HoaDonModel GetDatabyID(int id)
		{
			string msgError = "";
			try
			{
				var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_hoadon_get_by_id",
					 "@MaHoaDon", id);
				if (!string.IsNullOrEmpty(msgError))
					throw new Exception(msgError);
				return dt.ConvertTo<HoaDonModel>().FirstOrDefault();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public bool Create(HoaDonModel model)
		{
			string msgError = "";
			try
			{
				{
					var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "sp_hoadon_create",
					"@InvoiceID", model.InvoiceID,
					"@InvoiceDate", model.InvoiceDate,
					"@SupplierID", model.SupplierID);
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
}