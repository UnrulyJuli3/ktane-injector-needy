using Newtonsoft.Json;
// using wawa.Schemas;

public sealed class InjectorModSettings
{
    /* private static readonly TweaksEditorSettings TweaksEditorSettings = TweaksEditorSettings
        .CreateListing("Injector")
        .Register<InjectorModSettings>()
        .BuildAndClear(); */

    // [TweaksSetting("If empty, this setting will be ignored. Otherwise, ONLY these mod IDs will be allowed to show up on the needy.")]
    public string[] WhitelistModIds = new string[0];

    [JsonIgnore]
    public bool HasWhitelist => WhitelistModIds.Length > 0;
}