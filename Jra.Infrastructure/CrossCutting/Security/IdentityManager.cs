using WebAppSoC.Infrastructure.Crosscutting.Security;

namespace Jra.Infrastructure.CrossCutting.Security
{
    public class IdentityManager : IIdentityManager
    {
        private ApplicationSignInManager _signInManager = null;
        private ApplicationUserManager _appUserManager = null;

        public IdentityManager(ApplicationSignInManager signInManager, ApplicationUserManager appUserManager)
        {
            _signInManager = signInManager;
            _appUserManager = appUserManager;
        }

        public void Teste()
        {
            
        }
    }
}