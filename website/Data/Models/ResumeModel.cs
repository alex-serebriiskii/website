namespace Website.Data.Models;
public class ResumeModel
{
    public string Name {get;set;}// = "Lorem ipsum";
    public string Title {get;set;}// = "Lorem ipsum";
    public string Summary {get; set; }// = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.";
    public (string,string)[] ContactInfo {get;set; }// = new(string, string)[] { ("phone:", "123-456-7890")};

    public List<JobModel> Jobs {get;set;} = new List<JobModel>();
    public List<string> Skills = new List<string>(); 
    public List<string> Certs = new List<string>();
    public List<string> Projects = new List<string>();

}