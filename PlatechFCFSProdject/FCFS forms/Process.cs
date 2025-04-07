using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatechFCFSProdject
{
    public class Process
    {
        public string ProcessID { get; set; }
        public float ArrivalTime { get; set; }
        public float BurstTime { get; set; }
        public float StartTime { get; set; }
        public float CompletionTime { get; set; }
        public float TurnaroundTime { get; set; }
        public float WaitingTime { get; set; }
        public float PWT { get; set; }
        public float PCT { get; set; }
        public float PTAT { get; set; }
    }
}
