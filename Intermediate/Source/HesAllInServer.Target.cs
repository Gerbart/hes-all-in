using UnrealBuildTool;

public class HesAllInServerTarget : TargetRules
{
	public HesAllInServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("HesAllIn");
	}
}
