﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Symbiote.Core
{
    class WindowsPlatform : IPlatform
    {
        public WindowsPlatform() { }
        public Platform.PlatformType Type() { return Platform.PlatformType.Windows; }
        public string Version() { return Environment.OSVersion.VersionString; }
        public ISystemInfo Info()
        {
            return new WindowsSystemInfo();
        }
    }

    class WindowsSystemInfo: ISystemInfo
    {
        private double cpuTime;
        private double memoryUsage;
        private List<IDiskInfo> disks;

        public WindowsSystemInfo()
        {
            cpuTime = 0;
            memoryUsage = 0;
            disks = new List<IDiskInfo>();
            Refresh();
        }

        public double CPUTime()
        {
            return cpuTime;
        }

        public double MemoryUsage()
        {
            return memoryUsage;
        }

        public List<IDiskInfo> Disks()
        {
            return disks;
        }

        public void Refresh()
        {
            cpuTime = getCPUCounter();
            memoryUsage = getAvailableRAM();
            disks.Clear();
            
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                disks.Add(new WindowsDiskInfo(drive));
            }

        }

        public double getCPUCounter()
        {
            PerformanceCounter cpuCounter = new PerformanceCounter();
            cpuCounter.CategoryName = "Processor";
            cpuCounter.CounterName = "% Processor Time";
            cpuCounter.InstanceName = "_Total";

            cpuCounter.NextValue();
            System.Threading.Thread.Sleep(250);
            return cpuCounter.NextValue();
        }

        public double getAvailableRAM()
        {
            return new PerformanceCounter("Memory", "Available MBytes").NextValue();
        }
    }

    class WindowsDiskInfo : IDiskInfo
    {
        public string Name { get; private set; }
        public string Path { get; private set; }
        public string Type { get; private set; }
        public long Capacity { get; private set; }
        public long UsedSpace { get; private set; }
        public long FreeSpace { get; private set; }
        public double PercentFree { get; private set; }
        public double PercentUsed { get; private set; }

        public WindowsDiskInfo(DriveInfo drive)
        {
            try
            {
                this.Name = drive.Name;
                this.Path = drive.RootDirectory.ToString();
                this.Type = drive.DriveType.ToString();
                this.Capacity = drive.TotalSize;
                this.FreeSpace = drive.TotalFreeSpace;
                this.UsedSpace = Capacity - FreeSpace;
                this.PercentFree = FreeSpace / (double)Capacity;
                this.PercentUsed = UsedSpace / (double)Capacity;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
