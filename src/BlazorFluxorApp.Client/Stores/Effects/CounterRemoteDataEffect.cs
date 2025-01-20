using BlazorFluxorApp.Client.Stores.Actions;
using Fluxor;

namespace BlazorFluxorApp.Client.Stores.Effects
{
    public class CounterRemoteDataEffect : Effect<CounterFetchData>
    {
        public override Task HandleAsync(CounterFetchData action, IDispatcher dispatcher)
        {
            // TODO:: Get async initial data from API and dispatch the state if required
            return Task.CompletedTask;
        }
    }
}
