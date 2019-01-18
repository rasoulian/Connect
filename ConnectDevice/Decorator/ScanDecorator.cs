namespace ConnectDevice
{
    public class ScanDecorator : IScan
    {
        private readonly IScan _decoratedScanner;

        public ScanDecorator(IScan d)
        {
            this._decoratedScanner = d;
        } 

        public virtual string GetCard()
        {
            return _decoratedScanner.GetCard();
        }

        public virtual string GetFace()
        {
            return _decoratedScanner.GetFace(); 
        }

        public virtual string GetFinger()
        {
            return _decoratedScanner.GetFinger();
        }

        public virtual string GetTag()
        {
            return _decoratedScanner.GetTag();
        }
    }

}
