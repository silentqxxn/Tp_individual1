// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class TPN1 : ModuleRules
{
	public TPN1(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"TPN1",
			"TPN1/Variant_Platforming",
			"TPN1/Variant_Platforming/Animation",
			"TPN1/Variant_Combat",
			"TPN1/Variant_Combat/AI",
			"TPN1/Variant_Combat/Animation",
			"TPN1/Variant_Combat/Gameplay",
			"TPN1/Variant_Combat/Interfaces",
			"TPN1/Variant_Combat/UI",
			"TPN1/Variant_SideScrolling",
			"TPN1/Variant_SideScrolling/AI",
			"TPN1/Variant_SideScrolling/Gameplay",
			"TPN1/Variant_SideScrolling/Interfaces",
			"TPN1/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
