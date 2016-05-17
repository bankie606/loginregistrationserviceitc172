using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IShowTrackerService" in both code and config file together.
[ServiceContract]
public interface IShowTrackerService
{

    [OperationContract]
    bool RegisterVenue(Venue v, VenueLogin vl);

    [OperationContract]

    int VenueLogin(string userName, string password);
}

    [DataContract]
    public class VenueLite
    {
        //if you don't add DataMember it won't throw an error but it won't allow you to see the field
        [DataMember]
        public string VenueName { set; get; }

        [DataMember]
        public string VenueAddress { set; get; }

        [DataMember]
        public string VenueCity { set; get; }

        [DataMember]
        public DateTime VenueDateAdded { set; get; }
    }




