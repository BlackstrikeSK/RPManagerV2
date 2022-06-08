using Exiled.API.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace RPManagerV2
{
    public class Config : IConfig
    {
        [Description("Is the plugin enabled?")]
        public bool IsEnabled { get; set; } = true;

        [Description("Do you want the decontamination to occur?")]
        public bool NoDeconEnabled { get; set; } = true;

        [Description("Do you want to show a message to a player that has been taken into the endless void?")]
        public bool EnteringPocketMessageEnabled { get; set; } = true;

        [Description("Do you want to show a message to a player that has escaped from the endless void?")]
        public bool EscapingPocketMessageEnabled { get; set; } = true;

        [Description("List of Class-D broadcasts giving RP insturctions.")]
        public List<String> ClassDBroadcast { get; set; } = new List<String>()
        {
            "You are a <color=orange>Class-D</color> and you know about <color=red>SCP-173</color>",
            "You are a <color=orange>Class-D</color> and you know about <color=red>SCP-049</color>",
            "You are a <color=orange>Class-D</color> and you know about <color=red>SCP-079</color>",
            "You are a <color=orange>Class-D</color> and you know about <color=red>SCP-096</color>",
            "You are a <color=orange>Class-D</color> and you know about <color=red>SCP-106</color>",
            "You are a <color=orange>Class-D</color> and you know about the <color=green>Chaos Insurgency</color>",
            "You are a <color=orange>Class-D</color> and you know about the <color=blue>Foundation</color>",
            "You are a <color=orange>Class-D</color> and you know about the <color=yellow>Gate A</color>",
            "You are a <color=orange>Class-D</color> and you know about the <color=yellow>Gate B</color>",
            "You are a <color=orange>Class-D</color> and you know about the <color=red>Warhead</color>",
            "You are a <color=orange>Class-D</color> and you know about the <color=orange>Zones</color>",
            "You are a <color=orange>Class-D</color> and you know about the <color=blue>Tesla Gates</color>",
            "You are a <color=orange>Class-D</color> and you are too curious.",
            "You are a <color=orange>Class-D</color> and you hate the Facility Guards"
        };

        [Description("List of Scientist broadcasts giving RP instructions.")]
        public List<String> SciBroadcast { get; set; } = new List<String>()
        {
            "You are a <color=yellow>Scientist</color> and you never visited the <color=red>SCP-173</color>",
            "You are a <color=yellow>Scientist</color> and you never visited the <color=red>SCP-049</color>",
            "You are a <color=yellow>Scientist</color> and you never visited the <color=red>SCP-079</color>",
            "You are a <color=yellow>Scientist</color> and you never visited the <color=red>SCP-096</color>",
            "You are a <color=yellow>Scientist</color> and you never visited the <color=red>SCP-106</color>",
            "You are a <color=yellow>Scientist</color> and you never visited the <color=red>HCZ</color>",
            "You are a <color=yellow>Scientist</color> and you are friends with the <color=orange>Class-D Personnel</color>",
            "You are a <color=yellow>Scientist</color> and you secretely cooperate with <color=red>SCP-079</color>"
        };

        [Description("List of Faility Guard broadcasts giving RP instructions.")]
        public List<String> FacilityGuardBroadcast { get; set; } = new List<String>
        {
            "You are a <color=grey>Facility Guard</color> and you never heard about <color=red>SCP-106</color>",
            "You are a <color=grey>Facility Guard</color> and you never heard about <color=red>SCP-096</color>",
            "You are a <color=grey>Facility Guard</color> and you never heard about <color=red>SCP-079</color>",
            "You are a <color=grey>Facility Guard</color> and you never heard about <color=red>SCP-049</color>",
            "You are a <color=grey>Facility Guard</color> and you never heard about <color=red>SCP-173</color>",
            "You are a <color=grey>Facility Guard</color> and you never heard about the <color=green>Chaos Insurgency</color>",
            "You are a <color=grey>Facility Guard</color> and you heard about the <color=red>Warhead</color>",
            "You are a <color=grey>Facility Guard</color> and you never listen to your team."
        };

        //Single BCs

        [Description("A message for SCP-049 when it spawns.")]
        public string SCP049     { get; set; } = "You are an <color=red>SCP-049</color>, cooperate with your fellows and make some new friends!";

        [Description("A message for SCP-096 when it spawns.")]
        public string SCP096 { get; set; } = "You are an <color=red>SCP-096</color>, cooperate with your fellows and don't cry ;)";

        [Description("A message for SCP-079 when it spawns.")]
        public string SCP079 { get; set; } = "You are an <color=red>SCP-049</color>, cooperate with your fellows and help them by using your table of skills.";

        [Description("A message for SCP-173 when it spawns.")]
        public string SCP173 { get; set; } = "You are an <color=red>SCP-049</color>, cooperate with your fellows and wait until your prey blink.";

        [Description("A message for SCP-106 when it spawns.")]
        public string SCP106 { get; set; } = "You are an <color=red>SCP-049</color>, cooperate with your fellows and show your friends your pocket home.";

        [Description("A message for a player when he gets teleported into the Pocket Dimension.")]
        public string Entering106PocketBroadcast { get; set; } = "You have been captured by <color=red>SCP-106</color>, escape the <color=grey>Pocket Dimension</color> or you will die.";

        [Description("A message for a player when he gets teleported away from the Pocket Dimension.")]
        public string Escaping106PocketBroadcast { get; set; } = "You have escaped the <color=grey>Pocket Dimension</color>, run for your life and get your wounds patched.";
    }
}