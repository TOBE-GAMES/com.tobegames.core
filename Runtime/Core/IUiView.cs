namespace Tobe.Core
{
    public interface IUiView<TViewModel> : IRenderingComponent
    {
        TViewModel ViewModel { get;  }

        void SetModelDirty(bool value);

        ModelStrategy Strategy { get; set; }
        
        void Close();

        void Open(TViewModel model);
    }
}