using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets;
using UnityEngine.XR.Interaction.Toolkit.Transformers;

public class GameManager : MonoBehaviour 
{
    [SerializeField] private ARTransformer arTransformer;
    private bool _isPlaying = false;
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void ToggleGame()
    {
        _isPlaying = !_isPlaying;
        ObjectSpawner.Instance.canSpawnObjects = !_isPlaying;
        arTransformer.enabled = !_isPlaying;
    }
}
