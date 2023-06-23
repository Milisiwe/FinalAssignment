using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMemory : MonoBehaviour
{
    string[] CardRoutes = new string[] {"Boston to Miami", "Calgary to Phenix", "Calgary to Salt Lake City", "Chicago to New Orleans",
                                        "Chicago to Santa Fe", "Dallas to New York", "Denvar to El Paso", "Denver to Pittsburg",
                                        "Duluth to El Paso", "Duluth to Houston", "Helena to Los Angelos", "Kansas City to Houston",
                                        "Los Angelos to Chicago", "Los Angelos to Miami", "Los Angelos to New York", "Montreal to Atlanta",
                                        "Montreal to New Orleans", "New York to Atlanta", "Portland to Nashville", "Portland to Phoenix",
                                        "San Francisco to Atlanta", "Sault St. Marie to Nashville", "Sault St. Marie to Oklahoma City",
                                        "Seattle to Los Angelos", "Seattle to New York", "Toronto to Miami", "Vancouver to Montreal",
                                        "Vancouver to Santa Fe",  "Winnipeg to Houston", "Winnipeg to Little Rock"};

    string[] TrainCarCards = new string[] { "Red", "Blue", "Green", "Yellow", "Black" };
    
    int[] Points = new int[] {12, 13, 7, 7, 9, 11, 4, 11, 10, 8, 8, 5, 16, 20, 21, 9, 13, 6, 17, 11, 17, 8, 9, 9, 22, 10, 20, 13, 12, 11};

    static public GameMemory instance;
    //Cards variables need to be somewhere around here...



    // Start is called before the first frame update
    void Start()
    {
        instance = this;

        //Give 45 train cars to each player, I don't know if this is how players choose their train car colours?
        int PlayerRed = 45;
        int PlayerBlue = 45;
        int PlayerBlack = 45;
        int PlayerGreen = 45;
        int PlayerYellow = 45;

        //get cards on the game board
        //TrainCarCards = transform.GetComponentInChildren<Card>();
        //int k = 0;
        //Shuffle(TrainCarCards);
        //for (int i = 0; i < TrainCarCards.Length/4
        //{
        //    int iCardRoute = GetRandom(CardRoutes[GetI])
        //    string sCard = GetRandomFromArray()
        //}


        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
