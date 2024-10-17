class Mod
{
  public static void ModtPlayers()
  {
    string things = "";
    foreach (var player in PhotonNetwork.PlayerList)
    {  
      things += "<color=white>\nPlayer Name: " + player.NickName + " Player ID: " + player.UserId + "</color>";
      GameObject.Find("motd").GetComponent<Text>().text = "<color=yellow>InputHere</color>";
    }
    GameObject.Find("motdtext").GetComponent<Text>().text = things
    GameObject.Find("motd").GetComponent<Text>().text = "<color=white>Players</color>";
  }
}
