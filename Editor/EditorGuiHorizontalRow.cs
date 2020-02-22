using System;
using UnityEngine;

namespace Tobe.Core
{
    public class EditorGuiHorizontalRow : IDisposable
    {
        public EditorGuiHorizontalRow()
        {
            GUILayout.BeginHorizontal();
        }

        public void Dispose()
        {
            GUILayout.EndHorizontal();
        }
    }
}