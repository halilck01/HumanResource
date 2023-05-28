﻿using HumanResource.Application.Models.DTOs.CompanyDTO;
using HumanResource.Application.Models.DTOs.CompanyManagerDTO;
using HumanResource.Application.Models.VMs.CompanyManagerVMs;
using HumanResource.Application.Models.VMs.ExpenseVM;
using HumanResource.Application.Models.VMs.PersonelVM;
using Microsoft.AspNetCore.Identity;

namespace HumanResource.Application.Services.CompanyManagerService
{
    public interface ICompanyManagerService
    {
        Task<List<EmployeeVM>> GetEmployees(int companyId);
        Task<List<DepartmentVM>> GetDepartments();
        Task<List<TitleVM>> GetTitles();
        Task<CreateEmployeeVM> CreateEmployee(CreateEmployeeDTO model);
        Task<IdentityResult> UpdateEmployee(UpdateEmployeeDTO model);
        Task<List<CompanyManagerVM>> GetCompanyManagers();
        Task<bool> IsCompanyManager(string userName);
        Task<UpdateEmployeeDTO> GetByUserName(Guid id);
        Task Delete(Guid id);
        Task<List<PersonelLeaveRequestVM>> GetPersonelLeaveRequests(Guid id);
        Task<List<PersonelAdvanceRequestVM>> GetPersonelAdvanceRequests(Guid id);
        Task<List<PersonelExpenseRequestVM>> GetPersonelExpenseRequests(Guid id);
        Task<UpdateCompanyDTO> GetCompany(Guid id);
        Task <bool> UpdateCompany(UpdateCompanyDTO model);
        Task<List<ExpenseTypePieVM>> ExpensesDistributionByExpensesType();

	}
}
