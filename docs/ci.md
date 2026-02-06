# CI guidance

This repo is designed to support:

- Build and test on macOS runners
- Codesigning and notarization for app bundles
- Artifact packaging (DMG/PKG)

## Recommended pipeline steps

1. Restore and build samples
2. Run unit tests (where present)
3. Codesign app bundles
4. Notarize and staple
5. Publish artifacts
