// Copyright 1998-2017 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

[SupportedPlatforms(UnrealPlatformClass.Server)]
public class HoldYourBreathServerTarget : TargetRules   // Change this line as shown previously
{
       public HoldYourBreathServerTarget(TargetInfo Target) : base(Target)  // Change this line as shown previously
       {
        Type = TargetType.Server;
        ExtraModuleNames.Add("HoldYourBreath");    // Change this line as shown previously
       }
}