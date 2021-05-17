﻿using BlogTrybe.Application.ViewModels;
using BlogTrybe.Core.Repositories;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace BlogTrybe.Application.Queries.GetUser
{
    public class GetUserQueryHandler : IRequestHandler<GetUserQuery, UserViewModel>
    {
        private readonly IUserRepository _userRepository;

        public GetUserQueryHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<UserViewModel> Handle(GetUserQuery request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetByIdAsync(request.Id);

            if (user == null)
                return null;

            return new UserViewModel(user.DisplayName, user.Email, user.Image);
        }
    }
}
