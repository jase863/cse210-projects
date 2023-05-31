using System;

class Program
{
    static void Main(string[] args)
    {
        Address lectureAddress = new Address("27 Duke of Gloucester Street", "Williamsburg", "Virginia");
        Lecture lecture = new Lecture("Lecture", "A brief history of colonial weapons", "Come to the magazine across from the courthouse to hear an interesting lecture about colonial weapons", "6/12/23", "5:30 PM", lectureAddress, "Stan Johnson", "240");

        lecture.DisplayStandardDetails();
        lecture.DisplayFullDetails();
        lecture.DisplayShortDescription();
        
        Address receptionAddress = new Address("54 Deer Creek Street", "Allen", "Texas");
        Reception reception = new Reception("Reception", "Scott & Avari's Wedding", "We happily invite you to join us in celebrating the marriage of Scott and Avari", "8/14/23", "7:30 PM", receptionAddress, "beuer.michael4667@gmail.com");
    
        reception.DisplayStandardDetails();
        reception.DisplayFullDetails();
        reception.DisplayShortDescription();

        Address OutdoorGatheringAddress = new Address("5050 Confidence Loop", "Eden", "Utah");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Outdoor Gathering", "Movie on the mountain", "Come join us for an outdoor movie at the Beautiful Powder Mountain resort. Food and snow cones will be available for purchase", "7/10/23", "7:30 PM", OutdoorGatheringAddress, "It will be 63 degrees with winds up to 15 mph");

        outdoorGathering.DisplayStandardDetails();
        outdoorGathering.DisplayFullDetails();
        outdoorGathering.DisplayShortDescription();
    }
}
