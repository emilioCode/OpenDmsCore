using OpenDmsCore.Core.Entities;
using OpenDmsCore.Core.Interfaces;
using OpenDmsCore.Infrastructure.Data;
using System.Threading.Tasks;

namespace OpenDmsCore.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly OPEN_DMSContext _context;

        private readonly IRepository<Document> _documentRepository;
        private readonly IRepository<Company> _groupRepository;
        private readonly IRepository<Mimetype> _mimeTypeRepository;
        private readonly IRepository<Team> _teamRepository;
        private readonly IRepository<User> _userRepository;


        public UnitOfWork(OPEN_DMSContext context)
        {
            _context = context;
        }

        public IRepository<Document> DocumentRepository => _documentRepository ?? new BaseRepository<Document>(_context);

        public IRepository<Company> GroupRepository => _groupRepository ?? new BaseRepository<Company>(_context);

        public IRepository<Mimetype> MimetypeRepository => _mimeTypeRepository ?? new BaseRepository<Mimetype>(_context);

        public IRepository<Team> TeamRepository => _teamRepository ?? new BaseRepository<Team>(_context);

        public IRepository<User> UserRepository => _userRepository ?? new BaseRepository<User>(_context);

        public void Dispose()
        {
            if(_context != null)
            {
                _context.Dispose();
            }
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public async Task SAveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
