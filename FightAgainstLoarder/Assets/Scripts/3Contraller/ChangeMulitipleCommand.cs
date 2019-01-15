using System.Collections;
using System.Collections.Generic;
using strange.extensions.command.impl;
using UnityEngine;


public class ChangeMulitipleCommand:EventCommand 
{
    [Inject]
    public IntergationModel IntergationModel { get; set; }

    public override void Execute()
    {
        //1.修改model
        IntergationModel.Mulitiple *= (int)evt.data;
        //添加面板
    }
}


