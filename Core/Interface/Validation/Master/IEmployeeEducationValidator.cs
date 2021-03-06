﻿using Core.DomainModel;
using Core.Interface.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Interface.Validation
{
    public interface IEmployeeEducationValidator
    {
        bool ValidCreateObject(EmployeeEducation employeeEducation, IEmployeeService _employeeService);
        bool ValidUpdateObject(EmployeeEducation employeeEducation, IEmployeeService _employeeService);
        bool ValidDeleteObject(EmployeeEducation employeeEducation);
        bool isValid(EmployeeEducation employeeEducation);
        string PrintError(EmployeeEducation employeeEducation);
    }
}