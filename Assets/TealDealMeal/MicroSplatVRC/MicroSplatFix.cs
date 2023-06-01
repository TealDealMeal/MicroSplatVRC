#if UNITY_EDITOR
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using System.Collections;
using UnityEditor.SceneManagement;
using VRC.SDKBase.Editor.BuildPipeline;

public class MicroSplatFix : Editor {
#if __MICROSPLAT__
    [InitializeOnLoadMethod]
    static void Initialize() {
        EditorSceneManager.sceneOpened += OnEditorSceneManagerSceneOpened;
    }

    static void OnEditorSceneManagerSceneOpened(Scene scene, OpenSceneMode mode) {
        EditorCoroutine.Start(ApplyTerrainStorage());
    }

    public static IEnumerator ApplyTerrainStorage() {
        yield return new WaitForSeconds(0.5f);
        MicroSplatStorage[] terrainStorage = FindObjectsOfType<MicroSplatStorage>();

        foreach (MicroSplatStorage clone in terrainStorage) {
            MicroSplatTerrain storageTerrain = clone.originalGameObject.AddComponent<MicroSplatTerrain>();
            EditorUtility.CopySerialized(clone, storageTerrain);

            storageTerrain.templateMaterial = clone.material;
            storageTerrain.enabled = true;

            DestroyImmediate(clone.gameObject);
        }
    }

    class BuildRequested : IVRCSDKBuildRequestedCallback {
        public int callbackOrder { get { return 0; } }

        public bool OnBuildRequested(VRCSDKRequestedBuildType type) {
            CreateTerrainStorage();

            return true;
        }
    }

    public static void CreateTerrainStorage() {
        MicroSplatTerrain[] microSplatTerrain = FindObjectsOfType<MicroSplatTerrain>();

        foreach (MicroSplatTerrain _terrain in microSplatTerrain) {
            GameObject clone = new GameObject();
            clone.name = "_TempMicroSplatStorage";

            Terrain terrain = _terrain.terrain;
            Material material = _terrain.templateMaterial;

            MicroSplatStorage storage = clone.AddComponent<MicroSplatStorage>();
            storage.originalGameObject = _terrain.gameObject;
            storage.material = material;

            MicroSplatTerrain storageTerrain = clone.AddComponent<MicroSplatTerrain>();
            storageTerrain.enabled = false;
            EditorUtility.CopySerialized(storage, storageTerrain);

            DestroyImmediate(_terrain);
            terrain.materialTemplate = material;
        }
    }
#endif
}
#endif