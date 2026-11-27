using System;

namespace HospitalERManagementSystem.Models
{
    public class MedicalRecord
    {
        public string RecordId { get; set; }
        public string PatientId { get; set; }
        public string Diagnosis { get; set; }
        public string Notes { get; set; }
        public DateTime RecordedAt { get; set; }

        public MedicalRecord(string recordId, string patientId, string diagnosis, string notes)
        {
            RecordId = recordId;
            PatientId = patientId;
            Diagnosis = diagnosis;
            Notes = notes;
            RecordedAt = DateTime.Now;
        }

        public override string ToString()
        {
            return $"[{RecordId}] Patient: {PatientId} | {Diagnosis} - {Notes} ({RecordedAt:yyyy-MM-dd HH:mm})";
        }
    }
}