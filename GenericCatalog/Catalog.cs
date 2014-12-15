using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GenericCatalog
{
    public class Catalog<TElement> where TElement : IIdentifiable
    {
        private IList<TElement> _element = new List<TElement>();
        private readonly int count;

        public Catalog()
        {
            _element = new List<TElement>();
        }

        public bool Add(TElement element)
        {
            if (_element.Contains(element))
            {
                return false;
            }

            _element.Add(element);
            return true;
        }

        private TElement Find(int id)
        {
            foreach (var element in _element)
            {
                if (element.Id.Equals(id))
                {
                    return element;
                }
                return default (TElement);
            }


        }

        public int Count()
        {
            return _element.Count;
        }

        public IList<TElement> GetAll()
        {
            return _element;
        }

        public override string ToString()
        {
            return string.Join(", ", _element);
        }
    }
}
