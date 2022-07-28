using OpenDmsCore.Core.Entities;
using System;
using System.Threading.Tasks;

namespace OpenDmsCore.Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Document> DocumentRepository { get; }
        IRepository<Company> GroupRepository { get; }
        IRepository<Mimetype> MimetypeRepository { get; }
        IRepository<Team> TeamRepository { get; }
        IRepository<User> UserRepository { get; }

        void SaveChanges();
        Task SAveChangesAsync();
    }
}
