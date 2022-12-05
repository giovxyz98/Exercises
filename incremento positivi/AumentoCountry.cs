using System;

namespace incremento_positivi
{
    public class AumentoCountry:EventArgs
    {
       public int Pos;
        public AumentoCountry(int x)
        {
            this.Pos += x;
        }


    }
}
