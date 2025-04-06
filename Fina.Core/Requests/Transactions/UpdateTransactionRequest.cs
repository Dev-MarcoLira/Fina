using Fina.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fina.Core.Requests.Transactions
{
    internal class UpdateTransactionRequest : Request
    {
        public long Id { get; set; }

        [Required(ErrorMessage = "Invalid title")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Invalid type")]
        public ETransationType Type { get; set; } = ETransationType.Withdraw;

        [Required(ErrorMessage = "Invalid amount")]
        public decimal Amount { get; set; }

        [Required(ErrorMessage = "Invalid category")]
        public long CategoryId { get; set; }

        [Required(ErrorMessage = "Invalid date")]
        public DateTime? PaidOrReceivedAt { get; set; }
    }
}
