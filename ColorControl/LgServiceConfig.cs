﻿namespace ColorControl
{
    class LgServiceConfig
    {
        public bool PowerOnAfterStartup { get; set; }

        public bool PowerOnAfterResume { get; set; }

        public bool PowerOffOnShutdown { get; set; }

        public bool PowerOffOnStandby { get; set; }

        public int PowerOnDelayAfterResume { get; set; }

        public string PreferredMacAddress { get; set; }

        public string DeviceSearchKey { get; set; }

        public bool UseAlternateWol { get; set; }

        public LgServiceConfig()
        {
            PowerOnDelayAfterResume = 5000;
            DeviceSearchKey = "[LG]";
        }
    }
}
