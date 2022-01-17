using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingMaterialStore
{
    static class Helper
    {
        public static void FillBindingList<T>(IList<T> src, BindingList<T> dest)
        {
            dest.Clear();
            while(src.Count>0)
            {
                dest.Add(src[0]);
                src.RemoveAt(0);
            }

        }

    }
}
