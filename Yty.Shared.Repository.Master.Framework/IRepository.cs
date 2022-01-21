namespace Yty.Shared.Repository.Master.Framework
{
    /// <summary>
    /// Use it to define class is a repository
    /// </summary>
    /// <remarks>User IUnitOfWork</remarks>
    public interface IRepository
    {
        IUnitOfWork UnitOfWork { get; }
    }
}
