using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

namespace Tobe.Core
{
    public abstract class EditorTyped<TModel> : Editor where TModel : class
    {
        private TModel _model;
        
        protected TModel Target => _model ?? (_model = target as TModel);

        protected void SaveSceneDirty()
        {
            EditorSceneManager.MarkSceneDirty(SceneManager.GetActiveScene());
        }

        protected EditorGuiHorizontalRow Row()
        {
            return new EditorGuiHorizontalRow();
        }

        
    }
}