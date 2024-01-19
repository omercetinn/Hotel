﻿using Hotels.Application.Features.CQRS.Commands.BannerCommands;
using Hotels.Application.Interfaces;
using Hotels.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Application.Features.CQRS.Handlers.BannerHandler
{
    public class UpdateBannerCommandHandler
    {
        private readonly IRepository<Banner> _repository;

        public UpdateBannerCommandHandler(IRepository<Banner> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateBannerCommand command)
        {
            var values = await _repository.GetByIdAsync(command.BannerId);          
            values.Description= command.Description;
            values.Title= command.Title;
            values.VideoUrl= command.VideoUrl;
            values.VideoDescription= command.VideoDescription;
            await _repository.UpdateAsync(values);
        }
    }
}
