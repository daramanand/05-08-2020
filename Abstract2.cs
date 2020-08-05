using System;

namespace Bizruntime
{
    internal class Abstract2
    {
#pragma warning disable IDE1006 // Naming Styles
        public void getVendorID()
#pragma warning restore IDE1006 // Naming Styles
        {
            int s = new int();
            s = 001;
            Console.Write(s);
        }

#pragma warning disable IDE1006 // Naming Styles
        public void getSeqID()
#pragma warning restore IDE1006 // Naming Styles
        {
            int SeqID = new int();
            SeqID = 001;
            Console.Write(SeqID);
        }
    }
}

