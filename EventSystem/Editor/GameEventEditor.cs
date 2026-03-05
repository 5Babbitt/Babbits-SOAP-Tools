#if UNITY_EDITOR
using System.Collections;
using System.Reflection;
using UnityEditor;
using UnityEngine;

namespace SOAP.EventSystem.Editor
{
    [CustomEditor(typeof(GameEvent<>), true)]
    public class GameEventEditor : UnityEditor.Editor
    {
        private void OnEnable()
        {
            EditorApplication.update += Repaint;
        }

        private void OnDisable()
        {
            EditorApplication.update -= Repaint;
        }
        
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            EditorGUILayout.Space();

            DrawListeners();
            EditorGUILayout.Space();

            if (GUILayout.Button("Raise (default value)"))
                target.GetType()
                    .GetMethod("RaiseDefault", BindingFlags.NonPublic | BindingFlags.Instance)
                    ?.Invoke(target, null);
        }
        
        private void DrawListeners()
        {
            EditorGUILayout.LabelField("Registered Listeners", EditorStyles.boldLabel);

            // Walk up the hierarchy until we find the field
            var type = target.GetType();
            FieldInfo listenersField = null;
    
            while (type != null && listenersField == null)
            {
                listenersField = type.GetField("listeners", 
                    BindingFlags.NonPublic | BindingFlags.Instance);
                type = type.BaseType;
            }

            var listeners = listenersField?.GetValue(target) as IList;

            if (listeners == null || listeners.Count == 0)
            {
                EditorGUILayout.HelpBox("No listeners registered — only visible at runtime.", MessageType.Info);
                return;
            }

            GUI.enabled = false;
            foreach (var listener in listeners)
            {
                if (listener is MonoBehaviour mb)
                    EditorGUILayout.ObjectField(mb, typeof(MonoBehaviour), true);
                else
                    EditorGUILayout.LabelField(listener?.ToString() ?? "null");
            }
            GUI.enabled = true;
        }
    }
}
#endif