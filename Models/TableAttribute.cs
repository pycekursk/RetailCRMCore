using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailCRMCore.Models
{
    public class TableAttribute : Attribute
    {
        public string? ColumnName { get; set; }

        public TableAttribute(string columnName)
        {
            ColumnName = columnName;
        }
    }

    public class ActionAttribute : Attribute
    {
        public string ActionName { get; set; }

        public ActionAttribute(string actionName)
        {
            ActionName = actionName;
        }
    }
}
