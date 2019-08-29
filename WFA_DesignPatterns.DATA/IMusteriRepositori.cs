using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_DesignPatterns.DATA
{
   public interface IMusteriRepositori
    {
        bool ParaEkle(Musteri musteri, decimal miktar);

        bool ParaEksilt(Musteri musteri, decimal miktar);

    }
}
