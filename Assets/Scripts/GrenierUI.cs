using UnityEngine;
using TMPro;

public class GrenierUI : MonoBehaviour
{
    [SerializeField] private Grenier grenier;
    [SerializeField] private TMP_Text text;

    // Update is called once per frame
    void Update()
    {
        text.text = grenier.nb_graines.ToString();
    }
}
