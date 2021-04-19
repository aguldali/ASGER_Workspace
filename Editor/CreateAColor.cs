using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using MixedRealityWorkspace1.ColorSystem;

public class CreateAColor : MonoBehaviour
{
    [MenuItem("ASGER/Localization/Color")]
    public static void CreateAColorScriptableObject()
    {
        ColorKeeper asset = ScriptableObject.CreateInstance<ColorKeeper>();

        AssetDatabase.CreateAsset(asset, "Assets/Resources/ScriptableObjects/Colors/newColor.asset");
        AssetDatabase.SaveAssets();

        EditorUtility.FocusProjectWindow();

        Selection.activeObject = asset;
    }
}
