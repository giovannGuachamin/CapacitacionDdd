using CapacitacionDdd.Core.Domain.Entities;
using MediatR;

namespace CapacitacionDdd.Core.Application.Features.Queries.GetAuthorByCode
{
    public class GetAuthorByCodeQuery : IRequest<Author>
    {
        #region Propiedades

        public string Code { get; set; }

        #endregion

        #region Constructor

        public GetAuthorByCodeQuery(string code)
        {
            Code = code;
        }

        #endregion
    }
}
