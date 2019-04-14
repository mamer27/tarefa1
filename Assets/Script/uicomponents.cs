using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;


[Serializable]
public class uicomponents

{
[Serializable]
public class HUD

{
[Header("Text")]

public Text txtcoincount;
public Text txtlifecount;

[Header("Other")]
public GameObject panelhud;




}

[Serializable]
public class panel

{
[Header("Text")]

public Text txtscore;


[Header("Other")]
public GameObject levelcompletepanel;




}


[Serializable]
public class panel2

{
[Header("Text")]

public Text txtscore;


[Header("Other")]
public GameObject gameoverpanel;




}
public HUD hud;
public panel LCpanel;

public panel2 GOpanel;
}
