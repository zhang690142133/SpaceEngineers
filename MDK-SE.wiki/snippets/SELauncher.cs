using System;
using System.Reflection;

// Code by courtesy of Equinox
namespace Equinox
{
    public class SELauncher
    {
        public static void Main(string[] args)
        {
            // Space Engineers
            Environment.SetEnvironmentVariable("SteamAppId", "244850");
            Type type = Type.GetType("SpaceEngineers.MyProgram, SpaceEngineers");
            type.GetMethod("Main", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Public).Invoke(null, new object[] { args });

            // Medieval Engineers
            //Environment.SetEnvironmentVariable("SteamAppId", "333950");
            //Type type = Type.GetType("Medieval.MyProgram, MedievalEngineers");
            //type.GetMethod("Main", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Public).Invoke(null, new object[] { args });
        }
    }
}
