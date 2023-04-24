using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Infrastucture.Service
{
    public interface IContainer
    {
        void Register<TService>(TService implementation) where TService : IService;
        TService GetService<TService>() where TService : IService;
    }
}

public interface IService
{
    
}