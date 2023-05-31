using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medium.Medium_1380_1400
{
    internal class Medium_1396
    {
        Dictionary<int, Checks> GuestCheckIns = new Dictionary<int, Checks>();
        List<Travel> Travels = new List<Travel>();
        public Medium_1396()
        {

        }

        public void CheckIn(int id, string stationName, int t)
        {
            if (!GuestCheckIns.ContainsKey(id))
                GuestCheckIns.Add(id, new Checks { stationName = stationName, time = t });
        }

        public void CheckOut(int id, string stationName, int t)
        {
            Checks check = GuestCheckIns.GetValueOrDefault(id);
            Travels.Add(new Travel {startStation = check.stationName, endStation = stationName, time = t - check.time });
            GuestCheckIns.Remove(id);
        }

        public double GetAverageTime(string startStation, string endStation)
        {
            double AverageTime = 0;
            int count = 0;
            foreach (var travel in Travels)
            {
                if (travel.startStation == startStation && travel.endStation == endStation) 
                {
                    AverageTime += travel.time;
                    count++;
                }
            }
            return AverageTime/count;
        }

        class Checks
        {
            public string stationName { get; set; }
            public int time { get; set; }
        }

        class Travel
        {
            public string startStation { get; set; }
            public string endStation { get; set; }
            public int time { get; set; } 
        }

        /* BEST SOLUTION
         public class UndergroundSystem {
            private class Data{
                public int t=0;
                public int cnt=0;
                public double Avg{get=>(double)t/cnt;}
                public Data(){}
            }
            private class StartPoint{
                public string st;
                public int t;
                public StartPoint(string name, int time){ (st,t)=(name,time); }
            }

            private Dictionary<string,Dictionary<string,Data>> data;
            private Dictionary<int,StartPoint> info;
    
            public UndergroundSystem() {
                data = new Dictionary<string,Dictionary<string,Data>>();
                info = new Dictionary<int,StartPoint>();
            }
    
            public void CheckIn(int id, string stationName, int t) {
                info[id]=new StartPoint(stationName, t);
            }
    
            public void CheckOut(int id, string stationName, int t) {
                var sp=info[id];
                if(!data.ContainsKey(sp.st)) data[sp.st]=new Dictionary<string,Data>();
                if(!data[sp.st].ContainsKey(stationName)) data[sp.st][stationName]=new Data();
                data[sp.st][stationName].t+=(t-sp.t);
                data[sp.st][stationName].cnt++;
                info.Remove(id);
            }
    
            public double GetAverageTime(string startStation, string endStation) {
                return data[startStation][endStation].Avg;
            }
        } 
        */
    }
}
