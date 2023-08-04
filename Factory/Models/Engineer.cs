using System.Collections.Generic;

namespace Factory.Models
{
    public class Engineer
    {
        public int EngineerId { get; set; }
        public string JobTitle { get; set; }
        //Add department?
        public List<EngineerMachine> JoinEntities { get; }
    }
}