using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace FanSoft.DllRep.Api.Core.Data
{
    public static class DbInitializer
    {

        public static void Initialize(this DLLRepositoryContext context)
        {
            context.Database.Migrate();

            if (context.Arquivos.Any())
                return;

            //Add files teste

        }

    }
}
