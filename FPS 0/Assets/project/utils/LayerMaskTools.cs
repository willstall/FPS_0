using UnityEngine;

[AddComponentMenu("SimpleScripts/Utils/LayerMaskTools")]
public class LayerMaskTools : MonoBehaviour
{
    public static bool IsInLayerMask(GameObject obj, LayerMask mask)
    {
       return ((mask.value & (1 << obj.layer)) > 0);
    }
}
