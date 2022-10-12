using UnityEngine;
using UnityEngine.Rendering.Universal;

[RequireComponent(typeof(DecalProjector))]
public class DecalController : MonoBehaviour
{
    private DecalProjector project;

    public Vector3 DecalSize = Vector3.one;
    private void Awake()
    {
        project = GetComponent<DecalProjector>();
    }
    private void Update()
    {
        project.size = DecalSize;
    }
}
