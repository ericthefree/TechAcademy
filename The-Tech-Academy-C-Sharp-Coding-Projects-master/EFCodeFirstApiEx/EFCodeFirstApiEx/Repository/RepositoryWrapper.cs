﻿using System;
using System.Collections.Generic;
using System.Text;
using Contracts;
using Entities;

namespace Repository
{
    public class RepositoryWrapper: IRepositoryWrapper
    {
        private RepositoryContext _repoContext;
        private IOwnerRepository _owner;
        private IAccountRepository _account;

        public IOwnerRepository Owner
        {
            get
            {
                if(_owner == null)
                {
                    _owner = new OwnerRepository(_repoContext);
                }

                return _owner;
            }
        }

        public IAccountRepository Account
        {
            get
            {
                if(_account == null)
                {
                    _account = new AccountRepository(_repoContext);
                
                }

                return _account;
            }
        }

        IOwnerRepository IRepositoryWrapper.Owner { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        IAccountRepository IRepositoryWrapper.Account { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public RepositoryWrapper(RepositoryContext repositoryContext)
        {
            _repoContext = repositoryContext;
        }
    }
}
