using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using strange.extensions.context.impl;


public class GameRoot : ContextView
{
    void Awake()
    {
        context =new GameContext(this,true);

        //开启框架
        context.Start();
    }
    
}


