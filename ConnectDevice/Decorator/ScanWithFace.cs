namespace ConnectDevice
{
    public class ScanWithFace : ScanDecorator
    {
        public ScanWithFace(IScan s) : base(s)
        { }

        public override string GetFace()
        {
            return base.GetFace() + ", Scan Face by ";
        }
    }

}
