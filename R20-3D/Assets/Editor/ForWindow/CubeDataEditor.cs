using UnityEngine;
using UnityEditor;
using UnityEditor.Callbacks;
using System.Collections;
using System.Collections.Generic;

public class AssetHandler
{
    [OnOpenAsset()]
    public static bool OpenEditor(int instanceId, int line)
    {
        CubeData cubeData = EditorUtility.InstanceIDToObject(instanceId) as CubeData;
        if(cubeData != null)
        {
            CubeDataEditorWindow.Open(cubeData);
            return true;
        }
        return false;
    }
}

[CustomEditor(typeof(CubeData))]
public class CubeDataEditor : Editor
{
    public override void OnInspectorGUI()
    {
        if(GUILayout.Button("Open Editor"))
        {
            CubeDataEditorWindow.Open((CubeData)target);
        }
    }
}
