﻿using Microsoft.AspNetCore.Mvc;
using goglobe_API.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using goglobe_API.Data.Entities;
using goglobe_API.Data.DTOs.TravelOffers;
using System.Linq;
using AutoMapper;

namespace goglobe_API.Controllers
{
    [ApiController]
    [Route("/api/travelOffers")]
    public class TravelOfferController : ControllerBase
    {
        private readonly ITravelOfferRepository _travelOfferRepository;
        private readonly IMapper _mapper;

        public TravelOfferController(ITravelOfferRepository travelOfferRepository, IMapper mapper)
        {
            _travelOfferRepository = travelOfferRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<TravelOfferDTO>> GetAll()
        {
            return (await _travelOfferRepository.GetAll())
                .Select(obj => _mapper.Map<TravelOfferDTO>(obj));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TravelOfferDTO>> Get(int id)
        {
            var travelOffer = await _travelOfferRepository.Get(id);
            if (travelOffer == null) return NotFound($"Travel offer with id `{id}` was not found");

            return Ok(_mapper.Map<TravelOfferDTO>(travelOffer));
        }

        [HttpPost]
        public async Task<ActionResult<TravelOfferDTO>> Post(CreateTravelOfferDTO createTravelOfferDTO)
        {
            var travelOffer = _mapper.Map<TravelOffer>(createTravelOfferDTO);

            await _travelOfferRepository.Create(travelOffer);

            return Created($"/api/travelOffers.{travelOffer.Id}", _mapper.Map<TravelOfferDTO>(travelOffer));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<TravelOfferDTO>> Put(int id, CreateTravelOfferDTO createTravelOfferDTO)
        {
            var travelOffer = await _travelOfferRepository.Get(id);
            if (travelOffer == null) return NotFound($"TravelOffer with id `{id}` was not found");

            await _travelOfferRepository.Put(travelOffer);

            return Ok(_mapper.Map<TravelOfferDTO>(travelOffer));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<TravelOfferDTO>> Delete(int id)
        {
            var travelOffer = await _travelOfferRepository.Get(id);
            if (travelOffer == null) return NotFound($"TravelOffer with id `{id}` was not found");

            await _travelOfferRepository.Delete(travelOffer);

            return NoContent();
        }
    }
}
