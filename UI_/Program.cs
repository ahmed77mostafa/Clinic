using System;
using data;
using Services_;



class Program
{
    static void Main(string[] args)
    {
        //Create a new fclinic manager
        ClinincService clinicManager = new();

        Patient patient = new Patient()
        { 
            Name = "John",
            Age = 33,
            Gender = "Male"
        };

        clinicManager.AddPatient(patient);

        List<Patient> patients = clinicManager.GetAllPatients();

        foreach (var _patients in patients)
        {
            Console.WriteLine(_patients.ToString());
        }

        patient Age = 21;


    }
}
