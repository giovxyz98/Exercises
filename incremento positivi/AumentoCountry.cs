using System;

namespace incremento_positivi
{
    public class AumentoCountry:EventArgs
    {
        int Pos;
        public AumentoCountry(int x)
        {
            this.Pos += x;
        }


    }
}
