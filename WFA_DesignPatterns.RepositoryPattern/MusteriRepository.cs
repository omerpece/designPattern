using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_DesignPatterns.RepositoryPattern
{
    using System.Linq.Expressions;
    using WFA_DesignPatterns.DATA;
    using WFA_DesignPatterns.DATA.Context;

    public class MusteriRepository : SqlRepository<Musteri>, IMusteriRepositori
    {
        private DataContext _context;
        public MusteriRepository(WFA_DesignPatterns.DATA.Context.DataContext context)
            : base(context)
        {
            if (_context == null)
                _context = context;
        }

        public bool ParaEkle(Musteri musteri, decimal miktar)
        {
            if (miktar > 0)
            {
                musteri.Bakiye += miktar;
                return true;
            }
            return false;
        }

        public bool ParaEksilt(Musteri musteri, decimal miktar)
        {
            if (miktar >0 && musteri.Bakiye >= miktar)
            {
                musteri.Bakiye -= miktar;
                return true;
            }
            return false;

        }
    }
}
