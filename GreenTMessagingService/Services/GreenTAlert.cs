using System;
namespace GreenTMessagingService.Services
{
    public class GreenTAlert
    {
        public string Title { get; set; }

        public string Message { get; set; }

        public string Cancel { get; set; }

        public Action OnCompleted { get; set; }
    }
}
