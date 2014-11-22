// Converted from UnityScript to C# at http://www.M2H.nl/files/js_to_c.php - by Mike Hergaarden
// Do test the code! You usually need to change a few small bits.

using UnityEngine;
using System.Collections;

//namespace VOX
//{
	public class UUGui : MonoBehaviour {
	
		public bool anim = true;
		public Animation animation;
	
		void Start()
		{
			animation = transform.GetComponent<Animation>();
		}
		
		void OnGUI()
		{
			GUILayout.BeginArea(new Rect(Screen.width*0.05f, Screen.height*0.05f+20, Screen.width*0.1f, Screen.height*0.1f) );
			if (animation!= null)
			{
				anim = GUILayout.Toggle(anim,"Animation");
			
				if ( anim && !animation.isPlaying )
					animation.Play();
			
				if ( !anim && animation.isPlaying )
					animation.Stop();
			}
		
			Resolution maxRes = Screen.resolutions[Screen.resolutions.Length-1];
			Screen.fullScreen = GUILayout.Toggle(Screen.fullScreen,"Fullscreen");
			if (Screen.fullScreen && Screen.currentResolution.width != maxRes.width)
				Screen.SetResolution ( maxRes.width, maxRes.height, true);
			else if (Screen.currentResolution.width != maxRes.width )
				Screen.SetResolution (960,600,false);
				
			GUILayout.EndArea();
		}
	
	}
