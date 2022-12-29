using RobertEcommerce.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace RobertEcommerce.Permissions;

public class RobertEcommercePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(RobertEcommercePermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(RobertEcommercePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<RobertEcommerceResource>(name);
    }
}
