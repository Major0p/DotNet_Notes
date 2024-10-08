using core_Web_App.DTOs;

namespace core_Web_App.Repository
{
    public interface IResumeParserService
    {
        public Task<ResumeDataDto> GetResumeData(string id);
    }
}





