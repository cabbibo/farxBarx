using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using IMMATERIA;

public class PlumeParticles : Particles
{
   
    public Form skeleton;
    public int vertsPerVert;

    public override void SetCount(){
        count = skeleton.count * vertsPerVert;
    }
}
