﻿using MediatR;

namespace Toss.Server.Controllers
{
    public class DeleteTossCommand : IRequest
    {
        public DeleteTossCommand()
        {
        }

        public DeleteTossCommand(string tossId)
        {
            if (string.IsNullOrWhiteSpace(tossId))
            {
                throw new System.ArgumentException("message", nameof(tossId));
            }

            TossId = tossId;
        }

        public string TossId { get; set; }
    }
}