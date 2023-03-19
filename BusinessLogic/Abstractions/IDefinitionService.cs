﻿using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface IDefinitionService
    {
        Task<ServiceResponse> Get();
        Task<ServiceResponse> GetById(int id);
        Task<ServiceResponse> GetBySCode(string scode);
        Task<ServiceResponse> Delete(int id);
        Task<ServiceResponse> Save(DefinitionViewModel definition);
        Task<ServiceResponse> Update(DefinitionViewModel definition);
        Task<ServiceResponse> GetSCodeArabic();
    }
}
