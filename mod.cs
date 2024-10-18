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
  public string[] trackplayers = ""
  public static void Tracker()
  {
    string[] trackPlayers = {
      "uhh yea"
    };
    while (true) 
    {
      foreach (var player in PhotonNetwork.PlayerList)
      {
        if (trackPlayers.contains(player.Nickname.ToLower()))
        {
          string room = PhotonNetwork.CurrentRoom();
          string message = $"{player.Nickname} found in {room}";
          SendMessage(message)
        }
      }
    }
  }
}
