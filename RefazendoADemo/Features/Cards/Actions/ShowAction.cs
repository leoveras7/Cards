using BlazorState;

namespace RefazendoADemo.Features.Cards
{
    public partial class CardState
    { 
    public class ShowAction : IAction
    {
        public string DeckId { get; private set; }
            public ShowAction(string deckId)
            {
                DeckId = deckId;
            }
        }
    }
}
