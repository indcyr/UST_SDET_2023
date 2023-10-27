using Assignment.ExceptionHandling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment
{
    internal class MedicalRecord //: Patient
    {
        public MedicalRecord(int recId,double cost, int patientId,string? name, int age, string? diagnosis)// : base (patientId, name, age, diagnosis)
        {
            RecId = recId;
            Cost = cost;
            
        }

        public int RecId { get; set; }
        public double Cost { get; set; }

        List<MedicalRecord> medreport = new List<MedicalRecord>(); 

      /*  public void AddMedicalReport(MedicalRecord medicalRecord)
        {
            if((medicalRecord.Name == null||medicalRecord.Name==" ") ||(medicalRecord.Diagnosis == null|| medicalRecord.Name == " "))
            {
                throw new InvalidPatientDataException(ExceptionMessages.messages[1]);
            }
            else if(medicalRecord.Cost < 0)
            {
                throw new InvalidMedicalRecordException(ExceptionMessages.messages[2]);
            }
            else
            {
                medreport.Add(medicalRecord);
                Console.WriteLine("Patient added");
            }
        }
      */
    }
}
