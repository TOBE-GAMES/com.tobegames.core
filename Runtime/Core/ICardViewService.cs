namespace Tobe.Core
{
    public interface ICardViewService
    {
        void Enable(ICardView cardView);
        void Disable(ICardView cardView);
        void Show(ICardView cardView);
        void Hide(ICardView cardView);
        void ReflectViewModel(ICardView cardView, SimpleCardModel viewModel);
    }

    public class CardViewService : ICardViewService
    {
        public void Enable(ICardView cardView)
        {
            cardView.Body?.SetEnabled(true);
            cardView.Header?.SetEnabled(true);
            cardView.Footer?.SetEnabled(true);
            cardView.Background?.SetEnabled(true);
        }

        public void Disable(ICardView cardView)
        {
            cardView.Body?.SetEnabled(false);
            cardView.Header?.SetEnabled(false);
            cardView.Footer?.SetEnabled(false);
            cardView.Background?.SetEnabled(false);
        }

        public void Show(ICardView cardView)
        {
            cardView.Body?.Show();
            cardView.Header?.Show();
            cardView.Footer?.Show();
            cardView.Background?.SetEnabled(true);
        }

        public void Hide(ICardView cardView)
        {
            cardView.Body?.Hide();
            cardView.Header?.Hide();
            cardView.Footer?.Hide();
            cardView.Background?.SetEnabled(false);
        }

        public void ReflectViewModel(ICardView cardView, SimpleCardModel viewModel)
        {
            cardView.Header.Title.Text = viewModel.title;

            cardView.Body.Content.Text = viewModel.body;

            cardView.Footer.Content.Text = viewModel.footer;
        }
    }
}