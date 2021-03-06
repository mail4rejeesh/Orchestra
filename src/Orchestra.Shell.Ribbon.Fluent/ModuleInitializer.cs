﻿using Catel.IoC;
using Orchestra;
using Orchestra.Services;

/// <summary>
/// Used by the ModuleInit. All code inside the Initialize method is ran as soon as the assembly is loaded.
/// </summary>
public static partial class ModuleInitializer
{
    static partial void InitializeSpecific()
    {
        var serviceLocator = ServiceLocator.Default;

        var thirdPartyNoticesService = serviceLocator.ResolveType<IThirdPartyNoticesService>();
        thirdPartyNoticesService.AddWithTryCatch(() => new ResourceBasedThirdPartyNotice("ControlzEx", "https://github.com/ControlzEx/ControlzEx", "Orchestra.Shell.Ribbon.Fluent", "Orchestra.Orchestra.Shell.Ribbon.Fluent", "Resources.ThirdPartyNotices.controlzex.txt"));
        thirdPartyNoticesService.AddWithTryCatch(() => new ResourceBasedThirdPartyNotice("Fluent.Ribbon", "https://github.com/fluentribbon/Fluent.Ribbon", "Orchestra.Shell.Ribbon.Fluent", "Orchestra.Orchestra.Shell.Ribbon.Fluent", "Resources.ThirdPartyNotices.fluent.ribbon.txt"));
    }
}
