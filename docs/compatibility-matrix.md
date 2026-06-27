# Mod Compatibility Matrix

This page tracks compatibility testing performed with Nitrox Compatibility Framework (NCF).

Compatibility may vary depending on game version, Nitrox version, Nautilus version, and the specific mod version installed.

---

## Test Environment

| Component                      | Version           |
| ------------------------------ | ----------------- |
| Subnautica                     | 1.22.82304        |
| Nitrox                         | 1.8.1             |
| Tobey's BepInEx Pack           | 5.4.23-pack.3.1.1 |
| Nautilus                       | 1.0.0.51          |
| Nitrox Compatibility Framework | 1.0.0             |

---

## Test Summary

| Metric                  | Value |
| ----------------------- | ----: |
| Total Mods Evaluated    |    69 |
| Confirmed Working       |    30 |
| Expected Working        |    36 |
| Partial                 |     1 |
| Legacy API Incompatible |     3 |

---

## Status Key

| Status                     | Meaning                                                                                          |
| -------------------------- | ------------------------------------------------------------------------------------------------ |
| ✅ Working                 | No compatibility issues observed.                                                                |
| 🟡 Partial                 | Functions with one or more known limitations.                                                    |
| ❌ Legacy API Incompatible | Built against obsolete Nautilus/Subnautica APIs. Requires recompilation against the current SDK. |

---

## Confidence Key

| Confidence         | Meaning                                                                                                                |
| ------------------ | ---------------------------------------------------------------------------------------------------------------------- |
| Confirmed          | Successfully loaded and validated during multiplayer testing.                                                          |
| Initial Validation | Loaded successfully with no compatibility issues observed, but additional multiplayer gameplay testing is recommended. |

---

## Compatibility Matrix

