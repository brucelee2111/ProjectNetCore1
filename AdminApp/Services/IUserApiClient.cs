﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewModels.System.Users;

namespace AdminApp.Services
{
    public interface IUserApiClient
    {
        Task<string> Authenticate(LoginRequest request);
    }
}