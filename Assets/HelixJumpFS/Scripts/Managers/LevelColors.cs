using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class LevelPallete
{
    public Color AxisColor;
    public Color BallColor;
    public Color DefaultColor;
    public Color TrapSegmentColor;
    public Color FinishSegmentColor;
}
public class LevelColors : MonoBehaviour
{
    [SerializeField] private LevelPallete[] pallete;

    [SerializeField] private Material axisMaterial;
    [SerializeField] private Material ballsMaterial;
    [SerializeField] private Material defaultMaterial;
    [SerializeField] private Material trapMaterial;
    [SerializeField] private Material finishMaterial;

    private void Start()
    {
        int index = Random.Range(0, pallete.Length);

        axisMaterial.color = pallete[index].AxisColor;
        ballsMaterial.color = pallete[index].BallColor;
        defaultMaterial.color = pallete[index].DefaultColor;
        trapMaterial.color = pallete[index].TrapSegmentColor;
        finishMaterial.color = pallete[index].FinishSegmentColor;
    }
}
