using System;
using System.Collections.Generic;
using System.Text;

namespace SepidSystem.Connect
{
    public interface IScanner
    {
        byte[] Scan();
    }

    public class Scanner : IScanner
    {
        public byte[] Scan()
        {
            throw new NotImplementedException();
        }
    }
}
