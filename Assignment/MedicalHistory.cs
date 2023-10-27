using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class MedicalHistory
    {
        public int RecordId { get; set; }
        public int PatientId { get; set; }
        public string? Description { get; set; }
        public string? Date { get; set; }

        public static List<MedicalHistory> medicalHistory = new List<MedicalHistory>();
        public static void MedRecordInfo(int recordId, int patientId, string? description, string? date)
        {
            MedicalHistory medicalHistory = new MedicalHistory();
            medicalHistory.RecordId = recordId;
            medicalHistory.PatientId = patientId;
            medicalHistory.Description = description;
            medicalHistory.Date = date;

        }
    }
}
