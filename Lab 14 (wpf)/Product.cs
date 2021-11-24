using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_14__wpf_
{
    public enum Category
    {
        Food,
        Appliances
    }
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Picture { get; set; }
        public Category category { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
