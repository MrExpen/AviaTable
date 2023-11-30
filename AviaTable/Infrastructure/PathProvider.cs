using Microsoft.Win32;

namespace AviaTable.Infrastructure;

public class PathProvider : IPathProvider
{
    public string? GetSaveFilePath()
    {
        var saveFileDialog = new SaveFileDialog();
        return saveFileDialog.ShowDialog() == true ? saveFileDialog.FileName : null;
    }
    
    public string? GetLoadFilePath()
    {
        var openFileDialog = new OpenFileDialog { Multiselect = false };
        return openFileDialog.ShowDialog() == true ? openFileDialog.FileName : null;
    }
}