using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Manager
{
    class contract
    {
        public object Text;

        public string Newfile(string text)
        {
            Text = text;
            string Contract = text;
            if (!File.Exists(Contract))
            {
                File.CreateText(Contract);
            }
            return text;

        }

    }
}
