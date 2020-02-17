using UnityEngine;

namespace Tobe.Core
{
    public static class TransformHelpers
    {
        public static void DestroyAllChildren(this Transform parent, bool destroyImediate = false)
        {
            var count = parent.childCount;

            for (int i = 0; i < count; i++)
            {
                var child = parent.GetChild(i);
                
                if (destroyImediate)
                {
                    Object.DestroyImmediate(child.gameObject);
                }
                else
                {
                    Object.Destroy(child.gameObject);
                }
            }
        }
    }
}