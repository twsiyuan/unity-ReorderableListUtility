using UnityEditor;
using UnityEditorInternal;

[CustomEditor(typeof(ShopMenu))]
[CanEditMultipleObjects]
public class ShopMenuEditor : Editor
{
    private ReorderableList list1;
    private ReorderableList list2;

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        this.serializedObject.Update();

        EditorGUILayout.Space();
        EditorGUILayout.LabelField("Example1", EditorStyles.boldLabel);
        ReorderableListUtility.DoLayoutListWithFoldout(this.list1);

        EditorGUILayout.Space();
        EditorGUILayout.LabelField("Example2", EditorStyles.boldLabel);
        ReorderableListUtility.DoLayoutListWithFoldout(this.list2);

        this.serializedObject.ApplyModifiedProperties();
    }

    private void OnEnable()
    {
        var property = this.serializedObject.FindProperty("Drinks");

        this.list1 = ReorderableListUtility.CreateAutoLayout(property);
        this.list2 = ReorderableListUtility.CreateAutoLayout(
            property,
            new string[] { "Drink Name", "Cost", "Key Color" },
            new float?[] { 100, 70 });
    }
}