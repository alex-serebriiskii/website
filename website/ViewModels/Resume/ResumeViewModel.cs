using Website.Data.Models;
using Website.Data.Services.Interfaces;

namespace Website.ViewModels;

class ResumeViewModel{
    private readonly IResumeService _resumeService;
    public ResumeModel ResumeModel{ get; set; }
    public ResumeViewModel(IResumeService resumeService)
    {
        _resumeService = resumeService;
        ResumeModel = _resumeService.GetResume();
    }

    

}