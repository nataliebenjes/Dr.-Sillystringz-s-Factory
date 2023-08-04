using System.Collections.Generic;

namespace Factory.Models
{
    public class Machine
    {
        public int MachineId { get; set; }
        public string MachineName { get; set; }
        //Add serial no?
        public List<EngineerMachine> JoinEntities { get; }
    }
}