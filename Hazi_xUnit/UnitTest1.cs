using Xunit;
using System;

namespace teszteles
{
    public class Szamolo
    {
        public int Duplaz(int szam)
        {
            return szam * 2;
        }
    }
}


namespace teszteles.Tests
{
    public class SzamoloTeszt
    {
        [Fact] 
        public void duplaz_szamot()
        {
            var szamolo = new Szamolo(); 
            int bemenet = 4;
            int elvart = 8;

 
            int tenyleges = szamolo.Duplaz(bemenet);


            Assert.Equal(elvart, tenyleges); 

        }
    }
}