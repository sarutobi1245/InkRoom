using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using INK_API.Helpers;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using INK_API._Repositories.Interface;
using INK_API._Services.Interface;
using INK_API.DTO;
using INK_API.Models;
using Microsoft.EntityFrameworkCore;

namespace INK_API._Services.Services
{
    public class UserDetailService : IUserDetailService
    {
        private readonly IUserDetailRepository _repoUserDetail;
        private readonly IMapper _mapper;
        private readonly MapperConfiguration _configMapper;
        public UserDetailService(IUserDetailRepository repoBrand, IMapper mapper, MapperConfiguration configMapper)
        {
            _configMapper = configMapper;
            _mapper = mapper;
            _repoUserDetail = repoBrand;

        }

        //Thêm Brand mới vào bảng UserDetail
        public async Task<bool> Add(UserDetailDto model)
        {
            var UserDetail = _mapper.Map<UserDetail>(model);
            _repoUserDetail.Add(UserDetail);
            return await _repoUserDetail.SaveAll();
        }

        //Lấy danh sách Brand và phân trang
        public async Task<PagedList<UserDetailDto>> GetWithPaginations(PaginationParams param)
        {
            var lists = _repoUserDetail.FindAll().ProjectTo<UserDetailDto>(_configMapper).OrderByDescending(x => x.ID);
            return await PagedList<UserDetailDto>.CreateAsync(lists, param.PageNumber, param.PageSize);
        }
       
        public async Task<bool> Delete(object id)
        {
            var UserDetail = _repoUserDetail.FindById(id);
            _repoUserDetail.Remove(UserDetail);
            return await _repoUserDetail.SaveAll();
        }

        //Cập nhật Brand
        public async Task<bool> Update(UserDetailDto model)
        {
            var UserDetail = _mapper.Map<UserDetail>(model);
            _repoUserDetail.Update(UserDetail);
            return await _repoUserDetail.SaveAll();
        }
      
        //Lấy toàn bộ danh sách Brand 
        public async Task<List<UserDetailDto>> GetAllAsync()
        {
            return await _repoUserDetail.FindAll().ProjectTo<UserDetailDto>(_configMapper).OrderByDescending(x => x.ID).ToListAsync();
        }

        //Lấy Brand theo Brand_Id
        public UserDetailDto GetById(object id)
        {
            return  _mapper.Map<UserDetail, UserDetailDto>(_repoUserDetail.FindById(id));
        }

        public Task<PagedList<UserDetailDto>> Search(PaginationParams param, object text)
        {
            throw new NotImplementedException();
        }

        public Task<bool> MapUserDetailDto(UserDetailDto mapModel)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int userId, int lineID)
        {
            throw new NotImplementedException();
        }
    }
}