﻿using CopywritingWebSite.DataAccess.DbContexts;
using CopywritingWebSite.Domain.Entities;
using CopywritingWebSite.Service.Dtos.Acccount;
using CopywritingWebSite.Service.Helpers;
using CopywritingWebSite.Service.Interfaces;
using CopywritingWebSite.Service.Interfaces.Common;
using CopywritingWebSite.Service.Services.Common;
using CopywritingWebSite.Service.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace CopywritingWebSite.Service.Services
{
    public class AccountService : IAccountService
    {
        private readonly AppDbContext _appDbContext;
        private readonly IEmailService _emailService;
        private readonly IAuthManagaer _authManagaer;
        public AccountService(AppDbContext appDbContext, IEmailService emailService, IAuthManagaer authManagaer)
        {
            this._appDbContext = appDbContext;
            this._emailService = emailService;
            _authManagaer = authManagaer;
        }

        public async Task<string> LoginAsync(AccountLoginDto dto)
        {
            var user = await _appDbContext.Users.FirstOrDefaultAsync(x => x.Email == dto.Email);
            if (user is null)
            {
                return "";
            }

            var hashResault = PasswordHash.Verify(dto.Password, user.Salt, user.PasswordHash);
            if (hashResault)
            {
                GlobalVariableModel.Id = user.Id;
                GlobalVariableModel.UserRole = user.Role;
                return _authManagaer.GenerateToken(user); ;
            }
            return "";
        }

        public async Task<string> RegisterAsync(AccountRegisterDto dto)
        {
            var user = await _appDbContext.Users.FirstOrDefaultAsync(x => x.Email == dto.Email);
            if (user is not null)
            {
                return "Bu email mavjud";
            }
            int checkEmail = await SendEmail(dto.Email);
            GlobalVariableModel.EmailCheck = checkEmail;
            GlobalVariableModel.Email = dto.Email;
            var passwordHash = PasswordHash.Hash(dto.Password);
            var users = (User)dto;
            users.Salt = passwordHash.Salt;
            users.PasswordHash = passwordHash.Hash;
            users.CreateAt = TimeHelper.GetCurrentServerTime().ToString();
            _appDbContext.Users.Add(users);
            await _appDbContext.SaveChangesAsync();
            return "";
        }

        public async Task<int> SendEmail(string email)
        {
            var res = await _emailService.SendAsync(email);
            return res;
        }

        public async Task<bool> CheckEmail(string email)
        {
            var res = int.Parse(email) == GlobalVariableModel.EmailCheck;
            GlobalVariableModel.EmailCheck = 0;
            return res;
        }
    }
}
