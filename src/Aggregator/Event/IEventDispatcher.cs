using System.Threading;
using System.Threading.Tasks;

namespace Aggregator.Event
{
    /// <summary>
    /// Interface for an event dispatcher implementation.
    /// </summary>
    /// <typeparam name="TEventBase">The event base type.</typeparam>
    public interface IEventDispatcher<in TEventBase>
    {
        /// <summary>
        /// Called when zero or more events need to be dispatched during the handling of a single command.
        /// </summary>
        /// <param name="events">The events generated by the execution of a single command.</param>
        /// <param name="cancellationToken">A cancellation token that allows cancelling the process.</param>
        /// <returns>An awaitable <see cref="Task"/>.</returns>
        Task Dispatch(TEventBase[] events, CancellationToken cancellationToken);
    }
}
