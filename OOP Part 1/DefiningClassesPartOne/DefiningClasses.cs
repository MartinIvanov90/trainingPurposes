using System;

namespace DefiningClassesPartOne
{
    class DefiningClasses
    {
        static void Main()
        {
            Console.WriteLine(GSM.IPhone4S);
            GSMTest gsmTest = new GSMTest(5);
            gsmTest.PrintDevicesInfo();
            gsmTest.PrintIphoneInfo();

            GSMCallHistoryTest testDevice = new GSMCallHistoryTest();
            testDevice.GSMTester();
        }
    }
}
