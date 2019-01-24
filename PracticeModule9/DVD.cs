using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeModule9
{
    class DVD : Storage
    {
        private int _Type { get; set; }
        private double StorageValue { get; set; }
        private double Speed { get; set; }
        private double FreeSpace { get; set; }

        public DVD()
        {
            _Type = 2;
            StorageValue = 9000;
            Speed = 70;
            FreeSpace = StorageValue;
            Name = "Двусторонний DVD ";
            Model = String.Format("{0} GB DVD", StorageValue / 1000);
            
        }
        //if(_Type == 1)
        // {
        //    StorageValue = 5;
           
        // }

        public override void CopyDataToDevice(File files, out int timeSpend)
        {


            timeSpend = (int)(files.Size / Speed);
            FreeSpace = StorageValue - files.Size;

        }

        public override string GetDeviceInfo()
        {
            return String.Format("{0}{1}\nSpeed - {2}\nStorage Value - {3}\nFree Space - {4}\n", Name, Model, Speed, StorageValue, FreeSpace);
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
