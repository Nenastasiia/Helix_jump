using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum SegmentType
{
    Default,
    Trap,
    Empty,
    Finish
}
[RequireComponent(typeof(MeshRenderer))]
public class Segment : MonoBehaviour
{
    [SerializeField] private Material trapMaterial;
    [SerializeField] private Material finishMaterial;

    [SerializeField] private SegmentType type;
    public SegmentType Type => type;

    private MeshRenderer meshRenderer;
    private Animator animator;

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();

        animator = GetComponent<Animator>();
        animator.speed = 0;
    }

    public void SetTrap()
    {
        meshRenderer.enabled = true;
        meshRenderer.material = trapMaterial;

        type = SegmentType.Trap;
    }

    public void SetEmpty()
    {
        meshRenderer.enabled = false;

        type = SegmentType.Empty;
    }

    public void SetFinish()
    {
        meshRenderer.enabled = true;
        meshRenderer.material = finishMaterial;

        type = SegmentType.Finish;
    }

    public void MoveSegment()
    {
        animator.speed = 1;
    }
}
