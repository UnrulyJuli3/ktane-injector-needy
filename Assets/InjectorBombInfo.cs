using System.Collections.Generic;

public sealed class InjectorBombInfo : ModBombInfo
{
    private InjectorNeedy Module => GetComponentInParent<InjectorNeedy>();

    private void Assign()
    {
        var info = GetComponent<KMBombInfo>();
        info.TimeHandler = GetTimeCustom;
        info.FormattedTimeHandler = GetFormattedTimeCustom;
        info.StrikesHandler = GetStrikesCustom;
        info.ModuleNamesHandler = GetModuleNamesCustom;
        info.SolvableModuleNamesHandler = GetSolvableModuleNamesCustom;
        info.SolvedModuleNamesHandler = GetSolvedModuleNamesCustom;
        info.ModuleIDsHandler = GetModuleIDsCustom;
        info.SolvableModuleIDsHandler = GetSolvableModuleIDsCustom;
        info.SolvedModuleIDsHandler = GetSolvedModuleIDsCustom;
    }

    private void OnEnable()
    {
        Assign();
    }

    private void Start()
    {
        Assign();
    }

    private float GetTimeCustom() => Module ? Module.GetBombInfoTime() : GetTime();

    private string GetFormattedTimeCustom() => Module ? Module.GetBombInfoFormattedTime() : GetFormattedTime();

    private int GetStrikesCustom() => Module ? Module.GetBombInfoStrikes() : GetStrikes();

    private List<string> GetModuleNamesCustom() => Module ? Module.GetBombInfoModuleNames() : GetModuleNames();

    private List<string> GetSolvableModuleNamesCustom() => Module ? Module.GetBombInfoSolvableModuleNames() : GetSolvableModuleNames();

    private List<string> GetSolvedModuleNamesCustom() => Module ? Module.GetBombInfoSolvedModuleNames() : GetSolvedModuleNames();

    private List<string> GetModuleIDsCustom() => Module ? Module.GetBombInfoModuleIDs() : GetModuleTypes();

    private List<string> GetSolvableModuleIDsCustom() => Module ? Module.GetBombInfoSolvableModuleIDs() : GetSolvableModuleTypes();

    private List<string> GetSolvedModuleIDsCustom() => Module ? Module.GetBombInfoSolvedModuleIDs() : GetSolvedModuleTypes();
}