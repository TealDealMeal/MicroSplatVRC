# MicroSplatVRChat
This script allows you to use the MicroSplat shader in VRChat

You will only have access to the shader itself, a lot of features might not even work, I haven't done enough testing, you will probably have to test and see for yourself.

---

### Requirements:
- MicroSplat

---

### Setup:

1)

Install the script, it works automatically when building a world.

---
2)

Open MicroSplatTerrain.cs and find the line

float basemapDistance = 0;

and replace it with

float basemapDistance = terrain.basemapDistance; //0;

---
3)

Now change the "Base Map Dist." on the Terrain to whatever value you need, as MicroSplat likely set it to 0

---
4)

Lastly, you want to check your "Terrain Width and Length", as you need to set these same values in MicroSplat Shader Generator's "Global UV Scale", otherwise the textures in the editor will show up differently compared to than in-game
- X for Width
- Y for Length

---
5)

Have fun experimenting!
