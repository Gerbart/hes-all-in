using UnrealBuildTool;

public class HesAllInEditorTarget : TargetRules
{
	public HesAllInEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("HesAllIn");
	}
}
