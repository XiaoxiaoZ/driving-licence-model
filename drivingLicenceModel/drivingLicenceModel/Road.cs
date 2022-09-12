using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace drivingLicenceModel
{
    public class Road : Visulization
    {
        public List<Carriageway> Carriageways
        {
            get => default;
            set
            {
            }
        }

        public List<Verge> Verges
        {
            get => default;
            set
            {
            }
        }

        public List<RoadMarking> RoadMarkings
        {
            get => default;
            set
            {
            }
        }

        public List<TrafficSign> TrafficSigns
        {
            get => default;
            set
            {
            }
        }

        public override void Draw()
        {
            throw new NotImplementedException();
        }
    }
}