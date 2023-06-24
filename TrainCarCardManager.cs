using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class TrainCarCardManager : MonoBehaviour
{
    public string trainCarName;
    public int trainCarColor;

    public void TrainCarCard()
    {

    }


    public void TrainCarCard(string TrainCarName, string TrainCarColor)
    {
        trainCarName = TrainCarName;
        trainCarColor = TrainCarColor;
    }
}
