using System;
using System.Collections.Generic;
using System.Text;
using WebApiHelpersTypes.Helpers;

namespace OrdersDtoTypes.Helpers
{
    public class OrdersPagingParameters : PagingParameters
    {
        //Search values for the orders
        public string Id { get; set; }
        public string DatePlaced { get; set; }
        public string CustomerId { get; set; }
    }
}
