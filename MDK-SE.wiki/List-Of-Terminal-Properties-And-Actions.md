## Overview
**Note: Terminal actions and properties are for all intents and purposes obsolete since all vanilla block interfaces now contain proper API access to _most of_ this information. It is highly recommended you use those for less overhead.**

[IMyAdvancedDoor](#imyadvanceddoor)  
[IMyAirtightHangarDoor](#imyairtighthangardoor)  
[IMyAirtightSlideDoor](#imyairtightslidedoor)  
[IMyAirVent](#imyairvent)  
[IMyArtificialMassBlock](#imyartificialmassblock)  
[IMyAssembler](#imyassembler)  
[IMyBatteryBlock](#imybatteryblock)  
[IMyBeacon](#imybeacon)  
[IMyButtonPanel](#imybuttonpanel)  
[IMyCameraBlock](#imycamerablock)  
[IMyCargoContainer](#imycargocontainer)  
[IMyCockpit](#imycockpit)  
[IMyCollector](#imycollector)  
[IMyControlPanel](#imycontrolpanel)  
[IMyConveyorSorter](#imyconveyorsorter)  
[IMyCryoChamber](#imycryochamber)  
[IMyDecoy](#imydecoy)  
[IMyDoor](#imydoor)  
[IMyExtendedPistonBase](#imyextendedpistonbase)  
[IMyFunctionalBlock](#imyfunctionalblock)  
[IMyGasGenerator](#imygasgenerator)  
[IMyGasTank](#imygastank)  
[IMyGravityGenerator](#imygravitygenerator)  
[IMyGravityGeneratorSphere](#imygravitygeneratorsphere)  
[IMyGyro](#imygyro)  
[IMyHeatVent](#imyheatvent)  
[IMyInteriorLight](#imyinteriorlight)  
[IMyJumpDrive](#imyjumpdrive)  
[IMyLandingGear](#imylandinggear)  
[IMyLargeGatlingTurret](#imylargegatlingturret)  
[IMyLargeInteriorTurret](#imylargeinteriorturret)  
[IMyLaserAntenna](#imylaserantenna)  
[IMyMedicalRoom](#imymedicalroom)  
[IMyMotorAdvancedStator](#imymotoradvancedstator)  
[IMyMotorSuspension](#imymotorsuspension)  
[IMyOreDetector](#imyoredetector)  
[IMyOxygenFarm](#imyoxygenfarm)  
[IMyParachute](#imyparachute)  
[IMyPistonBase](#imypistonbase)  
[IMyProgrammableBlock](#imyprogrammableblock)  
[IMyProjector](#imyprojector)  
[IMyRadioAntenna](#imyradioantenna)  
[IMyReactor](#imyreactor)  
[IMyRefinery](#imyrefinery)  
[IMyReflectorLight](#imyreflectorlight)  
[IMyRemoteControl](#imyremotecontrol)  
[IMySafeZoneBlock](#imysafezoneblock)  
[IMySensorBlock](#imysensorblock)  
[IMyShipConnector](#imyshipconnector)  
[IMyShipController](#imyshipcontroller)  
[IMyShipDrill](#imyshipdrill)  
[IMyShipGrinder](#imyshipgrinder)  
[IMyShipMergeBlock](#imyshipmergeblock)  
[IMyShipWelder](#imyshipwelder)  
[IMySmallGatlingGun](#imysmallgatlinggun)  
[IMySmallMissileLauncher](#imysmallmissilelauncher)  
[IMySmallMissileLauncherReload](#imysmallmissilelauncherreload)  
[IMySolarPanel](#imysolarpanel)  
[IMySoundBlock](#imysoundblock)  
[IMySpaceBall](#imyspaceball)  
[IMyStoreBlock](#imystoreblock)  
[IMyTargetDummyBlock](#imytargetdummyblock)  
[IMyTerminalBlock](#imyterminalblock)  
[IMyTextPanel](#imytextpanel)  
[IMyThrust](#imythrust)  
[IMyTimerBlock](#imytimerblock)  
[IMyTurretControlBlock](#imyturretcontrolblock)  
[IMyUpgradeModule](#imyupgrademodule)  
[IMyWarhead](#imywarhead)  

## IMyAdvancedDoor

### Actions

|Name|Description|
|-|-|
|AnyoneCanUse|Anyone Can Use On/Off|
|DecreaseChangeIntervalSlider|Decrease Image change interval|
|DecreaseFontSize|Decrease Font Size|
|DecreaseTextPaddingSlider|Decrease Text Padding|
|IncreaseChangeIntervalSlider|Increase Image change interval|
|IncreaseFontSize|Increase Font Size|
|IncreaseTextPaddingSlider|Increase Text Padding|
|OnOff|Toggle block On/Off|
|OnOff_Off|Toggle block Off|
|OnOff_On|Toggle block On|
|Open| Open/Closed|
|Open_Off| Closed|
|Open_On| Open|
|PreserveAspectRatio|Preserve aspect ratio On/Off|
|ShowOnHUD|Show on HUD On/Off|
|ShowOnHUD_Off|Show on HUD Off|
|ShowOnHUD_On|Show on HUD On|

### Properties

|Name|Type|
|-|-|
|alignment|long|
|AnyoneCanUse|bool|
|BackgroundColor|Color|
|ChangeIntervalSlider|float|
|Content|long|
|Font|long|
|FontColor|Color|
|FontSize|float|
|Name|StringBuilder|
|OnOff|bool|
|Open|bool|
|PreserveAspectRatio|bool|
|ScriptBackgroundColor|Color|
|ScriptForegroundColor|Color|
|ShowInInventory|bool|
|ShowInTerminal|bool|
|ShowInToolbarConfig|bool|
|ShowOnHUD|bool|
|TextPaddingSlider|float|

## IMyAirtightHangarDoor

### Actions

|Name|Description|
|-|-|
|AnyoneCanUse|Anyone Can Use On/Off|
|DecreaseChangeIntervalSlider|Decrease Image change interval|
|DecreaseFontSize|Decrease Font Size|
|DecreaseTextPaddingSlider|Decrease Text Padding|
|IncreaseChangeIntervalSlider|Increase Image change interval|
|IncreaseFontSize|Increase Font Size|
|IncreaseTextPaddingSlider|Increase Text Padding|
|OnOff|Toggle block On/Off|
|OnOff_Off|Toggle block Off|
|OnOff_On|Toggle block On|
|Open| Open/Closed|
|Open_Off| Closed|
|Open_On| Open|
|PreserveAspectRatio|Preserve aspect ratio On/Off|
|ShowOnHUD|Show on HUD On/Off|
|ShowOnHUD_Off|Show on HUD Off|
|ShowOnHUD_On|Show on HUD On|

### Properties

|Name|Type|
|-|-|
|alignment|long|
|AnyoneCanUse|bool|
|BackgroundColor|Color|
|ChangeIntervalSlider|float|
|Content|long|
|Font|long|
|FontColor|Color|
|FontSize|float|
|Name|StringBuilder|
|OnOff|bool|
|Open|bool|
|PreserveAspectRatio|bool|
|ScriptBackgroundColor|Color|
|ScriptForegroundColor|Color|
|ShowInInventory|bool|
|ShowInTerminal|bool|
|ShowInToolbarConfig|bool|
|ShowOnHUD|bool|
|TextPaddingSlider|float|

## IMyAirtightSlideDoor

### Actions

|Name|Description|
|-|-|
|AnyoneCanUse|Anyone Can Use On/Off|
|DecreaseChangeIntervalSlider|Decrease Image change interval|
|DecreaseFontSize|Decrease Font Size|
|DecreaseTextPaddingSlider|Decrease Text Padding|
|IncreaseChangeIntervalSlider|Increase Image change interval|
|IncreaseFontSize|Increase Font Size|
|IncreaseTextPaddingSlider|Increase Text Padding|
|OnOff|Toggle block On/Off|
|OnOff_Off|Toggle block Off|
|OnOff_On|Toggle block On|
|Open| Open/Closed|
|Open_Off| Closed|
|Open_On| Open|
|PreserveAspectRatio|Preserve aspect ratio On/Off|
|ShowOnHUD|Show on HUD On/Off|
|ShowOnHUD_Off|Show on HUD Off|
|ShowOnHUD_On|Show on HUD On|

### Properties

|Name|Type|
|-|-|
|alignment|long|
|AnyoneCanUse|bool|
|BackgroundColor|Color|
|ChangeIntervalSlider|float|
|Content|long|
|Font|long|
|FontColor|Color|
|FontSize|float|
|Name|StringBuilder|
|OnOff|bool|
|Open|bool|
|PreserveAspectRatio|bool|
|ScriptBackgroundColor|Color|
|ScriptForegroundColor|Color|
|ShowInInventory|bool|
|ShowInTerminal|bool|
|ShowInToolbarConfig|bool|
|ShowOnHUD|bool|
|TextPaddingSlider|float|

## IMyAirVent

### Actions

|Name|Description|
|-|-|
|DecreaseChangeIntervalSlider|Decrease Image change interval|
|DecreaseFontSize|Decrease Font Size|
|DecreaseTextPaddingSlider|Decrease Text Padding|
|Depressurize|Depressurize On/Off|
|Depressurize_Off|Depressurize Off|
|Depressurize_On|Depressurize On|
|IncreaseChangeIntervalSlider|Increase Image change interval|
|IncreaseFontSize|Increase Font Size|
|IncreaseTextPaddingSlider|Increase Text Padding|
|OnOff|Toggle block On/Off|
|OnOff_Off|Toggle block Off|
|OnOff_On|Toggle block On|
|PreserveAspectRatio|Preserve aspect ratio On/Off|
|ShowOnHUD|Show on HUD On/Off|
|ShowOnHUD_Off|Show on HUD Off|
|ShowOnHUD_On|Show on HUD On|

### Properties

|Name|Type|
|-|-|
|alignment|long|
|BackgroundColor|Color|
|ChangeIntervalSlider|float|
|Content|long|
|Depressurize|bool|
|Font|long|
|FontColor|Color|
|FontSize|float|
|Name|StringBuilder|
|OnOff|bool|
|PreserveAspectRatio|bool|
|ScriptBackgroundColor|Color|
|ScriptForegroundColor|Color|
|ShowInInventory|bool|
|ShowInTerminal|bool|
|ShowInToolbarConfig|bool|
|ShowOnHUD|bool|
|TextPaddingSlider|float|

## IMyArtificialMassBlock

### Actions

|Name|Description|
|-|-|
|DecreaseChangeIntervalSlider|Decrease Image change interval|
|DecreaseFontSize|Decrease Font Size|
|DecreaseTextPaddingSlider|Decrease Text Padding|
|IncreaseChangeIntervalSlider|Increase Image change interval|
|IncreaseFontSize|Increase Font Size|
|IncreaseTextPaddingSlider|Increase Text Padding|
|OnOff|Toggle block On/Off|
|OnOff_Off|Toggle block Off|
|OnOff_On|Toggle block On|
|PreserveAspectRatio|Preserve aspect ratio On/Off|
|ShowOnHUD|Show on HUD On/Off|
|ShowOnHUD_Off|Show on HUD Off|
|ShowOnHUD_On|Show on HUD On|

### Properties

|Name|Type|
|-|-|
|alignment|long|
|BackgroundColor|Color|
|ChangeIntervalSlider|float|
|Content|long|
|Font|long|
|FontColor|Color|
|FontSize|float|
|Name|StringBuilder|
|OnOff|bool|
|PreserveAspectRatio|bool|
|ScriptBackgroundColor|Color|
|ScriptForegroundColor|Color|
|ShowInInventory|bool|
|ShowInTerminal|bool|
|ShowInToolbarConfig|bool|
|ShowOnHUD|bool|
|TextPaddingSlider|float|

## IMyAssembler

### Actions

|Name|Description|
|-|-|
|DecreaseChangeIntervalSlider|Decrease Image change interval|
|DecreaseFontSize|Decrease Font Size|
|DecreaseTextPaddingSlider|Decrease Text Padding|
|IncreaseChangeIntervalSlider|Increase Image change interval|
|IncreaseFontSize|Increase Font Size|
|IncreaseTextPaddingSlider|Increase Text Padding|
|OnOff|Toggle block On/Off|
|OnOff_Off|Toggle block Off|
|OnOff_On|Toggle block On|
|PreserveAspectRatio|Preserve aspect ratio On/Off|
|ShowOnHUD|Show on HUD On/Off|
|ShowOnHUD_Off|Show on HUD Off|
|ShowOnHUD_On|Show on HUD On|
|slaveMode|Cooperative Mode On/Off|
|UseConveyor|Use Conveyor System On/Off|

### Properties

|Name|Type|
|-|-|
|alignment|long|
|BackgroundColor|Color|
|ChangeIntervalSlider|float|
|Content|long|
|Font|long|
|FontColor|Color|
|FontSize|float|
|Name|StringBuilder|
|OnOff|bool|
|PreserveAspectRatio|bool|
|ScriptBackgroundColor|Color|
|ScriptForegroundColor|Color|
|ShowInInventory|bool|
|ShowInTerminal|bool|
|ShowInToolbarConfig|bool|
|ShowOnHUD|bool|
|slaveMode|bool|
|TextPaddingSlider|float|
|UseConveyor|bool|

## IMyBatteryBlock

### Actions

|Name|Description|
|-|-|
|Auto|Enable Auto|
|DecreaseChangeIntervalSlider|Decrease Image change interval|
|DecreaseFontSize|Decrease Font Size|
|DecreaseTextPaddingSlider|Decrease Text Padding|
|Discharge|Discharge On/Off|
|IncreaseChangeIntervalSlider|Increase Image change interval|
|IncreaseFontSize|Increase Font Size|
|IncreaseTextPaddingSlider|Increase Text Padding|
|OnOff|Toggle block On/Off|
|OnOff_Off|Toggle block Off|
|OnOff_On|Toggle block On|
|PreserveAspectRatio|Preserve aspect ratio On/Off|
|Recharge|Recharge On/Off|
|ShowOnHUD|Show on HUD On/Off|
|ShowOnHUD_Off|Show on HUD Off|
|ShowOnHUD_On|Show on HUD On|

### Properties

|Name|Type|
|-|-|
|alignment|long|
|BackgroundColor|Color|
|ChangeIntervalSlider|float|
|ChargeMode|long|
|Content|long|
|Font|long|
|FontColor|Color|
|FontSize|float|
|Name|StringBuilder|
|OnOff|bool|
|PreserveAspectRatio|bool|
|ScriptBackgroundColor|Color|
|ScriptForegroundColor|Color|
|ShowInInventory|bool|
|ShowInTerminal|bool|
|ShowInToolbarConfig|bool|
|ShowOnHUD|bool|
|TextPaddingSlider|float|

## IMyBeacon

### Actions

|Name|Description|
|-|-|
|DecreaseChangeIntervalSlider|Decrease Image change interval|
|DecreaseFontSize|Decrease Font Size|
|DecreaseRadius|Decrease Broadcast radius|
|DecreaseTextPaddingSlider|Decrease Text Padding|
|IncreaseChangeIntervalSlider|Increase Image change interval|
|IncreaseFontSize|Increase Font Size|
|IncreaseRadius|Increase Broadcast radius|
|IncreaseTextPaddingSlider|Increase Text Padding|
|OnOff|Toggle block On/Off|
|OnOff_Off|Toggle block Off|
|OnOff_On|Toggle block On|
|PreserveAspectRatio|Preserve aspect ratio On/Off|
|ShowOnHUD|Show on HUD On/Off|
|ShowOnHUD_Off|Show on HUD Off|
|ShowOnHUD_On|Show on HUD On|

### Properties

|Name|Type|
|-|-|
|alignment|long|
|BackgroundColor|Color|
|ChangeIntervalSlider|float|
|Content|long|
|CustomName|StringBuilder|
|Font|long|
|FontColor|Color|
|FontSize|float|
|HudText|StringBuilder|
|OnOff|bool|
|PreserveAspectRatio|bool|
|Radius|float|
|ScriptBackgroundColor|Color|
|ScriptForegroundColor|Color|
|ShowInInventory|bool|
|ShowInTerminal|bool|
|ShowInToolbarConfig|bool|
|ShowOnHUD|bool|
|TextPaddingSlider|float|

## IMyButtonPanel

### Actions

|Name|Description|
|-|-|
|AnyoneCanUse|Anyone Can Use On/Off|
|DecreaseChangeIntervalSlider|Decrease Image change interval|
|DecreaseFontSize|Decrease Font Size|
|DecreaseTextPaddingSlider|Decrease Text Padding|
|IncreaseChangeIntervalSlider|Increase Image change interval|
|IncreaseFontSize|Increase Font Size|
|IncreaseTextPaddingSlider|Increase Text Padding|
|OnOff|Toggle block On/Off|
|OnOff_Off|Toggle block Off|
|OnOff_On|Toggle block On|
|PreserveAspectRatio|Preserve aspect ratio On/Off|
|ShowOnHUD|Show on HUD On/Off|
|ShowOnHUD_Off|Show on HUD Off|
|ShowOnHUD_On|Show on HUD On|

### Properties

|Name|Type|
|-|-|
|alignment|long|
|AnyoneCanUse|bool|
|BackgroundColor|Color|
|ButtonName|StringBuilder|
|ChangeIntervalSlider|float|
|Content|long|
|Font|long|
|FontColor|Color|
|FontSize|float|
|Name|StringBuilder|
|OnOff|bool|
|PreserveAspectRatio|bool|
|ScriptBackgroundColor|Color|
|ScriptForegroundColor|Color|
|ShowInInventory|bool|
|ShowInTerminal|bool|
|ShowInToolbarConfig|bool|
|ShowOnHUD|bool|
|TextPaddingSlider|float|

## IMyCameraBlock

### Actions

|Name|Description|
|-|-|
|DecreaseChangeIntervalSlider|Decrease Image change interval|
|DecreaseFontSize|Decrease Font Size|
|DecreaseTextPaddingSlider|Decrease Text Padding|
|IncreaseChangeIntervalSlider|Increase Image change interval|
|IncreaseFontSize|Increase Font Size|
|IncreaseTextPaddingSlider|Increase Text Padding|
|OnOff|Toggle block On/Off|
|OnOff_Off|Toggle block Off|
|OnOff_On|Toggle block On|
|PreserveAspectRatio|Preserve aspect ratio On/Off|
|ShowOnHUD|Show on HUD On/Off|
|ShowOnHUD_Off|Show on HUD Off|
|ShowOnHUD_On|Show on HUD On|

### Properties

|Name|Type|
|-|-|
|alignment|long|
|BackgroundColor|Color|
|ChangeIntervalSlider|float|
|Content|long|
|Font|long|
|FontColor|Color|
|FontSize|float|
|Name|StringBuilder|
|OnOff|bool|
|PreserveAspectRatio|bool|
|ScriptBackgroundColor|Color|
|ScriptForegroundColor|Color|
|ShowInInventory|bool|
|ShowInTerminal|bool|
|ShowInToolbarConfig|bool|
|ShowOnHUD|bool|
|TextPaddingSlider|float|

## IMyCargoContainer

### Actions

|Name|Description|
|-|-|
|ShowOnHUD|Show on HUD On/Off|
|ShowOnHUD_Off|Show on HUD Off|
|ShowOnHUD_On|Show on HUD On|

### Properties

|Name|Type|
|-|-|
|Name|StringBuilder|
|ShowInInventory|bool|
|ShowInTerminal|bool|
|ShowInToolbarConfig|bool|
|ShowOnHUD|bool|

## IMyCockpit

### Actions

|Name|Description|
|-|-|
|ControlGyros|Control Gyros On/Off|
|ControlThrusters|Control thrusters On/Off|
|ControlWheels|Control wheels On/Off|
|DampenersOverride|Inertia dampeners On/Off|
|DecreaseChangeIntervalSlider|Decrease Image change interval|
|DecreaseFontSize|Decrease Font Size|
|DecreaseTextPaddingSlider|Decrease Text Padding|
|HandBrake|Handbrake On/Off|
|HorizonIndicator|Show horizon and altitude On/Off|
|IncreaseChangeIntervalSlider|Increase Image change interval|
|IncreaseFontSize|Increase Font Size|
|IncreaseTextPaddingSlider|Increase Text Padding|
|MainCockpit|Main cockpit On/Off|
|Park|Park On/Off|
|PreserveAspectRatio|Preserve aspect ratio On/Off|
|ShowOnHUD|Show on HUD On/Off|
|ShowOnHUD_Off|Show on HUD Off|
|ShowOnHUD_On|Show on HUD On|
|TargetLocking|Enable target locking On/Off|

### Properties

|Name|Type|
|-|-|
|alignment|long|
|BackgroundColor|Color|
|ChangeIntervalSlider|float|
|Content|long|
|ControlGyros|bool|
|ControlThrusters|bool|
|ControlWheels|bool|
|DampenersOverride|bool|
|Font|long|
|FontColor|Color|
|FontSize|float|
|HandBrake|bool|
|HorizonIndicator|bool|
|MainCockpit|bool|
|Name|StringBuilder|
|Park|bool|
|PreserveAspectRatio|bool|
|ScriptBackgroundColor|Color|
|ScriptForegroundColor|Color|
|ShowInInventory|bool|
|ShowInTerminal|bool|
|ShowInToolbarConfig|bool|
|ShowOnHUD|bool|
|TargetLocking|bool|
|TextPaddingSlider|float|

## IMyCollector

### Actions

|Name|Description|
|-|-|
|DecreaseChangeIntervalSlider|Decrease Image change interval|
|DecreaseFontSize|Decrease Font Size|
|DecreaseTextPaddingSlider|Decrease Text Padding|
|IncreaseChangeIntervalSlider|Increase Image change interval|
|IncreaseFontSize|Increase Font Size|
|IncreaseTextPaddingSlider|Increase Text Padding|
|OnOff|Toggle block On/Off|
|OnOff_Off|Toggle block Off|
|OnOff_On|Toggle block On|
|PreserveAspectRatio|Preserve aspect ratio On/Off|
|ShowOnHUD|Show on HUD On/Off|
|ShowOnHUD_Off|Show on HUD Off|
|ShowOnHUD_On|Show on HUD On|
|UseConveyor|Use Conveyor System On/Off|

### Properties

|Name|Type|
|-|-|
|alignment|long|
|BackgroundColor|Color|
|ChangeIntervalSlider|float|
|Content|long|
|Font|long|
|FontColor|Color|
|FontSize|float|
|Name|StringBuilder|
|OnOff|bool|
|PreserveAspectRatio|bool|
|ScriptBackgroundColor|Color|
|ScriptForegroundColor|Color|
|ShowInInventory|bool|
|ShowInTerminal|bool|
|ShowInToolbarConfig|bool|
|ShowOnHUD|bool|
|TextPaddingSlider|float|
|UseConveyor|bool|

## IMyControlPanel

### Actions

|Name|Description|
|-|-|
|ShowOnHUD|Show on HUD On/Off|
|ShowOnHUD_Off|Show on HUD Off|
|ShowOnHUD_On|Show on HUD On|

### Properties

|Name|Type|
|-|-|
|Name|StringBuilder|
|ShowInInventory|bool|
|ShowInTerminal|bool|
|ShowInToolbarConfig|bool|
|ShowOnHUD|bool|

## IMyConveyorSorter

### Actions

|Name|Description|
|-|-|
|DecreaseChangeIntervalSlider|Decrease Image change interval|
|DecreaseFontSize|Decrease Font Size|
|DecreaseTextPaddingSlider|Decrease Text Padding|
|DrainAll|Drain All On/Off|
|IncreaseChangeIntervalSlider|Increase Image change interval|
|IncreaseFontSize|Increase Font Size|
|IncreaseTextPaddingSlider|Increase Text Padding|
|OnOff|Toggle block On/Off|
|OnOff_Off|Toggle block Off|
|OnOff_On|Toggle block On|
|PreserveAspectRatio|Preserve aspect ratio On/Off|
|ShowOnHUD|Show on HUD On/Off|
|ShowOnHUD_Off|Show on HUD Off|
|ShowOnHUD_On|Show on HUD On|

### Properties

|Name|Type|
|-|-|
|alignment|long|
|BackgroundColor|Color|
|blacklistWhitelist|long|
|ChangeIntervalSlider|float|
|Content|long|
|DrainAll|bool|
|Font|long|
|FontColor|Color|
|FontSize|float|
|Name|StringBuilder|
|OnOff|bool|
|PreserveAspectRatio|bool|
|ScriptBackgroundColor|Color|
|ScriptForegroundColor|Color|
|ShowInInventory|bool|
|ShowInTerminal|bool|
|ShowInToolbarConfig|bool|
|ShowOnHUD|bool|
|TextPaddingSlider|float|

## IMyCryoChamber

### Actions

|Name|Description|
|-|-|
|ControlGyros|Control Gyros On/Off|
|ControlThrusters|Control thrusters On/Off|
|ControlWheels|Control wheels On/Off|
|DampenersOverride|Inertia dampeners On/Off|
|DecreaseChangeIntervalSlider|Decrease Image change interval|
|DecreaseFontSize|Decrease Font Size|
|DecreaseTextPaddingSlider|Decrease Text Padding|
|HandBrake|Handbrake On/Off|
|HorizonIndicator|Show horizon and altitude On/Off|
|IncreaseChangeIntervalSlider|Increase Image change interval|
|IncreaseFontSize|Increase Font Size|
|IncreaseTextPaddingSlider|Increase Text Padding|
|MainCockpit|Main cockpit On/Off|
|Park|Park On/Off|
|PreserveAspectRatio|Preserve aspect ratio On/Off|
|ShowOnHUD|Show on HUD On/Off|
|ShowOnHUD_Off|Show on HUD Off|
|ShowOnHUD_On|Show on HUD On|
|TargetLocking|Enable target locking On/Off|

### Properties

|Name|Type|
|-|-|
|alignment|long|
|BackgroundColor|Color|
|ChangeIntervalSlider|float|
|Content|long|
|ControlGyros|bool|
|ControlThrusters|bool|
|ControlWheels|bool|
|DampenersOverride|bool|
|Font|long|
|FontColor|Color|
|FontSize|float|
|HandBrake|bool|
|HorizonIndicator|bool|
|MainCockpit|bool|
|Name|StringBuilder|
|Park|bool|
|PreserveAspectRatio|bool|
|ScriptBackgroundColor|Color|
|ScriptForegroundColor|Color|
|ShowInInventory|bool|
|ShowInTerminal|bool|
|ShowInToolbarConfig|bool|
|ShowOnHUD|bool|
|TargetLocking|bool|
|TextPaddingSlider|float|

## IMyDecoy

### Actions

|Name|Description|
|-|-|
|DecreaseChangeIntervalSlider|Decrease Image change interval|
|DecreaseFontSize|Decrease Font Size|
|DecreaseTextPaddingSlider|Decrease Text Padding|
|IncreaseChangeIntervalSlider|Increase Image change interval|
|IncreaseFontSize|Increase Font Size|
|IncreaseTextPaddingSlider|Increase Text Padding|
|OnOff|Toggle block On/Off|
|OnOff_Off|Toggle block Off|
|OnOff_On|Toggle block On|
|PreserveAspectRatio|Preserve aspect ratio On/Off|
|ShowOnHUD|Show on HUD On/Off|
|ShowOnHUD_Off|Show on HUD Off|
|ShowOnHUD_On|Show on HUD On|

### Properties

|Name|Type|
|-|-|
|alignment|long|
|BackgroundColor|Color|
|ChangeIntervalSlider|float|
|Content|long|
|Font|long|
|FontColor|Color|
|FontSize|float|
|Name|StringBuilder|
|OnOff|bool|
|PreserveAspectRatio|bool|
|ScriptBackgroundColor|Color|
|ScriptForegroundColor|Color|
|ShowInInventory|bool|
|ShowInTerminal|bool|
|ShowInToolbarConfig|bool|
|ShowOnHUD|bool|
|TextPaddingSlider|float|

## IMyDoor

### Actions

|Name|Description|
|-|-|
|AnyoneCanUse|Anyone Can Use On/Off|
|DecreaseChangeIntervalSlider|Decrease Image change interval|
|DecreaseFontSize|Decrease Font Size|
|DecreaseTextPaddingSlider|Decrease Text Padding|
|IncreaseChangeIntervalSlider|Increase Image change interval|
|IncreaseFontSize|Increase Font Size|
|IncreaseTextPaddingSlider|Increase Text Padding|
|OnOff|Toggle block On/Off|
|OnOff_Off|Toggle block Off|
|OnOff_On|Toggle block On|
|Open| Open/Closed|
|Open_Off| Closed|
|Open_On| Open|
|PreserveAspectRatio|Preserve aspect ratio On/Off|
|ShowOnHUD|Show on HUD On/Off|
|ShowOnHUD_Off|Show on HUD Off|
|ShowOnHUD_On|Show on HUD On|

### Properties

|Name|Type|
|-|-|
|alignment|long|
|AnyoneCanUse|bool|
|BackgroundColor|Color|
|ChangeIntervalSlider|float|
|Content|long|
|Font|long|
|FontColor|Color|
|FontSize|float|
|Name|StringBuilder|
|OnOff|bool|
|Open|bool|
|PreserveAspectRatio|bool|
|ScriptBackgroundColor|Color|
|ScriptForegroundColor|Color|
|ShowInInventory|bool|
|ShowInTerminal|bool|
|ShowInToolbarConfig|bool|
|ShowOnHUD|bool|
|TextPaddingSlider|float|

## IMyExtendedPistonBase

### Actions

|Name|Description|
|-|-|
|Add Top Part|Add Piston Head|
|DecreaseChangeIntervalSlider|Decrease Image change interval|
|DecreaseFontSize|Decrease Font Size|
|DecreaseLowerLimit|Decrease Minimum distance|
|DecreaseMaxImpulseAxis|Decrease Max Impulse Axis|
|DecreaseMaxImpulseNonAxis|Decrease Max Impulse NonAxis|
|DecreaseSafetyDetach|Decrease Safety detach|
|DecreaseTextPaddingSlider|Decrease Text Padding|
|DecreaseUpperLimit|Decrease Maximum distance|
|DecreaseVelocity|Decrease Velocity|
|DecreaseWeld speed|Decrease Safety lock speed|
|Extend|Extend|
|Force weld|Safety lock override On/Off|
|IncreaseChangeIntervalSlider|Increase Image change interval|
|IncreaseFontSize|Increase Font Size|
|IncreaseLowerLimit|Increase Minimum distance|
|IncreaseMaxImpulseAxis|Increase Max Impulse Axis|
|IncreaseMaxImpulseNonAxis|Increase Max Impulse NonAxis|
|IncreaseSafetyDetach|Increase Safety detach|
|IncreaseTextPaddingSlider|Increase Text Padding|
|IncreaseUpperLimit|Increase Maximum distance|
|IncreaseVelocity|Increase Velocity|
|IncreaseWeld speed|Increase Safety lock speed|
|OnOff|Toggle block On/Off|
|OnOff_Off|Toggle block Off|
|OnOff_On|Toggle block On|
|PreserveAspectRatio|Preserve aspect ratio On/Off|
|ResetVelocity|Reset Velocity|
|Retract|Retract|
|Reverse|Reverse|
|ShareInertiaTensor|Share inertia tensor On/Off|
|ShowOnHUD|Show on HUD On/Off|
|ShowOnHUD_Off|Show on HUD Off|
|ShowOnHUD_On|Show on HUD On|

### Properties

|Name|Type|
|-|-|
|alignment|long|
|BackgroundColor|Color|
|ChangeIntervalSlider|float|
|Content|long|
|Font|long|
|FontColor|Color|
|FontSize|float|
|Force weld|bool|
|LowerLimit|float|
|MaxImpulseAxis|float|
|MaxImpulseNonAxis|float|
|Name|StringBuilder|
|OnOff|bool|
|PreserveAspectRatio|bool|
|SafetyDetach|float|
|ScriptBackgroundColor|Color|
|ScriptForegroundColor|Color|
|ShareInertiaTensor|bool|
|ShowInInventory|bool|
|ShowInTerminal|bool|
|ShowInToolbarConfig|bool|
|ShowOnHUD|bool|
|TextPaddingSlider|float|
|UpperLimit|float|
|Velocity|float|
|Weld speed|float|

## IMyFunctionalBlock

### Actions

|Name|Description|
|-|-|
|DecreaseChangeIntervalSlider|Decrease Image change interval|
|DecreaseFontSize|Decrease Font Size|
|DecreaseTextPaddingSlider|Decrease Text Padding|
|IncreaseChangeIntervalSlider|Increase Image change interval|
|IncreaseFontSize|Increase Font Size|
|IncreaseTextPaddingSlider|Increase Text Padding|
|OnOff|Toggle block On/Off|
|OnOff_Off|Toggle block Off|
|OnOff_On|Toggle block On|
|PreserveAspectRatio|Preserve aspect ratio On/Off|
|ShowOnHUD|Show on HUD On/Off|
|ShowOnHUD_Off|Show on HUD Off|
|ShowOnHUD_On|Show on HUD On|

### Properties

|Name|Type|
|-|-|
|alignment|long|
|BackgroundColor|Color|
|ChangeIntervalSlider|float|
|Content|long|
|Font|long|
|FontColor|Color|
|FontSize|float|
|Name|StringBuilder|
|OnOff|bool|
|PreserveAspectRatio|bool|
|ScriptBackgroundColor|Color|
|ScriptForegroundColor|Color|
|ShowInInventory|bool|
|ShowInTerminal|bool|
|ShowInToolbarConfig|bool|
|ShowOnHUD|bool|
|TextPaddingSlider|float|

## IMyGasGenerator

### Actions

|Name|Description|
|-|-|
|Auto-Refill|Auto-Refill On/Off|
|DecreaseChangeIntervalSlider|Decrease Image change interval|
|DecreaseFontSize|Decrease Font Size|
|DecreaseTextPaddingSlider|Decrease Text Padding|
|IncreaseChangeIntervalSlider|Increase Image change interval|
|IncreaseFontSize|Increase Font Size|
|IncreaseTextPaddingSlider|Increase Text Padding|
|OnOff|Toggle block On/Off|
|OnOff_Off|Toggle block Off|
|OnOff_On|Toggle block On|
|PreserveAspectRatio|Preserve aspect ratio On/Off|
|Refill|Refill Bottles|
|ShowOnHUD|Show on HUD On/Off|
|ShowOnHUD_Off|Show on HUD Off|
|ShowOnHUD_On|Show on HUD On|
|UseConveyor|Use Conveyor System On/Off|

### Properties

|Name|Type|
|-|-|
|alignment|long|
|Auto-Refill|bool|
|BackgroundColor|Color|
|ChangeIntervalSlider|float|
|Content|long|
|Font|long|
|FontColor|Color|
|FontSize|float|
|Name|StringBuilder|
|OnOff|bool|
|PreserveAspectRatio|bool|
|ScriptBackgroundColor|Color|
|ScriptForegroundColor|Color|
|ShowInInventory|bool|
|ShowInTerminal|bool|
|ShowInToolbarConfig|bool|
|ShowOnHUD|bool|
|TextPaddingSlider|float|
|UseConveyor|bool|

## IMyGasTank

### Actions

|Name|Description|
|-|-|
|Auto-Refill|Auto-Refill On/Off|
|DecreaseChangeIntervalSlider|Decrease Image change interval|
|DecreaseFontSize|Decrease Font Size|
|DecreaseTextPaddingSlider|Decrease Text Padding|
|IncreaseChangeIntervalSlider|Increase Image change interval|
|IncreaseFontSize|Increase Font Size|
|IncreaseTextPaddingSlider|Increase Text Padding|
|OnOff|Toggle block On/Off|
|OnOff_Off|Toggle block Off|
|OnOff_On|Toggle block On|
|PreserveAspectRatio|Preserve aspect ratio On/Off|
|Refill|Refill Bottles|
|ShowOnHUD|Show on HUD On/Off|
|ShowOnHUD_Off|Show on HUD Off|
|ShowOnHUD_On|Show on HUD On|
|Stockpile|Stockpile On/Off|
|Stockpile_Off|Stockpile Off|
|Stockpile_On|Stockpile On|

### Properties

|Name|Type|
|-|-|
|alignment|long|
|Auto-Refill|bool|
|BackgroundColor|Color|
|ChangeIntervalSlider|float|
|Content|long|
|Font|long|
|FontColor|Color|
|FontSize|float|
|Name|StringBuilder|
|OnOff|bool|
|PreserveAspectRatio|bool|
|ScriptBackgroundColor|Color|
|ScriptForegroundColor|Color|
|ShowInInventory|bool|
|ShowInTerminal|bool|
|ShowInToolbarConfig|bool|
|ShowOnHUD|bool|
|Stockpile|bool|
|TextPaddingSlider|float|

## IMyGravityGenerator

### Actions

|Name|Description|
|-|-|
|DecreaseChangeIntervalSlider|Decrease Image change interval|
|DecreaseDepth|Decrease Field depth|
|DecreaseFontSize|Decrease Font Size|
|DecreaseGravity|Decrease Acceleration|
|DecreaseHeight|Decrease Field height|
|DecreaseTextPaddingSlider|Decrease Text Padding|
|DecreaseWidth|Decrease Field width|
|IncreaseChangeIntervalSlider|Increase Image change interval|
|IncreaseDepth|Increase Field depth|
|IncreaseFontSize|Increase Font Size|
|IncreaseGravity|Increase Acceleration|
|IncreaseHeight|Increase Field height|
|IncreaseTextPaddingSlider|Increase Text Padding|
|IncreaseWidth|Increase Field width|
|OnOff|Toggle block On/Off|
|OnOff_Off|Toggle block Off|
|OnOff_On|Toggle block On|
|PreserveAspectRatio|Preserve aspect ratio On/Off|
|ShowOnHUD|Show on HUD On/Off|
|ShowOnHUD_Off|Show on HUD Off|
|ShowOnHUD_On|Show on HUD On|

### Properties

|Name|Type|
|-|-|
|alignment|long|
|BackgroundColor|Color|
|ChangeIntervalSlider|float|
|Content|long|
|Depth|float|
|Font|long|
|FontColor|Color|
|FontSize|float|
|Gravity|float|
|Height|float|
|Name|StringBuilder|
|OnOff|bool|
|PreserveAspectRatio|bool|
|ScriptBackgroundColor|Color|
|ScriptForegroundColor|Color|
|ShowInInventory|bool|
|ShowInTerminal|bool|
|ShowInToolbarConfig|bool|
|ShowOnHUD|bool|
|TextPaddingSlider|float|
|Width|float|

## IMyGravityGeneratorSphere

### Actions

|Name|Description|
|-|-|
|DecreaseChangeIntervalSlider|Decrease Image change interval|
|DecreaseFontSize|Decrease Font Size|
|DecreaseGravity|Decrease Acceleration|
|DecreaseRadius|Decrease Radius|
|DecreaseTextPaddingSlider|Decrease Text Padding|
|IncreaseChangeIntervalSlider|Increase Image change interval|
|IncreaseFontSize|Increase Font Size|
|IncreaseGravity|Increase Acceleration|
|IncreaseRadius|Increase Radius|
|IncreaseTextPaddingSlider|Increase Text Padding|
|OnOff|Toggle block On/Off|
|OnOff_Off|Toggle block Off|
|OnOff_On|Toggle block On|
|PreserveAspectRatio|Preserve aspect ratio On/Off|
|ShowOnHUD|Show on HUD On/Off|
|ShowOnHUD_Off|Show on HUD Off|
|ShowOnHUD_On|Show on HUD On|

### Properties

|Name|Type|
|-|-|
|alignment|long|
|BackgroundColor|Color|
|ChangeIntervalSlider|float|
|Content|long|
|Font|long|
|FontColor|Color|
|FontSize|float|
|Gravity|float|
|Name|StringBuilder|
|OnOff|bool|
|PreserveAspectRatio|bool|
|Radius|float|
|ScriptBackgroundColor|Color|
|ScriptForegroundColor|Color|
|ShowInInventory|bool|
|ShowInTerminal|bool|
|ShowInToolbarConfig|bool|
|ShowOnHUD|bool|
|TextPaddingSlider|float|

## IMyGyro

### Actions

|Name|Description|
|-|-|
|DecreaseChangeIntervalSlider|Decrease Image change interval|
|DecreaseFontSize|Decrease Font Size|
|DecreasePitch|Decrease Pitch override|
|DecreasePower|Decrease Power|
|DecreaseRoll|Decrease Roll override|
|DecreaseTextPaddingSlider|Decrease Text Padding|
|DecreaseYaw|Decrease Yaw override|
|IncreaseChangeIntervalSlider|Increase Image change interval|
|IncreaseFontSize|Increase Font Size|
|IncreasePitch|Increase Pitch override|
|IncreasePower|Increase Power|
|IncreaseRoll|Increase Roll override|
|IncreaseTextPaddingSlider|Increase Text Padding|
|IncreaseYaw|Increase Yaw override|
|OnOff|Toggle block On/Off|
|OnOff_Off|Toggle block Off|
|OnOff_On|Toggle block On|
|Override|Override controls On/Off|
|PreserveAspectRatio|Preserve aspect ratio On/Off|
|ShowOnHUD|Show on HUD On/Off|
|ShowOnHUD_Off|Show on HUD Off|
|ShowOnHUD_On|Show on HUD On|

### Properties

|Name|Type|
|-|-|
|alignment|long|
|BackgroundColor|Color|
|ChangeIntervalSlider|float|
|Content|long|
|Font|long|
|FontColor|Color|
|FontSize|float|
|Name|StringBuilder|
|OnOff|bool|
|Override|bool|
|Pitch|float|
|Power|float|
|PreserveAspectRatio|bool|
|Roll|float|
|ScriptBackgroundColor|Color|
|ScriptForegroundColor|Color|
|ShowInInventory|bool|
|ShowInTerminal|bool|
|ShowInToolbarConfig|bool|
|ShowOnHUD|bool|
|TextPaddingSlider|float|
|Yaw|float|

## IMyHeatVent

### Actions

|Name|Description|
|-|-|
|DecreaseChangeIntervalSlider|Decrease Image change interval|
|DecreaseFalloff|Decrease Falloff|
|DecreaseFontSize|Decrease Font Size|
|DecreaseIntensity|Decrease Intensity|
|DecreaseOffset|Decrease Offset|
|DecreasePowerDependency|Decrease Power Dependency|
|DecreaseRadius|Decrease Radius|
|DecreaseTextPaddingSlider|Decrease Text Padding|
|IncreaseChangeIntervalSlider|Increase Image change interval|
|IncreaseFalloff|Increase Falloff|
|IncreaseFontSize|Increase Font Size|
|IncreaseIntensity|Increase Intensity|
|IncreaseOffset|Increase Offset|
|IncreasePowerDependency|Increase Power Dependency|
|IncreaseRadius|Increase Radius|
|IncreaseTextPaddingSlider|Increase Text Padding|
|OnOff|Toggle block On/Off|
|OnOff_Off|Toggle block Off|
|OnOff_On|Toggle block On|
|PreserveAspectRatio|Preserve aspect ratio On/Off|
|ShowOnHUD|Show on HUD On/Off|
|ShowOnHUD_Off|Show on HUD Off|
|ShowOnHUD_On|Show on HUD On|

### Properties

|Name|Type|
|-|-|
|alignment|long|
|BackgroundColor|Color|
|ChangeIntervalSlider|float|
|ColorMax|Color|
|ColorMin|Color|
|Content|long|
|Falloff|float|
|Font|long|
|FontColor|Color|
|FontSize|float|
|Intensity|float|
|Name|StringBuilder|
|Offset|float|
|OnOff|bool|
|PowerDependency|float|
|PreserveAspectRatio|bool|
|Radius|float|
|ScriptBackgroundColor|Color|
|ScriptForegroundColor|Color|
|ShowInInventory|bool|
|ShowInTerminal|bool|
|ShowInToolbarConfig|bool|
|ShowOnHUD|bool|
|TextPaddingSlider|float|

## IMyInteriorLight

### Actions

|Name|Description|
|-|-|
|DecreaseBlink Interval|Decrease Blink Interval|
|DecreaseBlink Lenght|Decrease Blink Length|
|DecreaseBlink Offset|Decrease Blink Offset|
|DecreaseChangeIntervalSlider|Decrease Image change interval|
|DecreaseFalloff|Decrease Falloff|
|DecreaseFontSize|Decrease Font Size|
|DecreaseIntensity|Decrease Intensity|
|DecreaseOffset|Decrease Offset|
|DecreaseRadius|Decrease Radius|
|DecreaseTextPaddingSlider|Decrease Text Padding|
|IncreaseBlink Interval|Increase Blink Interval|
|IncreaseBlink Lenght|Increase Blink Length|
|IncreaseBlink Offset|Increase Blink Offset|
|IncreaseChangeIntervalSlider|Increase Image change interval|
|IncreaseFalloff|Increase Falloff|
|IncreaseFontSize|Increase Font Size|
|IncreaseIntensity|Increase Intensity|
|IncreaseOffset|Increase Offset|
|IncreaseRadius|Increase Radius|
|IncreaseTextPaddingSlider|Increase Text Padding|
|OnOff|Toggle block On/Off|
|OnOff_Off|Toggle block Off|
|OnOff_On|Toggle block On|
|PreserveAspectRatio|Preserve aspect ratio On/Off|
|ShowOnHUD|Show on HUD On/Off|
|ShowOnHUD_Off|Show on HUD Off|
|ShowOnHUD_On|Show on HUD On|

### Properties

|Name|Type|
|-|-|
|alignment|long|
|BackgroundColor|Color|
|Blink Interval|float|
|Blink Lenght|float|
|Blink Offset|float|
|ChangeIntervalSlider|float|
|Color|Color|
|Content|long|
|Falloff|float|
|Font|long|
|FontColor|Color|
|FontSize|float|
|Intensity|float|
|Name|StringBuilder|
|Offset|float|
|OnOff|bool|
|PreserveAspectRatio|bool|
|Radius|float|
|ScriptBackgroundColor|Color|
|ScriptForegroundColor|Color|
|ShowInInventory|bool|
|ShowInTerminal|bool|
|ShowInToolbarConfig|bool|
|ShowOnHUD|bool|
|TextPaddingSlider|float|

## IMyJumpDrive

### Actions

|Name|Description|
|-|-|
|DecreaseChangeIntervalSlider|Decrease Image change interval|
|DecreaseFontSize|Decrease Font Size|
|DecreaseJumpDistance|Decrease Distance|
|DecreaseTextPaddingSlider|Decrease Text Padding|
|IncreaseChangeIntervalSlider|Increase Image change interval|
|IncreaseFontSize|Increase Font Size|
|IncreaseJumpDistance|Increase Distance|
|IncreaseTextPaddingSlider|Increase Text Padding|
|OnOff|Toggle block On/Off|
|OnOff_Off|Toggle block Off|
|OnOff_On|Toggle block On|
|PreserveAspectRatio|Preserve aspect ratio On/Off|
|Recharge|Recharge On/Off|
|Recharge_Off|Recharge Off|
|Recharge_On|Recharge On|
|ShowOnHUD|Show on HUD On/Off|
|ShowOnHUD_Off|Show on HUD Off|
|ShowOnHUD_On|Show on HUD On|

### Properties

|Name|Type|
|-|-|
|alignment|long|
|BackgroundColor|Color|
|ChangeIntervalSlider|float|
|Content|long|
|Font|long|
|FontColor|Color|
|FontSize|float|
|JumpDistance|float|
|Name|StringBuilder|
|OnOff|bool|
|PreserveAspectRatio|bool|
|Recharge|bool|
|ScriptBackgroundColor|Color|
|ScriptForegroundColor|Color|
|ShowInInventory|bool|
|ShowInTerminal|bool|
|ShowInToolbarConfig|bool|
|ShowOnHUD|bool|
|TextPaddingSlider|float|

## IMyLandingGear

### Actions

|Name|Description|
|-|-|
|Autolock|Autolock On/Off|
|DecreaseChangeIntervalSlider|Decrease Image change interval|
|DecreaseFontSize|Decrease Font Size|
|DecreaseTextPaddingSlider|Decrease Text Padding|
|EnableParking|Used for parking On/Off|
|IncreaseChangeIntervalSlider|Increase Image change interval|
|IncreaseFontSize|Increase Font Size|
|IncreaseTextPaddingSlider|Increase Text Padding|
|Lock|Lock|
|OnOff|Toggle block On/Off|
|OnOff_Off|Toggle block Off|
|OnOff_On|Toggle block On|
|PreserveAspectRatio|Preserve aspect ratio On/Off|
|ShowOnHUD|Show on HUD On/Off|
|ShowOnHUD_Off|Show on HUD Off|
|ShowOnHUD_On|Show on HUD On|
|SwitchLock|Switch lock|
|Unlock|Unlock|

### Properties

|Name|Type|
|-|-|
|alignment|long|
|Autolock|bool|
|BackgroundColor|Color|
|ChangeIntervalSlider|float|
|Content|long|
|EnableParking|bool|
|Font|long|
|FontColor|Color|
|FontSize|float|
|Name|StringBuilder|
|OnOff|bool|
|PreserveAspectRatio|bool|
|ScriptBackgroundColor|Color|
|ScriptForegroundColor|Color|
|ShowInInventory|bool|
|ShowInTerminal|bool|
|ShowInToolbarConfig|bool|
|ShowOnHUD|bool|
|TextPaddingSlider|float|

## IMyLargeGatlingTurret

### Actions

|Name|Description|
|-|-|
|CopyTarget|Copy target|
|DecreaseChangeIntervalSlider|Decrease Image change interval|
|DecreaseFontSize|Decrease Font Size|
|DecreaseRange|Decrease AI aiming radius|
|DecreaseTextPaddingSlider|Decrease Text Padding|
|EnableIdleMovement|Enable idle movement On/Off|
|EnableIdleMovement_Off|Enable idle movement Off|
|EnableIdleMovement_On|Enable idle movement On|
|EnableTargetLocking|Enable target locking On/Off|
|ForgetTarget|Forget target|
|IncreaseChangeIntervalSlider|Increase Image change interval|
|IncreaseFontSize|Increase Font Size|
|IncreaseRange|Increase AI aiming radius|
|IncreaseTextPaddingSlider|Increase Text Padding|
|OnOff|Toggle block On/Off|
|OnOff_Off|Toggle block Off|
|OnOff_On|Toggle block On|
|PreserveAspectRatio|Preserve aspect ratio On/Off|
|Shoot|Shoot On/Off|
|Shoot_Off|Shoot Off|
|Shoot_On|Shoot On|
|ShootOnce|Shoot once|
|ShowOnHUD|Show on HUD On/Off|
|ShowOnHUD_Off|Show on HUD Off|
|ShowOnHUD_On|Show on HUD On|
|TargetCharacters|Target characters On/Off|
|TargetCharacters_Off|Target characters Off|
|TargetCharacters_On|Target characters On|
|TargetEnemies|Target Enemies On/Off|
|TargetEnemies_Off|Target Enemies Off|
|TargetEnemies_On|Target Enemies On|
|TargetFriends|Target Friends On/Off|
|TargetFriends_Off|Target Friends Off|
|TargetFriends_On|Target Friends On|
|TargetingGroup_CycleSubsystems|Cycle Subsystems|
|TargetingGroup_PowerSystems|Target Power systems|
|TargetingGroup_Propulsion|Target Propulsion|
|TargetingGroup_Weapons|Target Weapons|
|TargetLargeShips|Target large ships On/Off|
|TargetLargeShips_Off|Target large ships Off|
|TargetLargeShips_On|Target large ships On|
|TargetMeteors|Target meteors On/Off|
|TargetMeteors_Off|Target meteors Off|
|TargetMeteors_On|Target meteors On|
|TargetMissiles|Target missiles On/Off|
|TargetMissiles_Off|Target missiles Off|
|TargetMissiles_On|Target missiles On|
|TargetNeutrals|Target neutrals On/Off|
|TargetNeutrals_Off|Target neutrals Off|
|TargetNeutrals_On|Target neutrals On|
|TargetSmallShips|Target small ships On/Off|
|TargetSmallShips_Off|Target small ships Off|
|TargetSmallShips_On|Target small ships On|
|TargetStations|Target stations On/Off|
|TargetStations_Off|Target stations Off|
|TargetStations_On|Target stations On|
|UseConveyor|Use Conveyor System On/Off|

### Properties

|Name|Type|
|-|-|
|alignment|long|
|BackgroundColor|Color|
|ChangeIntervalSlider|float|
|Content|long|
|EnableIdleMovement|bool|
|EnableTargetLocking|bool|
|Font|long|
|FontColor|Color|
|FontSize|float|
|Name|StringBuilder|
|OnOff|bool|
|PreserveAspectRatio|bool|
|Range|float|
|ScriptBackgroundColor|Color|
|ScriptForegroundColor|Color|
|Shoot|bool|
|ShowInInventory|bool|
|ShowInTerminal|bool|
|ShowInToolbarConfig|bool|
|ShowOnHUD|bool|
|TargetCharacters|bool|
|TargetEnemies|bool|
|TargetFriends|bool|
|TargetingGroup_Selector|long|
|TargetLargeShips|bool|
|TargetMeteors|bool|
|TargetMissiles|bool|
|TargetNeutrals|bool|
|TargetSmallShips|bool|
|TargetStations|bool|
|TextPaddingSlider|float|
|UseConveyor|bool|

## IMyLargeInteriorTurret

### Actions

|Name|Description|
|-|-|
|CopyTarget|Copy target|
|DecreaseChangeIntervalSlider|Decrease Image change interval|
|DecreaseFontSize|Decrease Font Size|
|DecreaseRange|Decrease AI aiming radius|
|DecreaseTextPaddingSlider|Decrease Text Padding|
|EnableIdleMovement|Enable idle movement On/Off|
|EnableIdleMovement_Off|Enable idle movement Off|
|EnableIdleMovement_On|Enable idle movement On|
|EnableTargetLocking|Enable target locking On/Off|
|ForgetTarget|Forget target|
|IncreaseChangeIntervalSlider|Increase Image change interval|
|IncreaseFontSize|Increase Font Size|
|IncreaseRange|Increase AI aiming radius|
|IncreaseTextPaddingSlider|Increase Text Padding|
|OnOff|Toggle block On/Off|
|OnOff_Off|Toggle block Off|
|OnOff_On|Toggle block On|
|PreserveAspectRatio|Preserve aspect ratio On/Off|
|Shoot|Shoot On/Off|
|Shoot_Off|Shoot Off|
|Shoot_On|Shoot On|
|ShootOnce|Shoot once|
|ShowOnHUD|Show on HUD On/Off|
|ShowOnHUD_Off|Show on HUD Off|
|ShowOnHUD_On|Show on HUD On|
|TargetCharacters|Target characters On/Off|
|TargetCharacters_Off|Target characters Off|
|TargetCharacters_On|Target characters On|
|TargetEnemies|Target Enemies On/Off|
|TargetEnemies_Off|Target Enemies Off|
|TargetEnemies_On|Target Enemies On|
|TargetFriends|Target Friends On/Off|
|TargetFriends_Off|Target Friends Off|
|TargetFriends_On|Target Friends On|
|TargetingGroup_CycleSubsystems|Cycle Subsystems|
|TargetingGroup_PowerSystems|Target Power systems|
|TargetingGroup_Propulsion|Target Propulsion|
|TargetingGroup_Weapons|Target Weapons|
|TargetLargeShips|Target large ships On/Off|
|TargetLargeShips_Off|Target large ships Off|
|TargetLargeShips_On|Target large ships On|
|TargetMeteors|Target meteors On/Off|
|TargetMeteors_Off|Target meteors Off|
|TargetMeteors_On|Target meteors On|
|TargetMissiles|Target missiles On/Off|
|TargetMissiles_Off|Target missiles Off|
|TargetMissiles_On|Target missiles On|
|TargetNeutrals|Target neutrals On/Off|
|TargetNeutrals_Off|Target neutrals Off|
|TargetNeutrals_On|Target neutrals On|
|TargetSmallShips|Target small ships On/Off|
|TargetSmallShips_Off|Target small ships Off|
|TargetSmallShips_On|Target small ships On|
|TargetStations|Target stations On/Off|
|TargetStations_Off|Target stations Off|
|TargetStations_On|Target stations On|

### Properties

|Name|Type|
|-|-|
|alignment|long|
|BackgroundColor|Color|
|ChangeIntervalSlider|float|
|Content|long|
|EnableIdleMovement|bool|
|EnableTargetLocking|bool|
|Font|long|
|FontColor|Color|
|FontSize|float|
|Name|StringBuilder|
|OnOff|bool|
|PreserveAspectRatio|bool|
|Range|float|
|ScriptBackgroundColor|Color|
|ScriptForegroundColor|Color|
|Shoot|bool|
|ShowInInventory|bool|
|ShowInTerminal|bool|
|ShowInToolbarConfig|bool|
|ShowOnHUD|bool|
|TargetCharacters|bool|
|TargetEnemies|bool|
|TargetFriends|bool|
|TargetingGroup_Selector|long|
|TargetLargeShips|bool|
|TargetMeteors|bool|
|TargetMissiles|bool|
|TargetNeutrals|bool|
|TargetSmallShips|bool|
|TargetStations|bool|
|TextPaddingSlider|float|

## IMyLaserAntenna

### Actions

|Name|Description|
|-|-|
|ConnectGPS|Connect to coords|
|DecreaseChangeIntervalSlider|Decrease Image change interval|
|DecreaseFontSize|Decrease Font Size|
|DecreaseRange|Decrease Range|
|DecreaseTextPaddingSlider|Decrease Text Padding|
|Idle|Idle|
|IncreaseChangeIntervalSlider|Increase Image change interval|
|IncreaseFontSize|Increase Font Size|
|IncreaseRange|Increase Range|
|IncreaseTextPaddingSlider|Increase Text Padding|
|isPerm|Permanent connection On/Off|
|OnOff|Toggle block On/Off|
|OnOff_Off|Toggle block Off|
|OnOff_On|Toggle block On|
|PasteGpsCoords|Paste coords|
|PreserveAspectRatio|Preserve aspect ratio On/Off|
|ShowOnHUD|Show on HUD On/Off|
|ShowOnHUD_Off|Show on HUD Off|
|ShowOnHUD_On|Show on HUD On|

### Properties

|Name|Type|
|-|-|
|alignment|long|
|BackgroundColor|Color|
|ChangeIntervalSlider|float|
|Content|long|
|Font|long|
|FontColor|Color|
|FontSize|float|
|gpsCoords|StringBuilder|
|isPerm|bool|
|Name|StringBuilder|
|OnOff|bool|
|PreserveAspectRatio|bool|
|Range|float|
|ScriptBackgroundColor|Color|
|ScriptForegroundColor|Color|
|ShowInInventory|bool|
|ShowInTerminal|bool|
|ShowInToolbarConfig|bool|
|ShowOnHUD|bool|
|TextPaddingSlider|float|

## IMyMedicalRoom

### Actions

|Name|Description|
|-|-|
|DecreaseChangeIntervalSlider|Decrease Image change interval|
|DecreaseFontSize|Decrease Font Size|
|DecreaseTextPaddingSlider|Decrease Text Padding|
|IncreaseChangeIntervalSlider|Increase Image change interval|
|IncreaseFontSize|Increase Font Size|
|IncreaseTextPaddingSlider|Increase Text Padding|
|OnOff|Toggle block On/Off|
|OnOff_Off|Toggle block Off|
|OnOff_On|Toggle block On|
|PreserveAspectRatio|Preserve aspect ratio On/Off|
|ShowOnHUD|Show on HUD On/Off|
|ShowOnHUD_Off|Show on HUD Off|
|ShowOnHUD_On|Show on HUD On|

### Properties

|Name|Type|
|-|-|
|alignment|long|
|BackgroundColor|Color|
|ChangeIntervalSlider|float|
|Content|long|
|Font|long|
|FontColor|Color|
|FontSize|float|
|Name|StringBuilder|
|OnOff|bool|
|PreserveAspectRatio|bool|
|ScriptBackgroundColor|Color|
|ScriptForegroundColor|Color|
|SetFaction|bool|
|ShowInInventory|bool|
|ShowInTerminal|bool|
|ShowInToolbarConfig|bool|
|ShowOnHUD|bool|
|SpawnName|StringBuilder|
|TakeOwnership|bool|
|TextPaddingSlider|float|

## IMyMotorAdvancedStator

### Actions

|Name|Description|
|-|-|
|AddHingeTopPart|Add Hinge Head|
|AddRotorTopPart|Add Rotor Head|
|AddSmallHingeTopPart|Add Small Head|
|AddSmallRotorTopPart|Add Small Head|
|Attach|Attach|
|DecreaseBrakingTorque|Decrease Braking torque|
|DecreaseChangeIntervalSlider|Decrease Image change interval|
|DecreaseDisplacement|Decrease Rotor displacement|
|DecreaseFontSize|Decrease Font Size|
|DecreaseLowerLimit|Decrease Lower limit|
|DecreaseSafetyDetach|Decrease Safety detach|
|DecreaseTextPaddingSlider|Decrease Text Padding|
|DecreaseTorque|Decrease Torque|
|DecreaseUpperLimit|Decrease Upper limit|
|DecreaseVelocity|Decrease Velocity|
|DecreaseWeld speed|Decrease Safety lock speed|
|Detach|Detach|
|Force weld|Safety lock override On/Off|
|HingeLock|Hinge lock On/Off|
|IncreaseBrakingTorque|Increase Braking torque|
|IncreaseChangeIntervalSlider|Increase Image change interval|
|IncreaseDisplacement|Increase Rotor displacement|
|IncreaseFontSize|Increase Font Size|
|IncreaseLowerLimit|Increase Lower limit|
|IncreaseSafetyDetach|Increase Safety detach|
|IncreaseTextPaddingSlider|Increase Text Padding|
|IncreaseTorque|Increase Torque|
|IncreaseUpperLimit|Increase Upper limit|
|IncreaseVelocity|Increase Velocity|
|IncreaseWeld speed|Increase Safety lock speed|
|OnOff|Toggle block On/Off|
|OnOff_Off|Toggle block Off|
|OnOff_On|Toggle block On|
|PreserveAspectRatio|Preserve aspect ratio On/Off|
|ResetVelocity|Reset Velocity|
|Reverse|Reverse|
|RotorLock|Rotor lock On/Off|
|ShareInertiaTensor|Share inertia tensor On/Off|
|ShowOnHUD|Show on HUD On/Off|
|ShowOnHUD_Off|Show on HUD Off|
|ShowOnHUD_On|Show on HUD On|

### Properties

|Name|Type|
|-|-|
|alignment|long|
|BackgroundColor|Color|
|BrakingTorque|float|
|ChangeIntervalSlider|float|
|Content|long|
|Displacement|float|
|Font|long|
|FontColor|Color|
|FontSize|float|
|Force weld|bool|
|HingeLock|bool|
|LowerLimit|float|
|Name|StringBuilder|
|OnOff|bool|
|PreserveAspectRatio|bool|
|RotorLock|bool|
|SafetyDetach|float|
|ScriptBackgroundColor|Color|
|ScriptForegroundColor|Color|
|ShareInertiaTensor|bool|
|ShowInInventory|bool|
|ShowInTerminal|bool|
|ShowInToolbarConfig|bool|
|ShowOnHUD|bool|
|TextPaddingSlider|float|
|Torque|float|
|UpperLimit|float|
|Velocity|float|
|Weld speed|float|

## IMyMotorSuspension

### Actions

|Name|Description|
|-|-|
|Add Top Part|Add Wheel|
|AirShock|AirShock On/Off|
|Braking|Brake On/Off|
|DecreaseChangeIntervalSlider|Decrease Image change interval|
|DecreaseFontSize|Decrease Font Size|
|DecreaseFriction|Decrease Friction|
|DecreaseHeight|Decrease Height Offset|
|DecreaseMaxSteerAngle|Decrease Steering Angle|
|DecreasePower|Decrease Power|
|DecreasePropulsion override|Decrease Propulsion override|
|DecreaseSafetyDetach|Decrease Safety detach|
|DecreaseSpeed Limit|Decrease Speed limit|
|DecreaseSteer override|Decrease Steer override|
|DecreaseStrength|Decrease Strength|
|DecreaseTextPaddingSlider|Decrease Text Padding|
|DecreaseWeld speed|Decrease Safety lock speed|
|EnableParking|Allow Parking Brake On/Off|
|Force weld|Safety lock override On/Off|
|IncreaseChangeIntervalSlider|Increase Image change interval|
|IncreaseFontSize|Increase Font Size|
|IncreaseFriction|Increase Friction|
|IncreaseHeight|Increase Height Offset|
|IncreaseMaxSteerAngle|Increase Steering Angle|
|IncreasePower|Increase Power|
|IncreasePropulsion override|Increase Propulsion override|
|IncreaseSafetyDetach|Increase Safety detach|
|IncreaseSpeed Limit|Increase Speed limit|
|IncreaseSteer override|Increase Steer override|
|IncreaseStrength|Increase Strength|
|IncreaseTextPaddingSlider|Increase Text Padding|
|IncreaseWeld speed|Increase Safety lock speed|
|InvertPropulsion|Invert Propulsion On/Off|
|InvertSteering|Invert Steering On/Off|
|OnOff|Toggle block On/Off|
|OnOff_Off|Toggle block Off|
|OnOff_On|Toggle block On|
|PreserveAspectRatio|Preserve aspect ratio On/Off|
|Propulsion|Propulsion On/Off|
|ResetHeight|Reset Height Offset|
|ResetMaxSteerAngle|Reset Steering Angle|
|ResetPropulsion override|Reset Propulsion override|
|ResetSpeed Limit|Reset Speed limit|
|ResetSteer override|Reset Steer override|
|ShareInertiaTensor|Share inertia tensor On/Off|
|ShowOnHUD|Show on HUD On/Off|
|ShowOnHUD_Off|Show on HUD Off|
|ShowOnHUD_On|Show on HUD On|
|Steering|Steering On/Off|

### Properties

|Name|Type|
|-|-|
|AirShock|bool|
|alignment|long|
|BackgroundColor|Color|
|Braking|bool|
|ChangeIntervalSlider|float|
|Content|long|
|EnableParking|bool|
|Font|long|
|FontColor|Color|
|FontSize|float|
|Force weld|bool|
|Friction|float|
|Height|float|
|InvertPropulsion|bool|
|InvertSteering|bool|
|MaxSteerAngle|float|
|Name|StringBuilder|
|OnOff|bool|
|Power|float|
|PreserveAspectRatio|bool|
|Propulsion|bool|
|Propulsion override|float|
|SafetyDetach|float|
|ScriptBackgroundColor|Color|
|ScriptForegroundColor|Color|
|ShareInertiaTensor|bool|
|ShowInInventory|bool|
|ShowInTerminal|bool|
|ShowInToolbarConfig|bool|
|ShowOnHUD|bool|
|Speed Limit|float|
|Steer override|float|
|Steering|bool|
|Strength|float|
|TextPaddingSlider|float|
|Weld speed|float|

## IMyOreDetector

### Actions

|Name|Description|
|-|-|
|BroadcastUsingAntennas|Broadcast using antennas On/Off|
|DecreaseChangeIntervalSlider|Decrease Image change interval|
|DecreaseFontSize|Decrease Font Size|
|DecreaseTextPaddingSlider|Decrease Text Padding|
|IncreaseChangeIntervalSlider|Increase Image change interval|
|IncreaseFontSize|Increase Font Size|
|IncreaseTextPaddingSlider|Increase Text Padding|
|OnOff|Toggle block On/Off|
|OnOff_Off|Toggle block Off|
|OnOff_On|Toggle block On|
|PreserveAspectRatio|Preserve aspect ratio On/Off|
|ShowOnHUD|Show on HUD On/Off|
|ShowOnHUD_Off|Show on HUD Off|
|ShowOnHUD_On|Show on HUD On|

### Properties

|Name|Type|
|-|-|
|alignment|long|
|BackgroundColor|Color|
|BroadcastUsingAntennas|bool|
|ChangeIntervalSlider|float|
|Content|long|
|Font|long|
|FontColor|Color|
|FontSize|float|
|Name|StringBuilder|
|OnOff|bool|
|PreserveAspectRatio|bool|
|Range|float|
|ScriptBackgroundColor|Color|
|ScriptForegroundColor|Color|
|ShowInInventory|bool|
|ShowInTerminal|bool|
|ShowInToolbarConfig|bool|
|ShowOnHUD|bool|
|TextPaddingSlider|float|

## IMyOxygenFarm

### Actions

|Name|Description|
|-|-|
|DecreaseChangeIntervalSlider|Decrease Image change interval|
|DecreaseFontSize|Decrease Font Size|
|DecreaseTextPaddingSlider|Decrease Text Padding|
|IncreaseChangeIntervalSlider|Increase Image change interval|
|IncreaseFontSize|Increase Font Size|
|IncreaseTextPaddingSlider|Increase Text Padding|
|OnOff|Toggle block On/Off|
|OnOff_Off|Toggle block Off|
|OnOff_On|Toggle block On|
|PreserveAspectRatio|Preserve aspect ratio On/Off|
|ShowOnHUD|Show on HUD On/Off|
|ShowOnHUD_Off|Show on HUD Off|
|ShowOnHUD_On|Show on HUD On|

### Properties

|Name|Type|
|-|-|
|alignment|long|
|BackgroundColor|Color|
|ChangeIntervalSlider|float|
|Content|long|
|Font|long|
|FontColor|Color|
|FontSize|float|
|Name|StringBuilder|
|OnOff|bool|
|PreserveAspectRatio|bool|
|ScriptBackgroundColor|Color|
|ScriptForegroundColor|Color|
|ShowInInventory|bool|
|ShowInTerminal|bool|
|ShowInToolbarConfig|bool|
|ShowOnHUD|bool|
|TextPaddingSlider|float|

## IMyParachute

### Actions

|Name|Description|
|-|-|
|AnyoneCanUse|Anyone Can Use On/Off|
|AutoDeploy|Auto deploy On/Off|
|DecreaseChangeIntervalSlider|Decrease Image change interval|
|DecreaseFontSize|Decrease Font Size|
|DecreaseTextPaddingSlider|Decrease Text Padding|
|IncreaseChangeIntervalSlider|Increase Image change interval|
|IncreaseFontSize|Increase Font Size|
|IncreaseTextPaddingSlider|Increase Text Padding|
|OnOff|Toggle block On/Off|
|OnOff_Off|Toggle block Off|
|OnOff_On|Toggle block On|
|Open| Open/Closed|
|Open_Off| Closed|
|Open_On| Open|
|PreserveAspectRatio|Preserve aspect ratio On/Off|
|ShowOnHUD|Show on HUD On/Off|
|ShowOnHUD_Off|Show on HUD Off|
|ShowOnHUD_On|Show on HUD On|

### Properties

|Name|Type|
|-|-|
|alignment|long|
|AnyoneCanUse|bool|
|AutoDeploy|bool|
|AutoDeployHeight|float|
|BackgroundColor|Color|
|ChangeIntervalSlider|float|
|Content|long|
|Font|long|
|FontColor|Color|
|FontSize|float|
|Name|StringBuilder|
|OnOff|bool|
|Open|bool|
|PreserveAspectRatio|bool|
|ScriptBackgroundColor|Color|
|ScriptForegroundColor|Color|
|ShowInInventory|bool|
|ShowInTerminal|bool|
|ShowInToolbarConfig|bool|
|ShowOnHUD|bool|
|TextPaddingSlider|float|

## IMyPistonBase

### Actions

|Name|Description|
|-|-|
|Add Top Part|Add Piston Head|
|DecreaseChangeIntervalSlider|Decrease Image change interval|
|DecreaseFontSize|Decrease Font Size|
|DecreaseLowerLimit|Decrease Minimum distance|
|DecreaseMaxImpulseAxis|Decrease Max Impulse Axis|
|DecreaseMaxImpulseNonAxis|Decrease Max Impulse NonAxis|
|DecreaseSafetyDetach|Decrease Safety detach|
|DecreaseTextPaddingSlider|Decrease Text Padding|
|DecreaseUpperLimit|Decrease Maximum distance|
|DecreaseVelocity|Decrease Velocity|
|DecreaseWeld speed|Decrease Safety lock speed|
|Extend|Extend|
|Force weld|Safety lock override On/Off|
|IncreaseChangeIntervalSlider|Increase Image change interval|
|IncreaseFontSize|Increase Font Size|
|IncreaseLowerLimit|Increase Minimum distance|
|IncreaseMaxImpulseAxis|Increase Max Impulse Axis|
|IncreaseMaxImpulseNonAxis|Increase Max Impulse NonAxis|
|IncreaseSafetyDetach|Increase Safety detach|
|IncreaseTextPaddingSlider|Increase Text Padding|
|IncreaseUpperLimit|Increase Maximum distance|
|IncreaseVelocity|Increase Velocity|
|IncreaseWeld speed|Increase Safety lock speed|
|OnOff|Toggle block On/Off|
|OnOff_Off|Toggle block Off|
|OnOff_On|Toggle block On|
|PreserveAspectRatio|Preserve aspect ratio On/Off|
|ResetVelocity|Reset Velocity|
|Retract|Retract|
|Reverse|Reverse|
|ShareInertiaTensor|Share inertia tensor On/Off|
|ShowOnHUD|Show on HUD On/Off|
|ShowOnHUD_Off|Show on HUD Off|
|ShowOnHUD_On|Show on HUD On|

### Properties

|Name|Type|
|-|-|
|alignment|long|
|BackgroundColor|Color|
|ChangeIntervalSlider|float|
|Content|long|
|Font|long|
|FontColor|Color|
|FontSize|float|
|Force weld|bool|
|LowerLimit|float|
|MaxImpulseAxis|float|
|MaxImpulseNonAxis|float|
|Name|StringBuilder|
|OnOff|bool|
|PreserveAspectRatio|bool|
|SafetyDetach|float|
|ScriptBackgroundColor|Color|
|ScriptForegroundColor|Color|
|ShareInertiaTensor|bool|
|ShowInInventory|bool|
|ShowInTerminal|bool|
|ShowInToolbarConfig|bool|
|ShowOnHUD|bool|
|TextPaddingSlider|float|
|UpperLimit|float|
|Velocity|float|
|Weld speed|float|

## IMyProgrammableBlock

### Actions

|Name|Description|
|-|-|
|DecreaseChangeIntervalSlider|Decrease Image change interval|
|DecreaseFontSize|Decrease Font Size|
|DecreaseTextPaddingSlider|Decrease Text Padding|
|IncreaseChangeIntervalSlider|Increase Image change interval|
|IncreaseFontSize|Increase Font Size|
|IncreaseTextPaddingSlider|Increase Text Padding|
|OnOff|Toggle block On/Off|
|OnOff_Off|Toggle block Off|
|OnOff_On|Toggle block On|
|PreserveAspectRatio|Preserve aspect ratio On/Off|
|Run|Run|
|RunWithDefaultArgument|Run with default argument|
|ShowOnHUD|Show on HUD On/Off|
|ShowOnHUD_Off|Show on HUD Off|
|ShowOnHUD_On|Show on HUD On|

### Properties

|Name|Type|
|-|-|
|alignment|long|
|BackgroundColor|Color|
|ChangeIntervalSlider|float|
|ConsoleCommand|StringBuilder|
|Content|long|
|Font|long|
|FontColor|Color|
|FontSize|float|
|Name|StringBuilder|
|OnOff|bool|
|PreserveAspectRatio|bool|
|ScriptBackgroundColor|Color|
|ScriptForegroundColor|Color|
|ShowInInventory|bool|
|ShowInTerminal|bool|
|ShowInToolbarConfig|bool|
|ShowOnHUD|bool|
|TextPaddingSlider|float|

## IMyProjector

### Actions

|Name|Description|
|-|-|
|DecreaseChangeIntervalSlider|Decrease Image change interval|
|DecreaseFontSize|Decrease Font Size|
|DecreaseRotX|Decrease Pitch|
|DecreaseRotY|Decrease Yaw|
|DecreaseRotZ|Decrease Roll|
|DecreaseScale|Decrease Scale|
|DecreaseTextPaddingSlider|Decrease Text Padding|
|DecreaseX|Decrease Horizontal offset|
|DecreaseY|Decrease Vertical offset|
|DecreaseZ|Decrease Forward offset|
|IncreaseChangeIntervalSlider|Increase Image change interval|
|IncreaseFontSize|Increase Font Size|
|IncreaseRotX|Increase Pitch|
|IncreaseRotY|Increase Yaw|
|IncreaseRotZ|Increase Roll|
|IncreaseScale|Increase Scale|
|IncreaseTextPaddingSlider|Increase Text Padding|
|IncreaseX|Increase Horizontal offset|
|IncreaseY|Increase Vertical offset|
|IncreaseZ|Increase Forward offset|
|KeepProjection|Keep Projection On/Off|
|OnOff|Toggle block On/Off|
|OnOff_Off|Toggle block Off|
|OnOff_On|Toggle block On|
|PreserveAspectRatio|Preserve aspect ratio On/Off|
|ShowOnHUD|Show on HUD On/Off|
|ShowOnHUD_Off|Show on HUD Off|
|ShowOnHUD_On|Show on HUD On|
|SpawnProjection|Spawn projection|

### Properties

|Name|Type|
|-|-|
|alignment|long|
|BackgroundColor|Color|
|ChangeIntervalSlider|float|
|Content|long|
|Font|long|
|FontColor|Color|
|FontSize|float|
|GetOwnership|bool|
|InstantBuilding|bool|
|KeepProjection|bool|
|Name|StringBuilder|
|NumberOfBlocks|float|
|NumberOfProjections|float|
|OnOff|bool|
|PreserveAspectRatio|bool|
|RotX|float|
|RotY|float|
|RotZ|float|
|Scale|float|
|ScriptBackgroundColor|Color|
|ScriptForegroundColor|Color|
|ShowInInventory|bool|
|ShowInTerminal|bool|
|ShowInToolbarConfig|bool|
|ShowOnHUD|bool|
|ShowOnlyBuildable|bool|
|TextPaddingSlider|float|
|X|float|
|Y|float|
|Z|float|

## IMyRadioAntenna

### Actions

|Name|Description|
|-|-|
|DecreaseChangeIntervalSlider|Decrease Image change interval|
|DecreaseFontSize|Decrease Font Size|
|DecreaseRadius|Decrease Broadcast radius|
|DecreaseTextPaddingSlider|Decrease Text Padding|
|EnableBroadCast|Enable broadcasting On/Off|
|IncreaseChangeIntervalSlider|Increase Image change interval|
|IncreaseFontSize|Increase Font Size|
|IncreaseRadius|Increase Broadcast radius|
|IncreaseTextPaddingSlider|Increase Text Padding|
|OnOff|Toggle block On/Off|
|OnOff_Off|Toggle block Off|
|OnOff_On|Toggle block On|
|PreserveAspectRatio|Preserve aspect ratio On/Off|
|ShowShipName|Show ship name On/Off|

### Properties

|Name|Type|
|-|-|
|alignment|long|
|BackgroundColor|Color|
|ChangeIntervalSlider|float|
|Content|long|
|CustomName|StringBuilder|
|EnableBroadCast|bool|
|Font|long|
|FontColor|Color|
|FontSize|float|
|HudText|StringBuilder|
|OnOff|bool|
|PreserveAspectRatio|bool|
|Radius|float|
|ScriptBackgroundColor|Color|
|ScriptForegroundColor|Color|
|ShowInTerminal|bool|
|ShowInToolbarConfig|bool|
|ShowShipName|bool|
|TextPaddingSlider|float|

## IMyReactor

### Actions

|Name|Description|
|-|-|
|DecreaseChangeIntervalSlider|Decrease Image change interval|
|DecreaseFontSize|Decrease Font Size|
|DecreaseTextPaddingSlider|Decrease Text Padding|
|IncreaseChangeIntervalSlider|Increase Image change interval|
|IncreaseFontSize|Increase Font Size|
|IncreaseTextPaddingSlider|Increase Text Padding|
|OnOff|Toggle block On/Off|
|OnOff_Off|Toggle block Off|
|OnOff_On|Toggle block On|
|PreserveAspectRatio|Preserve aspect ratio On/Off|
|ShowOnHUD|Show on HUD On/Off|
|ShowOnHUD_Off|Show on HUD Off|
|ShowOnHUD_On|Show on HUD On|
|UseConveyor|Use Conveyor System On/Off|

### Properties

|Name|Type|
|-|-|
|alignment|long|
|BackgroundColor|Color|
|ChangeIntervalSlider|float|
|Content|long|
|Font|long|
|FontColor|Color|
|FontSize|float|
|Name|StringBuilder|
|OnOff|bool|
|PreserveAspectRatio|bool|
|ScriptBackgroundColor|Color|
|ScriptForegroundColor|Color|
|ShowInInventory|bool|
|ShowInTerminal|bool|
|ShowInToolbarConfig|bool|
|ShowOnHUD|bool|
|TextPaddingSlider|float|
|UseConveyor|bool|

## IMyRefinery

### Actions

|Name|Description|
|-|-|
|DecreaseChangeIntervalSlider|Decrease Image change interval|
|DecreaseFontSize|Decrease Font Size|
|DecreaseTextPaddingSlider|Decrease Text Padding|
|IncreaseChangeIntervalSlider|Increase Image change interval|
|IncreaseFontSize|Increase Font Size|
|IncreaseTextPaddingSlider|Increase Text Padding|
|OnOff|Toggle block On/Off|
|OnOff_Off|Toggle block Off|
|OnOff_On|Toggle block On|
|PreserveAspectRatio|Preserve aspect ratio On/Off|
|ShowOnHUD|Show on HUD On/Off|
|ShowOnHUD_Off|Show on HUD Off|
|ShowOnHUD_On|Show on HUD On|
|UseConveyor|Use Conveyor System On/Off|

### Properties

|Name|Type|
|-|-|
|alignment|long|
|BackgroundColor|Color|
|ChangeIntervalSlider|float|
|Content|long|
|Font|long|
|FontColor|Color|
|FontSize|float|
|Name|StringBuilder|
|OnOff|bool|
|PreserveAspectRatio|bool|
|ScriptBackgroundColor|Color|
|ScriptForegroundColor|Color|
|ShowInInventory|bool|
|ShowInTerminal|bool|
|ShowInToolbarConfig|bool|
|ShowOnHUD|bool|
|TextPaddingSlider|float|
|UseConveyor|bool|

## IMyReflectorLight

### Actions

|Name|Description|
|-|-|
|DecreaseBlink Interval|Decrease Blink Interval|
|DecreaseBlink Lenght|Decrease Blink Length|
|DecreaseBlink Offset|Decrease Blink Offset|
|DecreaseChangeIntervalSlider|Decrease Image change interval|
|DecreaseFalloff|Decrease Falloff|
|DecreaseFontSize|Decrease Font Size|
|DecreaseIntensity|Decrease Intensity|
|DecreaseOffset|Decrease Offset|
|DecreaseRadius|Decrease Radius|
|DecreaseRotationSpeed|Decrease Rotation speed|
|DecreaseTextPaddingSlider|Decrease Text Padding|
|IncreaseBlink Interval|Increase Blink Interval|
|IncreaseBlink Lenght|Increase Blink Length|
|IncreaseBlink Offset|Increase Blink Offset|
|IncreaseChangeIntervalSlider|Increase Image change interval|
|IncreaseFalloff|Increase Falloff|
|IncreaseFontSize|Increase Font Size|
|IncreaseIntensity|Increase Intensity|
|IncreaseOffset|Increase Offset|
|IncreaseRadius|Increase Radius|
|IncreaseRotationSpeed|Increase Rotation speed|
|IncreaseTextPaddingSlider|Increase Text Padding|
|OnOff|Toggle block On/Off|
|OnOff_Off|Toggle block Off|
|OnOff_On|Toggle block On|
|PreserveAspectRatio|Preserve aspect ratio On/Off|
|ShowOnHUD|Show on HUD On/Off|
|ShowOnHUD_Off|Show on HUD Off|
|ShowOnHUD_On|Show on HUD On|

### Properties

|Name|Type|
|-|-|
|alignment|long|
|BackgroundColor|Color|
|Blink Interval|float|
|Blink Lenght|float|
|Blink Offset|float|
|ChangeIntervalSlider|float|
|Color|Color|
|Content|long|
|Falloff|float|
|Font|long|
|FontColor|Color|
|FontSize|float|
|Intensity|float|
|Name|StringBuilder|
|Offset|float|
|OnOff|bool|
|PreserveAspectRatio|bool|
|Radius|float|
|RotationSpeed|float|
|ScriptBackgroundColor|Color|
|ScriptForegroundColor|Color|
|ShowInInventory|bool|
|ShowInTerminal|bool|
|ShowInToolbarConfig|bool|
|ShowOnHUD|bool|
|TextPaddingSlider|float|

## IMyRemoteControl

### Actions

|Name|Description|
|-|-|
|AutoPilot|Autopilot On/Off|
|AutoPilot_Off|Autopilot Off|
|AutoPilot_On|Autopilot On|
|Backward|Backward|
|CollisionAvoidance|Collision avoidance On/Off|
|CollisionAvoidance_Off|Collision avoidance Off|
|CollisionAvoidance_On|Collision avoidance On|
|ControlGyros|Control Gyros On/Off|
|ControlThrusters|Control thrusters On/Off|
|ControlWheels|Control wheels On/Off|
|DampenersOverride|Inertia dampeners On/Off|
|DecreaseSpeedLimit|Decrease Speed limit|
|DockingMode|Precision Mode On/Off|
|DockingMode_Off|Precision Mode Off|
|DockingMode_On|Precision Mode On|
|Down|Down|
|Forward|Forward|
|HandBrake|Handbrake On/Off|
|HorizonIndicator|Show horizon and altitude On/Off|
|IncreaseSpeedLimit|Increase Speed limit|
|Left|Left|
|MainCockpit|Main cockpit On/Off|
|MainRemoteControl|Main Remote Control On/Off|
|Park|Park On/Off|
|Right|Right|
|ShowOnHUD|Show on HUD On/Off|
|ShowOnHUD_Off|Show on HUD Off|
|ShowOnHUD_On|Show on HUD On|
|TargetLocking|Enable target locking On/Off|
|Up|Up|

### Properties

|Name|Type|
|-|-|
|AutoPilot|bool|
|CameraList|long|
|CollisionAvoidance|bool|
|ControlGyros|bool|
|ControlThrusters|bool|
|ControlWheels|bool|
|DampenersOverride|bool|
|Direction|long|
|DockingMode|bool|
|FlightMode|long|
|HandBrake|bool|
|HorizonIndicator|bool|
|MainCockpit|bool|
|MainRemoteControl|bool|
|Name|StringBuilder|
|Park|bool|
|ShowInInventory|bool|
|ShowInTerminal|bool|
|ShowInToolbarConfig|bool|
|ShowOnHUD|bool|
|SpeedLimit|float|
|TargetLocking|bool|

## IMySafeZoneBlock

### Actions

|Name|Description|
|-|-|
|DecreaseChangeIntervalSlider|Decrease Image change interval|
|DecreaseFontSize|Decrease Font Size|
|DecreaseSafeZoneXSlider|Decrease Set Width|
|DecreaseTextPaddingSlider|Decrease Text Padding|
|IncreaseChangeIntervalSlider|Increase Image change interval|
|IncreaseFontSize|Increase Font Size|
|IncreaseSafeZoneXSlider|Increase Set Width|
|IncreaseTextPaddingSlider|Increase Text Padding|
|OnOff|Toggle block On/Off|
|OnOff_Off|Toggle block Off|
|OnOff_On|Toggle block On|
|PreserveAspectRatio|Preserve aspect ratio On/Off|
|ShowOnHUD|Show on HUD On/Off|
|ShowOnHUD_Off|Show on HUD Off|
|ShowOnHUD_On|Show on HUD On|

### Properties

|Name|Type|
|-|-|
|alignment|long|
|BackgroundColor|Color|
|ChangeIntervalSlider|float|
|Content|long|
|Font|long|
|FontColor|Color|
|FontSize|float|
|Name|StringBuilder|
|OnOff|bool|
|PreserveAspectRatio|bool|
|SafeZoneBuildingCb|bool|
|SafeZoneBuildingProjectionCb|bool|
|SafeZoneColor|Color|
|SafeZoneConvertToStationCb|bool|
|SafeZoneCreate|bool|
|SafeZoneDamageCb|bool|
|SafeZoneDrillingCb|bool|
|SafeZoneGrindingCb|bool|
|SafeZoneLandingGearCb|bool|
|SafeZoneShapeCombo|long|
|SafeZoneShootingCb|bool|
|SafeZoneSlider|float|
|SafeZoneTextureCombo|long|
|SafeZoneVoxelHandCb|bool|
|SafeZoneWeldingCb|bool|
|SafeZoneXSlider|float|
|SafeZoneYSlider|float|
|SafeZoneZSlider|float|
|ScriptBackgroundColor|Color|
|ScriptForegroundColor|Color|
|ShowInInventory|bool|
|ShowInTerminal|bool|
|ShowInToolbarConfig|bool|
|ShowOnHUD|bool|
|TextPaddingSlider|float|

## IMySensorBlock

### Actions

|Name|Description|
|-|-|
|DecreaseBack|Decrease Back extent|
|DecreaseBottom|Decrease Bottom extent|
|DecreaseChangeIntervalSlider|Decrease Image change interval|
|DecreaseFontSize|Decrease Font Size|
|DecreaseFront|Decrease Front extent|
|DecreaseLeft|Decrease Left extent|
|DecreaseRight|Decrease Right extent|
|DecreaseTextPaddingSlider|Decrease Text Padding|
|DecreaseTop|Decrease Top extent|
|Detect Asteroids|Detect asteroids On/Off|
|Detect Asteroids_Off|Detect asteroids Off|
|Detect Asteroids_On|Detect asteroids On|
|Detect Enemy|Detect enemy On/Off|
|Detect Enemy_Off|Detect enemy Off|
|Detect Enemy_On|Detect enemy On|
|Detect Floating Objects|Detect floating objects On/Off|
|Detect Floating Objects_Off|Detect floating objects Off|
|Detect Floating Objects_On|Detect floating objects On|
|Detect Friendly|Detect friendly On/Off|
|Detect Friendly_Off|Detect friendly Off|
|Detect Friendly_On|Detect friendly On|
|Detect Large Ships|Detect large ships On/Off|
|Detect Large Ships_Off|Detect large ships Off|
|Detect Large Ships_On|Detect large ships On|
|Detect Neutral|Detect neutral On/Off|
|Detect Neutral_Off|Detect neutral Off|
|Detect Neutral_On|Detect neutral On|
|Detect Owner|Detect owner On/Off|
|Detect Owner_Off|Detect owner Off|
|Detect Owner_On|Detect owner On|
|Detect Players|Detect players On/Off|
|Detect Players_Off|Detect players Off|
|Detect Players_On|Detect players On|
|Detect Small Ships|Detect small ships On/Off|
|Detect Small Ships_Off|Detect small ships Off|
|Detect Small Ships_On|Detect small ships On|
|Detect Stations|Detect stations On/Off|
|Detect Stations_Off|Detect stations Off|
|Detect Stations_On|Detect stations On|
|Detect Subgrids|Detect subgrids On/Off|
|Detect Subgrids_Off|Detect subgrids Off|
|Detect Subgrids_On|Detect subgrids On|
|IncreaseBack|Increase Back extent|
|IncreaseBottom|Increase Bottom extent|
|IncreaseChangeIntervalSlider|Increase Image change interval|
|IncreaseFontSize|Increase Font Size|
|IncreaseFront|Increase Front extent|
|IncreaseLeft|Increase Left extent|
|IncreaseRight|Increase Right extent|
|IncreaseTextPaddingSlider|Increase Text Padding|
|IncreaseTop|Increase Top extent|
|OnOff|Toggle block On/Off|
|OnOff_Off|Toggle block Off|
|OnOff_On|Toggle block On|
|PreserveAspectRatio|Preserve aspect ratio On/Off|
|ShowOnHUD|Show on HUD On/Off|
|ShowOnHUD_Off|Show on HUD Off|
|ShowOnHUD_On|Show on HUD On|

### Properties

|Name|Type|
|-|-|
|alignment|long|
|Audible Proximity Alert|bool|
|Back|float|
|BackgroundColor|Color|
|Bottom|float|
|ChangeIntervalSlider|float|
|Content|long|
|Detect Asteroids|bool|
|Detect Enemy|bool|
|Detect Floating Objects|bool|
|Detect Friendly|bool|
|Detect Large Ships|bool|
|Detect Neutral|bool|
|Detect Owner|bool|
|Detect Players|bool|
|Detect Small Ships|bool|
|Detect Stations|bool|
|Detect Subgrids|bool|
|Font|long|
|FontColor|Color|
|FontSize|float|
|Front|float|
|Left|float|
|Name|StringBuilder|
|OnOff|bool|
|PreserveAspectRatio|bool|
|Right|float|
|ScriptBackgroundColor|Color|
|ScriptForegroundColor|Color|
|ShowInInventory|bool|
|ShowInTerminal|bool|
|ShowInToolbarConfig|bool|
|ShowOnHUD|bool|
|TextPaddingSlider|float|
|Top|float|

## IMyShipConnector

### Actions

|Name|Description|
|-|-|
|CollectAll|Collect All On/Off|
|DecreaseAutoUnlockTime|Decrease Autounlock Time|
|DecreaseChangeIntervalSlider|Decrease Image change interval|
|DecreaseFontSize|Decrease Font Size|
|DecreaseStrength|Decrease Strength|
|DecreaseTextPaddingSlider|Decrease Text Padding|
|EnableParking|Used for parking On/Off|
|IncreaseAutoUnlockTime|Increase Autounlock Time|
|IncreaseChangeIntervalSlider|Increase Image change interval|
|IncreaseFontSize|Increase Font Size|
|IncreaseStrength|Increase Strength|
|IncreaseTextPaddingSlider|Increase Text Padding|
|Lock|Lock|
|OnOff|Toggle block On/Off|
|OnOff_Off|Toggle block Off|
|OnOff_On|Toggle block On|
|PowerTransferOverride|Override Power Transfer On/Off|
|PreserveAspectRatio|Preserve aspect ratio On/Off|
|ShowOnHUD|Show on HUD On/Off|
|ShowOnHUD_Off|Show on HUD Off|
|ShowOnHUD_On|Show on HUD On|
|SwitchLock|Switch lock|
|ThrowOut|Throw Out On/Off|
|Trading|Trading Mode On/Off|
|Unlock|Unlock|

### Properties

|Name|Type|
|-|-|
|alignment|long|
|AutoUnlockTime|float|
|BackgroundColor|Color|
|ChangeIntervalSlider|float|
|CollectAll|bool|
|Content|long|
|EnableParking|bool|
|Font|long|
|FontColor|Color|
|FontSize|float|
|Name|StringBuilder|
|OnOff|bool|
|PowerTransferOverride|bool|
|PreserveAspectRatio|bool|
|ScriptBackgroundColor|Color|
|ScriptForegroundColor|Color|
|ShowInInventory|bool|
|ShowInTerminal|bool|
|ShowInToolbarConfig|bool|
|ShowOnHUD|bool|
|Strength|float|
|TextPaddingSlider|float|
|ThrowOut|bool|
|Trading|bool|

## IMyShipController

### Actions

|Name|Description|
|-|-|
|ControlGyros|Control Gyros On/Off|
|ControlThrusters|Control thrusters On/Off|
|ControlWheels|Control wheels On/Off|
|DampenersOverride|Inertia dampeners On/Off|
|HandBrake|Handbrake On/Off|
|HorizonIndicator|Show horizon and altitude On/Off|
|MainCockpit|Main cockpit On/Off|
|Park|Park On/Off|
|ShowOnHUD|Show on HUD On/Off|
|ShowOnHUD_Off|Show on HUD Off|
|ShowOnHUD_On|Show on HUD On|
|TargetLocking|Enable target locking On/Off|

### Properties

|Name|Type|
|-|-|
|ControlGyros|bool|
|ControlThrusters|bool|
|ControlWheels|bool|
|DampenersOverride|bool|
|HandBrake|bool|
|HorizonIndicator|bool|
|MainCockpit|bool|
|Name|StringBuilder|
|Park|bool|
|ShowInInventory|bool|
|ShowInTerminal|bool|
|ShowInToolbarConfig|bool|
|ShowOnHUD|bool|
|TargetLocking|bool|

## IMyShipDrill

### Actions

|Name|Description|
|-|-|
|DecreaseChangeIntervalSlider|Decrease Image change interval|
|DecreaseFontSize|Decrease Font Size|
|DecreaseTextPaddingSlider|Decrease Text Padding|
|IncreaseChangeIntervalSlider|Increase Image change interval|
|IncreaseFontSize|Increase Font Size|
|IncreaseTextPaddingSlider|Increase Text Padding|
|OnOff|Toggle block On/Off|
|OnOff_Off|Toggle block Off|
|OnOff_On|Toggle block On|
|PreserveAspectRatio|Preserve aspect ratio On/Off|
|ShowOnHUD|Show on HUD On/Off|
|ShowOnHUD_Off|Show on HUD Off|
|ShowOnHUD_On|Show on HUD On|
|UseConveyor|Use Conveyor System On/Off|

### Properties

|Name|Type|
|-|-|
|alignment|long|
|BackgroundColor|Color|
|ChangeIntervalSlider|float|
|Content|long|
|Font|long|
|FontColor|Color|
|FontSize|float|
|Name|StringBuilder|
|OnOff|bool|
|PreserveAspectRatio|bool|
|ScriptBackgroundColor|Color|
|ScriptForegroundColor|Color|
|ShowInInventory|bool|
|ShowInTerminal|bool|
|ShowInToolbarConfig|bool|
|ShowOnHUD|bool|
|TextPaddingSlider|float|
|UseConveyor|bool|

## IMyShipGrinder

### Actions

|Name|Description|
|-|-|
|DecreaseChangeIntervalSlider|Decrease Image change interval|
|DecreaseFontSize|Decrease Font Size|
|DecreaseTextPaddingSlider|Decrease Text Padding|
|IncreaseChangeIntervalSlider|Increase Image change interval|
|IncreaseFontSize|Increase Font Size|
|IncreaseTextPaddingSlider|Increase Text Padding|
|OnOff|Toggle block On/Off|
|OnOff_Off|Toggle block Off|
|OnOff_On|Toggle block On|
|PreserveAspectRatio|Preserve aspect ratio On/Off|
|ShowOnHUD|Show on HUD On/Off|
|ShowOnHUD_Off|Show on HUD Off|
|ShowOnHUD_On|Show on HUD On|
|UseConveyor|Use Conveyor System On/Off|

### Properties

|Name|Type|
|-|-|
|alignment|long|
|BackgroundColor|Color|
|ChangeIntervalSlider|float|
|Content|long|
|Font|long|
|FontColor|Color|
|FontSize|float|
|Name|StringBuilder|
|OnOff|bool|
|PreserveAspectRatio|bool|
|ScriptBackgroundColor|Color|
|ScriptForegroundColor|Color|
|ShowInInventory|bool|
|ShowInTerminal|bool|
|ShowInToolbarConfig|bool|
|ShowOnHUD|bool|
|TextPaddingSlider|float|
|UseConveyor|bool|

## IMyShipMergeBlock

### Actions

|Name|Description|
|-|-|
|DecreaseChangeIntervalSlider|Decrease Image change interval|
|DecreaseFontSize|Decrease Font Size|
|DecreaseTextPaddingSlider|Decrease Text Padding|
|IncreaseChangeIntervalSlider|Increase Image change interval|
|IncreaseFontSize|Increase Font Size|
|IncreaseTextPaddingSlider|Increase Text Padding|
|OnOff|Toggle block On/Off|
|OnOff_Off|Toggle block Off|
|OnOff_On|Toggle block On|
|PreserveAspectRatio|Preserve aspect ratio On/Off|
|ShowOnHUD|Show on HUD On/Off|
|ShowOnHUD_Off|Show on HUD Off|
|ShowOnHUD_On|Show on HUD On|

### Properties

|Name|Type|
|-|-|
|alignment|long|
|BackgroundColor|Color|
|ChangeIntervalSlider|float|
|Content|long|
|Font|long|
|FontColor|Color|
|FontSize|float|
|Name|StringBuilder|
|OnOff|bool|
|PreserveAspectRatio|bool|
|ScriptBackgroundColor|Color|
|ScriptForegroundColor|Color|
|ShowInInventory|bool|
|ShowInTerminal|bool|
|ShowInToolbarConfig|bool|
|ShowOnHUD|bool|
|TextPaddingSlider|float|

## IMyShipWelder

### Actions

|Name|Description|
|-|-|
|DecreaseChangeIntervalSlider|Decrease Image change interval|
|DecreaseFontSize|Decrease Font Size|
|DecreaseTextPaddingSlider|Decrease Text Padding|
|helpOthers|Help Others On/Off|
|IncreaseChangeIntervalSlider|Increase Image change interval|
|IncreaseFontSize|Increase Font Size|
|IncreaseTextPaddingSlider|Increase Text Padding|
|OnOff|Toggle block On/Off|
|OnOff_Off|Toggle block Off|
|OnOff_On|Toggle block On|
|PreserveAspectRatio|Preserve aspect ratio On/Off|
|ShowOnHUD|Show on HUD On/Off|
|ShowOnHUD_Off|Show on HUD Off|
|ShowOnHUD_On|Show on HUD On|
|UseConveyor|Use Conveyor System On/Off|

### Properties

|Name|Type|
|-|-|
|alignment|long|
|BackgroundColor|Color|
|ChangeIntervalSlider|float|
|Content|long|
|Font|long|
|FontColor|Color|
|FontSize|float|
|helpOthers|bool|
|Name|StringBuilder|
|OnOff|bool|
|PreserveAspectRatio|bool|
|ScriptBackgroundColor|Color|
|ScriptForegroundColor|Color|
|ShowInInventory|bool|
|ShowInTerminal|bool|
|ShowInToolbarConfig|bool|
|ShowOnHUD|bool|
|TextPaddingSlider|float|
|UseConveyor|bool|

## IMySmallGatlingGun

### Actions

|Name|Description|
|-|-|
|DecreaseChangeIntervalSlider|Decrease Image change interval|
|DecreaseFontSize|Decrease Font Size|
|DecreaseTextPaddingSlider|Decrease Text Padding|
|IncreaseChangeIntervalSlider|Increase Image change interval|
|IncreaseFontSize|Increase Font Size|
|IncreaseTextPaddingSlider|Increase Text Padding|
|OnOff|Toggle block On/Off|
|OnOff_Off|Toggle block Off|
|OnOff_On|Toggle block On|
|PreserveAspectRatio|Preserve aspect ratio On/Off|
|Shoot|Shoot On/Off|
|Shoot_Off|Shoot Off|
|Shoot_On|Shoot On|
|ShootOnce|Shoot once|
|ShowOnHUD|Show on HUD On/Off|
|ShowOnHUD_Off|Show on HUD Off|
|ShowOnHUD_On|Show on HUD On|
|UseConveyor|Use Conveyor System On/Off|

### Properties

|Name|Type|
|-|-|
|alignment|long|
|BackgroundColor|Color|
|ChangeIntervalSlider|float|
|Content|long|
|Font|long|
|FontColor|Color|
|FontSize|float|
|Name|StringBuilder|
|OnOff|bool|
|PreserveAspectRatio|bool|
|ScriptBackgroundColor|Color|
|ScriptForegroundColor|Color|
|Shoot|bool|
|ShowInInventory|bool|
|ShowInTerminal|bool|
|ShowInToolbarConfig|bool|
|ShowOnHUD|bool|
|TextPaddingSlider|float|
|UseConveyor|bool|

## IMySmallMissileLauncher

### Actions

|Name|Description|
|-|-|
|DecreaseChangeIntervalSlider|Decrease Image change interval|
|DecreaseFontSize|Decrease Font Size|
|DecreaseTextPaddingSlider|Decrease Text Padding|
|IncreaseChangeIntervalSlider|Increase Image change interval|
|IncreaseFontSize|Increase Font Size|
|IncreaseTextPaddingSlider|Increase Text Padding|
|OnOff|Toggle block On/Off|
|OnOff_Off|Toggle block Off|
|OnOff_On|Toggle block On|
|PreserveAspectRatio|Preserve aspect ratio On/Off|
|Shoot|Shoot On/Off|
|Shoot_Off|Shoot Off|
|Shoot_On|Shoot On|
|ShootOnce|Shoot once|
|ShowOnHUD|Show on HUD On/Off|
|ShowOnHUD_Off|Show on HUD Off|
|ShowOnHUD_On|Show on HUD On|
|UseConveyor|Use Conveyor System On/Off|

### Properties

|Name|Type|
|-|-|
|alignment|long|
|BackgroundColor|Color|
|ChangeIntervalSlider|float|
|Content|long|
|Font|long|
|FontColor|Color|
|FontSize|float|
|Name|StringBuilder|
|OnOff|bool|
|PreserveAspectRatio|bool|
|ScriptBackgroundColor|Color|
|ScriptForegroundColor|Color|
|Shoot|bool|
|ShowInInventory|bool|
|ShowInTerminal|bool|
|ShowInToolbarConfig|bool|
|ShowOnHUD|bool|
|TextPaddingSlider|float|
|UseConveyor|bool|

## IMySmallMissileLauncherReload

### Actions

|Name|Description|
|-|-|
|DecreaseChangeIntervalSlider|Decrease Image change interval|
|DecreaseFontSize|Decrease Font Size|
|DecreaseTextPaddingSlider|Decrease Text Padding|
|IncreaseChangeIntervalSlider|Increase Image change interval|
|IncreaseFontSize|Increase Font Size|
|IncreaseTextPaddingSlider|Increase Text Padding|
|OnOff|Toggle block On/Off|
|OnOff_Off|Toggle block Off|
|OnOff_On|Toggle block On|
|PreserveAspectRatio|Preserve aspect ratio On/Off|
|Shoot|Shoot On/Off|
|Shoot_Off|Shoot Off|
|Shoot_On|Shoot On|
|ShootOnce|Shoot once|
|ShowOnHUD|Show on HUD On/Off|
|ShowOnHUD_Off|Show on HUD Off|
|ShowOnHUD_On|Show on HUD On|
|UseConveyor|Use Conveyor System On/Off|
|UseConveyor|Use Conveyor System On/Off|

### Properties

|Name|Type|
|-|-|
|alignment|long|
|BackgroundColor|Color|
|ChangeIntervalSlider|float|
|Content|long|
|Font|long|
|FontColor|Color|
|FontSize|float|
|Name|StringBuilder|
|OnOff|bool|
|PreserveAspectRatio|bool|
|ScriptBackgroundColor|Color|
|ScriptForegroundColor|Color|
|Shoot|bool|
|ShowInInventory|bool|
|ShowInTerminal|bool|
|ShowInToolbarConfig|bool|
|ShowOnHUD|bool|
|TextPaddingSlider|float|
|UseConveyor|bool|
|UseConveyor|bool|

## IMySolarPanel

### Actions

|Name|Description|
|-|-|
|DecreaseChangeIntervalSlider|Decrease Image change interval|
|DecreaseFontSize|Decrease Font Size|
|DecreaseTextPaddingSlider|Decrease Text Padding|
|IncreaseChangeIntervalSlider|Increase Image change interval|
|IncreaseFontSize|Increase Font Size|
|IncreaseTextPaddingSlider|Increase Text Padding|
|OnOff|Toggle block On/Off|
|OnOff_Off|Toggle block Off|
|OnOff_On|Toggle block On|
|PreserveAspectRatio|Preserve aspect ratio On/Off|
|ShowOnHUD|Show on HUD On/Off|
|ShowOnHUD_Off|Show on HUD Off|
|ShowOnHUD_On|Show on HUD On|

### Properties

|Name|Type|
|-|-|
|alignment|long|
|BackgroundColor|Color|
|ChangeIntervalSlider|float|
|Content|long|
|Font|long|
|FontColor|Color|
|FontSize|float|
|Name|StringBuilder|
|OnOff|bool|
|PreserveAspectRatio|bool|
|ScriptBackgroundColor|Color|
|ScriptForegroundColor|Color|
|ShowInInventory|bool|
|ShowInTerminal|bool|
|ShowInToolbarConfig|bool|
|ShowOnHUD|bool|
|TextPaddingSlider|float|

## IMySoundBlock

### Actions

|Name|Description|
|-|-|
|DecreaseChangeIntervalSlider|Decrease Image change interval|
|DecreaseFontSize|Decrease Font Size|
|DecreaseLoopableSlider|Decrease Loop time|
|DecreaseRangeSlider|Decrease Range|
|DecreaseTextPaddingSlider|Decrease Text Padding|
|DecreaseVolumeSlider|Decrease Volume|
|IncreaseChangeIntervalSlider|Increase Image change interval|
|IncreaseFontSize|Increase Font Size|
|IncreaseLoopableSlider|Increase Loop time|
|IncreaseRangeSlider|Increase Range|
|IncreaseTextPaddingSlider|Increase Text Padding|
|IncreaseVolumeSlider|Increase Volume|
|OnOff|Toggle block On/Off|
|OnOff_Off|Toggle block Off|
|OnOff_On|Toggle block On|
|PlaySound|Play|
|PreserveAspectRatio|Preserve aspect ratio On/Off|
|ShowOnHUD|Show on HUD On/Off|
|ShowOnHUD_Off|Show on HUD Off|
|ShowOnHUD_On|Show on HUD On|
|StopSound|Stop|

### Properties

|Name|Type|
|-|-|
|alignment|long|
|BackgroundColor|Color|
|ChangeIntervalSlider|float|
|Content|long|
|Font|long|
|FontColor|Color|
|FontSize|float|
|LoopableSlider|float|
|Name|StringBuilder|
|OnOff|bool|
|PreserveAspectRatio|bool|
|RangeSlider|float|
|ScriptBackgroundColor|Color|
|ScriptForegroundColor|Color|
|ShowInInventory|bool|
|ShowInTerminal|bool|
|ShowInToolbarConfig|bool|
|ShowOnHUD|bool|
|TextPaddingSlider|float|
|VolumeSlider|float|

## IMySpaceBall

### Actions

|Name|Description|
|-|-|
|DecreaseChangeIntervalSlider|Decrease Image change interval|
|DecreaseFontSize|Decrease Font Size|
|DecreaseTextPaddingSlider|Decrease Text Padding|
|DecreaseVirtualMass|Decrease Virtual mass|
|EnableBroadCast|Enable broadcasting On/Off|
|IncreaseChangeIntervalSlider|Increase Image change interval|
|IncreaseFontSize|Increase Font Size|
|IncreaseTextPaddingSlider|Increase Text Padding|
|IncreaseVirtualMass|Increase Virtual mass|
|OnOff|Toggle block On/Off|
|OnOff_Off|Toggle block Off|
|OnOff_On|Toggle block On|
|PreserveAspectRatio|Preserve aspect ratio On/Off|
|ShowOnHUD|Show on HUD On/Off|
|ShowOnHUD_Off|Show on HUD Off|
|ShowOnHUD_On|Show on HUD On|

### Properties

|Name|Type|
|-|-|
|alignment|long|
|BackgroundColor|Color|
|ChangeIntervalSlider|float|
|Content|long|
|EnableBroadCast|bool|
|Font|long|
|FontColor|Color|
|FontSize|float|
|Name|StringBuilder|
|OnOff|bool|
|PreserveAspectRatio|bool|
|ScriptBackgroundColor|Color|
|ScriptForegroundColor|Color|
|ShowInInventory|bool|
|ShowInTerminal|bool|
|ShowInToolbarConfig|bool|
|ShowOnHUD|bool|
|TextPaddingSlider|float|
|VirtualMass|float|

## IMyStoreBlock

### Actions

|Name|Description|
|-|-|
|AnyoneCanUse|Anyone Can Use On/Off|
|DecreaseChangeIntervalSlider|Decrease Image change interval|
|DecreaseFontSize|Decrease Font Size|
|DecreaseTextPaddingSlider|Decrease Text Padding|
|IncreaseChangeIntervalSlider|Increase Image change interval|
|IncreaseFontSize|Increase Font Size|
|IncreaseTextPaddingSlider|Increase Text Padding|
|OnOff|Toggle block On/Off|
|OnOff_Off|Toggle block Off|
|OnOff_On|Toggle block On|
|PreserveAspectRatio|Preserve aspect ratio On/Off|
|ShowOnHUD|Show on HUD On/Off|
|ShowOnHUD_Off|Show on HUD Off|
|ShowOnHUD_On|Show on HUD On|
|UseConveyor|Use Conveyor System On/Off|

### Properties

|Name|Type|
|-|-|
|alignment|long|
|AnyoneCanUse|bool|
|BackgroundColor|Color|
|ChangeIntervalSlider|float|
|Content|long|
|Font|long|
|FontColor|Color|
|FontSize|float|
|Name|StringBuilder|
|OnOff|bool|
|PreserveAspectRatio|bool|
|ScriptBackgroundColor|Color|
|ScriptForegroundColor|Color|
|ShowInInventory|bool|
|ShowInTerminal|bool|
|ShowInToolbarConfig|bool|
|ShowOnHUD|bool|
|TextPaddingSlider|float|
|UseConveyor|bool|

## IMyTargetDummyBlock

### Actions

|Name|Description|
|-|-|
|DecreaseChangeIntervalSlider|Decrease Image change interval|
|DecreaseDelay|Decrease Regeneration delay|
|DecreaseFontSize|Decrease Font Size|
|DecreaseTextPaddingSlider|Decrease Text Padding|
|IncreaseChangeIntervalSlider|Increase Image change interval|
|IncreaseDelay|Increase Regeneration delay|
|IncreaseFontSize|Increase Font Size|
|IncreaseTextPaddingSlider|Increase Text Padding|
|OnOff|Toggle block On/Off|
|OnOff_Off|Toggle block Off|
|OnOff_On|Toggle block On|
|PreserveAspectRatio|Preserve aspect ratio On/Off|
|ShowOnHUD|Show on HUD On/Off|
|ShowOnHUD_Off|Show on HUD Off|
|ShowOnHUD_On|Show on HUD On|

### Properties

|Name|Type|
|-|-|
|alignment|long|
|BackgroundColor|Color|
|ChangeIntervalSlider|float|
|Content|long|
|Delay|float|
|Enable Restoration|bool|
|Font|long|
|FontColor|Color|
|FontSize|float|
|Name|StringBuilder|
|OnOff|bool|
|PreserveAspectRatio|bool|
|ScriptBackgroundColor|Color|
|ScriptForegroundColor|Color|
|ShowInInventory|bool|
|ShowInTerminal|bool|
|ShowInToolbarConfig|bool|
|ShowOnHUD|bool|
|TextPaddingSlider|float|

## IMyTerminalBlock

### Actions

|Name|Description|
|-|-|
|ShowOnHUD|Show on HUD On/Off|
|ShowOnHUD_Off|Show on HUD Off|
|ShowOnHUD_On|Show on HUD On|

### Properties

|Name|Type|
|-|-|
|Name|StringBuilder|
|ShowInInventory|bool|
|ShowInTerminal|bool|
|ShowInToolbarConfig|bool|
|ShowOnHUD|bool|

## IMyTextPanel

### Actions

|Name|Description|
|-|-|
|DecreaseChangeIntervalSlider|Decrease Image change interval|
|DecreaseChangeIntervalSlider|Decrease Image change interval|
|DecreaseFontSize|Decrease Font Size|
|DecreaseFontSize|Decrease Font Size|
|DecreaseRotate|Decrease Rotation|
|DecreaseTextPaddingSlider|Decrease Text Padding|
|DecreaseTextPaddingSlider|Decrease Text Padding|
|IncreaseChangeIntervalSlider|Increase Image change interval|
|IncreaseChangeIntervalSlider|Increase Image change interval|
|IncreaseFontSize|Increase Font Size|
|IncreaseFontSize|Increase Font Size|
|IncreaseRotate|Increase Rotation|
|IncreaseTextPaddingSlider|Increase Text Padding|
|IncreaseTextPaddingSlider|Increase Text Padding|
|OnOff|Toggle block On/Off|
|OnOff_Off|Toggle block Off|
|OnOff_On|Toggle block On|
|PreserveAspectRatio|Preserve aspect ratio On/Off|
|PreserveAspectRatio|Preserve aspect ratio On/Off|
|ShowOnHUD|Show on HUD On/Off|
|ShowOnHUD_Off|Show on HUD Off|
|ShowOnHUD_On|Show on HUD On|

### Properties

|Name|Type|
|-|-|
|alignment|long|
|alignment|long|
|BackgroundColor|Color|
|BackgroundColor|Color|
|ChangeIntervalSlider|float|
|ChangeIntervalSlider|float|
|Content|long|
|Content|long|
|Font|long|
|Font|long|
|FontColor|Color|
|FontColor|Color|
|FontSize|float|
|FontSize|float|
|Name|StringBuilder|
|OnOff|bool|
|PreserveAspectRatio|bool|
|PreserveAspectRatio|bool|
|Rotate|float|
|ScriptBackgroundColor|Color|
|ScriptBackgroundColor|Color|
|ScriptForegroundColor|Color|
|ScriptForegroundColor|Color|
|ShowInInventory|bool|
|ShowInTerminal|bool|
|ShowInToolbarConfig|bool|
|ShowOnHUD|bool|
|TextPaddingSlider|float|
|TextPaddingSlider|float|
|Title|StringBuilder|

## IMyThrust

### Actions

|Name|Description|
|-|-|
|DecreaseChangeIntervalSlider|Decrease Image change interval|
|DecreaseFontSize|Decrease Font Size|
|DecreaseOverride|Decrease Thrust override|
|DecreaseTextPaddingSlider|Decrease Text Padding|
|IncreaseChangeIntervalSlider|Increase Image change interval|
|IncreaseFontSize|Increase Font Size|
|IncreaseOverride|Increase Thrust override|
|IncreaseTextPaddingSlider|Increase Text Padding|
|OnOff|Toggle block On/Off|
|OnOff_Off|Toggle block Off|
|OnOff_On|Toggle block On|
|PreserveAspectRatio|Preserve aspect ratio On/Off|
|ShowOnHUD|Show on HUD On/Off|
|ShowOnHUD_Off|Show on HUD Off|
|ShowOnHUD_On|Show on HUD On|

### Properties

|Name|Type|
|-|-|
|alignment|long|
|BackgroundColor|Color|
|ChangeIntervalSlider|float|
|Content|long|
|Font|long|
|FontColor|Color|
|FontSize|float|
|Name|StringBuilder|
|OnOff|bool|
|Override|float|
|PreserveAspectRatio|bool|
|ScriptBackgroundColor|Color|
|ScriptForegroundColor|Color|
|ShowInInventory|bool|
|ShowInTerminal|bool|
|ShowInToolbarConfig|bool|
|ShowOnHUD|bool|
|TextPaddingSlider|float|

## IMyTimerBlock

### Actions

|Name|Description|
|-|-|
|DecreaseChangeIntervalSlider|Decrease Image change interval|
|DecreaseFontSize|Decrease Font Size|
|DecreaseTextPaddingSlider|Decrease Text Padding|
|DecreaseTriggerDelay|Decrease Delay|
|IncreaseChangeIntervalSlider|Increase Image change interval|
|IncreaseFontSize|Increase Font Size|
|IncreaseTextPaddingSlider|Increase Text Padding|
|IncreaseTriggerDelay|Increase Delay|
|OnOff|Toggle block On/Off|
|OnOff_Off|Toggle block Off|
|OnOff_On|Toggle block On|
|PreserveAspectRatio|Preserve aspect ratio On/Off|
|ShowOnHUD|Show on HUD On/Off|
|ShowOnHUD_Off|Show on HUD Off|
|ShowOnHUD_On|Show on HUD On|
|Silent|Silent On/Off|
|Start|Start|
|Stop|Stop|
|TriggerNow|Trigger now|

### Properties

|Name|Type|
|-|-|
|alignment|long|
|BackgroundColor|Color|
|ChangeIntervalSlider|float|
|Content|long|
|Font|long|
|FontColor|Color|
|FontSize|float|
|Name|StringBuilder|
|OnOff|bool|
|PreserveAspectRatio|bool|
|ScriptBackgroundColor|Color|
|ScriptForegroundColor|Color|
|ShowInInventory|bool|
|ShowInTerminal|bool|
|ShowInToolbarConfig|bool|
|ShowOnHUD|bool|
|Silent|bool|
|TextPaddingSlider|float|
|TriggerDelay|float|

## IMyTurretControlBlock

### Actions

|Name|Description|
|-|-|
|AI|Enable AI On/Off|
|AI_Off|Enable AI Off|
|AI_On|Enable AI On|
|CopyTarget|Copy target|
|DecreaseAngleDeviation|Decrease Angle deviation|
|DecreaseChangeIntervalSlider|Decrease Image change interval|
|DecreaseFontSize|Decrease Font Size|
|DecreaseMultiplierAz|Decrease Azimuth velocity multiplier|
|DecreaseMultiplierEl|Decrease Elevation velocity multiplier|
|DecreaseRange|Decrease AI aiming radius|
|DecreaseTextPaddingSlider|Decrease Text Padding|
|EnableTargetLocking|Enable target locking On/Off|
|ForgetTarget|Forget target|
|IncreaseAngleDeviation|Increase Angle deviation|
|IncreaseChangeIntervalSlider|Increase Image change interval|
|IncreaseFontSize|Increase Font Size|
|IncreaseMultiplierAz|Increase Azimuth velocity multiplier|
|IncreaseMultiplierEl|Increase Elevation velocity multiplier|
|IncreaseRange|Increase AI aiming radius|
|IncreaseTextPaddingSlider|Increase Text Padding|
|OnOff|Toggle block On/Off|
|OnOff_Off|Toggle block Off|
|OnOff_On|Toggle block On|
|PreserveAspectRatio|Preserve aspect ratio On/Off|
|ShowOnHUD|Show on HUD On/Off|
|ShowOnHUD_Off|Show on HUD Off|
|ShowOnHUD_On|Show on HUD On|
|TargetCharacters|Target characters On/Off|
|TargetCharacters_Off|Target characters Off|
|TargetCharacters_On|Target characters On|
|TargetEnemies|Target Enemies On/Off|
|TargetEnemies_Off|Target Enemies Off|
|TargetEnemies_On|Target Enemies On|
|TargetFriends|Target Friends On/Off|
|TargetFriends_Off|Target Friends Off|
|TargetFriends_On|Target Friends On|
|TargetingGroup_CycleSubsystems|Cycle Subsystems|
|TargetingGroup_PowerSystems|Target Power systems|
|TargetingGroup_Propulsion|Target Propulsion|
|TargetingGroup_Weapons|Target Weapons|
|TargetLargeShips|Target large ships On/Off|
|TargetLargeShips_Off|Target large ships Off|
|TargetLargeShips_On|Target large ships On|
|TargetMeteors|Target meteors On/Off|
|TargetMeteors_Off|Target meteors Off|
|TargetMeteors_On|Target meteors On|
|TargetMissiles|Target missiles On/Off|
|TargetMissiles_Off|Target missiles Off|
|TargetMissiles_On|Target missiles On|
|TargetNeutrals|Target neutrals On/Off|
|TargetNeutrals_Off|Target neutrals Off|
|TargetNeutrals_On|Target neutrals On|
|TargetSmallShips|Target small ships On/Off|
|TargetSmallShips_Off|Target small ships Off|
|TargetSmallShips_On|Target small ships On|
|TargetStations|Target stations On/Off|
|TargetStations_Off|Target stations Off|
|TargetStations_On|Target stations On|

### Properties

|Name|Type|
|-|-|
|AI|bool|
|alignment|long|
|AngleDeviation|float|
|BackgroundColor|Color|
|CameraList|long|
|ChangeIntervalSlider|float|
|Content|long|
|EnableTargetLocking|bool|
|Font|long|
|FontColor|Color|
|FontSize|float|
|MultiplierAz|float|
|MultiplierEl|float|
|Name|StringBuilder|
|OnOff|bool|
|PreserveAspectRatio|bool|
|Range|float|
|RotorAzimuth|long|
|RotorElevation|long|
|ScriptBackgroundColor|Color|
|ScriptForegroundColor|Color|
|ShowInInventory|bool|
|ShowInTerminal|bool|
|ShowInToolbarConfig|bool|
|ShowOnHUD|bool|
|TargetCharacters|bool|
|TargetEnemies|bool|
|TargetFriends|bool|
|TargetingGroup_Selector|long|
|TargetLargeShips|bool|
|TargetMeteors|bool|
|TargetMissiles|bool|
|TargetNeutrals|bool|
|TargetSmallShips|bool|
|TargetStations|bool|
|TextPaddingSlider|float|

## IMyUpgradeModule

### Actions

|Name|Description|
|-|-|
|DecreaseChangeIntervalSlider|Decrease Image change interval|
|DecreaseFontSize|Decrease Font Size|
|DecreaseTextPaddingSlider|Decrease Text Padding|
|IncreaseChangeIntervalSlider|Increase Image change interval|
|IncreaseFontSize|Increase Font Size|
|IncreaseTextPaddingSlider|Increase Text Padding|
|OnOff|Toggle block On/Off|
|OnOff_Off|Toggle block Off|
|OnOff_On|Toggle block On|
|PreserveAspectRatio|Preserve aspect ratio On/Off|
|ShowOnHUD|Show on HUD On/Off|
|ShowOnHUD_Off|Show on HUD Off|
|ShowOnHUD_On|Show on HUD On|

### Properties

|Name|Type|
|-|-|
|alignment|long|
|BackgroundColor|Color|
|ChangeIntervalSlider|float|
|Content|long|
|Font|long|
|FontColor|Color|
|FontSize|float|
|Name|StringBuilder|
|OnOff|bool|
|PreserveAspectRatio|bool|
|ScriptBackgroundColor|Color|
|ScriptForegroundColor|Color|
|ShowInInventory|bool|
|ShowInTerminal|bool|
|ShowInToolbarConfig|bool|
|ShowOnHUD|bool|
|TextPaddingSlider|float|

## IMyWarhead

### Actions

|Name|Description|
|-|-|
|DecreaseDetonationTime|Decrease Detonation time|
|Detonate|Detonate|
|IncreaseDetonationTime|Increase Detonation time|
|Safety|Arm warhead On/Off|
|ShowOnHUD|Show on HUD On/Off|
|ShowOnHUD_Off|Show on HUD Off|
|ShowOnHUD_On|Show on HUD On|
|StartCountdown|Start countdown|
|StopCountdown|Stop countdown|

### Properties

|Name|Type|
|-|-|
|DetonationTime|float|
|Name|StringBuilder|
|Safety|bool|
|ShowInInventory|bool|
|ShowInTerminal|bool|
|ShowInToolbarConfig|bool|
|ShowOnHUD|bool|

