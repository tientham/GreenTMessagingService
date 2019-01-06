using System;
namespace GreenTMessagingService.Services
{
    public class GreenTQuestion
    {
        public string Title { get; set; }

        public string Question { get; set; }

        /// <summary>
        /// Gets or sets the positive button text.
        /// </summary>
        /// <value>The positive.</value>
        public string Positive { get; set; }

        /// <summary>
        /// Gets or sets the negative button text.
        /// </summary>
        /// <value>The negative.</value>
        public string Negative { get; set; }

        public Action<bool> OnCompleted { get; set; }
    }
}
