using System;
namespace GreenTMessagingService.Interfaces
{
    public interface IGreenTMessagingService
    {
        /// <summary>
        /// Subscribe the specified message and callback.
        /// </summary>
        /// <param name="message">Message.</param>
        /// <param name="callback">Callback.</param>
        void Subscribe(string message, Action<IGreenTMessagingService> callback);

        /// <summary>
        /// Subscribe the specified message and callback with parameter.
        /// </summary>
        /// <param name="message">Message.</param>
        /// <param name="callback">Callback.</param>
        /// <typeparam name="TArgs">The 1st type parameter.</typeparam>
        void Subscribe<TArgs>(string message, Action<IGreenTMessagingService, TArgs> callback);

        /// <summary>
        /// Send the specified message.
        /// </summary>
        /// <param name="message">Message.</param>
        void Send(string message);

        /// <summary>
        /// Send the specified message and args.
        /// </summary>
        /// <param name="message">Message.</param>
        /// <param name="args">Arguments.</param>
        /// <typeparam name="TArgs">The 1st type parameter.</typeparam>
        void Send<TArgs>(string message, TArgs args);

        /// <summary>
        /// Unsubscribe the specified message.
        /// </summary>
        /// <param name="message">Message.</param>
        void Unsubscribe(string message);

        /// <summary>
        /// Unsubscribe the specified message.
        /// </summary>
        /// <param name="message">Message.</param>
        /// <typeparam name="TArgs">The 1st type parameter.</typeparam>
        void Unsubscribe<TArgs>(string message);
    }
}
