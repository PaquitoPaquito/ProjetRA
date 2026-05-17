using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class DisableButton : MonoBehaviour
{
    [SerializeField] private GameObject actionManager;
    
    public void OnDisable(){
        actionManager.setActive(false);
    }
}
