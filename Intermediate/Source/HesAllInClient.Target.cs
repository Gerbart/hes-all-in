using UnrealBuildTool;

public class HesAllInClientTarget : TargetRules
{
	public HesAllInClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("HesAllIn");
	}
}
