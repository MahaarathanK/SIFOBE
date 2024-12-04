﻿using SIFO.Model.Request;
using SIFO.Model.Response;

namespace SIFO.APIService.Hospital.Service.Contracts
{
    public interface IHospitalService
    {
        public Task<ApiResponse<PagedResponse<HospitalResponse>>> GetAllHospitalAsync(int pageNo, int pageSize, string filter, string sortColumn, string sortDirection);
        public Task<ApiResponse<HospitalResponse>> GetHospitalByIdAsync(long hospitalId);
        public Task<ApiResponse<string>> DeleteHospitalAsync(long hospitalId);
        public Task<ApiResponse<string>> CreateHospitalAsync(HospitalRequest request);
        public Task<ApiResponse<string>> UpdateHospitalAsync(HospitalRequest request, long id);
    }
}
