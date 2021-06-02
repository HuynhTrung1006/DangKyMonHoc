using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WPF_Admin_DangKyMonHoc.ModelsClass;

namespace WPF_Admin_DangKyMonHoc.XuLy
{
	class CXulyQLNV
	{
		private static HttpClient hc = new HttpClient();
		public static List<NhanVien> getAllDSNV()
		{
			string url = @"https://localhost:44357/api/qlnv";
			var kq = hc.GetAsync(url);
			kq.Wait();
			var ok = kq.Result.Content;
			var list = ok.ReadAsAsync<List<NhanVien>>();
			return list.Result.ToList();
		}
		public static bool PostThemNV(NhanVien a)
		{
			try
			{
				string url = @"https://localhost:44357/api/qlnv";
				var kq = hc.PostAsJsonAsync(url, a);
				kq.Wait();
				return kq.Result.IsSuccessStatusCode;
			}
			catch (Exception)
			{
				return false;
			}
		}
		public static bool DeleteXoaNV(string id)
		{
			try
			{
				string url = @"https://localhost:44357/api/qlnv/" + id;
				var kq = hc.DeleteAsync(url);
				kq.Wait();
				return kq.Result.IsSuccessStatusCode;
			}
			catch(Exception)
			{
				return false;
			}
		}
		public static bool PutSuaNV(NhanVien a)
		{
			try
			{
				string url = @"https://localhost:44357/api/qlnv";
				var kq = hc.PutAsJsonAsync(url, a);
				kq.Wait();
				return kq.Result.IsSuccessStatusCode;
			}
			catch (Exception)
			{ 
				return false;
			}

			
		}
	}
}
