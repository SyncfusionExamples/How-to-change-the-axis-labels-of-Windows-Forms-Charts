using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStarted_Chart
{
    public class SalesData
    {
        private double item;

        private double sales;

        public double Item
        {
            get { return item; }

            set { item = value; }
        }
        public double Sales
        {
            get { return sales; }

            set { sales = value; }
        }

        public SalesData(double item, double sales)
        {
            this.Item = item;

            this.sales = sales;
        }
    }
}