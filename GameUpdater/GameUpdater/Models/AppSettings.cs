namespace GameUpdater.Models;

/// <summary>
/// Application settings loaded from appsettings.json
/// </summary>
public class AppSettings
{
    public LauncherSettings LauncherSettings { get; set; } = new();
    public SocialLinks SocialLinks { get; set; } = new();
    public UISettings UISettings { get; set; } = new();
}

/// <summary>
/// Core launcher settings for update and game functionality
/// </summary>
public class LauncherSettings
{
    public string PatchUrl { get; set; } = "http://localhost/7dtd/patch.json";
    public string UpdateBaseUrl { get; set; } = "http://localhost/7dtd/update/";
    public string NewsUrl { get; set; } = "http://localhost/7dtd/api/news.php";
    public string WebContentUrl { get; set; } = "http://localhost/7dtd/";
    public string GameExecutable { get; set; } = "7DaysToDie.exe";
    public bool SkipUpdateOnStartup { get; set; } = false;
    public bool MinimizeOnGameLaunch { get; set; } = true;
    public bool CloseOnGameLaunch { get; set; } = false;
}

/// <summary>
/// Social media and website URLs
/// </summary>
public class SocialLinks
{
    public string WebsiteUrl { get; set; } = "https://7daystodie.com";
    public string ShopUrl { get; set; } = "https://7daystodie.com/shop";
    public string SupportUrl { get; set; } = "https://7daystodie.com/support";
    public string DiscordUrl { get; set; } = "https://discord.gg/7daystodie";
    public string YoutubeUrl { get; set; } = "";
    public string FacebookUrl { get; set; } = "";
    public string InstagramUrl { get; set; } = "";
    public string TwitterUrl { get; set; } = "";
}

/// <summary>
/// UI customization settings
/// </summary>
public class UISettings
{
    public string Theme { get; set; } = "DarkGaming";
    public string AccentColor { get; set; } = "#00A3FF";
    public bool ShowNewsPanel { get; set; } = true;
    public bool AnimationsEnabled { get; set; } = true;
}
