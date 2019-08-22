using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(DictionaryScript))]
public class DictionaryScriptEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        if (((DictionaryScript)target).modifyValues)
        {
            if (GUILayout.Button("Save changes"))
            {
                ((DictionaryScript)target).DeserializeDictionary();
            }

        }
        EditorGUILayout.LabelField("", GUI.skin.horizontalSlider);
        if (GUILayout.Button("Print Dictionary"))
        {
            ((DictionaryScript)target).PrintDictionary();
        }
    }
}
