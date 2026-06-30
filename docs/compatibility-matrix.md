# Mod Compatibility Matrix

This page tracks compatibility testing performed with Nitrox Compatibility Framework (NCF).

Compatibility may vary depending on game version, Nitrox version, Nautilus version, and the specific mod version installed.

---

## Test Environment

| Component                      | Version           | Link                                                     |
| ------------------------------ | ----------------- | -------------------------------------------------------- |
| Subnautica                     | 1.22.82304        |                                                          |
| Nitrox                         | 1.8.1             |                                                          |
| Tobey's BepInEx Pack           | 5.4.23-pack.3.1.1 | https://www.nexusmods.com/subnautica/mods/1108           |
| Nautilus                       | 1.0.0.51          | https://www.nexusmods.com/subnautica/mods/1262           |
| Nitrox Compatibility Framework | 1.0.0             | https://github.com/Blamefulmass108/NitroxCompatFramework |

---

## Test Summary

| Metric                  | Value |
| ----------------------- | ----: |
| Total Mods Evaluated    |    80 |
| Confirmed Working       |    26 |
| Initial Validation      |    36 |
| Partially Working       |     2 |
| Unknown                 |     7 |
| Legacy/API Incompatible |     4 |
| Fully Incompatible      |     5 |

---

## Status Key

| Status                            | Meaning                                                                                                                       |
| --------------------------------- | ----------------------------------------------------------------------------------------------------------------------------- |
| ✅ Confirmed / Initial Validation | No compatibility issues observed during MP gameplay / No compatibility issues with loading into a world (not fully tested)    |
| 🟡 Partially Working / Unknown    | Functions with one or more known limitations / Reported issues affecting gameplay by users (needs direct investigation)       |
| ❌ LEGACY / INCOMPATIBLE          | Built against obsolete Nautilus/Subnautica APIs, updated version not found / Causes game or save breaking issues (DO NOT USE) |

---

## Confidence Key

| Confidence         | Meaning                                                                                                                |
| ------------------ | ---------------------------------------------------------------------------------------------------------------------- |
| Confirmed          | Successfully loaded and validated during multiplayer testing.                                                          |
| Initial Validation | Loaded successfully with no compatibility issues observed, but additional multiplayer gameplay testing is recommended. |
| Partially Working  | Successfully loaded, but has some aspect that may be buggy or not completely operable. Exercise caution.               |
| Unknown            | These mods have some potentially critical issues that may be fixed in an NCF update if possible. Exercise caution.     |
| LEGACY             | These mods were created and compiled against an outdated version of the Nautilus or Subnautica API. Will not work.     |
| INCOMPATIBLE       | These mods are game-breaking or potentially save destroying and are completely incompatible even with NCF.             |

For the major desync issues, including creatures, vehicles, stories, and more, there is currently a development underway to complete an update to NCF, making it NCSF (Nitrox Compatibility/Synchronicity Framework). Keep checking back for updates. 

---

## Compatibility Matrix

