using Newtonsoft.Json;

public sealed class KtaneModule
{
    [JsonProperty("ModuleID")]
    public string ModuleId;

    // [JsonProperty("Name")]
    public string Name;

    public string FileName;

    // [JsonProperty("Origin")]
    public string Origin;

    public string Type;

    public string Quirks;

    public string BossStatus;

    [JsonProperty("SteamID")]
    public string SteamId;

    // [JsonProperty("DefuserDifficulty")]
    public string DefuserDifficulty;

    public string ExpertDifficulty;

    public string TranslationOf;

    public TPDetails TwitchPlays;
}

public sealed class TPDetails
{
    public decimal Score;
}

public sealed class KtaneResponse
{
    [JsonProperty("KtaneModules")]
    public KtaneModule[] Modules;
}