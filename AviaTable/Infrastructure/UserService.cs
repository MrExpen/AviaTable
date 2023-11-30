using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AviaTable.Models;
using Newtonsoft.Json;

namespace AviaTable.Infrastructure;

public class UserService : IUserService
{
    private readonly IPathProvider _pathProvider;

    public UserService(IPathProvider pathProvider)
    {
        _pathProvider = pathProvider;
    }

    public async Task Save(IEnumerable<User> users)
    {
        var path = _pathProvider.GetSaveFilePath();

        if (path is null)
            return;

        var json = JsonConvert.SerializeObject(users);
        await File.WriteAllTextAsync(path, json);
    }

    public async Task<IEnumerable<User>> Load()
    {
        var path = _pathProvider.GetLoadFilePath();

        if (path is null || !File.Exists(path))
            return Enumerable.Empty<User>();

        var json = await File.ReadAllTextAsync(path);

        var result = JsonConvert.DeserializeObject<IEnumerable<User>>(json);

        return result ?? Enumerable.Empty<User>();
    }
}