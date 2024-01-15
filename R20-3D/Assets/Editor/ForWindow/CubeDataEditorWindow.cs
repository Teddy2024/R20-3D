using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;

public class CubeDataEditorWindow : ExtendedEditorWindow
{
    bool canTurn;
    bool canChangeColor;

    public static void Open(CubeData cubeData)
    {
        CubeDataEditorWindow window = GetWindow<CubeDataEditorWindow>("Cube Data Window");
        window.serializedObject = new SerializedObject(cubeData);
    }
    
    private void OnGUI() 
    {
        if (serializedObject == null)
        {
            Debug.Log("Noooooo");
            return;
        }
        currentProperty = serializedObject.FindProperty("DemoCubeDataList");
        
        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.BeginVertical("box", GUILayout.MaxWidth(150), GUILayout.ExpandHeight(true));
        DrawSldebar(currentProperty);
        EditorGUILayout.EndVertical();
        EditorGUILayout.BeginVertical("box", GUILayout.ExpandHeight(true));
        if(selectdeProperty != null)
        {
            DrawSelectedPropertiesPanel();
        }
        else
        {
            EditorGUILayout.LabelField("Selected a Cube from list");
        }
        EditorGUILayout.EndVertical();
        EditorGUILayout.EndHorizontal();

        Apply();
    }

    void DrawSelectedPropertiesPanel()
    {
        currentProperty = selectdeProperty;

        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.BeginVertical();
        SerializedProperty spriteProperty = currentProperty.FindPropertyRelative("sprite");
        spriteProperty.objectReferenceValue = EditorGUILayout.ObjectField(spriteProperty.objectReferenceValue, typeof(Sprite), false, GUILayout.Height(100), GUILayout.Width(100)) as Sprite;
        EditorGUILayout.EndVertical();
        EditorGUILayout.BeginVertical();
        DrawField("name", true);
        GUILayout.Space(20);
        DrawField("color", true);
        EditorGUILayout.EndVertical();
        EditorGUILayout.EndHorizontal();

        DrawField("description", true);

        EditorGUILayout.BeginHorizontal();
        if(GUILayout.Button("TurnByTime"))
        {
            canTurn = true;
            canChangeColor = false;
            
        }
        if(GUILayout.Button("ChangeColorByTime"))
        {
            canTurn = false;
            canChangeColor = true;
        }
        EditorGUILayout.EndHorizontal();

        if(canTurn)
        {
            EditorGUILayout.BeginVertical();
            DrawField("canTurn", true);
            DrawField("turnTime", true);
            DrawField("turnAngle", true);
            EditorGUILayout.EndVertical();
        }
        if(canChangeColor)
        {
            EditorGUILayout.BeginVertical();
            DrawField("canChangeColor", true);
            DrawField("changeTime", true);
            DrawField("changeColors", true);
            EditorGUILayout.EndVertical();
        }
    }
}
