using SoftwareEngineering2.InterfaceObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineering2.Iterator
{
    class InterFaceObjectsCollection : IInterfaceObjectsCollection
    {
        private List<IInterfaceObject> _interfaceObjects;

        public InterFaceObjectsCollection()
        {
            _interfaceObjects = new List<IInterfaceObject>();
        }
        public IIterator Iterator()
        {
            return new InterfaceObjectsIterator(_interfaceObjects);
        }
    }
}
