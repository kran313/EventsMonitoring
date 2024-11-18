using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsMonitoring.CommonClasses
{
    public class Branch
    {
        public string sport { get; set; }
        public string branchId { get; set; }
        public string branchName { get; set; }


        public Branch(string sport, string branchId, string branchName)
        {
            this.sport = sport;
            this.branchId = branchId;
            this.branchName = branchName;
        }

        public override string ToString()
        {
            return branchName;
        }
    }
}
