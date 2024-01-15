using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Cube)), CanEditMultipleObjects]
public class CubeEditor : Editor
{
    public override void OnInspectorGUI()
    {
        Cube cube = (Cube) target;
        if(cube == null)return;
        
        EditorGUI.BeginChangeCheck();
            GUILayout.Label("Slider");
            cube._bazeSize = EditorGUILayout.Slider("Slider", cube._bazeSize, 0f, 10f);


            GUILayout.Space(10);
            GUILayout.Label("TextField");
            cube._text = GUILayout.TextField(cube._text);
        if(EditorGUI.EndChangeCheck())
        {
            Debug.Log("Slider Change");
        }

        cube.transform.localScale = Vector3.one * cube._bazeSize;
        
        GUILayout.BeginVertical();
            if(GUILayout.Button("Generate Random Color"))
            {
                cube.GenerateColor();
            }
            if(GUILayout.Button("Reset"))
            {
                cube.ResetColor();
            }
        GUILayout.EndVertical();
    }
}
