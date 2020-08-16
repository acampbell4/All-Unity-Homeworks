using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintBallPellet : MonoBehaviour
{
    public List<Material> ourPaints = new List<Material>();
    private int paintIndex = 0;
   private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag =="Paintable")       //== means you are compairing two = means equal
        {
            //do the painting
            collision.collider.GetComponent<Renderer>().material = ourPaints[paintIndex];

            paintIndex++;
            if(paintIndex == ourPaints.Count)
            {
                paintIndex = 0;
            }
        }
    }
}
