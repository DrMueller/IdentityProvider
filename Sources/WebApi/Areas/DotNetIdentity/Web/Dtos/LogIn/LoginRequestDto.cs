﻿namespace Mmu.IdentityProvider.WebApi.Areas.DotNetIdentity.Web.Dtos.LogIn
{
    public class LogInRequestDto
    {
        public string Password { get; set; }
        public bool RememberLogin { get; set; }
        public string ReturnUrl { get; set; }
        public string UserName { get; set; }
    }
}