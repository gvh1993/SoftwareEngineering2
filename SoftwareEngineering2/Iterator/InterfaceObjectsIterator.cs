using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftwareEngineering2.InterfaceObjects;

namespace SoftwareEngineering2.Iterator
{
    class InterfaceObjectsIterator : IIterator
    {
        private List<IInterfaceObject> _interfaceObjects;
        private int position;
        public InterfaceObjectsIterator(List<IInterfaceObject> interfaceObjects)
        {
            _interfaceObjects = interfaceObjects;
        }
        public bool HasNext()
        {
            while ()
            {

            }
        }

        public IInterfaceObject Next()
        {
            throw new NotImplementedException();
        }
    }
}
