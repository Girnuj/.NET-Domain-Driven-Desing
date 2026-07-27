using Wpm.Clinic.Domain.Entities;
using Wpm.Clinic.Domain.ValueObjects;
using Wpm.SharedKernel;

namespace Wpm.Clinic.Domain;

public class Consultation : AggregateRoot
{
    public PatientId PatientId { get; init; }
    public Text Diagnosis { get; private set; }
    public Text Treatment { get; private set; }
    public Weight CurrentWeight { get; private set; }
    public ConsultationStatus Status { get; private set; }
    public DateTime Start { get; init; }
    public DateTime? End { get; private set; }

    private readonly List<DrugAdministration> _administeredDrugs = new();
    public IReadOnlyCollection<DrugAdministration> AdministeredDrugs => _administeredDrugs;

    private readonly List<VitalSigns> _vitalSignReadings = new();
    public IReadOnlyCollection<VitalSigns> VitalSignReadings => _vitalSignReadings;

    public Consultation(PatientId patientId)
    {
        Id = Guid.NewGuid();
        PatientId = patientId;
    }

    public void SetWeight(Weight weight)
    {
        ValidateConsultationStatus();
        CurrentWeight = weight;
        Status = ConsultationStatus.Started;
    }

    public void SetDiagnosis(Text diagnosis)
    {
        ValidateConsultationStatus();
        Diagnosis = diagnosis;
    }

    public void SetTreatment(Text treatment)
    {
        ValidateConsultationStatus();
        Treatment = treatment;
    }
    public void ConsultationEnd()
    {
        ValidateConsultationStatus();
        var nullValues = Diagnosis == null || Treatment == null || CurrentWeight == null;

        if (nullValues)
            throw new InvalidOperationException("La consulta no puede ser finalizada.");

        Status = ConsultationStatus.Finalized;
        End = DateTime.UtcNow;
    }

    public void AdministerDrug(DrugId drugId, Dose dose)
    {
        ValidateConsultationStatus();
        var newDrugAdministration = new DrugAdministration(drugId, dose);
        _administeredDrugs.Add(newDrugAdministration);
    }

    public void RegisterVitalSigns(IEnumerable<VitalSigns> vitalSigns)
    {
        ValidateConsultationStatus();
        _vitalSignReadings.AddRange(vitalSigns);
    }

    private void ValidateConsultationStatus()
    {
        if (Status == ConsultationStatus.Finalized)
            throw new InvalidOperationException("La consulta ya está finalizada.");
    }
}
public enum ConsultationStatus
{
    Started,
    Finalized
}
