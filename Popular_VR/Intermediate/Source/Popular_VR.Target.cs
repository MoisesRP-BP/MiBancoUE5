using UnrealBuildTool;

public class Popular_VRTarget : TargetRules
{
	public Popular_VRTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Popular_VR");
	}
}
