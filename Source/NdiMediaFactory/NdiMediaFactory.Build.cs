// Copyright 1998-2016 Epic Games, Inc. All Rights Reserved.

namespace UnrealBuildTool.Rules
{
	public class NdiMediaFactory : ModuleRules
	{
		public NdiMediaFactory(ReadOnlyTargetRules Target) : base(Target)
		{
			DynamicallyLoadedModuleNames.AddRange(
				new string[] {
					"Media",
				}
			);

			PrivateDependencyModuleNames.AddRange(
				new string[] {
					"MediaAssets",
					"Projects",
				}
			);

			PrivateIncludePathModuleNames.AddRange(
				new string[] {
					"Media",
					"NdiMedia",
				}
			);

			PrivateIncludePaths.AddRange(
				new string[] {
					"NdiMediaFactory/Private",
				}
			);

            PublicDependencyModuleNames.AddRange(
                new string[] {
                    "Core",
                    "CoreUObject",
                }
            );

            if (Target.Type == TargetRules.TargetType.Editor)
			{
				DynamicallyLoadedModuleNames.Add("Settings");
				PrivateIncludePathModuleNames.Add("Settings");
			}

			if ((Target.Platform == UnrealTargetPlatform.Mac) ||
				(Target.Platform == UnrealTargetPlatform.Linux) ||
				(Target.Platform == UnrealTargetPlatform.Win32) ||
				(Target.Platform == UnrealTargetPlatform.Win64))
			{
				DynamicallyLoadedModuleNames.Add("NdiMedia");
			}
		}
	}
}
