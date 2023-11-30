namespace AviaTable.Infrastructure;

public interface IPathProvider
{
    string? GetSaveFilePath();

    string? GetLoadFilePath();
}