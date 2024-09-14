using Website.Data.Services.Interfaces;
using Website.Data.Models;

namespace Website.Data.Services;

public class ResumeService : IResumeService{
    private ResumeModel resume;
    public ResumeService(IConfiguration configuration){
        var resumepath = configuration["ResumeConfigPath"];
        if(string.IsNullOrEmpty(resumepath)){
            throw new Exception("No resume path has been provided");
        }
        using (StreamReader reader = new StreamReader(resumepath)) {
            var raw = reader.ReadToEnd();
            resume = Newtonsoft.Json.JsonConvert.DeserializeObject<ResumeModel>(raw);
        }
    }
    public ResumeModel GetResume()
    {
        return resume;
    }
}