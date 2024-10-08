using AutoMapper;
using core_Web_App.DTOs;
using Microsoft.EntityFrameworkCore;

namespace core_Web_App.Repository
{
    public class ResumeParserServices : IResumeParserService
    {
        private readonly DbContext _db;
        private readonly IMapper _mapper;
       
        public ResumeParserServices(DbContext db,IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<ResumeDataDto> GetResumeData(string id)
        {
            if (!string.IsNullOrEmpty(id))
            {
                var fileData = await _db.fileStorageDetails.Where(fl=>fl.id == id).FirstOrDefaultAsync();
                var fileInfo = await _db.fileDetails.Where(fl=>fl.id == id).FirstOrDefaultAsync();
                
                
            }
            throw new NotImplementedException();
        }
    }
}


