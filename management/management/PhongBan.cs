using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace management
{
    class PhongBan
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public PhongBan(int id, string name)
        {
            this.ID = id;
            this.Name = name;
            
        }
    }
}
