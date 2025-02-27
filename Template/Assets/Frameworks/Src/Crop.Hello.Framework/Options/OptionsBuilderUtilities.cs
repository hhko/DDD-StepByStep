﻿using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Crop.Hello.Framework.Options;

internal static class OptionsBuilderUtilities
{
    public static OptionsBuilder<TOptions> ValidateFluentValidation<TOptions>(
        this OptionsBuilder<TOptions> optionsBuilder)
        where TOptions : class
    {
        optionsBuilder.Services.AddSingleton<IValidateOptions<TOptions>>(provider =>
            new FluentValidationOptions<TOptions>(
                optionsBuilder.Name,
                provider));

        return optionsBuilder;
    }
}
