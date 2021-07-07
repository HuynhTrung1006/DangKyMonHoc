using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Wpf_DangKyMonHoc.Models;

namespace Wpf_DangKyMonHoc.XuLy
{
    class XLAnh
    {
		private static HttpClient hc = new HttpClient();
		private  Xuly_Chung xlc = new Xuly_Chung();
		public static bool Post(FileUpload a)
		{
			try
			{
				string url = @"https://localhost:44319/api/FileUploads";
				var kq = hc.PostAsJsonAsync(url, a);
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
