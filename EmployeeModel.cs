using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOdotNetAssignment
{
    public class EmployeeModel
    {
        public int emp_id { get; set; }
        public string emp_name { get; set; }
        public long phone_number { get; set; }
        public string city { get; set; }
        public int salary { get; set; }
        
        public DateTime start_date { get; set; }

    }
}
