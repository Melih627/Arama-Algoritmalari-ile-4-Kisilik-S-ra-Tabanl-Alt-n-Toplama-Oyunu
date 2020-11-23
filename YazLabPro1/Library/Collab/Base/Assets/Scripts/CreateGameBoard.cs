using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateGameBoard : MonoBehaviour
{
    public GameObject cubePrefab1;
    public GameObject cubePrefab2;
    public GameObject[,] CubeMatris;
    public GameObject playerAprefab;
    public GameObject playerBprefab;
    public GameObject playerCprefab;
    public GameObject playerDprefab;
    public GameObject OyuncuA;
    public GameObject OyuncuB;
    public GameObject OyuncuC;
    public GameObject OyuncuD;

    public int Counter;
    public int KareSayisiZ=10;
    public int KareSayisiX = 10;


    // Start is called before the first frame update
    void Start()
    {
        KareSayisiZ = PlayerPrefs.GetInt("_N");
        KareSayisiX = PlayerPrefs.GetInt("_M");
        CubeMatris = new GameObject[KareSayisiX,KareSayisiZ];
        Counter = 0;
        createBoard();
        CreatePlayers();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(OyuncuA.GetComponent<PlayerA>().Gold);
        //Debug.Log(OyuncuB.GetComponent<PlayerB>().Gold);
        //Debug.Log(OyuncuC.GetComponent<PlayerC>().Gold);
        //Debug.Log(OyuncuD.GetComponent<PlayerD>().Gold);
        //Debug.Log(OyuncuA.GetComponent<PlayerA>().HedefBelirlemeMaliyeti);
        //Debug.Log(OyuncuB.GetComponent<PlayerB>().HedefBelirlemeMaliyeti);
        //Debug.Log(OyuncuC.GetComponent<PlayerC>().HedefBelirlemeMaliyeti);
        //Debug.Log(OyuncuD.GetComponent<PlayerD>().HedefBelirlemeMaliyeti);
        //Debug.Log(OyuncuA.GetComponent<PlayerA>().HamleMaliyeti);
        //Debug.Log(OyuncuB.GetComponent<PlayerB>().HamleMaliyeti);
        //Debug.Log(OyuncuC.GetComponent<PlayerC>().HamleMaliyeti);
        //Debug.Log(OyuncuD.GetComponent<PlayerD>().HamleMaliyeti);
    }
    void createBoard()
    {
        for (int i = 0; i < KareSayisiZ; i++)
        {

            for (int j = 0; j < KareSayisiX; j++)
            {
                if (Counter % 2 == 0)
                {
                    GameObject cubeObj = Instantiate(cubePrefab1, new Vector3(j, 0, i), Quaternion.identity);

                }
                else
                {
                    GameObject cubeObj = Instantiate(cubePrefab2, new Vector3(j, 0, i), Quaternion.identity);
                }
                Counter++;

            }
            if (KareSayisiX % 2 == 0)
            {
                Counter++;
            }
            


        }




    }
    void CreatePlayers()
    {

         OyuncuA =Instantiate(playerAprefab, new Vector3(0, 1, 0), Quaternion.identity)as GameObject;
         OyuncuB =Instantiate(playerBprefab, new Vector3(KareSayisiX-1, 1, 0), Quaternion.identity)as GameObject;
         OyuncuC = Instantiate(playerCprefab, new Vector3(KareSayisiX - 1, 1, KareSayisiZ - 1), Quaternion.identity)as GameObject;
         OyuncuD = Instantiate(playerDprefab, new Vector3(0, 1, KareSayisiZ - 1), Quaternion.identity)as GameObject;
     

    }

  
   
}
