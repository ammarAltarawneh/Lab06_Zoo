using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_Zoo.ZooInterfaces
{
    public interface ILifeSpan
    {
        int LifeSpanPeriod { get; set; } 
        void LifeSpan();
    }
}
