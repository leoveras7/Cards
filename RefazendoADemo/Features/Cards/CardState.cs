using BlazorState;

namespace RefazendoADemo.Features.Cards
{
    public partial class CardState : State<CardState>
    {
        public string DeckId { get; private set; }
        public int RemainingCards { get; private set; }
        public string CurrentCard { get; private set; }
        public string CurrentSuit { get; private set; }
        public string CurrentImage { get; private set; }
        public bool Loading { get; private set; }

        public override void Initialize()
        {
            Loading = false;
            DeckId = null;
            RemainingCards = 0;
            CurrentCard = "None";
            CurrentSuit = "None";
            CurrentImage = "https://i.pinimg.com/originals/10/80/a4/1080a4bd1a33cec92019fab5efb3995d.png";
        }
    }
}
