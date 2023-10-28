using DataAccessLayer.Interface;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
	public partial class ChiTietHDNResponsitory : IChiTietHDNResponsitory
	{
		private IDatabaseHelper _dbHelper;
		public ChiTietHDNResponsitory(IDatabaseHelper dbHelper)
		{
			_dbHelper = dbHelper;
		}
		public List<ChiTietHDNModel> GetallChiTietHDN()
		{
			string msgError = "";
			try
			{
				var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_get_all_chitietHDN");
				if (!string.IsNullOrEmpty(msgError))
					throw new Exception(msgError);
				return dt.ConvertTo<ChiTietHDNModel>().ToList();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public bool Create(ChiTietHDNModel model)
		{
			string msgError = "";
			try
			{
				string result = "";
				var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_create_chitietHDN",
				"@InvoiceDetailID", model.InvoiceDetailID,
				"@InvoiceID", model.InvoiceID,
				"@ProductID", model.ProductID,
				"@Quantity", model.Quantity,
				"@UnitPrice", model.UnitPrice);
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

		public bool Update(ChiTietHDNModel model)
		{
			string msgError = "";
			try
			{
				string result = "";
				var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_update_chitietHDN",
				"@InvoiceDetailID", model.InvoiceDetailID,
				"@InvoiceID", model.InvoiceID,
				"@ProductID", model.ProductID,
				"@Quantity", model.Quantity,
				"@UnitPrice", model.UnitPrice);
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
				var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_update_chitietHDN",
				"@InvoiceDetailID", id);
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
