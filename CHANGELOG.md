# Changelog

All notable changes to Nitrox Compatibility Framework (NCF) will be documented in this file.

The format is based on Keep a Changelog and Semantic Versioning.

---

## [1.0.0] - 2026-06-26

### Added

- Initial public release of Nitrox Compatibility Framework (NCF).
- Runtime compatibility layer for Nitrox and modern Nautilus-based mods.
- Automatic recovery of Nitrox GameInput initialization failures.
- Gameplay InputActionMap recovery and enablement.
- Compatibility diagnostics and runtime logging.

### Compatibility

Verified working with:

#### Core

- Nitrox 1.8.1
- Tobey's BepInEx Pack 5.4.23-pack.3.1.1
- Nautilus 1.0.0.pre-51

#### Tested Mods

- Map v1.5.12
- QuickSlotsPlus v3.0.0
- QuickStore v0.2.2
- VisibleLockerInterior 2025 v2.0.4
- AutosortLockersSN v1.0.8b
- SlotExtender v3.0
- ModdedArmsHelper v1.6
- SeamothArms v2.1
- ConfigurationManager for BepInEx v18.4.1-tweaks.2.0.0
- VehicleFramework v2.0.8
- Beluga v2.0.4
- MoreCyclopsUpgrades (Purple Edition) v1.0.2.1
- CyclopsAutoZapper (Purple Edition) v1.0.1.1
- CyclopsEngineUpgrades (Purple Edition) v1.0.0.1
- CyclopsNuclearUpgrades (Purple Edition) v1.0.0.1
- CyclopsSpeedUpgrades (Purple Edition) v1.0.0.1

### Fixed

- Restored gameplay controls after Nitrox interrupted GameInput initialization.
- Resolved compatibility issues preventing modern Nautilus mods from functioning under Nitrox.
- Restored Vehicle Framework compatibility.
- Restored custom vehicle compatibility.

### Known Issues

- QuickSlotsPlus currently cannot assign keybindings to slots beyond the vanilla five through its settings UI.
- Compatibility testing for additional mods is ongoing. 