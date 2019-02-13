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

    public class Scan
    {
        private readonly IScanner _scanner;

        public Scan(IScanner scanner)
        {
            _scanner = scanner;
            
        }

        public byte[] GetFinger()
        {
            return _scanner.Scan();
        }
    }
}
