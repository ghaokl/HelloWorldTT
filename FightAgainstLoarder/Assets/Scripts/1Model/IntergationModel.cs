using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class IntergationModel
{
    /// <summary>
    /// 基础积分
    /// </summary>
    private int basePoint;
    public int BasePoint
    {
        get
        {
            return basePoint;
        }
        set { basePoint = value; }
    }

    /// <summary>
    /// 翻倍
    /// </summary>
    private int mulitiple;
    public int Mulitiple
    {
        get
        {
            return mulitiple;
        }
        set { mulitiple = value; }
    }

    private int result;
    public int Result
    {
        get { return (Mulitiple*BasePoint); }
        set { result = value; }
    }

    private int playerIntegration;
    public int PlayerIntegration
    {
        get
        {
            return playerIntegration;
        }
        set
        {
            if (value < 0)
            {
                playerIntegration = 0;
            }
            else
            {
                playerIntegration = value;
            }
        }
        
    }

    private int computerLeftIntegration;
    public int ComputerLeftIntegration
    {
        get
        {
            return computerLeftIntegration;
        }
        set
        {
            if (value < 0)
                computerLeftIntegration = 0;
            else
            {
                computerLeftIntegration = value;
            }
        }
    }

    private int computerRightIntegration;
    public int ComputerRightIntegration
    {
        get
        {
            return computerRightIntegration;
        }
        set
        {
            if (value < 0)
            {
                computerRightIntegration = 0;
            }
            else
            {
                computerRightIntegration = value;
            }
        }
    }

    public void InitIntegration()
    {
        Mulitiple = 1;
        BasePoint = 100;
        PlayerIntegration = 1500;
        ComputerLeftIntegration = 1500;
        ComputerRightIntegration = 1500;
    }

}


