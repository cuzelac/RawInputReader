using System;
using Newtonsoft.Json;
using HidSharp;


namespace RawInputReader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SCREW YOU BUDDY");
            var list = DeviceList.Local;
            var allDeviceList = list.GetAllDevices();

            Console.WriteLine(
                FormatJson(
                  JsonConvert.SerializeObject(allDeviceList)
                ));
        }

        // Console.WriteLine(FormatJson("{'a': 1, 'b': [2,3,4]}"));
        private static string FormatJson(string json)
        {
            return JsonConvert.SerializeObject(
                JsonConvert.DeserializeObject(json),
                Formatting.Indented);
        }
    }
}
