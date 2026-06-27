# Compatibility Matrix

This page tracks mods tested with Nitrox Compatibility Framework.

Compatibility can vary by game version, Nitrox version, Nautilus version, and mod version. Use the listed versions when trying to reproduce results.

## Test Environment

| Component | Version |
| --- | --- |
| Subnautica | 1.22.82304 |
| Nitrox | 1.8.1 |
| Tobey's BepInEx Pack | 5.4.23-pack.3.1.1 |
| Nautilus | 1.0.0.pre-51 |
| Nitrox Compatibility Framework | 1.0.0 |

## Status Key

| Status | Meaning |
| --- | --- |
| ✅ Working | Loaded and functioned in Nitrox testing |
| 🟡 Partial | Loaded and mostly worked, but has a known limitation |
| 🔵 Needs More Testing | Initial load/functionality looks promising, but multiplayer behavior needs more validation |
| ⚪ Untested | Not yet tested |

## Core / Utility Mods

| Mod | Version | Status | Notes |
| --- | ---: | :---: | --- |
| Map | 1.5.12 | ✅ Working | Loads and functions in Nitrox |
| QuickStore | 0.2.2 | ✅ Working | Loads and functions in Nitrox |
| ConfigurationManager for BepInEx | 18.4.1-tweaks.2.0.0 | ✅ Working | Required for some modern mods |

## UI / Controls

| Mod | Version | Status | Notes |
| --- | ---: | :---: | --- |
| QuickSlotsPlus | 3.0.0 | 🟡 Partial | Functions, but keybinding assignment for slots above the vanilla five is not currently exposed in settings |

## Storage / Base

| Mod | Version | Status | Notes |
| --- | ---: | :---: | --- |
| VisibleLockerInterior 2025 | 2.0.4 | ✅ Working | Custom locker visuals function in Nitrox |
| AutosortLockersSN | 1.0.8b | ✅ Working | Custom buildables, recipes, and storage systems function in Nitrox |

## Seamoth / Vehicle Equipment

| Mod | Version | Status | Notes |
| --- | ---: | :---: | --- |
| SlotExtender | 3.0 | ✅ Working | Additional vehicle slots function |
| ModdedArmsHelper | 1.6 | ✅ Working | Required by Seamoth Arms |
| SeamothArms | 2.1 | ✅ Working | Arms load and function; tested with drill arm |

## Vehicle Framework

| Mod | Version | Status | Notes |
| --- | ---: | :---: | --- |
| VehicleFramework | 2.0.8 | ✅ Working | Loads and functions with modern Nautilus under Nitrox |
| Beluga | 2.0.4 | ✅ Working | Custom submarine loads and functions in Nitrox |

## Cyclops Mods

| Mod | Version | Status | Notes |
| --- | ---: | :---: | --- |
| MoreCyclopsUpgrades (Purple Edition) | 1.0.2.1 | ✅ Working | Modern Purple Edition confirmed functional |
| CyclopsAutoZapper (Purple Edition) | 1.0.1.1 | ✅ Working | Confirmed functional |
| CyclopsEngineUpgrades (Purple Edition) | 1.0.0.1 | ✅ Working | Confirmed functional |
| CyclopsNuclearUpgrades (Purple Edition) | 1.0.0.1 | ✅ Working | Confirmed functional |
| CyclopsSpeedUpgrades (Purple Edition) | 1.0.0.1 | ✅ Working | Confirmed functional |

## Notes

- Older legacy versions of some mods may fail due to outdated game API references.
- Prefer current modern Nautilus-compatible versions where available.
- Mods should generally be installed with matching versions across all multiplayer clients.
- Multiplayer sync behavior may require additional long-session testing even when initial functionality works.
