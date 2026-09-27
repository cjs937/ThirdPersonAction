// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class ActionGameTesting : ModuleRules
{
	public ActionGameTesting(ReadOnlyTargetRules Target) : base(Target)
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
			"ActionGameTesting",
			"ActionGameTesting/Variant_Platforming",
			"ActionGameTesting/Variant_Platforming/Animation",
			"ActionGameTesting/Variant_Combat",
			"ActionGameTesting/Variant_Combat/AI",
			"ActionGameTesting/Variant_Combat/Animation",
			"ActionGameTesting/Variant_Combat/Gameplay",
			"ActionGameTesting/Variant_Combat/Interfaces",
			"ActionGameTesting/Variant_Combat/UI",
			"ActionGameTesting/Variant_SideScrolling",
			"ActionGameTesting/Variant_SideScrolling/AI",
			"ActionGameTesting/Variant_SideScrolling/Gameplay",
			"ActionGameTesting/Variant_SideScrolling/Interfaces",
			"ActionGameTesting/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
