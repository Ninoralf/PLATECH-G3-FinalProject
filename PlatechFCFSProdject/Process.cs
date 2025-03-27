using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatechFCFSProdject
{
    class Process
    {
        public string Name { get; set; }
        public int ArrivalTime { get; set; }
        public int BurstTime { get; set; }
        public int StartTime { get; set; }
        public int CompletionTime { get; set; }
        public int TurnaroundTime { get; set; }
        public int WaitingTime { get; set; }
    }
}
