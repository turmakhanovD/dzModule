using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PracticeModule9
{
    public class Flash : Storage
    {
        private double SpeedUsb30 { get; set; }
        private double StorageValue { get; set; }
        private double FreeSpace { get; set; }

        public Flash()
        {
            SpeedUsb30 = 60;      //MBps
            StorageValue = 4000;   //MB
            FreeSpace = StorageValue;
            Name = "Flash Drive";
            Model = String.Format(" {0} GB USB3.0", StorageValue / 1000);
        }

     

   
        public override void CopyDataToDevice(File files, out int timeSpend)
        {                 

            timeSpend = (int)(files.Size / SpeedUsb30);
            FreeSpace = StorageValue - files.Size;
           
        }

        public override string GetDeviceInfo()
        {
            return String.Format("{0}{1}\nSpeed - {2}\nStorage Value - {3}\nFree Space - {4}\n", Name, Model, SpeedUsb30, StorageValue, FreeSpace);
        }

        public override double GetFreeSpaceValue()
        {
            return FreeSpace;
        }

        public override double GetStorageValue()
        {
            return StorageValue;
        }

        public override int GetDevicesNum(File file)
        {
            return (int)(file.Size / StorageValue);
        }

    }
}