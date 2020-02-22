using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Tobe.Core
{
    [CustomEditor(typeof(ShaderParameterBlockComponent))]
    public class ShaderParameterBlockComponentEditor : EditorTyped<ShaderParameterBlockComponent>
    {
        public override void OnInspectorGUI()
        {
            GUILayout.Label("Colors");

            if (GUILayout.Button("+", GUILayout.Width(20)))
            {
                var l = Target.colorShaderParameters?.ToList() ?? new List<ColorShaderParameter>();

                l.Add(new ColorShaderParameter());

                Target.colorShaderParameters = l.ToArray();

                SaveSceneDirty();
            }

            var colors = Target.colorShaderParameters;

            if (colors != null)
            {
                EditorGuiHelpers.PrintArray(colors, (i, parameter) =>
                {
                    using (var row = Row())
                    {
                        GUILayout.TextArea(parameter?.parameterName, GUILayout.Width(150));

                        EditorGUILayout.ColorField(parameter?.value ?? Color.black, GUILayout.Width(150));

                        if (GUILayout.Button(new GUIContent("x", "Delete")))
                        {
                            Target.colorShaderParameters = ArrayHelpers.RemoveAt(colors, i);

                            SaveSceneDirty();
                        }
                    }
                });
            }

            using (Row())
            {
                GUILayout.Label("Ints");

                if (GUILayout.Button("+", GUILayout.Width(20)))
                {
                    var l = Target.intShaderParameters?.ToList() ?? new List<IntShaderParameter>();

                    l.Add(new IntShaderParameter());

                    Target.intShaderParameters = l.ToArray();

                    SaveSceneDirty();
                }
            }

            var ints = Target.intShaderParameters;
            if (ints != null)
            {
                EditorGuiHelpers.PrintArray(ints, (i, parameter) =>
                {
                    using (var row = Row())
                    {
                        GUILayout.TextArea(parameter?.parameterName, GUILayout.Width(150));

                        EditorGUILayout.IntField(parameter?.value ?? 0, GUILayout.Width(150));

                        if (GUILayout.Button(new GUIContent("x", "Delete")))
                        {
                            Target.intShaderParameters = ArrayHelpers.RemoveAt(ints, i);

                            SaveSceneDirty();
                        }
                    }
                });
            }

            using (Row())
            {
                GUILayout.Label("Floats");

                if (GUILayout.Button("+", GUILayout.Width(20)))
                {
                    var l = Target.floatShaderParameters?.ToList() ?? new List<FloatShaderParameter>();

                    l.Add(new FloatShaderParameter());

                    Target.floatShaderParameters = l.ToArray();

                    SaveSceneDirty();
                }
            }


            var floats = Target.floatShaderParameters;

            if (floats != null)
            {
                EditorGuiHelpers.PrintArray(floats, (i, parameter) =>
                {
                    using (var row = Row())
                    {
                        GUILayout.TextArea(parameter?.parameterName, GUILayout.Width(150));

                        EditorGUILayout.FloatField(parameter?.value ?? 0, GUILayout.Width(150));

                        if (GUILayout.Button(new GUIContent("x", "Delete")))
                        {
                            Target.floatShaderParameters = ArrayHelpers.RemoveAt(floats, i);

                            SaveSceneDirty();
                        }
                    }
                });
            }

            base.OnInspectorGUI();
        }
    }
}