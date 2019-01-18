namespace SepidSystem.Connect
{
    public class ScanWithTag : ScanDecorator
    {
        public ScanWithTag(IScan d) : base(d)
        { }

        public override string GetTag()
        {
            return base.GetTag() + ", Scan Tag";
        }

    }

}
