﻿using BarkodluSatis.BLL.Contracts;
using BarkodluSatis.DLL.BarkodDBObjects;
using BarkodluSatis.DLL.Contracts;
using BarkodluSatis.DLL.EFCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkodluSatis.BLL
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<IBarkodService> _barkodService;
        private readonly Lazy<IHizliUrunService> _hizliUrunService;
        private readonly Lazy<IIslemService> _islemService;
        private readonly Lazy<IIslemOzetService> _islemOzetService;
        private readonly Lazy<IKullaniciService> _kullaniciService;
        private readonly Lazy<ISabitService> _sabitService;
        private readonly Lazy<ISatisService> _satisService;
        private readonly Lazy<IStokHareketService> _stokHareketService;
        private readonly Lazy<ITeraziService> _teraziService;
        private readonly Lazy<IUrunService> _urunService;
        private readonly Lazy<IUrunGrupService> _urunGrupService;
        private readonly Lazy<IAuthenticationService> _authService;
        public ServiceManager(IRepositoryManager repositoryManager,UserManager<User> userManager,IConfiguration configuration)
        {
            _barkodService = new Lazy<IBarkodService>(()=>new BarkodService(repositoryManager));
            _hizliUrunService = new Lazy<IHizliUrunService>(()=>new HizliUrunService(repositoryManager));
            _islemService = new Lazy<IIslemService>(()=>new IslemService(repositoryManager));
            _islemOzetService = new Lazy<IIslemOzetService>(() => new IslemOzetService(repositoryManager));
            _kullaniciService = new Lazy<IKullaniciService>(()=>new KullaniciService(repositoryManager));
            _sabitService=new Lazy<ISabitService>(()=>new SabitService(repositoryManager));
            _satisService=new Lazy<ISatisService>(()=>new SatisService(repositoryManager));
            _stokHareketService = new Lazy<IStokHareketService>(()=>new StokHareketService(repositoryManager));
            _teraziService=new Lazy<ITeraziService>(()=>new TeraziService(repositoryManager));
            _urunService=new Lazy<IUrunService>(()=>new UrunService(repositoryManager));
            _urunGrupService = new Lazy<IUrunGrupService>(()=>new UrunGrupService(repositoryManager));
            _authService=new Lazy<IAuthenticationService>(()=>new AuthenticationService(userManager,configuration));
        }

        public IBarkodService BarkodService => _barkodService.Value;

        public IHizliUrunService HizliUrunService =>_hizliUrunService.Value;

        public IIslemService IslemService => _islemService.Value;

        public IIslemOzetService IslemOzetService => _islemOzetService.Value;

        public IKullaniciService KullaniciService => _kullaniciService.Value;

        public ISabitService SabitService => _sabitService.Value;

        public ISatisService SatisService => _satisService.Value;

        public IStokHareketService StokHareketService => _stokHareketService.Value;

        public ITeraziService TeraziService => _teraziService.Value;

        public IUrunService UrunService => _urunService.Value;

        public IUrunGrupService UrunGrupService => _urunGrupService.Value;

        public IAuthenticationService AuthenticationService => _authService.Value;
    }
}
