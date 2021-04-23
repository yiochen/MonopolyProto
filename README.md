Monopoly proto exports
Created following instruction at
https://neogeek.dev/creating-custom-packages-for-unity-2018.3/

To use install https://github.com/yiochen/MonopolyProto.git#upm in Unity.

# Make changes

When proto changes, run ./.copy.sh in root directory of this package to bring
the cs file over.
Open unity to generate the meta files for the new cs files.

# Releasee

- Update the version number in `Assets/MonopolyProto/package.json`
- commit `main` branch to github
- github action will automatically push to upm branch
