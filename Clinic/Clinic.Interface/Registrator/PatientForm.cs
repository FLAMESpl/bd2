﻿using Clinic.Data;
using Clinic.Facades.Patients;
using Clinic.Interface.Common;
using Clinic.Interface.Common.Helpers;
using System;
using System.Data.Linq;
using System.Linq;
using System.Windows.Forms;

namespace Clinic.Interface.Registrator
{
    public partial class PatientForm : Form
    {
        private ActionType actionType;
        private Patient patient;

        public PatientForm()
        {
            InitializeComponent();
            SetupComponent();
        }

        public PatientForm(Patient patient, ActionType actionType)
        {
            InitializeComponent();
            SetupComponent();

            this.actionType = actionType;
            this.patient = patient;
            labelledInputFirstName.Input = patient.Name;
            labelledInputLastName.Input = patient.Surname;
            labelledInputEvidenceNumber.Input = patient.PESEL;
            bindingSourceAddresses.AddRange(patient.Addresses);
        }

        private void SetupComponent()
        {
            doneCancelDialog.Cancel += Cancel;
            doneCancelDialog.Done += Done;
        }

        private void CreatePatient()
        {
            patient.Name = labelledInputFirstName.Input;
            patient.PESEL = labelledInputEvidenceNumber.Input;
            patient.Surname = labelledInputLastName.Input;
            patient.Addresses.AddRange(bindingSourceAddresses.List.Cast<Address>());

            PatientsService.Add(patient);
        }

        private void UpdatePatient()
        {
            patient.Name = labelledInputFirstName.Input;
            patient.PESEL = labelledInputEvidenceNumber.Input;
            patient.Surname = labelledInputLastName.Input;
            patient.Addresses.Clear();
            patient.Addresses.AddRange(bindingSourceAddresses.List.Cast<Address>());

            PatientsService.Update(patient);
        }

        private void Cancel(object sender, EventArgs e)
        {
            Close();
        }

        private void Done(object sender, EventArgs e)
        {
            switch (actionType)
            {
                case ActionType.Create:
                    CreatePatient();
                    break;
                case ActionType.Update:
                    UpdatePatient();
                    break;
                default:
                    break;
            }

            Close();
        }
    }
}