using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(FieldGenerator))]
public class FieldGeneratorEditor : Editor
{
    FieldGenerator fieldGenerator;

    private void OnEnable()
    {
        fieldGenerator = serializedObject.targetObject as FieldGenerator;
    }

    public override void OnInspectorGUI()
    {
        serializedObject.Update();
        base.OnInspectorGUI();

        if (GUILayout.Button("Generate"))
        {
            fieldGenerator.ClearFieldImmediate();
            fieldGenerator.Generate();
        }

        if (GUILayout.Button("Clear"))
        {
            fieldGenerator.ClearFieldImmediate();
        }

        serializedObject.ApplyModifiedProperties();
    }
}
