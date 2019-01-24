using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeModule9
{
    class Program
    {
        static void Main(string[] args)
        {
            Flash flash = new Flash();
            File file = new File();
            HDD hdd = new HDD();
            DVD dvd = new DVD();
            int timeSpend = 0;

            file.Size = 3500;
            Console.WriteLine(flash.GetDeviceInfo());
            flash.CopyDataToDevice(file, out timeSpend);
            Console.WriteLine("To copy {1} GB data from file to your flash took {0} secs\n",timeSpend, file.Size/1000 );
            Console.WriteLine( "Free size that you have got after copying: {0}GB",flash.GetFreeSpaceValue()/1000 );

            Console.WriteLine("____________________________________");

            timeSpend = 0;
            Console.WriteLine(hdd.GetDeviceInfo());
            hdd.CopyDataToDevice(file, out timeSpend);
            Console.WriteLine("To copy {1} GB data from file to your hdd took {0} secs\n", timeSpend, file.Size / 1000);
            Console.WriteLine("Free size that you have got after copying: {0}GB", hdd.GetFreeSpaceValue()/1000);

            Console.WriteLine("____________________________________");

            timeSpend = 0;
            Console.WriteLine(dvd.GetDeviceInfo());
            dvd.CopyDataToDevice(file, out timeSpend);
            Console.WriteLine("To copy {1} GB data from file to your dvd took {0} secs\n", timeSpend, file.Size / 1000);
            Console.WriteLine("Free size that you have got after copying: {0} GB", dvd.GetFreeSpaceValue()/1000);

            Console.ReadLine();


        }
    }
}
