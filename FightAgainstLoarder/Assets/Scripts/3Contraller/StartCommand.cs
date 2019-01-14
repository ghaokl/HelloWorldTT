using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using strange;
using strange.extensions.command.impl;


public class StartCommand : Command
{
    [Inject]
    public IntergationModel IntergationModel { get; set; }

    /// <summary>
    /// 执行事件
    /// </summary>
    public override void Execute()
    {
        Tool.CreatePanel(PanelType.StartPanel);

        //初始化model
        IntergationModel.InitIntegration();
    }
}


