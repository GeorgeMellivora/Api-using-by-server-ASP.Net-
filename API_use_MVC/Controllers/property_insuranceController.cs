using API_use_MVC.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace API_use_MVC.Controllers
{
    public class property_insuranceController : Controller
    {
        // GET: property_insurance
        public async Task<ActionResult> Index()
        {
            string TargetUri = "https://ins-info.ib.gov.tw/opendata/json-06161601.aspx";

            HttpClient client = new HttpClient();
            client.MaxResponseContentBufferSize = Int32.MaxValue;
            var response = await client.GetAsync(TargetUri);

            if (response.IsSuccessStatusCode)
            {
                string jsonResult = await response.Content.ReadAsStringAsync(); // 讀取回傳的 JSON 資料
                var data = JsonConvert.DeserializeObject<List<property_insuranceData>>(jsonResult); // 解析 JSON 資料到 List<property_insuranceData>

                ViewBag.Result = data; // 將 List<YourDataModel> 傳給檢視使用
                return View(data);
            }
            else
            {
                return View("Error"); // 處理回傳失敗的情況
            }
        }
    }
}