using MelonLoader;
using BTD_Mod_Helper;
using BananzaBTD6;

[assembly: MelonInfo(typeof(BananzaBTD6.Main), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace BananzaBTD6;

public class Main : BloonsTD6Mod
{
    public override void OnApplicationStart()
    {
        ModHelper.Msg<Main>("BananzaBTD6 loaded!");
    }
}