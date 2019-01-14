using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using strange.extensions.context.impl;
using strange.extensions.context.api;


public class GameContext : MVCSContext
{
    public GameContext(MonoBehaviour view, bool autoMapping) : base(view, autoMapping)
    {
    }

    protected override void mapBindings()
    {
        //model
        injectionBinder.Bind<IntergationModel>().To<IntergationModel>().ToSingleton();
        //只需要调用一次
        commandBinder.Bind(ContextEvent.START).To<StartCommand>().Once();
        //View
        //Command
    }
}


