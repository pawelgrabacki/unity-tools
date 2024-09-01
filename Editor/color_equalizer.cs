using System;
using UnityEditor;

public class color_equalizer : EditorWindow
{
    //initial setup

    [MenuItem("TestPG/color_equalizer")]
    private static void Init()
    {
        var inspWndType = typeof(SceneView);
        var window = GetWindow<color_equalizer>(inspWndType);
    }

    private void OnGUI()
    {
        
        EditorGUILayout.LabelField("color_equalizer", EditorStyles.boldLabel);

    }
}