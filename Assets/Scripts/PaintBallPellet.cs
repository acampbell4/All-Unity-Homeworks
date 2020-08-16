using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintBallPellet : MonoBehaviour
{
    public List<Material> ourPaints = new List<Material>();
   private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag =="Paintable")       //== means you are compairing two = means equal
        {
            //do the painting
        }
    }
}
