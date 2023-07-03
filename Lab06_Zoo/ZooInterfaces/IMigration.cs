using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
using System.Threading.Tasks;

namespace Lab06_Zoo.ZooInterfaces
{
    public interface IMigration
    {
         int MigrationDestance { get; set; }
        void MigrationHapit();
    }
}
