﻿using System.Collections.Generic;
using System.Threading;

namespace owl
{
    public static class Globals
    {
        public static Class.Config                        Config            = null; // Global VTConfig class
        public static Dictionary<string, Class.Account>   CurrentProfile    = null; // Global Dictionary of all the account instances <special id, account class>
        public static FormMain                            hFormMain         = null; // Handle to our main form for access and invoking
        public static Thread                              ParserQueue       = null; // Handle to the parser queue thread that manages all the running parser threads
        public static Thread                              hMainThread       = null; // Handle to the main Thread

        public static string                              passKey           = "";   // Store the passkey
        // I know that bad actors can simply take a peek at the memory and find the user's password but...
        // It's not really *THAT* unconventional since the whole encryption is for keeping the json profiles away from plain text and the whole hashing is just for verification that the password is indeed correct.
        
        public const  string                              Charset           = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"; // Predefined charset

        public static int RunningThreads
        {
            get
            {
                return RunningThreadsCount;
            }

            set
            {
                if (!(RunningThreads < 0))
                    RunningThreadsCount = RunningThreads;
            }
        }

        private static int RunningThreadsCount = 0; // Number of parser threads that are running

        // Global constant information
        public static class Info
        {
            public const int    vMajor       = 0,
                                vMinor       = 1,
                                vPatch       = 0;

            public const string verStr       = "0.1.0",
                                cfgPath      = "./config.json",
                                profilesPath = "./profiles";
        }

        // Cached values for some aspects of the program
        public static class Cache
        {
            public static bool   OnTop          = false, // Add account form is always on top of every other window
                                 
                                 AddAnother     = false, // Automatically re-open the add account menu (Ignored on edit mode)
                                 AddAnotherFlag = false; // Set to true when the user selected "Add" account, otherwise false. This is to prevent re-opening the UI if the user closed it

            public static string Notes          = "",    // Cached notes 
                                 TitleFallback  = "";    // Main form title fallback
        }
    }
}
