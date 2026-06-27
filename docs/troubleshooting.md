# Troubleshooting

This page covers the most common issues encountered while using Nitrox Compatibility Framework (NCF).

---

## Known Working Baseline

Subnautica                1.22.82304
Nitrox                    1.8.1
BepInEx                   5.4.23-pack.3.1.1
Nautilus                  1.0.0.pre-51
Nitrox Compatibility Framework 1.0.0

---

# Gameplay controls do not work

## Symptoms

- Cannot move after joining a Nitrox world.
- Mouse works in menus but not in gameplay.
- Keyboard and controller input do not function.

## Cause

Nitrox interrupts `GameInputSystem.Initialize()`, preventing the Gameplay `InputActionMap` from being enabled.

## Solution

Ensure NCF is installed correctly.

A successful startup should contain messages similar to:

```text
[NCF] GameInputSystem.Initialize threw an exception. Beginning recovery.
[NCF] Gameplay InputActionMap enabled.
```

If these messages are missing:

- Verify NCF is installed.
- Verify Harmony patches were applied.
- Verify you are using a supported Nitrox version.

---

# A mod does not appear in-game

## Symptoms

- No recipes.
- No PDA entries.
- No buildables.
- Mod appears to load but nothing exists.

## Things to check

- Correct version of Nautilus installed.
- Required dependencies installed.
- Mod loaded successfully in `LogOutput.log`.
- No startup exceptions occurred.

---

# Vehicle Framework mods do not load

## Symptoms

- Vehicle Framework reports missing dependencies.
- Beluga or other vehicles never appear.

## Solution

Verify:

- Supported Nautilus version.
- Matching Vehicle Framework version.
- Matching multiplayer mod versions on every client.

---

# QuickSlotsPlus cannot bind slots above the vanilla five

## Symptoms

Extra slots function, but the keybinding menu does not allow assigning keys.

## Status

Known issue.

Gameplay functionality is unaffected, but the current settings UI does not expose key assignment for the additional slots.

---

# Multiplayer desync

## Symptoms

Players see different objects, recipes, or vehicles.

## Solution

All players should use identical versions of:

- Nitrox
- BepInEx
- Nautilus
- Nitrox Compatibility Framework
- Gameplay-affecting mods

Mixing versions is not supported.

---

# The game crashes during startup

## Things to check

- Incorrect mod version
- Missing dependency
- Duplicate mods
- Multiple versions of the same framework
- Unsupported Subnautica version

Review:

```text
BepInEx/LogOutput.log
```

for the first exception that occurs during startup.

---

# Reporting an issue

Please include:

- Subnautica version
- Nitrox version
- NCF version
- Nautilus version
- BepInEx version
- Complete mod list
- `BepInEx/LogOutput.log`
- Steps to reproduce the issue

Issues that include logs and reproduction steps are significantly easier to investigate.

---

# Still having problems?

Before opening a GitHub issue:

1. Confirm you are using supported versions.
2. Test with only:
   - BepInEx
   - Nitrox
   - Nautilus
   - NCF
3. Add mods back one at a time until the issue reappears.

This process quickly identifies whether the problem is caused by a specific mod or by the compatibility framework.