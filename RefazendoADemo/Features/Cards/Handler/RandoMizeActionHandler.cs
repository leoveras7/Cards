using BlazorState;
using MediatR;
using RefazendoADemo.Models;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading;
using System.Threading.Tasks;


namespace RefazendoADemo.Features.Cards
{
    public partial class CardState
    {
        public class RandoMizeActionHandler : ActionHandler<RandoMizeAction>
        {
            private readonly HttpClient _httpClient;

            public RandoMizeActionHandler(IStore store, HttpClient httpClient) : base(store)
            {
                _httpClient = httpClient;
            }

            CardState State => Store.GetState<CardState>();

            public override async Task<Unit> Handle(RandoMizeAction aAction, CancellationToken aCancellationToken)
            {
                var response = await _httpClient.GetFromJsonAsync<RandoMizeResponse>("https://deckofcardsapi.com/api/deck/new/shuffle/?deck_count=1");

                if (response.Success)
                {
                    State.DeckId = response.DeckId;
                    State.RemainingCards = response.Remaining;
                }
                else
                {
                    State.DeckId = null;
                    State.RemainingCards = 0;
                }

                return await Unit.Task;
            }
        }
    }
}
