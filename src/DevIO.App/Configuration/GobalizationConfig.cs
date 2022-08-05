﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Localization;
using System.Collections.Generic;
using System.Globalization;

namespace DevIO.App.Configuration
{
    public static class GobalizationConfig
    {
        public static IApplicationBuilder UseGlobalizationConfig(this IApplicationBuilder app)
        {
            var defaltCulture = new CultureInfo("pt-BR");
            var localizationOptions = new RequestLocalizationOptions
            {
                DefaultRequestCulture = new RequestCulture(defaltCulture),
                SupportedCultures = new List<CultureInfo> { defaltCulture },
                SupportedUICultures = new List<CultureInfo> { defaltCulture }

            };
            app.UseRequestLocalization(localizationOptions);

            return app;
        }
    }
}