| Mod                                     |             Version | Status |     Confidence     | Notes                                                              |
| --------------------------------------- | ------------------: | :----: | :----------------: | ------------------------------------------------------------------ |
| AdvancedInventory                       |              1.0.4a |    ✅  | Initial Validation | Loaded successfully.                                               |
| AlterraMiniFridge                       |               1.0.2 |    ❌  |      Confirmed     | Obsolete Nautilus API.                                             |
| AnisotropicFix                          |               2.0.0 |    ✅  | Initial Validation | Loaded successfully.                                               |
| AutoSortLockers SN                      |            1.0.0.0e |    ✅  |      Confirmed     | Multiplayer tested successfully.                                   |
| BagEquipment                            |               1.2.1 |    ✅  | Initial Validation | Loaded successfully.                                               |
| BaseLegsRemoval                         |             2.0.0.1 |    ✅  |      Confirmed     | Loaded successfully.                                               |
| BaseLightSwitch                         |             1.0.0.0 |    ✅  | Initial Validation | Loaded successfully.                                               |
| BepInExTweaks                           |               1.2.1 |    ✅  | Initial Validation | Loaded successfully.                                               |
| BetterBioReactor (Purple Edition)       |             1.0.0.1 |    ✅  | Initial Validation | Loaded successfully.                                               |
| BetterScannerBlips (Purple Edition)     |             1.0.0.1 |    ✅  |      Confirmed     | Multiplayer tested successfully.                                   |
| BetterVehicleStorage (Purple Edition)   |             1.0.1.1 |    ✅  | Initial Validation | Loaded successfully.                                               |
| BlueprintSearchBar                      |               1.1.0 |    ✅  | Initial Validation | Loaded successfully.                                               |
| BlueprintsBetterUI                      |               1.0.2 |    ✅  | Initial Validation | Loaded successfully.                                               |
| BuildingTweaks                          |             2.0.1.1 |    ✅  |      Confirmed     | Multiplayer tested successfully.                                   |
| ConfigurationManager for BepInEx        | 18.4.1-tweaks.2.0.0 |    ✅  |      Confirmed     | Required dependency.                                               |
| CuddlefishRecall                        |               1.4.0 |    ✅  |      Confirmed     | Multiplayer tested successfully.                                   |
| CustomizedStorage                       |               1.0.5 |    ✅  | Initial Validation | Loaded successfully.                                               |
| CustomizeYourSpawns                     |             2.0.0.1 |    ✅  | Initial Validation | Loaded successfully.                                               |
| CyclopsAutoZappers (Purple Edition)     |             1.0.1.1 |    ✅  |      Confirmed     | Multiplayer tested successfully.                                   |
| CyclopsDockingMod                       |               2.1.1 |    ❌  |      Confirmed     | Obsolete Nautilus API.                                             |
| CyclopsEngineUpgrades (Purple Edition)  |             1.0.0.1 |    ✅  |      Confirmed     | Multiplayer tested successfully.                                   |
| CyclopsEnhancement_Sonar                |                 0.1 |    ✅  |      Confirmed     | Multiplayer tested successfully.                                   |
| CyclopsNuclearUpgrades (Purple Edition) |             1.0.0.1 |    ✅  |      Confirmed     | Multiplayer tested successfully.                                   |
| CyclopsSpeedUpgrades (Purple Edition)   |             1.0.0.1 |    ✅  |      Confirmed     | Multiplayer tested successfully.                                   |
| Defabricator                            |             2.0.1.1 |    ✅  | Initial Validation | Loaded successfully.                                               |
| DrillableScan                           |               2.0.0 |    ✅  | Initial Validation | Loaded successfully.                                               |
| DropStorageItemsOnDestroy               |               1.0.1 |    ✅  | Initial Validation | Loaded successfully.                                               |
| DropUpgradesOnDestroy                   |             2.0.0.1 |    ✅  | Initial Validation | Loaded successfully.                                               |
| EasyCraft                               |               1.1.6 |    ✅  | Initial Validation | Loaded successfully.                                               |
| EnableAchievements                      |               5.0.0 |    ✅  |      Confirmed     | Multiplayer tested successfully.                                   |
| EnhancedGravTrap                        |               1.4.3 |    ✅  | Initial Validation | Loaded successfully.                                               |
| FabricatorNoAutoClose                   |             2.0.0.1 |    ✅  | Initial Validation | Loaded successfully.                                               |
| FastLoadingScreen                       |               2.0.1 |    ✅  | Initial Validation | Loaded successfully.                                               |
| FreeBaseLights                          |               1.0.0 |    ✅  | Initial Validation | Loaded successfully.                                               |
| FreeLook                                |               2.4.4 |    ✅  |      Confirmed     | Multiplayer tested successfully.                                   |
| GeysersPerformanceFix                   |               1.0.1 |    ✅  | Initial Validation | Loaded successfully.                                               |
| HullReinforcementFix                    |               1.2.7 |    ✅  |      Confirmed     | Multiplayer tested successfully.                                   |
| ImprovedPowerNetwork                    |             2.0.0.1 |    ✅  |      Confirmed     | Multiplayer tested successfully.                                   |
| ImprovedScanInfo                        |               2.0.0 |    ✅  |      Confirmed     | Multiplayer tested successfully.                                   |
| LaserCutterSpeed                        |               2.5.0 |    ✅  |      Confirmed     | Multiplayer tested successfully.                                   |
| LongerSigns                             |               1.0.0 |    ✅  | Initial Validation | Loaded successfully.                                               |
| Map                                     |              1.5.12 |    ✅  |      Confirmed     | Multiplayer tested successfully.                                   |
| MoonpoolVehicleRepair SN                |               1.0.7 |    ✅  |      Confirmed     | Multiplayer tested successfully.                                   |
| MoreCyclopsUpgrades (Purple Edition)    |             1.0.2.1 |    ✅  |      Confirmed     | Multiplayer tested successfully.                                   |
| MoreModifiedItems (Purple Edition)      |             2.0.5.1 |    ✅  | Initial Validation | Loaded successfully.                                               |
| NoEpilepsyWarning                       |               5.0.0 |    ✅  |      Confirmed     | Multiplayer tested successfully.                                   |
| NoLoudBangsInCyclops                    |               1.0.2 |    ✅  | Initial Validation | Loaded successfully.                                               |
| PickupableStorageEnhanced               |             2.0.0.2 |    ✅  | Initial Validation | Loaded successfully.                                               |
| PicturesFromDatabase                    |                 1.0 |    ✅  | Initial Validation | Loaded successfully.                                               |
| QuickBatterySwitch                      |               0.1.0 |    ✅  |      Confirmed     | Multiplayer tested successfully.                                   |
| QuickSlotsPlus                          |               3.0.0 |   🟡   |      Confirmed     | Additional quick-slot keybinding assignment not currently exposed. |
| QuickStore                              |               0.2.2 |    ✅  |      Confirmed     | Multiplayer tested successfully.                                   |
| QuickUnpinRecipes                       |               1.1.0 |    ✅  | Initial Validation | Loaded successfully.                                               |
| RadialTabs                              |             2.0.0.1 |    ✅  | Initial Validation | Loaded successfully.                                               |
| RepairTransportLights                   |                 1.0 |    ✅  | Initial Validation | Loaded successfully.                                               |
| ScannableTimeCapsules                   |             2.0.0.1 |    ✅  | Initial Validation | Loaded successfully.                                               |
| SeamothEject                            |               2.0.2 |    ✅  |      Confirmed     | Multiplayer tested successfully.                                   |
| SeamothEnhancement_Sonar                |              0.10.0 |    ✅  |      Confirmed     | Multiplayer tested successfully.                                   |
| SeamothThermalReactor                   |             2.0.0.1 |    ✅  | Initial Validation | Loaded successfully.                                               |
| SinkingItemsFix                         |               2.0.0 |    ✅  | Initial Validation | Loaded successfully.                                               |
| SleekBases                              |                 2.3 |    ✅  |      Confirmed     | Multiplayer tested successfully.                                   |
| SlotExtender                            |                 3.0 |    ✅  |      Confirmed     | Multiplayer tested successfully.                                   |
| SnapBuilder                             |                 2.4 |    ✅  | Initial Validation | Loaded successfully.                                               |
| StorageInfo                             |               2.2.0 |    ✅  | Initial Validation | Loaded successfully.                                               |
| SwimChargeInventory                     |               2.1.0 |    ✅  |      Confirmed     | Multiplayer tested successfully.                                   |
| TrackEverything                         |               0.1.0 |    ✅  |      Confirmed     | Multiplayer tested successfully.                                   |
| TrueBaseColorizer                       |                 1.8 |    ❌  |      Confirmed     | Obsolete Nautilus API.                                             |
| UpgradedJumpJetModule                   |               1.1.4 |    ✅  |      Confirmed     | Multiplayer tested successfully.                                   |
| VisibleLockerInterior                   |               2.0.4 |    ✅  |      Confirmed     | Multiplayer tested successfully.                                   |

---

## Notes

* Approximately **69 community mods** have been evaluated with Nitrox Compatibility Framework.
* The only confirmed incompatibilities are due to legacy Nautilus/Subnautica API changes rather than Nitrox Compatibility Framework itself.
* Mods marked **Initial Validation** loaded successfully without runtime compatibility issues but should receive additional multiplayer gameplay testing before being considered fully validated.
* Unless otherwise noted, all players in a multiplayer session should use matching versions of the tested mods.
