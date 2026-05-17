using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    [SerializeField] private Grenier[] greniers;
    private int currentPlayer = 0;
    private int[] scores = {0,0};
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i<12; i++)
        {
            greniers[i].id = i;
            if(i<7) greniers[i].player_id = 0;
            else greniers[i].player_id = 1;
        }
    }

    // Update is called once per frame
    public void Play(int grenierId)
    {
        int grenierFinal = 0;
        for (int i = 0; i<greniers[grenierId].nb_graines; i++){
            greniers[(grenierId+i)%12].nb_graines++;
            grenierFinal = (grenierId+i)%12;
        }
        Grenier currentGrenier = greniers[grenierFinal];
        while (0 < currentGrenier.nb_graines && currentGrenier.nb_graines < 3 && currentGrenier.player_id != currentPlayer){
            scores[currentPlayer] += currentGrenier.nb_graines;
            currentGrenier.nb_graines = 0;
            currentGrenier = greniers[(currentGrenier.id-1)%12];
        }
        currentPlayer = 1-currentPlayer;
        greniers[grenierId].nb_graines = 0;   
    }
}
