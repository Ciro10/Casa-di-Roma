using System;

namespace Casa_di_Roma.Models
{
        public class ErrorViewModel
        {
                public string RequestId { get; set; }

                public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
        }
}