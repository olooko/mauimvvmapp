using MauiMvvmApp.Resources.Styles;

namespace MauiMvvmApp.Services
{
    interface IApplicationService
    {
        void ChangeTheme(string theme);
    }

    public class ApplicationService : IApplicationService
    {
        public void ChangeTheme(string theme)
        {
            var dictionaries = Application.Current!.Resources.MergedDictionaries;

            dictionaries.Clear();

            switch (theme)
            {
                case "Light": dictionaries.Add(new ColorsLight()); break;
                case "Dark": dictionaries.Add(new ColorsDark()); break;
                case "TeamsDark": dictionaries.Add(new ColorsTeamsDark()); break;
                case "TeamsHighContrast": dictionaries.Add(new ColorsTeamsHighContrast()); break;
                case "TeamsLight": dictionaries.Add(new ColorsTeamsLight()); break;
            }

            dictionaries.Add(new Brushes());
            dictionaries.Add(new Styles());
        }
    }
}
