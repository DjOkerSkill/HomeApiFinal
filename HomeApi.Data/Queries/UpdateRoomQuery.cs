using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeApi.Data.Queries
{
    public class UpdateRoomQuery
    {
        public string Name { get; set; }
        public int NewVoltage { get; set; }

        public UpdateRoomQuery (string name, int newVoltage) 
        { Name = name; NewVoltage = newVoltage; }
    }
}