| Mod                                     |             Version | Status |     Confidence     | Notes                                                                           | Link                                                                      |
| --------------------------------------- | ------------------: | :----: | :----------------: | ------------------------------------------------------------------------------- | ----------------------------------------------                            |
| AdvancedInventory                       |              1.0.4a |    ✅  | Initial Validation | Loaded successfully.                                                            | https://www.nexusmods.com/subnautica/mods/490                             |
| AlterraMiniFridge                       |               1.0.2 |    ❌  |       LEGACY       | Obsolete Nautilus API.                                                          | https://www.nexusmods.com/subnautica/mods/1793                            |
| Alterra Sea Voyager (Any Version)       |               x.x.x |    ❌  |    INCOMPATIBLE    | Critical issue with Nitrox sync. **USAGE CAUSES PERMA-DESYNC. DO NOT USE!**     | https://www.nexusmods.com/subnautica/mods/604                             |
| AnisotropicFix                          |               2.0.0 |    ✅  | Initial Validation | Loaded successfully.                                                            | https://www.nexusmods.com/subnautica/mods/185                             |
| AutoSortLockers SN                      |            1.0.0.0e |    ✅  |      Confirmed     | Multiplayer tested successfully.                                                | https://www.nexusmods.com/subnautica/mods/1504                            |
| BagEquipment                            |               1.2.1 |    ✅  | Initial Validation | Loaded successfully.                                                            | https://www.nexusmods.com/subnautica/mods/493                             |
| BaseLegsRemoval                         |             2.0.0.1 |    ✅  | Initial Validation | Loaded successfully.                                                            | https://www.nexusmods.com/subnautica/mods/1118                            |
| BaseLightSwitch                         |             1.0.0.0 |    🟡  |       Unknown      | Loaded successfully. Actual synchronicity untested                              | https://www.nexusmods.com/subnautica/mods/1485                            |
| BelugaSubmarine                         |               2.0.4 |    ❌  |    INCOMPATIBLE    | Critical issue with Nitrox sync. **USAGE CAUSES PERMA-DESYNC. DO NOT USE!**     | https://www.nexusmods.com/subnautica/mods/1748                            |
| BepInExTweaks                           |               1.2.1 |    ✅  | Initial Validation | Loaded successfully.                                                            | https://www.nexusmods.com/subnautica/mods/1104                            |
| BetterBioReactor (Purple Edition)       |             1.0.0.1 |    ✅  | Initial Validation | Loaded successfully.                                                            | https://www.nexusmods.com/subnautica/mods/1466                            |
| BetterScannerBlips (Purple Edition)     |             1.0.0.1 |    ✅  |      Confirmed     | Multiplayer tested successfully.                                                | https://www.nexusmods.com/subnautica/mods/1467                            |
| BetterVehicleStorage (Purple Edition)   |             1.0.1.1 |    ✅  |      Confirmed     | Multiplayer tested successfully.                                                | https://www.nexusmods.com/subnautica/mods/1471                            |
| BlueprintSearchBar                      |               1.1.0 |    ✅  |      Confirmed     | Multiplayer tested successfully.                                                | https://www.nexusmods.com/subnautica/mods/1300                            |
| BlueprintsImprovedUI                    |               1.0.2 |    ✅  |      Confirmed     | Multiplayer tested successfully.                                                | https://www.nexusmods.com/subnautica/mods/990                             |
| BuildingTweaks                          |             2.0.1.1 |    ✅  | Initial Validation | Loaded successfully.                                                            | https://www.nexusmods.com/subnautica/mods/1121                            |
| ConfigurationManager for BepInEx        | 18.4.1-tweaks.2.0.0 |    ✅  |      Confirmed     | Required dependency.                                                            | https://www.nexusmods.com/subnautica/mods/1112                            |
| CuddlefishRecall                        |               1.4.0 |    ✅  | Initial Validation | Loaded successfully.                                                            | https://www.nexusmods.com/subnautica/mods/1190                            |
| CustomizedStorage                       |               1.0.5 |    ✅  | Initial Validation | Loaded successfully.                                                            | https://www.nexusmods.com/subnautica/mods/35                              |
| CustomizeYourSpawns                     |             2.0.0.1 |    ✅  | Initial Validation | Loaded successfully.                                                            | https://www.nexusmods.com/subnautica/mods/1124                            |
| CyclopsAutoZappers (Purple Edition)     |             1.0.1.1 |    ✅  |      Confirmed     | Multiplayer tested successfully.                                                | https://www.nexusmods.com/subnautica/mods/1429                            |
| CyclopsDockingMod                       |               2.1.1 |    ❌  |       LEGACY       | Obsolete Nautilus API.                                                          | https://www.nexusmods.com/subnautica/mods/554                             |
| CyclopsDockingMod (Continued)           |               2.1.1 |    🟡  |       Unknown      | Updated CyclopsDockingMod. Needs further testing, autopilot causes base desync. | https://www.nexusmods.com/subnautica/mods/2799                            |
| CyclopsEngineUpgrades (Purple Edition)  |             1.0.0.1 |    ✅  |      Confirmed     | Multiplayer tested successfully.                                                | https://www.nexusmods.com/subnautica/mods/1428                            |
| CyclopsEnhancement_Sonar                |                 0.1 |    ✅  |      Confirmed     | Multiplayer tested successfully.                                                | https://www.nexusmods.com/subnautica/mods/1358                            |
| CyclopsNuclearUpgrades (Purple Edition) |             1.0.0.1 |    ✅  |      Confirmed     | Multiplayer tested successfully.                                                | https://www.nexusmods.com/subnautica/mods/1430                            |
| CyclopsSpeedUpgrades (Purple Edition)   |             1.0.0.1 |    ✅  |      Confirmed     | Multiplayer tested successfully.                                                | https://www.nexusmods.com/subnautica/mods/1427                            |
| Defabricator                            |             2.0.1.1 |    ✅  | Initial Validation | Loaded successfully.                                                            | https://www.nexusmods.com/subnautica/mods/216                             |
| DeeperWatersCreatures                   |                 0.5 |    ❌  |    INCOMPATIBLE    | Prevents loading. Incompatible currently. (User reported)                       | https://www.nexusmods.com/subnautica/mods/1750                            |
| DrillableScan                           |               2.0.0 |    ✅  | Initial Validation | Loaded successfully.                                                            | https://www.nexusmods.com/subnautica/mods/1440                            |
| DropStorageItemsOnDestroy               |               1.0.1 |    ✅  | Initial Validation | Loaded successfully.                                                            | https://www.nexusmods.com/subnautica/mods/1256                            |
| DropUpgradesOnDestroy                   |             2.0.0.1 |    ✅  | Initial Validation | Loaded successfully.                                                            | https://www.nexusmods.com/subnautica/mods/1126                            |
| EasyCraft                               |               1.1.6 |    🟡  |       Unknown      | Users report base building desync. **CAUTION** Likely incompatible at this time.| https://www.nexusmods.com/subnautica/mods/24                              |
| Echelon                                 |               2.0.1 |    ❌  |    INCOMPATIBLE    | Critical issue with Nitrox sync. **USAGE CAUSES PERMA-DESYNC. DO NOT USE!**     | https://www.nexusmods.com/subnautica/mods/2153 
| EnhancedGravTrap                        |               1.4.3 |    ✅  | Initial Validation | Loaded successfully.                                                            | https://www.nexusmods.com/subnautica/mods/1340                            |
| EpicStructureLoader                     |               1.0.2 |    🟡  |       Unknown      | Mods that require this have issues loading, unknown if this is the problem.     | https://www.nexusmods.com/subnautica/mods/1666                            |
| FabricatorNoAutoClose                   |             2.0.0.1 |    ✅  | Initial Validation | Loaded successfully.                                                            | https://www.nexusmods.com/subnautica/mods/1127                            |
| FastLoadingScreen                       |               2.0.1 |    ✅  |      Confirmed     | Multiplayer tested successfully.                                                | https://www.nexusmods.com/subnautica/mods/763                             |
| FreeBaseLights                          |               1.0.0 |    ✅  | Initial Validation | Loaded successfully.                                                            | https://www.nexusmods.com/subnautica/mods/1266                            |
| FreeLook                                |               2.4.4 |    ✅  |      Confirmed     | Multiplayer tested successfully.                                                | https://www.nexusmods.com/subnautica/mods/517                             |
| GeysersPerformanceFix                   |               1.0.1 |    ✅  | Initial Validation | Loaded successfully.                                                            | https://www.nexusmods.com/subnautica/mods/394                             |
| HullReinforcementFix                    |               1.2.7 |    ✅  |      Confirmed     | Multiplayer tested successfully.                                                | https://www.nexusmods.com/subnautica/mods/1348                            |
| HydraSubmarine                          |               1.1.0 |    ❌  |    INCOMPATIBLE    | Critical issue with Nitrox sync. **USAGE CAUSES PERMA-DESYNC. DO NOT USE!**     | https://www.nexusmods.com/subnautica/mods/1912                            |
| ImprovedPowerNetwork                    |             2.0.0.1 |    ✅  | Initial Validation | Loaded successfully.                                                            | https://www.nexusmods.com/subnautica/mods/1129                            |
| ImprovedScanInfo                        |               2.0.0 |    ✅  | Initial Validation | Loaded successfully.                                                            | https://www.nexusmods.com/subnautica/mods/1228                            |
| LaserCutterSpeed                        |               2.5.0 |    ✅  | Initial Validation | Loaded successfully.                                                            | https://www.nexusmods.com/subnautica/mods/1214                            |
| LockerLabel                             |               1.3.0 |    🟡  |  Partially Working | Labels work local, but are not synced. Needs to be updated or NCF bridged.¹     | https://www.nexusmods.com/subnautica/mods/3785                            |
| LongerSigns                             |               1.0.0 |    ✅  | Initial Validation | Loaded successfully.                                                            | https://www.nexusmods.com/subnautica/mods/1296                            |
| Map                                     |              1.5.12 |    ✅  |      Confirmed     | Multiplayer tested successfully.                                                | https://www.nexusmods.com/subnautica/mods/12                              |
| MoonpoolVehicleRepair SN                |               1.0.7 |    ✅  |      Confirmed     | Multiplayer tested successfully.                                                | https://www.nexusmods.com/subnautica/mods/51                              |
| MoreCyclopsUpgrades (Purple Edition)    |             1.0.2.1 |    ✅  |      Confirmed     | Multiplayer tested successfully.                                                | https://www.nexusmods.com/subnautica/mods/1407                            |
| MoreModifiedItems (Purple Edition)      |             2.0.5.1 |    ✅  | Initial Validation | Loaded successfully.                                                            | https://www.nexusmods.com/subnautica/mods/398                             |
| NoLoudBangsInCyclops                    |               1.0.2 |    ✅  | Initial Validation | Loaded successfully.                                                            | https://www.nexusmods.com/subnautica/mods/950                             |
| NoPdaDelay                              |               1.1.0 |    ✅  | Initial Validation | Loaded successfully.                                                            | https://www.nexusmods.com/subnautica/mods/1105                            |
| PickupableStorageEnhanced               |             2.0.0.2 |    ✅  | Initial Validation | Loaded successfully.                                                            | https://www.nexusmods.com/subnautica/mods/220                             |
| PicturesFromDatabase                    |                 1.0 |    ✅  | Initial Validation | Loaded successfully.                                                            | https://www.nexusmods.com/subnautica/mods/1195                            |
| QuickBatterySwitch                      |               0.1.0 |    ✅  |      Confirmed     | Multiplayer tested successfully.                                                | https://www.nexusmods.com/subnautica/mods/1221                            |
| QuickSlotsPlus                          |               3.0.0 |    🟡  |  Partially Working | Working, but additional quick-slot keybinding assignment not currently exposed. | https://www.nexusmods.com/subnautica/mods/984                             |
| QuickStore                              |               0.2.2 |    ✅  |      Confirmed     | Multiplayer tested successfully.                                                | https://www.nexusmods.com/subnautica/mods/1215                            |
| QuickUnpinRecipes                       |               1.1.0 |    ✅  | Initial Validation | Loaded successfully.                                                            | https://www.nexusmods.com/subnautica/mods/1305                            |
| RadialTabs                              |             2.0.0.1 |    ✅  | Initial Validation | Loaded successfully.                                                            | https://www.nexusmods.com/subnautica/mods/207                             |
| RepairTransportLights                   |                 1.0 |    ✅  | Initial Validation | Loaded successfully.                                                            | https://www.nexusmods.com/subnautica/mods/1231                            |
| ScannableTimeCapsules                   |             2.0.0.1 |    ✅  | Initial Validation | Loaded successfully.                                                            | https://www.nexusmods.com/subnautica/mods/1138                            |
| SeamothEject                            |               2.0.2 |    ✅  |      Confirmed     | Multiplayer tested successfully.                                                | https://www.nexusmods.com/subnautica/mods/740                             |
| SeamothEnhancement_Sonar                |              0.10.0 |    ✅  |      Confirmed     | Multiplayer tested successfully.                                                | https://www.nexusmods.com/subnautica/mods/1322                            |
| SeamothThermalReactor                   |             2.0.0.1 |    ✅  | Initial Validation | Loaded successfully.                                                            | https://www.nexusmods.com/subnautica/mods/1139                            |
| SinkingItemsFix                         |               2.0.0 |    ✅  | Initial Validation | Loaded successfully.                                                            | https://www.nexusmods.com/subnautica/mods/864                             |
| SleekBases                              |                 2.3 |    ✅  | Initial Validation | Loaded successfully.                                                            | https://www.nexusmods.com/subnautica/mods/1180                            |
| SlotExtender                            |                 3.0 |    ❌  |       LEGACY       | Obsolete Nautilus API.                                                          | https://www.nexusmods.com/subnautica/mods/142                             |
| SlotExtender 2025                       |                 1.0 |    ✅  |      Confirmed     | Updated SlotExtender to function with the modern Nautilus API                   | https://www.nexusmods.com/subnautica/mods/3194                            |
| SnapBuilder                             |                 2.4 |    ✅  |      Confirmed     | Multiplayer tested Successfully.                                                | https://www.nexusmods.com/subnautica/mods/427                             |
| StorageInfo                             |               2.2.0 |    ✅  | Initial Validation | Loaded successfully.                                                            | https://www.nexusmods.com/subnautica/mods/229                             |
| SwimChargeInventory                     |               2.1.0 |    ✅  | Initial Validation | Loaded successfully.                                                            | https://www.nexusmods.com/subnautica/mods/1169                            |
| TerrainPatcher                          |               1.1.0 |    🟡  |       Unknown      | Mods that require this have issues loading, unknown if this is the problem.     | https://github.com/Esper89/Subnautica-TerrainPatcher/releases/tag/v1.1.0  |
| TextureReplacer                         |               1.2.6 |    🟡  |       Unknown      | Mods that require this have issues loading, unknown if this is the problem.     | https://www.nexusmods.com/subnautica/mods/1371                            |
| TrackEverything                         |               0.1.0 |    ✅  |      Confirmed     | Multiplayer tested successfully.                                                | https://www.nexusmods.com/subnautica/mods/1235                            |
| TrueBaseColorizer                       |                 1.8 |    ❌  |       LEGACY       | Obsolete Nautilus API.                                                          | https://www.nexusmods.com/subnautica/mods/1212                            |
| UpgradedJumpJetModule                   |               1.1.4 |    ✅  |      Confirmed     | Multiplayer tested successfully.                                                | https://www.nexusmods.com/subnautica/mods/1316                            |
| VehicleFramework                        |               2.0.8 |    🟡  |       Unknown      | Critical desync when using mod vehicles. Advise against using.                  | https://www.nexusmods.com/subnautica/mods/859                             |
| VisibleLockerInterior 2025              |               2.0.4 |    ✅  |      Confirmed     | Multiplayer tested successfully.                                                | https://www.nexusmods.com/subnautica/mods/2547                            |

---

## Notes

* Currently **80 community mods** have been evaluated with Nitrox Compatibility Framework.
* The only confirmed incompatibilities are due to legacy Nautilus/Subnautica API changes rather than Nitrox Compatibility Framework itself.
* Mods marked **Initial Validation** loaded successfully without runtime compatibility issues but should receive additional multiplayer gameplay testing before being considered fully validated.
* Unless otherwise noted, all players in a multiplayer session should use matching versions of the tested mods.
* As it stands, vehicle mods cause a critical desync error with Nitrox and should not be used. *Saves will be corrupted if used.* There is no plan in NCF's future to make a fix for this.
* ¹ Mod creator has been informed. Potential NCF bridge coming soon if demand exists.
