using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenier : MonoBehaviour
{
    public int nb_graines;
    public int id;
    public int player_id;
    [SerializeField] private Board board;
    // Start is called before the first frame update
    void Start()
    {
        nb_graines = 4;   
    }

    public void OnPlay()
    {
        Debug.Log("ok");
        board.Play(id);
    }
}
