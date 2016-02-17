using System;
using System.Collections.Generic;
namespace GenWebScrape {
    
    public partial class DB {

        public void CleanExpiredResults()
        {
            List<ResultSetsRow> toRemove = new List<ResultSetsRow>();

            foreach (ResultSetsRow row in ResultSets.Rows)
            {
                if (row.StartTime + row.Expiration >= DateTime.Now) toRemove.Add(row);
            }

            foreach (ResultSetsRow row in toRemove) ResultSets.Rows.Remove(row);
        }

        public void FillLookupTables()
        {
            //Fill Lookup Tables
            /*if (AlertComparison.Rows.Count == 0)
            {
                AlertComparison.AddAlertComparisonRow(">");
                AlertComparison.AddAlertComparisonRow(">=");
                AlertComparison.AddAlertComparisonRow("<=");
                AlertComparison.AddAlertComparisonRow("<");
                AlertComparison.AddAlertComparisonRow("==");
                AlertComparison.AddAlertComparisonRow("!=");
            }*/

            if (ParamType.Rows.Count == 0)
            {
                ParamType.AddParamTypeRow("Integer");
                ParamType.AddParamTypeRow("Decimal");
                ParamType.AddParamTypeRow("Text");
            }

            if (ResultFieldType.Rows.Count == 0)
            {
                ResultFieldType.AddResultFieldTypeRow("Text");
                ResultFieldType.AddResultFieldTypeRow("Link");
                ResultFieldType.AddResultFieldTypeRow("Picture");
            }

            if (PagingType.Rows.Count == 0)
            {
                PagingType.AddPagingTypeRow("URL Parameter");
                PagingType.AddPagingTypeRow("Cookie");
                //PagingType.AddPagingTypeRow("Javascript");
            }
        }
    }
}
