namespace SepidSystem.Connect
{
    public class ScanWithBioMini : ScanDecorator
    {
        public ScanWithBioMini(IScan s) : base(s)
        { }

        public override string GetFinger()
        {
            return base.GetFinger() + ", Scan Finger by BioStar";
        }
    }

}
