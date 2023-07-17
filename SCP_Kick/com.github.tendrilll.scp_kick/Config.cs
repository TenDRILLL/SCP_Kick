﻿using System.ComponentModel;
using Exiled.API.Interfaces;

namespace SCP_Kick.com.github.tendrilll.scp_kick {
    public sealed class Config : IConfig {
        [Description("Is the Plugin enabled.")]
        public bool IsEnabled { get; set; } = true;

        [Description("Debug mode.")]
        public bool Debug { get; set; } = false;

        [Description("Permission required to join.")]
        public string Permission { get; set; } = "access.join";

        [Description("Can NorthWood staff bypass this perm?")]
        public bool NWBypass { get; set; } = true;

        [Description("Kick message.")]
        public string KickMessage { get; set; } = "You don't have the required permissions to join.";
    }
}