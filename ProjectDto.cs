namespace core_Web_App.DTOs
{
    public class ProjectDto
    {
        public string ProjectTitle { get; set; }

        public string ProjectDescription { get; set; }

        public IEnumerable<string> Techs { get; set; }

    }
}


