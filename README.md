This project exists because the long-standing assumption was that modern Nautilus mods and Nitrox could not coexist. NCF demonstrates that many of those incompatibilities can be resolved through a shared runtime compatibility layer rather than individual patches to each mod.



Nitrox Compatibility Framework v1.0.0

The first public release of Nitrox Compatibility Framework (NCF).

NCF is a runtime compatibility framework designed to improve compatibility between Nitrox Multiplayer and modern BepInEx/Nautilus mods without modifying Nitrox or the supported mods themselves.

Highlights
Restores gameplay input initialization when Nitrox interrupts the game's input setup.
Enables compatibility with modern Nautilus releases.
Supports current Vehicle Framework-based mods.
Preserves multiplayer functionality while allowing compatible mods to load normally.
Lightweight runtime patching with no changes required to Nitrox or supported mods.
Verified Compatibility
Core
Nitrox 1.8.1
Tobey's BepInEx Pack 5.4.23-pack.3.1.1
Nautilus 1.0.0.pre-51
Tested Mods
Map v1.5.12
QuickSlotsPlus v3.0.0 (known keybinding UI limitation for slots above vanilla 5)
VisibleLockerInterior 2025 v2.0.4
AutosortLockersSN v1.0.8b
QuickStore v0.2.2
SlotExtender v3.0
ModdedArmsHelper v1.6
SeamothArms v2.1
ConfigurationManager for BepInEx v18.4.1-tweaks.2.0.0
VehicleFramework v2.0.8
Beluga v2.0.4
MoreCyclopsUpgrades (Purple Edition) v1.0.2.1
CyclopsAutoZapper (Purple Edition) v1.0.1.1
CyclopsEngineUpgrades (Purple Edition) v1.0.0.1
CyclopsNuclearUpgrades (Purple Edition) v1.0.0.1
CyclopsSpeedUpgrades (Purple Edition) v1.0.0.1
Known Issues
QuickSlotsPlus currently cannot assign keybindings for slots beyond the vanilla five through its settings UI, although the mod otherwise functions correctly.
Compatibility testing is ongoing. Additional mods will be added to the compatibility matrix over time.
Looking Forward

NCF is intended to become a general compatibility layer for Nitrox and the Subnautica mod ecosystem. Future releases will focus on expanding compatibility, improving diagnostics, and supporting additional mods and framework versions.