namespace Szpitalnex.Core.Dto
{
    public class DiagnosedDiseaseDto
    {
        public int Id { get; set; }
        public VisitDto Visit { get; set; }
        public DiseaseDto Disease { get; set; }
    }
}
