﻿using UnityEngine;
using System.Collections;

namespace NFSDK
{
    public class NFCSDKPlugin : NFIPlugin
    {
        public NFCSDKPlugin(NFIPluginManager pluginManager)
        {
            mPluginManager = pluginManager;
        }
        public override string GetPluginName()
        {
            return "NFCSDKPlugin";
        }

        public override void Install()
        {
            Debug.Log("NFCSDKPlugin Install");
            AddModule<NFIElementModule>(new NFCElementModule(mPluginManager));
            AddModule<NFIClassModule>(new NFCClassModule(mPluginManager));
            AddModule<NFIKernelModule>(new NFCKernelModule(mPluginManager));
            AddModule<NFIEventModule>(new NFCEventModule(mPluginManager));
        }
        public override void Uninstall()
        {
            Debug.Log("NFCSDKPlugin Uninstall");
            mPluginManager.RemoveModule("NFIElementModule");
            mPluginManager.RemoveModule("NFIClassModule");
            mPluginManager.RemoveModule("NFIKernelModule");
            mPluginManager.RemoveModule("NFIEventModule");
            mModules.Clear();
        }
    }
}
