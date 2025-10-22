using ICities;

namespace MeaningfulAcademicWorks.Source
{
    public class ModInfo : IUserMod
    {
        public string Name => "Meaningful Academic Works";
        public string Description => "Adds small city-wide bonuses for academic works generated in the university. Bonus depends on academic work category. Requires the Campus DLC";
    }
}