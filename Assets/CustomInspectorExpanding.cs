using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;

// Tell what class inspector we're trying to customize
[CustomEditor(typeof(CustomInspectorExpanding))]
[CanEditMultipleObjects]
public class CustomInspectorExpandingEditor : Editor
{
    // SerializedProperties are friends. A curse but a friend
    public override void OnInspectorGUI()
    {
        // Use Unity to automate row and column divisions with BeginHorizontal and BeginVertical
        EditorGUILayout.BeginHorizontal();
                if(GUILayout.Button("Randomize Color")) ((CustomInspectorExpanding)target).RandomizeColor();
            EditorGUILayout.EndHorizontal();

        EditorGUILayout.BeginHorizontal();
            if(GUILayout.Button("Set Color")) ((CustomInspectorExpanding)target).ApplyColor();
            if(GUILayout.Button("Set Color (HDR)")) ((CustomInspectorExpanding)target).ApplyColor(true);
        EditorGUILayout.EndHorizontal();
        // Draw the default one
        base.OnInspectorGUI();
    }
}
#endif

public class CustomInspectorExpanding : DefaultInspectorExpanding
{

}
