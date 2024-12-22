# Enemy Door Speed Multipiler Dumper

Lethal Company Mod to dump enemy door open speed multipiler values on joining a lobby.

## Development

Create a new directory `lib` at the repository root.
Copy a DLL file into `lib/` from `C:\Program Files (x86)\Steam\steamapps\common\Lethal Company`.

- `Lethal Company_Data\Managed\Assembly-CSharp.dll`

## Build

```powershell
# Debug build
dotnet build

# Release build
dotnet build --configuration Release
```

## Install

### Debug build

1. Install BeplnEx: https://docs.bepinex.dev/articles/user_guide/installation/index.html
2. Copy a DLL file into `C:\Program Files (x86)\Steam\steamapps\common\Lethal Company\BepInEx\plugins` from `bin\Debug\netstandard2.1\EnemyDoorSpeedMultipilerDumper.dll`.

### Release build

1. Install BeplnEx: https://docs.bepinex.dev/articles/user_guide/installation/index.html
2. Copy a DLL file into into `C:\Program Files (x86)\Steam\steamapps\common\Lethal Company\BepInEx\plugins` from `bin\Release\netstandard2.1\EnemyDoorSpeedMultipilerDumper.dll`.

### r2modman

1. Select a DLL file from `Settings > Import local mod`.
