﻿using BusinessLogic.Abstractions;
using BusinessLogic.Contexts;
using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Implementations
{
    public class SubjectService : ISubjectService
    {
        private readonly IDatabaseContext _db;

        public SubjectService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> Delete(int subjectId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(subjectId), subjectId.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteSubject", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetSubjects");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetById(int subjectId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(subjectId), subjectId.ToString());

            var dalResponse = await _db.ExecuteQuery("GetSubjectById", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetByClassId(int classId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(classId), classId.ToString());

            var dalResponse = await _db.ExecuteQuery("GetByClassId", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetByEmpId(int employeeId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(employeeId), employeeId.ToString());

            var dalResponse = await _db.ExecuteQuery("GetByEmpId", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetByDepId(int depId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(depId), depId.ToString());

            var dalResponse = await _db.ExecuteQuery("GetByDepId", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Save(SubjectViewModel subject)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveSubject",
               _db.CreateListOfSqlParams(subject, new List<string>() { "SubjectId" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Update(SubjectViewModel subject)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdateSubject",
               _db.CreateListOfSqlParams(subject, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
    }
}
