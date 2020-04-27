using TMPro;
using UnityEngine;
using Zenject;

namespace Tobe.Core
{
    public class UiManager : MonoBehaviour
    {
        public SimpleCardModel model;

        public RectTransform root;

        [Inject] private IUiViewFactory _uiViewFactory;
        
        public void CreateCard()
        {
            
            var instance = _uiViewFactory.CreateCardView(model) as CardView ;
            
            instance.transform.SetParent(root, false);
            
            instance.Open(model);
        }
    }
}