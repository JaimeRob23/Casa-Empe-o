﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CasaEmpeño.Model
{
    public interface IUserRepository
    {
        bool AuthenticateUser(NetworkCredential credential);

        void Add(UserModel userModel);

        void Edit(UserModel userModel);

        void Delete(UserModel userModel);

        UserModel GetById(int id);

        UserModel GetByUsername(string username);
        void Delete(string id);
    }
}
