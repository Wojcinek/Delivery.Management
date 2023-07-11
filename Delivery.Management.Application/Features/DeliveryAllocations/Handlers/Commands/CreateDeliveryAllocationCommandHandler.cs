using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Delivery.Management.Application.Contracts.Presistence;
using Delivery.Management.Application.Features.DeliveryAllocations.Requests.Commands;
using Delivery.Management.Domain;
using MediatR;

namespace Delivery.Management.Application.Features.DeliveryAllocations.Handlers.Commands
{
    public class CreateDeliveryAllocationCommandHandler : IRequestHandler<CreateDeliveryAllocationCommand, int>
    {
        private readonly IDeliveryAllocationRepository _deliveryAllocationRepository;
        private readonly IMapper _mapper;

        public CreateDeliveryAllocationCommandHandler(IDeliveryAllocationRepository deliveryAllocationRepository, IMapper mapper)
        {
            _deliveryAllocationRepository = deliveryAllocationRepository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateDeliveryAllocationCommand request, CancellationToken cancellationToken)
        {
            var deliveryAllocation = _mapper.Map<DeliveryAllocation>(request.DeliveryAllocationDto);

            deliveryAllocation = await _deliveryAllocationRepository.AddAsync(deliveryAllocation);

            return deliveryAllocation.Id;
        }
    }
}
