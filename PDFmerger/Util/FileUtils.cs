public static class FileUtils
{
    /// <summary>
    /// ファイルサイズ表記の整理
    /// </summary>
    /// <param name="size"></param>
    /// <param name="scale"></param>
    /// <param name="standard"></param>
    /// <returns></returns>
    public static string ToReadableSize(double size, int scale = 0, int standard = 1024)
    {
        var unit = new[] { "B", "KB", "MB", "GB" };
        if (scale == unit.Length - 1 || size <= standard)
        {
            return $"{size.ToString(".##")} {unit[scale]}";
        }
        return ToReadableSize(size / standard, scale + 1, standard);
    }
}