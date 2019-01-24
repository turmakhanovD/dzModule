using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeModule9
{
    public class HDD : Storage
    {
        private double SpeedUsb20 { get; set; }
        private double SectionStorageValue { get; set; }
        private double FreeSpace { get; set; }
        private int Section { get; set; }

        public HDD()
        {
            SpeedUsb20 = 20;      //MBps
            SectionStorageValue = 20000;   //MB
            Section = 5;
            FreeSpace = SectionStorageValue;
            Name = "Removable HDD Drive";
            Model = String.Format(" {0} GB USB 2.0", (SectionStorageValue * Section) / 1000);
        }


        public override void CopyDataToDevice(File files, out int timeSpend)
        {
           

            timeSpend = (int)(files.Size / SpeedUsb20);
            FreeSpace = SectionStorageValue - files.Size;

        }

        public override string GetDeviceInfo()
        {
            return String.Format("{0}{1}\nSpeed - {2}\nStorage Value - {3}\nFree Space - {4}\n", Name, Model, SpeedUsb20, SectionStorageValue, FreeSpace);
        }

        public override double GetFreeSpaceValue()
        {
            return FreeSpace;
        }

        public override double GetStorageValue()
        {
            return SectionStorageValue;
        }

        public override int GetDevicesNum(File file)
        {
            return (int)(file.Size / SectionStorageValue);
        }


    }
}
