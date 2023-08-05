using System.Collections.Generic;

namespace Factory.Models
{
    public class Engineer
    {
        public int EngineerId { get; set; }
        public string PersonName { get; set; }
        //Add department?
        public List<EngineerMachine> JoinEntities { get; }
    }
}