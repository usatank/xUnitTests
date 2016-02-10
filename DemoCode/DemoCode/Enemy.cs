using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCode
{
    public abstract class Enemy
    {
        private string _name = "Default Name";

        public string Name
        {
            get { return _name; }
            set { this._name = value;  }
        }
    }
}
