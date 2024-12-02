using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BassDetector
{
    public class PathMgt
    {

        public static List<string> ListAllWaveFiles(Enums.Humidity humidity, Enums.WaveLength waveLength)
        {
            List<string> waveList = new List<string>();

            string fileId = string.Empty;
            string humidityId = string.Empty;
            string waveLengthId = string.Empty;
            string dirString = string.Format("{0}Resources", Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\")));

            switch (humidity)
            {
                case Enums.Humidity.Dry:
                    humidityId = "D";
                    break;
                case Enums.Humidity.Wet:
                    humidityId = "W";
                    break;
            }

            switch (waveLength)
            {
                case Enums.WaveLength.Short:
                    waveLengthId = "S";
                    break;
                case Enums.WaveLength.Med:
                    waveLengthId = "M";
                    break;
                case Enums.WaveLength.Long:
                    waveLengthId = "L";
                    break;
            }

            fileId = humidityId + waveLengthId;

            try
            {
                if (Directory.Exists(dirString))
                {
                    string[] files = Directory.GetFiles(dirString);

                    foreach (string file in files)
                    {
                        if (Path.GetFileName(file).StartsWith(fileId, StringComparison.OrdinalIgnoreCase))
                        {
                            waveList.Add(file);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Directory does not exist.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            return waveList;
        }

        public static string ReturnRandomWaveFile(Enums.Humidity humidity, Enums.WaveLength waveLength)
        {
            string randomWaveName = string.Empty;
            List<string> waveList = ListAllWaveFiles(humidity, waveLength);

            Random random = new Random();
            int randomIndex = random.Next(0, waveList.Count);
            randomWaveName = waveList[randomIndex];

            return randomWaveName;
        }

    }
}
