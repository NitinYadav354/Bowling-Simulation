# Bowling-Simulation

> A 3D physics-based cricket bowling simulator built with Unity and C#.
> 
 ![Last commit](https://img.shields.io/github/last-commit/NitinYadav354/Bowling-Simulation?style=for-the-badge&logo=github) ![License](https://img.shields.io/badge/license-MIT-green?style=for-the-badge)

##  Table of Contents

- [Description](#description)
- [Key Features](#key-features)
- [Use Cases](#use-cases)
- [Quick Start](#quick-start)
- [Project Structure](#project-structure)
- [Contributors](#contributors)
- [Contributing](#contributing)
- [License](#license)

##  Description

Bowling-Simulation is a 3D cricket bowling simulator built using Unity and C# that models the mechanics behind real-world fast and spin bowling. It provides a visual and physics-based framework for exploring dynamics such as swing, seam position, spin drift, and pitch surface interaction.

##  Key Features

- **🏏 Fast and Spin Bowling Modes** — Simulates various delivery styles, including fast bowling and spin variations such as leg spin and off spin.
- **🌬️ Aerodynamic Swing and Drift Mechanics** — Calculates conventional swing and spin drift based on seam angle, release velocity, air resistance, and the Magnus effect.
- **🏟️ Pitch Surface Interaction** — Adjusts ball bounce and turn based on impact point, surface friction, and ball age.
- **🎥 Multiple Visual Camera Views** — Offers various perspective options, including bowler view, follow camera, side view, and pitch camera.
- **📈 Trajectory Tracking and Telemetry** — Renders a trajectory path from release to impact alongside real-time UI data for ball speed, swing, and bounce distance.

##  Use Cases

- Prototyping bowling mechanics and ball physics for 3D cricket games in Unity.
- Visualizing aerodynamics and pitch friction impacts on cricket ball trajectories for analytics or educational purposes.
- Studying custom physics scripting layered on top of Unity's built-in physics engine.


##  Quick Start

```bash

# 1. Clone the repository
git clone https://github.com/NitinYadav354/Bowling-Simulation.git

# See the Development Setup section below
```

## Project Structure

```
.
├── Assets
│   ├── Crease 1.png
│   ├── Crease 1.png.meta
│   ├── Crease.png
│   ├── Crease.png.meta
│   ├── Green.mat
│   ├── Green.mat.meta
│   ├── InputSystem_Actions.inputactions
│   ├── InputSystem_Actions.inputactions.meta
│   ├── Materials
│   │   ├── Ball.physicMaterial
│   │   ├── Ball.physicMaterial.meta
│   │   ├── Crease.mat
│   │   ├── Crease.mat.meta
│   │   ├── Ground.physicMaterial
│   │   ├── Ground.physicMaterial.meta
│   │   ├── Pitch.physicMaterial
│   │   ├── Pitch.physicMaterial.meta
│   │   ├── Untitled.mat
│   │   └── Untitled.mat.meta
│   ├── Materials.meta
│   ├── Scenes
│   │   ├── SampleScene.unity
│   │   └── SampleScene.unity.meta
│   ├── Scenes.meta
│   ├── Scripts
│   │   ├── Camera_Switch.cs
│   │   ├── Camera_Switch.cs.meta
│   │   ├── NewMonoBehaviourScript.cs
│   │   ├── NewMonoBehaviourScript.cs.meta
│   │   ├── Wicket.cs
│   │   ├── Wicket.cs.meta
│   │   ├── position.cs
│   │   └── position.cs.meta
│   ├── Scripts.meta
│   ├── Settings
│   │   ├── DefaultVolumeProfile.asset
│   │   ├── DefaultVolumeProfile.asset.meta
│   │   ├── Mobile_RPAsset.asset
│   │   ├── Mobile_RPAsset.asset.meta
│   │   ├── Mobile_Renderer.asset
│   │   ├── Mobile_Renderer.asset.meta
│   │   ├── PC_RPAsset.asset
│   │   ├── PC_RPAsset.asset.meta
│   │   ├── PC_Renderer.asset
│   │   ├── PC_Renderer.asset.meta
│   │   ├── SampleSceneProfile.asset
│   │   ├── SampleSceneProfile.asset.meta
│   │   ├── UniversalRenderPipelineGlobalSettings.asset
│   │   └── UniversalRenderPipelineGlobalSettings.asset.meta
│   ├── Settings.meta
│   ├── Untitled.png
│   ├── Untitled.png.meta
│   ├── free-3d-game-asset-cricket-ball-pbr-texture
│   │   ├── source
│   │   │   ├── Wicket.fbx
│   │   │   ├── Wicket.fbx.meta
│   │   │   ├── cricket ball.fbx
│   │   │   └── cricket ball.fbx.meta
│   │   ├── source.meta
│   │   ├── textures
│   │   │   ├── cricket ball_Bake1_PBR_Diffuse 1.png
│   │   │   ├── cricket ball_Bake1_PBR_Diffuse 1.png.meta
│   │   │   ├── cricket ball_Bake1_PBR_Diffuse.png
│   │   │   ├── cricket ball_Bake1_PBR_Diffuse.png.meta
│   │   │   ├── cricket ball_Bake1_PBR_Roughness 1.png
│   │   │   ├── cricket ball_Bake1_PBR_Roughness 1.png.meta
│   │   │   ├── cricket ball_Bake1_PBR_Roughness.png
│   │   │   └── cricket ball_Bake1_PBR_Roughness.png.meta
│   │   └── textures.meta
│   ├── free-3d-game-asset-cricket-ball-pbr-texture.meta
│   ├── full pitch.mat
│   ├── full pitch.mat.meta
│   ├── man
│   │   ├── source
│   │   │   ├── fdx54mtvuz28-FinalBaseMesh
│   │   │   │   ├── FinalBaseMesh.obj
│   │   │   │   └── FinalBaseMesh.obj.meta
│   │   │   └── fdx54mtvuz28-FinalBaseMesh.meta
│   │   ├── source.meta
│   │   ├── textures
│   │   │   ├── internal_ground_ao_texture.jpeg
│   │   │   └── internal_ground_ao_texture.jpeg.meta
│   │   └── textures.meta
│   ├── man.meta
│   ├── playing pitch.mat
│   └── playing pitch.mat.meta
├── LICENSE
├── Packages/
└── ProjectSettings/

```

## Contributors


<p align="left">
<a href="https://github.com/NitinYadav354" title="NitinYadav354"><img src="https://avatars.githubusercontent.com/u/183586651?v=4&s=64" width="64" height="64" alt="NitinYadav354" style="border-radius:50%" /></a>
</p>


## Contributing

Contributions are welcome! Here's the standard flow:

1. **Fork** the repository
2. **Clone** your fork: `git clone https://github.com/NitinYadav354/Bowling-Simulation.git`
3. **Branch**: `git checkout -b feature/your-feature`
4. **Commit**: `git commit -m 'feat: add some feature'`
5. **Push**: `git push origin feature/your-feature`
6. **Open** a pull request

Please follow the existing code style and include tests for new behavior where applicable.

## License

This project is licensed under the **MIT** License.

---


