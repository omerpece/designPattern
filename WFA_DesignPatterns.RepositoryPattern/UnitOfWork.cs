using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_DesignPatterns.RepositoryPattern
{

    using WFA_DesignPatterns.DATA.Context;
    public class UnitOfWork
    {
        readonly DataContext _context;

        public UnitOfWork()
        {
            _context = new DataContext();
            // hantal yuklenme kontrolu. birbirine baglı nesneler gelmeyecek 
            //default u true dur 

            _context.Configuration.LazyLoadingEnabled = false;
            _context.Database.CommandTimeout = 36000;
        }

        private MusteriRepository _musteriRepository;
      

        internal MusteriRepository MusteriRepository
        {
            get
            {
                if (_musteriRepository == null)
                    _musteriRepository = new MusteriRepository(_context);

                return _musteriRepository;
                
            }
            set
            {
                _musteriRepository = value;
            }
        }


       


        private KategoriRepository _kategoriRepository;
        

        internal KategoriRepository KategoriRepository
        {
            get
            {
                if (_kategoriRepository == null)
                    _kategoriRepository = new KategoriRepository(_context);

                return _kategoriRepository;

            }
            set
            {
                _kategoriRepository = value;
            }
        }
        private OgrenciRepository _ogrenciRepository;


        internal OgrenciRepository OgrenciRepository
        {
            get
            {
                if (_ogrenciRepository == null)
                    _ogrenciRepository = new OgrenciRepository(_context);

                return _ogrenciRepository;

            }
            set
            {
                _ogrenciRepository = value;
            }
        }




        public int Save()
        {
            return _context.SaveChanges();
        }




    }
}
