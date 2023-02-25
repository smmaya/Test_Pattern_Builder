using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace TestPatternBuilder.Data
{
    public static class EnumExtensions
    {
        // To get the Display name parameters from the Enum where spaces are needed
        public static string? GetDisplayName(this Enum enumValue)
        {
            return enumValue.GetType()?
                .GetMember(enumValue.ToString())?
                .First()?
                .GetCustomAttribute<DisplayAttribute>()?
                .GetName();
        }

    }
}

