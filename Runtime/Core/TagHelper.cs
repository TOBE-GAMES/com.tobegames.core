using System;
using System.Linq;

namespace Tobe.Core
{
    public static class TagHelper
    {
        public static bool Contains(string[] tags, string tag)
        {
            return tags.Any(x => x.Equals(tag, StringComparison.InvariantCultureIgnoreCase));
        }
    }

    public static class AppHelper
    {
        public static void Quit()
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;

#endif
        }
    }
}