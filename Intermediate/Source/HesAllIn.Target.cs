using UnrealBuildTool;

public class HesAllInTarget : TargetRules
{
	public HesAllInTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("HesAllIn");
	}
}
