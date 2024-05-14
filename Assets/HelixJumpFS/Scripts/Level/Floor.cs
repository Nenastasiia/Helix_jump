using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{
    [SerializeField] private List<Segment> defaultSegments;

    public void AddEmptySegment(int amount)
    {
        for(int i = 0; i< amount; i++)
        {
            defaultSegments[i].SetEmpty();
        }

        //Обратный цикл, так как при удалении массив сдвигается влево
        for(int i = amount; i > 0; i--)
        {
            defaultSegments.RemoveAt(i);
        }
    }

    public void AddRandomTrapSegment(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            int index = Random.Range(0, defaultSegments.Count);

            defaultSegments[index].SetTrap();
            defaultSegments.RemoveAt(index);
        }
    }

    public void SetRandomRotation()
    {
        transform.eulerAngles = new Vector3(0, Random.Range(0, 360), 0);
    }

    public void SetFinishFullFloor()
    {
        for (int i = 0; i < defaultSegments.Count; i++)
        {
            defaultSegments[i].SetFinish();
        }
    }
    public void MoveFloorSegments()
    {
       for (int i = 0; i < defaultSegments.Count; i++)
       {
            if (defaultSegments[i] != null)
            {
                defaultSegments[i].MoveSegment();
            }    
       }
    }
}
