using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using IMMATERIA;

public class BindPlumeData : Binder
{
    public PlumeParticles plume;

    public override void Bind(){
        toBind.BindInt("_VertsPerVert", ()=> plume.vertsPerVert );
        toBind.BindForm("_BaseBuffer", plume.skeleton );
    }
}
