using System;
using GreenTMessagingService.Interfaces;
using Xamarin.Forms;

namespace GreenTMessagingService.Services
{
    /// <summary>
    /// Green TM essaging service implementation. We wrap MessagingCenter Api here.
    /// </summary>
    public class GreenTMessagingService : IGreenTMessagingService
    {
        static GreenTMessagingService instance = null;

        public static GreenTMessagingService Current => (instance ?? (instance = new GreenTMessagingService()));

        public static void Init()
        {
            var time = DateTime.UtcNow;
        }

        /// <summary>
        /// Subscribe the specified message and callback.
        /// </summary>
        /// <param name="message">Message.</param>
        /// <param name="callback">Callback.</param>
        public void Subscribe(string message, Action<IGreenTMessagingService> callback)
        => MessagingCenter.Subscribe<GreenTMessagingService>(this, message, callback);

        /// <summary>
        /// Subscribe the specified message and callback.
        /// </summary>
        /// <param name="message">Message.</param>
        /// <param name="callback">Callback.</param>
        /// <typeparam name="TArgs">The 1st type parameter.</typeparam>
        public void Subscribe<TArgs>(string message, Action<IGreenTMessagingService, TArgs> callback)
        => MessagingCenter.Subscribe<GreenTMessagingService, TArgs>(this, message, callback);

        /// <summary>
        /// Send the specified message.
        /// </summary>
        /// <param name="message">Message.</param>
        public void Send(string message) => MessagingCenter.Send<GreenTMessagingService>(this, message);

        /// <summary>
        /// Send the specified message and args.
        /// </summary>
        /// <param name="message">Message.</param>
        /// <param name="args">Arguments.</param>
        /// <typeparam name="TArgs">The 1st type parameter.</typeparam>
        public void Send<TArgs>(string message, TArgs args) => MessagingCenter.Send<GreenTMessagingService, TArgs>(this, message, args);

        /// <summary>
        /// Unsubscribe the specified message.
        /// </summary>
        /// <param name="message">Message.</param>
        public void Unsubscribe(string message) => MessagingCenter.Unsubscribe<GreenTMessagingService>(this, message);

        public void Unsubscribe<TArgs>(string message) => MessagingCenter.Unsubscribe<GreenTMessagingService, TArgs>(this, message);
    }
}
