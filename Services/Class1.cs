using data;

namespace Services_
{
    public class ClinincService
    {
        private List<Patient> patients = new List<Patient>();

        public void AddPatient(Patient patint)
        {
            patients.Add(patint);
        }

        public List<Patient> GetAllPatients()
        {
            return patients;
        }

        public Patient GetPatientById(int id)
        {
            return patients.Find(patint => patint.Id == id);
        }
        public void UpdatePatient(Patient patint)
        {
            Patient existingPatient = GetPatientById(patint.Id);

            existingPatient.Name = patint.Name;
            existingPatient.Age = patint.Age;
            existingPatient.Gender = patint.Gender;
        }
        public void DeletPatient(Patient patient)
        {
            patients.Remove(patient);
        }
    }
}