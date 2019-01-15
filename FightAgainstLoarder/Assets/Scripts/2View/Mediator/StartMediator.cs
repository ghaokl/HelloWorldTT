using System.Collections;
using System.Collections.Generic;
using strange.extensions.mediation.impl;
using UnityEngine;


public class StartMediator :EventMediator
{
    [Inject]
    public StartView StartView { get; set; }

    public override void OnRegister()
    {
        StartView.oneBtn.onClick.AddListener(OnOneBtnClick);
        StartView.twoBtn.onClick.AddListener(OnTwoBtnClick);

    }

    public override void OnRemove()
    {
        StartView.oneBtn.onClick.RemoveListener(OnOneBtnClick);
        StartView.twoBtn.onClick.RemoveListener(OnTwoBtnClick);

    }

    private void OnOneBtnClick()
    {
        //1.修改model
        dispatcher.Dispatch(CommandEvent.ChangeMulitiple,1);
        //2.删除面板
        Destroy(StartView.gameObject);
    }

    private void OnTwoBtnClick()
    {
        dispatcher.Dispatch(CommandEvent.ChangeMulitiple,2);
        Destroy(StartView.gameObject);
    }
}


