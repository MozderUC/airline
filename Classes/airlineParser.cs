using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using airline.Classes.Aircrafts.CargoAircrafts;
using airline.Classes.Aircrafts.PassengerAircrafts;

namespace airline.Classes
{
    class airlineParser
    {
        
            private const String TEXT_FILE_NAME = "airlineData.txt";

            public List<AircraftObj> parse()
            {
                String readingText;
                An_2 an_2 = new An_2();
                Boeing_747 boeing_747 = new Boeing_747();
                Il_86 il_86 = new Il_86();
                An_124_100 an_124_100 = new An_124_100();
                Boeing_727_100C boeing_727_100C = new Boeing_727_100C();

                List<AircraftObj> aircrafts = new List<AircraftObj>();

                try
                {
                    using (StreamReader sr = new StreamReader(TEXT_FILE_NAME))
                    {
                        while (!sr.EndOfStream)
                        {
                            readingText = sr.ReadLine();
                            switch (readingText)
                            {
                                case "An-2":
                                    an_2 = readAn2(sr);
                                    aircrafts.Add(new An_2(an_2.ManufactureYear, an_2.ID1, an_2.AircraftWeight, an_2.FuelReserve, an_2.AverarageRage, an_2.HumanCapacity, an_2.CargoCapacity, an_2.ModelName, an_2.FuelConsumption));
                                    break;

                                case "Boeing-747":
                                    boeing_747 = readBoeing_747(sr);
                                    aircrafts.Add(new Boeing_747(boeing_747.ManufactureYear, boeing_747.ID1, boeing_747.AircraftWeight, boeing_747.FuelReserve, boeing_747.AverarageRage, boeing_747.HumanCapacity, boeing_747.CargoCapacity, boeing_747.ModelName, boeing_747.FuelConsumption));
                                    break;                     
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("The file could not be read: " + e.ToString());
                }           
                return aircrafts;
            }

            private An_2 readAn2(StreamReader sr)
            {
                
                An_2 an_2 = new An_2();
                for (;;)
                {
                    String buffer = sr.ReadLine();
                    if (buffer.IndexOf(":") > 0)
                    {
                        string[] mbuff = buffer.Split(':');
                        switch (mbuff[0])
                        {
                            case "modelName": an_2.ModelName = mbuff[1]; break;
                            case "manufactureYear": an_2.ManufactureYear = Convert.ToInt32(mbuff[1]); break;
                            case "ID": an_2.ID1 = mbuff[1]; break;
                            case "aircraftWeight": an_2.AircraftWeight = Convert.ToInt32(mbuff[1]); break;
                            case "fuelReserve": an_2.FuelReserve = Convert.ToInt32(mbuff[1]); break;
                            case "fuelConsumption": an_2.FuelConsumption = Convert.ToInt32(mbuff[1]); break;
                            case "averarageRage": an_2.AverarageRage = Convert.ToInt32(mbuff[1]); break;
                            case "humanCapacity": an_2.HumanCapacity = Convert.ToInt32(mbuff[1]); break;
                            case "cargoCapacity": an_2.CargoCapacity = Convert.ToInt32(mbuff[1]); break;
                        }
                    }
                    else
                    {
                        return an_2;
                    }
                }
            }
            private Boeing_747 readBoeing_747(StreamReader sr)
            {

                Boeing_747 boeing_747 = new Boeing_747();
                for (;;)
                {
                    String buffer = sr.ReadLine();
                    if (buffer.IndexOf(":") > 0)
                    {
                        string[] mbuff = buffer.Split(':');
                        switch (mbuff[0])
                        {
                            case "modelName": boeing_747.ModelName = mbuff[1]; break;
                            case "manufactureYear": boeing_747.ManufactureYear = Convert.ToInt32(mbuff[1]); break;
                            case "ID": boeing_747.ID1 = mbuff[1]; break;
                            case "aircraftWeight": boeing_747.AircraftWeight = Convert.ToInt32(mbuff[1]); break;
                            case "fuelReserve": boeing_747.FuelReserve = Convert.ToInt32(mbuff[1]); break;
                            case "fuelConsumption": boeing_747.FuelConsumption = Convert.ToInt32(mbuff[1]); break;
                            case "averarageRage": boeing_747.AverarageRage = Convert.ToInt32(mbuff[1]); break;
                            case "humanCapacity": boeing_747.HumanCapacity = Convert.ToInt32(mbuff[1]); break;
                            case "cargoCapacity": boeing_747.CargoCapacity = Convert.ToInt32(mbuff[1]); break;
                    }
                    }
                    else
                    {
                        return boeing_747;
                    }
                }
            }
        }
}

