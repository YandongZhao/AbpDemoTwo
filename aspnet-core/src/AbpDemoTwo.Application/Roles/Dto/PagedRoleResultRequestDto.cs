using Abp.Application.Services.Dto;

namespace AbpDemoTwo.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

