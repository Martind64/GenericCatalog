using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCatalog
{
    public class Student : IIdentifiable
    {
        public int Id { get; private set; }
    }
}
