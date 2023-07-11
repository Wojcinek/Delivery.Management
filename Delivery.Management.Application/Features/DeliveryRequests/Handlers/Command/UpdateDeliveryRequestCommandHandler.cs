using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Delivery.Management.Application.Contracts.Presistence;
using Delivery.Management.Application.Features.DeliveryRequests.Requests.Command;
using MediatR;

namespace Delivery.Management.Application.Features.DeliveryRequests.Handlers.Command
{
    public class UpdateDeliveryRequestCommandHandler : IRequestHandler<UpdateDeliveryRequestCommand, Unit>
    {
        private readonly IDeliveryRequestRepository _deliveryRequestRepository;
        private readonly IMapper _mapper;

        public UpdateDeliveryRequestCommandHandler(IDeliveryRequestRepository deliveryRequestRepository, IMapper mapper)
        {
            _deliveryRequestRepository = deliveryRequestRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(UpdateDeliveryRequestCommand request, CancellationToken cancellationToken)
        {

            var deliveryRequest = await _deliveryRequestRepository.GetAsync(request.DeliveryRequestDto.Id);

            if (request.DeliveryRequestDto != null)
            {
                _mapper.Map(request.DeliveryRequestDto, deliveryRequest);

                await _deliveryRequestRepository.UpdateAsync(deliveryRequest);
            }

            return Unit.Value;
        }
    }
}
