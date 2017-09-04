using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Password.Interface;
using Password.Entity;
using Password.Common;

namespace Password.BLL
{
    public class BaseManager
    {
        protected SendBackParameter sendBackParameter { private set; get; }
        public BaseManager(SendBackParameter sendBackParameter)
        {
            this.sendBackParameter = sendBackParameter;
        }
    }
}
