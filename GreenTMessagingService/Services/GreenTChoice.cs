using System;
namespace GreenTMessagingService.Services
{
    public class GreenTChoice
    {
        public string Title { get; set; }

        public string Question { get; set; }

        public string Destruction { get; set; }

        /// <summary>
        /// Gets or sets the items displayed in the list.
        /// </summary>
        /// <value>The items.</value>
        public string[] Items { get; set; }

        public Action<string> OnCompleted { get; set; }
    }
}
