using System;
using System.Collections.Generic;
using System.Text;

namespace SepidSystem.Connect
{
    public interface IScan
    {
        string GetFinger();
        string GetFace();
        string GetCard();
        string GetTag();
    }

    public class SimpleScan : IScan
    {
        public string GetFinger()
        {
            return 2312313.ToString("X");
        }
        public string GetFace()
        {
            return 123123123.ToString("X");
        }
        public string GetCard()
        {
            return 1231231.ToString("X");
        }
        public string GetTag()
        {
            return 12361231.ToString("X");
        }
    }

}
