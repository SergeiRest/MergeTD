using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Infrastucture.Service
{
    public class Container : IContainer
    {
        public void Register<TService>(TService implementation) where TService : IService
        {
            Implementation<TService>.ServiceInstance = implementation;
        }

        public TService GetService<TService>() where TService : IService
        {
            return Implementation<TService>.ServiceInstance;
        }

        private static class Implementation<TService> where TService : IService
        {
            public static TService ServiceInstance;
        }
    }
}