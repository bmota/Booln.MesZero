using Booln.MesZero.Dto;

namespace Booln.MesZero.Common.Dto
{
    public class FindUsersInput : PagedAndFilteredInputDto
    {
        public int? TenantId { get; set; }
    }
}