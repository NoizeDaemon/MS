using Avalonia.Media;
using Material.Colors;
using Material.Styles.Themes;
using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Material.Styles.Themes.Base;
using Avalonia;

namespace MS
{
    public static class Themes
    {
        public static Theme CustomLight = Theme.Create(Theme.Light, LookUp(PrimaryColor.Lime), LookUp(SecondaryColor.Indigo));
        public static Theme CustomDark = Theme.Create(Theme.Dark, LookUp(PrimaryColor.Cyan), LookUp(SecondaryColor.Purple));
        public static Theme PinkGoodness = Theme.Create(Theme.Light, Colors.DeepPink, Colors.HotPink);


        static Themes() // Brush Overrides
        {
            CustomLight.Paper = Colors.AliceBlue;

            PinkGoodness.Paper = Colors.LightPink;
            PinkGoodness.PrimaryDark = Colors.Pink;
        }

        private static Color LookUp(PrimaryColor primaryColor)
        {
            return SwatchHelper.Lookup[(MaterialColor)primaryColor];
        }

        private static Color LookUp(SecondaryColor primaryColor)
        {
            return SwatchHelper.Lookup[(MaterialColor)primaryColor];
        }

        public static void Change(Theme theme)
        {
            var themeBootstrap = Application.Current.LocateMaterialTheme<MaterialThemeBase>();
            themeBootstrap.CurrentTheme = theme;
        }
    }
}
