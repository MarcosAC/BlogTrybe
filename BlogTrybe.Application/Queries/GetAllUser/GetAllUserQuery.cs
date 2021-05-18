using BlogTrybe.Application.ViewModels;
using MediatR;
using System.Collections.Generic;

namespace BlogTrybe.Application.Queries.GetAllUser
{
    public class GetAllUserQuery : IRequest<List<UserViewModel>>
    {
        public GetAllUserQuery(string query)
        {
            Query = query;
        }

        public string Query { get; private set; }
    }
}
