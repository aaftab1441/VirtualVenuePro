﻿using VirtualVenuePro.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace VirtualVenuePro.Permissions;

public class VirtualVenueProPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(VirtualVenueProPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(VirtualVenueProPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<VirtualVenueProResource>(name);
    }
}
