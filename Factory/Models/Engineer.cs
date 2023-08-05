using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
    public class Engineer
    {
        public int EngineerId { get; set; }
        [Required(ErrorMessage = "The engineer must have a name!")]
        public string PersonName { get; set; }
        //Add department?
        public List<EngineerMachine> EngineerMachines { get; set; }
    }
}