# MicroSplatVRChat
This script allows you to use the MicroSplat shader in VRChat

You will only have access to the shader itself, a lot of features might not even work, I haven't done enough testing, you will probably have to play around with it and see for yourself.

---

### Requirements:
- MicroSplat

---

### Setup:

- Install the script, it works automatically when building a world.

---

- Open MicroSplatTerrain.cs and find the line

```float basemapDistance = 0;```


- and replace it with

```float basemapDistance = terrain.basemapDistance; //0;```

![2](https://github.com/TealDealMeal/MicroSplatVRChat/assets/97361953/3c9aede3-5e3c-45ef-a442-20f54b5ecfdb)

---

- Now change the "Base Map Dist." on the Terrain to whatever value you need, as MicroSplat likely set it to 0

![3](https://github.com/TealDealMeal/MicroSplatVRChat/assets/97361953/69f363b2-ce0b-4c60-81fb-785f036f7d76)

---

- Lastly, you want to check your "Terrain Width and Length", as you need to set these same values in MicroSplat Shader Generator's "Global UV Scale", otherwise the textures in the editor will show up differently when compared to in-game.

![4a](https://github.com/TealDealMeal/MicroSplatVRChat/assets/97361953/f3d47d52-39e0-4ab1-9715-6aad39d0b762)
![4b](https://github.com/TealDealMeal/MicroSplatVRChat/assets/97361953/d04392c6-ec5b-4917-af08-c3e7a02d91fc)

- X for Width
- Y for Length

---

- That's all, have fun experimenting with MicroSplat!
