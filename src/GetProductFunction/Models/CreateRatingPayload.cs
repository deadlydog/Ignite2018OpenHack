using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions.Models
{
    public class CreateRatingPayload
    {
        public Guid userId { get; set; }
        public Guid productId { get; set; }
        public Guid locationName { get; set; }
        public Guid rating { get; set; }

    }

}
