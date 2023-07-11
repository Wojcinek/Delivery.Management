using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Delivery.Management.Application.Contracts.Presistence;
using Delivery.Management.Application.Features.DeliveryRequests.Requests.Command;
using Delivery.Management.Domain;
using MediatR;

namespace Delivery.Management.Application.Features.DeliveryRequests.Handlers.Command
{
    public class CreateDeliveryRequestCommandHandler : IRequestHandler<CreateDeliveryRequestCommand, int>
    {
        private readonly IDeliveryRequestRepository _deliveryRequestRepository;
        private readonly IMapper _mapper;

        public CreateDeliveryRequestCommandHandler(IDeliveryRequestRepository deliveryRequestRepository, IMapper mapper)
        {
            _deliveryRequestRepository = deliveryRequestRepository;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreateDeliveryRequestCommand request, CancellationToken cancellationToken)
        {
            var deliveryRequest = _mapper.Map<DeliveryRequest>(request.DeliveryRequestDto); 

            deliveryRequest = await _deliveryRequestRepository.AddAsync(deliveryRequest);

            return deliveryRequest.Id;
        }
    }
}
