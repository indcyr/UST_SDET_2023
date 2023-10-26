using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Patient
    {
        public int PatientId { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? Diagnosis { get; set; }

        List<Patient> pat = new List<Patient>();

        public Patient(int patientId, string? name, int age, string? diagnosis)
        {
            PatientId = patientId;
            Name = name;
            Age = age;
            Diagnosis = diagnosis;
        }

        public void AddPatient(Patient patient) 
        {
            if(patient.Age < 0 || patient.Age > 120)
            {
                throw new ArgumentException("Age should be btwn 0 and 120");
            }
            else if(patient.Name == "" || patient.Diagnosis == "")
            {
                throw new ArgumentException("Patient name and diagnosis should not be null ");
            }
            else
            {
                pat.Add(patient);
                Console.WriteLine("Patient Added");

            }

        }




    }
}
