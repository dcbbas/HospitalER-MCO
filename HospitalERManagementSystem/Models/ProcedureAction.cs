using System;

namespace HospitalERManagementSystem.Models
{
    public class ProcedureAction
    {
        public string ActionId { get; set; }
        public string PatientId { get; set; }
        public string ActionName { get; set; }
        public string Details { get; set; }
        public DateTime PerformedAt { get; set; }

        public ProcedureAction(string actionId, string patientId, string actionName, string details)
        {
            ActionId = actionId;
            PatientId = patientId;
            ActionName = actionName;
            Details = details;
            PerformedAt = DateTime.Now;
        }

        public override string ToString()
        {
            return $"[{ActionId}] Patient: {PatientId} | {ActionName} - {Details} ({PerformedAt:yyyy-MM-dd HH:mm})";
        }
    }
}