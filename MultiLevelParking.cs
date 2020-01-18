using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
namespace PT_lab_1
{
    public class MultiLevelParking
    {
        List<Parking<ITransport>> parkingStages;
        private const int countPlaces = 20;
        private int pictureWidth;
        private int pictureHeight;
        public MultiLevelParking(int countStages, int pictureWidth, int pictureHeight)
        {
            parkingStages = new List<Parking<ITransport>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
            for (int i = 0; i < countStages; ++i)
            {
                parkingStages.Add(new Parking<ITransport>(countPlaces, pictureWidth,
               pictureHeight));
            }
        }
        public Parking<ITransport> this[int ind]
        {
            get
            {
                if (ind > -1 && ind < parkingStages.Count)
                {
                    return parkingStages[ind];
                }
                return null;
            }
        }
        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter sw = new StreamWriter(filename))
            {
                sw.WriteLine("CountLeveles:" + parkingStages.Count);
                foreach (var level in parkingStages)
                {
                    sw.WriteLine("Level");
                    for (int i = 0; i < countPlaces; i++)
                    {
                        var transport = level[i];
                        if (transport != null)
                        {
                            if (transport.GetType().Name == "Car")
                            {
                                sw.Write(i + ":Car:");
                            }
                            if (transport.GetType().Name == "autotrain")
                            {
                                sw.Write(i + ":autotrain:");
                            }
                            sw.WriteLine(transport);
                        }
                    }
                }
                
            }
            return true;
        }
        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
            }
            int level = -1;
            using (StreamReader fs = new StreamReader(filename))
            {
                string temp = fs.ReadLine();
                if (temp.Contains("CountLeveles:"))
                {
                    if (parkingStages != null)
                    {

                        parkingStages.Clear();
                    }
                    parkingStages = new List<Parking<ITransport>>();
                }
                else
                {
                    return false;
                }

                while (!fs.EndOfStream)
                {
                    temp = fs.ReadLine();
                    if (temp.Contains("Level"))
                    {
                        parkingStages.Add(new Parking<ITransport>(countPlaces, pictureWidth, pictureHeight));
                        level++;
                    }
                    else 
                    {
                        int index = Convert.ToInt32(temp.Split(':')[0]);
                        ITransport truck = null;
                        if (temp.Contains("autotrain"))
                        {
                            truck = new autotrain(temp.Split(':')[2]);
                        }
                        else
                        {
                            truck = new Car(temp.Split(':')[2]);
                        }
                        parkingStages[level][index] = truck;
                    }
                }
            }
            return true;
        }
    }
}
