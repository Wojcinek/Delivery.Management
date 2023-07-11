﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delivery.Management.Application.DTOs.DeliveryAllocation;
using MediatR;

namespace Delivery.Management.Application.Features.DeliveryAllocations.Requests.Commands
{
    public class CreateDeliveryAllocationCommand : IRequest<int>
    {
        public CreateDeliveryAllocationDto DeliveryAllocationDto { get; set; }
    }
}
