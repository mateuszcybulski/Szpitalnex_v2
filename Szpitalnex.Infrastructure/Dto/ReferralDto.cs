namespace Szpitalnex.Core.Dto
{
    public class ReferralDto
    {
        public int Id { get; set; }
        public string Purpose { get; set; }

        public SpecializationDto Specialization { get; set; }

        public VisitDto Visit { get; set; }
    }
}
