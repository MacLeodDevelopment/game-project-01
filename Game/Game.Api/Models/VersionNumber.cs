namespace Game.Api.Models;

public class VersionNumber
{
    private static int _major;
    private static int _minor;
    private static int _patch;

    public string Version => $"{_major}.{_minor}.{_patch}";

    public VersionNumber()
    {
        _major = 1;
        _minor = 0;
        _patch = 0;
    }
}