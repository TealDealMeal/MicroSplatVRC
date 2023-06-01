# MicroSplatVRC
This script allows you to use the MicroSplat shader in VRChat

You will only have access to the shader itself, a lot of features might not even work, I haven't done enough testing, you will probably have to play around with it and see for yourself.

---

### Requirements:
- MicroSplat

---

### Setup:

- Install the script, it works automatically when building a world.

---

- Open MicroSplatTerrain.cs

![1](https://github.com/TealDealMeal/MicroSplatVRC/assets/97361953/8ee55024-ae89-4b3d-bb7e-f16e1d6c38d1)

- Now find the line:

```float basemapDistance = 0;```

- and replace it with

```float basemapDistance = terrain.basemapDistance; //0;```

![2](https://github.com/TealDealMeal/MicroSplatVRC/assets/97361953/3c9aede3-5e3c-45ef-a442-20f54b5ecfdb)

---

- Now change the "Base Map Dist." on the Terrain to whatever value you need, as MicroSplat likely set it to 0

![3](https://github.com/TealDealMeal/MicroSplatVRC/assets/97361953/69f363b2-ce0b-4c60-81fb-785f036f7d76)

---

- Lastly, you want to check your "Terrain Width and Length", as you need to set these same values in MicroSplat Shader Generator's "Global UV Scale", otherwise the textures in the editor will show up differently when compared to in-game.

![4a](https://github.com/TealDealMeal/MicroSplatVRC/assets/97361953/f3d47d52-39e0-4ab1-9715-6aad39d0b762)
![4b](https://github.com/TealDealMeal/MicroSplatVRC/assets/97361953/d04392c6-ec5b-4917-af08-c3e7a02d91fc)

- X for Width
- Y for Length

---

(Optional)

- To change texture resolution, you have to change the resolution of the texture itself, then click Update in the MicroSplatConfig

![5](https://github.com/TealDealMeal/MicroSplatVRC/assets/97361953/9e60428e-176e-491a-a3ab-dedbdacee593)
![5b](https://github.com/TealDealMeal/MicroSplatVRC/assets/97361953/9b21030f-6294-4cfd-a314-f3e84b429230)

---

- That's all, have fun experimenting with MicroSplat!

![image](https://github.com/TealDealMeal/MicroSplatVRC/assets/97361953/ecad4b6a-ef0c-42fc-8952-de2b293d1edf)
