    var isPause = false;
    var MainMenu : Rect = Rect(10, 10, 200, 200);
     var mouseSensitivityX : float;
     var mouseSensitivityY : float;
    
    function Update () {
    if( Input.GetKeyDown(KeyCode.Escape))
    {
    Screen.lockCursor = false;
    isPause = !isPause;
    if(isPause)
    Time.timeScale = 0;
    else
    Time.timeScale = 1;
    }
    }
     
    function OnGUI()
    {
    if(isPause)
    GUI.Window(0, MainMenu, TheMainMenu, "Pause Menu");
    
    }
     
   function TheMainMenu () {
    //if(GUILayout.Button("Main Menu")){
    //Application.LoadLevel(0);
    //}
    //if(GUILayout.Button("Restart")){
    //Application.LoadLevel(1);
    //}
    //if(GUILayout.Button("Quit")){
    //Application.Quit();
    //}
    


		GUILayout.BeginVertical(GUI.skin.box);
		GUILayout.Label("Instructions:");
		GUILayout.Label("Arrows or WASD to move.");
		GUILayout.Label("Mouse to Turn");
		GUILayout.Label("Left Mouse to Interact");
		GUILayout.EndVertical();

		
    
    }