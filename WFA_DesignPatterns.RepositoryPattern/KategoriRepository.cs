namespace WFA_DesignPatterns.RepositoryPattern
{
    using WFA_DesignPatterns.DATA;
    using WFA_DesignPatterns.DATA.Context;

    public class KategoriRepository : SqlRepository<Kategori>
    {
        private DataContext _context;
        public KategoriRepository(WFA_DesignPatterns.DATA.Context.DataContext context)
            : base(context)
        {
            if (_context == null)
                _context = context;


        }


    }


}
