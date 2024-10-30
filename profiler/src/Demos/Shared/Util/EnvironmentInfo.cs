// <copyright file="EnvironmentInfo.cs" company="Datadog">
// Unless explicitly stated otherwise all files in this repository are licensed under the Apache 2 License.
// This product includes software developed at Datadog (https://www.datadoghq.com/). Copyright 2022 Datadog, Inc.
// </copyright>

using System;
using System.Diagnostics;
using System.IO;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Text;

namespace Datadog.Demos.Util
{
    public static class EnvironmentInfo
    {
        private static string _environmentDescription = null;

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static string GetCurrentProcessFileName()
        {
            try
            {
                return Path.GetFileName(Process.GetCurrentProcess().MainModule.FileName);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{Environment.NewLine}{ex}");
                return "<Unknown Process>";
            }
        }

        public static void PrintDescriptionToConsole()
        {
            Console.WriteLine($"{Environment.NewLine}{GetDescription()}");
        }

        public static string GetDescription()
        {
            string environmentDescription = _environmentDescription;
            if (environmentDescription == null)
            {
                environmentDescription = ConstructDescriptionString();
                _environmentDescription = environmentDescription;
            }

            return environmentDescription;
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        private static string ConstructDescriptionString()
        {
            var str = new StringBuilder();

            string processName = "-Unknown-";
            string machineName = "-Unknown-";
            int processId = -1;

            try
            {
                using (var currentProcess = Process.GetCurrentProcess())
                {
                    processName = currentProcess.ProcessName;
                    machineName = currentProcess.MachineName;
                    processId = currentProcess.Id;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{Environment.NewLine}{ex}");
            }

            str.AppendLine("Environment info");
            str.AppendLine("{ ");
            str.AppendLine($"    Process Id:              {processId}");
            str.AppendLine($"    Process Name:            {processName}");
            str.AppendLine($"    Machine Name:            {machineName}");
            str.AppendLine($"    Current Working Dir:     {Environment.CurrentDirectory}");
            str.AppendLine($"    Is64BitProcess:          {Environment.Is64BitProcess}");
            str.AppendLine($"    Runtime version:         {Environment.Version}");
            str.AppendLine($"    OS version:              {Environment.OSVersion}");
            str.AppendLine($"    Common App Data folder:  {Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData)}");
            str.AppendLine($"    GC Mode:                 {(GCSettings.IsServerGC ? "Server" : "Workstation")} ({GCSettings.LatencyMode})");
            str.AppendLine();

            str.AppendLine("    Variables:");
            str.AppendLine();
            str.AppendLine("        CORECLR_ENABLE_PROFILING:                     " + (Environment.GetEnvironmentVariable("CORECLR_ENABLE_PROFILING") ?? "null"));
            str.AppendLine("        CORECLR_PROFILER:                             " + (Environment.GetEnvironmentVariable("CORECLR_PROFILER") ?? "null"));
            str.AppendLine("        CORECLR_PROFILER_PATH_64:                     " + (Environment.GetEnvironmentVariable("CORECLR_PROFILER_PATH_64") ?? "null"));
            str.AppendLine("        CORECLR_PROFILER_PATH_32:                     " + (Environment.GetEnvironmentVariable("CORECLR_PROFILER_PATH_32") ?? "null"));
            str.AppendLine("        CORECLR_PROFILER_PATH:                        " + (Environment.GetEnvironmentVariable("CORECLR_PROFILER_PATH") ?? "null"));
            str.AppendLine();
            str.AppendLine("        COR_ENABLE_PROFILING:                         " + (Environment.GetEnvironmentVariable("COR_ENABLE_PROFILING") ?? "null"));
            str.AppendLine("        COR_PROFILER:                                 " + (Environment.GetEnvironmentVariable("COR_PROFILER") ?? "null"));
            str.AppendLine("        COR_PROFILER_PATH_64:                         " + (Environment.GetEnvironmentVariable("COR_PROFILER_PATH_64") ?? "null"));
            str.AppendLine("        COR_PROFILER_PATH_32:                         " + (Environment.GetEnvironmentVariable("COR_PROFILER_PATH_32") ?? "null"));
            str.AppendLine("        COR_PROFILER_PATH:                            " + (Environment.GetEnvironmentVariable("COR_PROFILER_PATH") ?? "null"));
            str.AppendLine();
            str.AppendLine("        DD_PROFILING_ENABLED:                         " + (Environment.GetEnvironmentVariable("DD_PROFILING_ENABLED") ?? "null"));
            str.AppendLine("        DD_PROFILING_CPU_ENABLED:                     " + (Environment.GetEnvironmentVariable("DD_PROFILING_CPU_ENABLED") ?? "null"));
            str.AppendLine("        DD_PROFILING_WALLTIME_ENABLED:                " + (Environment.GetEnvironmentVariable("DD_PROFILING_WALLTIME_ENABLED") ?? "null"));
            str.AppendLine("        DD_PROFILING_EXCEPTION_ENABLED:               " + (Environment.GetEnvironmentVariable("DD_PROFILING_EXCEPTION_ENABLED") ?? "null"));
            str.AppendLine("        DD_PROFILING_ALLOCATION_ENABLED:              " + (Environment.GetEnvironmentVariable("DD_PROFILING_ALLOCATION_ENABLED") ?? "null"));
            str.AppendLine("        DD_PROFILING_LOCK_ENABLED:                    " + (Environment.GetEnvironmentVariable("DD_PROFILING_LOCK_ENABLED") ?? "null"));
            str.AppendLine("        DD_PROFILING_CONTENTION_ENABLED:              " + (Environment.GetEnvironmentVariable("DD_PROFILING_CONTENTION_ENABLED") ?? "null"));
            str.AppendLine("        DD_PROFILING_GC_ENABLED:                      " + (Environment.GetEnvironmentVariable("DD_PROFILING_GC_ENABLED") ?? "null"));
            str.AppendLine("        DD_PROFILING_HEAP_ENABLED:                    " + (Environment.GetEnvironmentVariable("DD_PROFILING_HEAP_ENABLED") ?? "null"));
            str.AppendLine();
            str.AppendLine("        DD_LOADER_REWRITE_MODULE_INITIALIZER_ENABLED: " + (Environment.GetEnvironmentVariable("DD_LOADER_REWRITE_MODULE_INITIALIZER_ENABLED") ?? "null"));
            str.AppendLine("        DD_LOADER_REWRITE_MODULE_ENTRYPOINT_ENABLED:  " + (Environment.GetEnvironmentVariable("DD_LOADER_REWRITE_MODULE_ENTRYPOINT_ENABLED") ?? "null"));
            str.AppendLine("        DD_LOADER_REWRITE_MSCORLIB_ENABLED:           " + (Environment.GetEnvironmentVariable("DD_LOADER_REWRITE_MSCORLIB_ENABLED") ?? "null"));
            str.AppendLine();
            str.AppendLine("        COMPlus_EnableDiagnostics:                    " + (Environment.GetEnvironmentVariable("COMPlus_EnableDiagnostics") ?? "null"));
            str.AppendLine("        LD_PRELOAD:                                   " + (Environment.GetEnvironmentVariable("LD_PRELOAD") ?? "null"));
            str.AppendLine();

            str.AppendLine("    RuntimeEnvironmentInfo:");
            str.AppendLine("        " + RuntimeEnvironmentInfo.Instance);

            str.AppendLine();
#if NETCOREAPP2_2_OR_GREATER
            str.AppendLine("    AppDomain.CurrentDomain.SetupInformation.TargetFrameworkName:");
            str.AppendLine("        \"" + (AppDomain.CurrentDomain?.SetupInformation?.TargetFrameworkName ?? "<NULL>") + "\"");
#endif
            str.AppendLine("} ");
            str.AppendLine();

            return str.ToString();
        }
    }
}
