﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace HospitalProjectFrontEnd.Models.Interfaces
{
    public interface IPatientManager
    {
        Task<List<Patient>> GetAllPatients();
        Task<Patient> GetPatientById(int patientId);
        Task<List<Patient>> GetPatientsByName(string name);

        Task<HttpResponseMessage> AddPatient(Patient patient);
        Patient CreatePatient(string name, string birthday, int status);
        Task RemovePatientById(int patientId);
        Task UpdatePatientById(int patientId, Patient patient);

        Task AssignPatientResource(int patientId, int resourceId);
    }
}
