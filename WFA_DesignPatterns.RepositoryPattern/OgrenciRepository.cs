namespace WFA_DesignPatterns.RepositoryPattern
{
    using WFA_DesignPatterns.DATA;
    using WFA_DesignPatterns.DATA.Context;

    public class OgrenciRepository : SqlRepository<Musteri>
    {
        private DataContext _context;
        public OgrenciRepository(WFA_DesignPatterns.DATA.Context.DataContext context)
            : base(context)
        {
            if (_context == null)
                _context = context;


        }


    }


}
