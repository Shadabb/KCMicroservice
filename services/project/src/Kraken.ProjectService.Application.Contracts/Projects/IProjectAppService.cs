using Kraken.ProjectService.Projects.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Kraken.ProjectService.Projects
{
    public interface IProjectAppService : IApplicationService
    {
        Task<List<ProjectDto>> GetAllAsync();

        Task<ProjectDto> Create(ProjectDto projectDto);
    }
}
