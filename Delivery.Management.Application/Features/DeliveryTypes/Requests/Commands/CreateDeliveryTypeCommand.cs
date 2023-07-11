using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delivery.Management.Application.DTOs.DeliveryType;
using MediatR;

namespace Delivery.Management.Application.Features.DeliveryTypes.Requests.Commands
{
    public class CreateDeliveryTypeCommand : IRequest<int>
    {
        public CreateDeliveryTypeDto DeliveryTypeDto { get; set; }
    }
}
