namespace Szpitalnex.Core.Dto
{
    public class PrescribedMedicineDto
    {
        public int Id { get; set; }

        public VisitDto Visit { get; set; }

        public MedicineDto Medicine { get; set; }
        public string Recommendations { get; set; }
    }
}
