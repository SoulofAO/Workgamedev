using UnrealBuildTool;

public class WorkTarget : TargetRules
{
	public WorkTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("Work");
	}
}
