using BlazorFluxorApp.Stores.Actions;
using BlazorFluxorApp.Stores.States;
using Fluxor;

namespace BlazorFluxorApp.Client.Stores.Reducers
{
    public class CounterReducer : Reducer<CounterState, IncrementCounterAction>
    {
        public CounterReducer()
        {
            
        }
        public override CounterState Reduce(CounterState state, IncrementCounterAction action)
        {
            // Update the state by incrementing the ClickCount
            return new CounterState(state.ClickCount + 1);
        }
    }
}
