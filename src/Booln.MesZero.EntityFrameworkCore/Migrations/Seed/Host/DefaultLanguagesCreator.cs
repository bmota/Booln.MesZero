using System.Collections.Generic;
using System.Linq;
using Abp.Localization;
using Booln.MesZero.EntityFrameworkCore;

namespace Booln.MesZero.Migrations.Seed.Host
{
    public class DefaultLanguagesCreator
    {
        public static List<ApplicationLanguage> InitialLanguages => GetInitialLanguages();

        private readonly AbpZeroTemplateDbContext _context;

        private static List<ApplicationLanguage> GetInitialLanguages()
        {
            return new List<ApplicationLanguage>
            {
                new ApplicationLanguage(null, "en", "English", "famfamfam-flags gb"),
                new ApplicationLanguage(null, "zh-CN", "简体中文", "famfamfam-flags cn")
                //new ApplicationLanguage(null, "ar", "العربية", "famfamfam-flags sa"),
                //new ApplicationLanguage(null, "de", "Deutsch", "famfamfam-flags de"),
                //new ApplicationLanguage(null, "it", "Italiano", "famfamfam-flags it"),
                //new ApplicationLanguage(null, "fr", "Français", "famfamfam-flags fr"),
                //new ApplicationLanguage(null, "pt-BR", "Português (Brasil)", "famfamfam-flags br"),
                //new ApplicationLanguage(null, "tr", "Türkçe", "famfamfam-flags tr"),
                //new ApplicationLanguage(null, "ru", "Pусский", "famfamfam-flags ru"),                
                //new ApplicationLanguage(null, "es-MX", "Español (México)", "famfamfam-flags mx"),
                //new ApplicationLanguage(null, "es", "Español (Spanish)", "famfamfam-flags es")
            };
        }

        public DefaultLanguagesCreator(AbpZeroTemplateDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateLanguages();
        }

        private void CreateLanguages()
        {
            foreach (var language in InitialLanguages)
            {
                AddLanguageIfNotExists(language);
            }
        }

        private void AddLanguageIfNotExists(ApplicationLanguage language)
        {
            if (_context.Languages.Any(l => l.TenantId == language.TenantId && l.Name == language.Name))
            {
                return;
            }

            _context.Languages.Add(language);

            _context.SaveChanges();
        }
    }
}