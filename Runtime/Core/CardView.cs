using System;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Tobe.Core
{
    public class CardView : MonoComponent, ICardView
    {
        [SerializeField] private CardHeader header;

        [SerializeField] private CardBody body;

        [SerializeField] private CardFooter footer;

        [SerializeField] private SimpleCardModel simpleCardModel;

        [SerializeField] private UiImageComponent background;

        [SerializeField] private ModelStrategy modelStrategy;

        public ICardHeader Header => header;

        public ICardBody Body => body;

        public ICardFooter Footer => footer;
        
        public IUiImageComponent Background => background;
        
        public SimpleCardModel ViewModel => simpleCardModel;

        private bool _isModelDirty = true;

        private ICardViewService _cardViewService;
        
        public class Factory : PlaceholderFactory<CardView>
        {
            
        }
        
        [Inject]
        private void Ctor(ICardViewService service)
        {
            _cardViewService = service;
        }
        
        public void SetModelDirty(bool value)
        {
            _isModelDirty = value;
        }

        public ModelStrategy Strategy
        {
            get => modelStrategy;
            set => modelStrategy = value;
        }

        public void Close()
        {
            Destroy(gameObject);
        }

        public void Open(SimpleCardModel model)
        {
            simpleCardModel = model;
        }
      
        public void Show()
        {
            _cardViewService.Show(this);
        }

        public void Hide()
        {
            _cardViewService.Hide(this);
        }
      
        protected override void OnUpdate()
        {
            switch (modelStrategy)
            {
                case ModelStrategy.EachUpdate:
                    _cardViewService.ReflectViewModel(this, ViewModel);
                    break;
                case ModelStrategy.IfModelIsDirty:
                    if (_isModelDirty)
                    {
                        _cardViewService.ReflectViewModel(this, ViewModel);
                        _isModelDirty = false;
                    }

                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public override void SetEnabled(bool value)
        {
            base.SetEnabled(value);

            if (value)
            {
                _cardViewService.Enable(this);
            }
            else
            {
                _cardViewService.Disable(this);
            }
        }
    }
}