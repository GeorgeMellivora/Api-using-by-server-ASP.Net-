using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_use_MVC.Models
{
    public class StockData
    {
        public string OccurDate { get; set; }
        public string OccurSeason { get; set; }
        public string INSURER_Name { get; set; }
        public string StockholderName { get; set; }
        public string Shares { get; set; }
        public string SharesRatio { get; set; }
        public string PledgeShares { get; set; }
        public string PledgeSharesRatio { get; set; }
    }
}