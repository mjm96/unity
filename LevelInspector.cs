using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(MyObject))]
//[CanEditMultipleObjects]
public class LevelInspector : Editor
{
	public MyObject targetLevel;
	SerializedProperty tex;

    public void OnEnable()
    {
		targetLevel = (MyObject)target;
		tex = serializedObject.FindProperty ("tx");
    }
    public override void OnInspectorGUI()
    {
		serializedObject.Update ();

		targetLevel.position= EditorGUILayout.Vector3Field ("position", targetLevel.position);
		 EditorGUILayout.ObjectField (tex, typeof(Texture));
	
		//EditorGUI.DrawTextureAlpha ();
		serializedObject.ApplyModifiedProperties ();
      
    }
}
