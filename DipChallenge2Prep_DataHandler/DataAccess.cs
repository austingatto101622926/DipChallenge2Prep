using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DipChallenge2Prep_DataHandler
{
    public class DataAccess
    {
        public ControllerHandler<Type> Handler;

        public DataAccess(string baseAddress)
        {
            Handler = new ControllerHandler<Type>(baseAddress, "controlPath"); 
        }
    }
}
