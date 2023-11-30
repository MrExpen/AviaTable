using System.Collections.Generic;
using System.Threading.Tasks;
using AviaTable.Models;

namespace AviaTable.Infrastructure;

public interface IUserService
{
    Task Save(IEnumerable<User> users);

    Task<IEnumerable<User>> Load();
}