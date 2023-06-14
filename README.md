# MicroSplatVRC
This script and setup allows you to use the MicroSplat shader in VRChat.

MicroSplat by itself, doesn't work with VRChat as it relies on runtime components to function.<br>
With this system, you will only have access to the shader itself, a lot of features might not even work.<br>
I haven't done enough testing, you will probably have to play around with it and see for yourself.

---

### Requirements:
- [MicroSplat](https://assetstore.unity.com/packages/tools/terrain/microsplat-96478)

---

### Setup:

- Install the latest release, the script will automatically run when building the world.

---

- Open MicroSplatTerrain.cs

![1](https://github.com/TealDealMeal/MicroSplatVRC/assets/97361953/de6453b9-2459-46be-832e-d965def26aea)

- Now find the line:

```float basemapDistance = 0;```

- and replace it with

```float basemapDistance = terrain.basemapDistance; //0;```

![2](https://github.com/TealDealMeal/MicroSplatVRC/assets/97361953/4e56ac40-564d-4efd-8b25-db0b7e1faee2)

---

- Now change the "Base Map Dist." on the Terrain to whatever value you need, as MicroSplat likely set it to 0

![3](https://github.com/TealDealMeal/MicroSplatVRC/assets/97361953/6d177537-9e46-4a5a-9fa3-b29a44d6d90f)

---

- Lastly, you want to check your "Terrain Width and Length", as you need to set these same values in MicroSplat Shader Generator's "Global UV Scale", otherwise the textures in the editor will show up differently when compared to in-game.

![4a](https://github.com/TealDealMeal/MicroSplatVRC/assets/97361953/75429b40-6799-4e78-ae08-297737957f7f)
![4b](https://github.com/TealDealMeal/MicroSplatVRC/assets/97361953/4effceed-e127-4e3c-a344-89e026013bcb)

- X for Width
- Y for Length

---

(Optional)

- To change texture resolution, you have to change the resolution of the texture itself, then click Update in the MicroSplatConfig

![5](https://github.com/TealDealMeal/MicroSplatVRC/assets/97361953/7769a693-418b-4bbb-a5af-d59f1c72b989)
![5b](https://github.com/TealDealMeal/MicroSplatVRC/assets/97361953/bfca5a7a-f397-4b94-81bc-5336c9fbf03d)

---

- That's all, have fun experimenting with MicroSplat!

![image](https://github.com/TealDealMeal/MicroSplatVRC/assets/97361953/0263c0c8-5ac0-490e-90d1-d91309b49cdc)
