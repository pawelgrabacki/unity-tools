using System;
using UnityEditor;

public class Example : EditorWindow
{
    //initial setup

    [MenuItem("TestPG/__Example")]
    private static void Init()
    {
        var inspWndType = typeof(SceneView);
        var window = GetWindow<Example>(inspWndType);
    }

    private void OnGUI()
    {
        
        EditorGUILayout.LabelField("Example", EditorStyles.boldLabel);

    }
}