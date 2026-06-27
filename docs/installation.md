# Installation

This guide explains how to install Nitrox Compatibility Framework.

## Requirements

Install these first:

| Component | Tested Version |
| --- | --- |
| Subnautica | 1.22.82304 |
| Nitrox | 1.8.1 |
| Tobey's BepInEx Pack for Subnautica | 5.4.23-pack.3.1.1 |
| Nautilus | 1.0.0.pre-51 |
| Nitrox Compatibility Framework | 1.0.0 |

All multiplayer clients should use the same mod versions.

## Install NCF

1. Download the latest `NitroxCompatFramework_vX.X.X.zip` release.
2. Open your Subnautica install folder.
3. Open:
    - BepInEx/plugins/

## Extract the release zip into BepInEx/plugins/

The final layout should look like this:

Subnautica/
└─ BepInEx/
   └─ plugins/
      └─ NitroxCompatFramework/
         └─ NitroxCompatFramework.dll

## Install Other Mods

Install other BepInEx/Nautilus mods normally into:

- BepInEx/plugins/

Recommended baseline:

- BepInEx Pack
- Nitrox
- Nautilus
- NitroxCompatFramework

Then add tested compatible mods.

## Verifying Installation

Start Subnautica and check BepInEx/LogOutput.log.

A successful NCF load should include lines similar to:

[Info   :Nitrox Compat Framework] [NCF] Nitrox Compatibility Framework v1.0.0
[Info   :Nitrox Compat Framework] [NCF] Compatibility layer ready.
[Info   :Nitrox Compat Framework] [NCF] Harmony patches applied.

When joining a Nitrox world, NCF may also log:

[NCF] GameInputSystem.Initialize threw an exception. Beginning recovery.
[NCF] Gameplay InputActionMap enabled.

This is expected when NCF recovers gameplay input.

## Multiplayer Notes

- Every player should use the same versions of Nitrox, Nautilus, NCF, and gameplay-affecting mods.
- Mods that add items, vehicles, recipes, TechTypes, or prefabs should be installed by all players.
- UI-only mods may not always need to match, but matching clients is still recommended.
- Long-session multiplayer sync testing is still recommended for large mods.

## Updating NCF

- Close Subnautica.
- Delete the old BepInEx/plugins/NitroxCompatFramework/ folder.
- Extract the new release folder into BepInEx/plugins/.
- Start the game and check the log.

## Uninstalling NCF

- Close Subnautica.
- Delete:
- BepInEx/plugins/NitroxCompatFramework/
- Start the game normally.

Mods that depend on NCF compatibility may stop working correctly under Nitrox after removal.
