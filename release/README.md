# Release Process

This directory contains files and notes used when preparing official Nitrox Compatibility Framework releases.

## Release Checklist

Before publishing a release:

- [ ] Update `NcfInfo.Version`
- [ ] Update `CHANGELOG.md`
- [ ] Update `compatibility-matrix.md`
- [ ] Verify `README.md` reflects the latest supported versions.
- [ ] Perform a clean build.
- [ ] Test with the current supported baseline.
- [ ] Package the release zip.
- [ ] Create the GitHub Release.
- [ ] Upload the release archive.
- [ ] Publish release notes.

---

## Release Package Layout

The release archive should contain:

```text
NitroxCompatFramework_vX.X.X.zip
└── NitroxCompatFramework/
    └── NitroxCompatFramework.dll
```

Users should extract the `NitroxCompatFramework` folder directly into:

```text
Subnautica/
└── BepInEx/
    └── plugins/
```

---

## Current Tested Baseline

| Component | Version |
| --- | --- |
| Subnautica | 1.22.82304 |
| Nitrox | 1.8.1 |
| Tobey's BepInEx Pack | 5.4.23-pack.3.1.1 |
| Nautilus | 1.0.0.pre-51 |
| NCF | 1.0.0 |

---

## Versioning

NCF follows Semantic Versioning.

- **Major** – Breaking compatibility or major architectural changes.
- **Minor** – New compatibility support and significant new functionality.
- **Patch** – Bug fixes, diagnostics, documentation, or small compatibility improvements.

Examples:

- 1.0.0
- 1.1.0
- 1.1.1

---

## Notes

Every public release should be built from a clean repository and tested against the current supported baseline before publishing.
