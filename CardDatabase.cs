using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    public static List<TrainCarCard> trainCarList = new List<TrainCarCard>();
    public static List<DestinationCard> destinationTicketList = new List<DestinationCard>();

    void Awake()
    {
        trainCarList.Add(new TrainCarCard("Box Train Car", "Yellow"));
        trainCarList.Add(new TrainCarCard("Caboose Train Car", "Green"));
        trainCarList.Add(new TrainCarCard("Coal Train Car", "Red"));
        trainCarList.Add(new TrainCarCard("Freight Train Car", "Purple"));
        trainCarList.Add(new TrainCarCard("Hopper Train Car", "Black"));
        trainCarList.Add(new TrainCarCard("Tanker Train Car", "Orange"));
        trainCarList.Add(new TrainCarCard("Passenger Train Car", "Blue"));
        trainCarList.Add(new TrainCarCard("Reefer Train Car", "White"));
        trainCarList.Add(new TrainCarCard("Locomotive Train Car", "Multicolor"));

        destinationTicketList.Add(new DestinationCard("Boston to Miami", 12));
        destinationTicketList.Add(new DestinationCard("Calgary to Phoenix", 13));
        destinationTicketList.Add(new DestinationCard("Calgary to salt Lake City", 7));
        destinationTicketList.Add(new DestinationCard("Chicago to New Orleans", 7));
        destinationTicketList.Add(new DestinationCard("Chicago to Santa Fe", 9));
        destinationTicketList.Add(new DestinationCard("Dallas to New York", 11));
        destinationTicketList.Add(new DestinationCard("Denver to El Paso", 4));
        destinationTicketList.Add(new DestinationCard("Denver to Pittsburgh", 11));
        destinationTicketList.Add(new DestinationCard("Duluth to El Paso", 10));
        destinationTicketList.Add(new DestinationCard("Duluth to Houston", 8));
        destinationTicketList.Add(new DestinationCard("Helena to Los Angeles", 8));
        destinationTicketList.Add(new DestinationCard("Kansas City to Houston", 5));
        destinationTicketList.Add(new DestinationCard("Los Angeles to Chicago", 16));
        destinationTicketList.Add(new DestinationCard("Los Angeles to Miami", 20));
        destinationTicketList.Add(new DestinationCard("Los Angeles to New York", 21));
        destinationTicketList.Add(new DestinationCard("Montreal to Atlanta", 9));
        destinationTicketList.Add(new DestinationCard("Montreal to New Orleans", 13));
        destinationTicketList.Add(new DestinationCard("New York to Atlanta", 6));
        destinationTicketList.Add(new DestinationCard("Portland to Nashville", 17));
        destinationTicketList.Add(new DestinationCard("Portland to Phoenix", 11));
        destinationTicketList.Add(new DestinationCard("San Francisco to Atlanta", 17));
        destinationTicketList.Add(new DestinationCard("Sault St. Marie to Nashville", 8));
        destinationTicketList.Add(new DestinationCard("Sault St. Marie to Oklahoma City", 9));
        destinationTicketList.Add(new DestinationCard("Seattle to Los Angeles", 9));
        destinationTicketList.Add(new DestinationCard("Seattle to New York", 22));
        destinationTicketList.Add(new DestiniationCard("Toronto to Miami", 10));
        destinationTicketList.Add(new DestinationCard("Vancouver to Montreal", 20));
        destinationTicketList.Add(new DestinationCard("Vancouver to Santa Fe", 13));
        destinationTicketList.Add(new DestinationCard("Winnipeg to Houston", 12));
        destinationTicketList.Add(new DestinationCard("Winnipeg to Little Rock", 11));
    }
}
