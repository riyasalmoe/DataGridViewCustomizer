using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridViewCustomizer
{
    public class SampleModel
    {
        

        public string UID { get; set; }
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public decimal Limit { get; set; }
        public string MobileNumber { get; set; }

        public SampleModel(Random rnd)
        {
            rnd.Next();
            UID = Guid.NewGuid().ToString().Trim();
            Id = rnd.Next(maxValue: 100);
            CustomerName = $"Customer {Id}";
            Address = $"Address {Id}";
            Limit = rnd.Next(minValue: 20000, maxValue: 100000);
            MobileNumber = $"050{rnd.Next(minValue: 2041234, maxValue: 9999999)}";
        }
    }
}
