using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;

public class ExtendedEditorWindow : EditorWindow
{
    protected SerializedObject serializedObject;
    protected SerializedProperty currentProperty;

    private string selectdePropertyPath;
    protected SerializedProperty selectdeProperty;

    protected void DrawProperties(SerializedProperty prop, bool drawChildren)
    {
        string lastPropPath = string.Empty;

        foreach(SerializedProperty p in prop)
        {
            if(p.isArray && p.propertyType == SerializedPropertyType.Generic)
            {
                EditorGUILayout.BeginHorizontal();
                p.isExpanded = EditorGUILayout.Foldout(p.isExpanded, p.displayName);
                EditorGUILayout.EndHorizontal();

                if(p.isExpanded)
                {
                    EditorGUI.indentLevel++;
                    DrawProperties(p, drawChildren);
                    EditorGUI.indentLevel--;
                }
            }
            else
            {
                if(!string.IsNullOrEmpty(lastPropPath) && p.propertyPath.Contains(lastPropPath)){ continue; }
                lastPropPath = p.propertyPath;
                EditorGUILayout.PropertyField(p, drawChildren);
            }
        }
    }

    protected void DrawSldebar(SerializedProperty prop)
    {
        foreach(SerializedProperty p in prop)
        {
            if(GUILayout.Button(p.displayName))
            {
                selectdePropertyPath = p.propertyPath;
            }
        }

        if(!string.IsNullOrEmpty(selectdePropertyPath))
        {
            selectdeProperty = serializedObject.FindProperty(selectdePropertyPath);
        }
    }

    protected void DrawField(string propName, bool relative)
    {
        if(relative && currentProperty != null)
        {
            EditorGUILayout.PropertyField(currentProperty.FindPropertyRelative(propName), true);
        }
        else if(serializedObject != null)
        {
            EditorGUILayout.PropertyField(serializedObject.FindProperty(propName), true);
        }
    }

    protected void Apply()
    {
        serializedObject.ApplyModifiedProperties();
    }
}
