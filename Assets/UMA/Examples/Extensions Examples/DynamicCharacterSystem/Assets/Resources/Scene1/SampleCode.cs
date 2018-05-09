using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using UMA.Examples;
using System.Collections;
using System.IO;

namespace UMA.CharacterSystem.Examples
{
	public class SampleCode : MonoBehaviour
	{

		public DynamicCharacterAvatar Avatar;
		public GameObject SlotPrefab;
		public GameObject WardrobePrefab;
		public GameObject SlotPanel;
		public GameObject WardrobePanel;
		public GameObject ColorPrefab;
		public GameObject DnaPrefab;
		public GameObject LabelPrefab;
		public GameObject GeneralHelpText;
		public GameObject WardrobeHelpText;
		public GameObject ColorsHelpText;
		public GameObject DnaHelpText;
		public GameObject AvatarPrefab;
		public MouseOrbitImproved Orbiter;
		public SharedColorTable HairColor;
		public SharedColorTable SkinColor;
		public SharedColorTable EyesColor;
		public SharedColorTable ClothingColor;
		public GameObject Canvas;
		public DynamicCharacterBuilderLogic DynamicCharacterBuilderLogic;
		FileHandler fileHandler;

		public static List<string> RandomizedAvatars;
		public static int count = 1;
		public string CharacterName;
		public SampleCode()
		{
			RandomizedAvatars = new List<string>();
			DynamicCharacterBuilderLogic = new DynamicCharacterBuilderLogic();
			fileHandler = new FileHandler();
		}
		/// <summary>
		/// Remove any controls from the panels
		/// </summary>
		private void Cleanup()
		{
			GeneralHelpText.SetActive(false);
			DnaHelpText.SetActive(false);
			WardrobeHelpText.SetActive(false);
			ColorsHelpText.SetActive(false);

			foreach (Transform t in SlotPanel.transform)
			{
				UMAUtils.DestroySceneObject(t.gameObject);
			}
			foreach (Transform t in WardrobePanel.transform)
			{
				UMAUtils.DestroySceneObject(t.gameObject);
			}
		}

		public void HelpClick()
		{
			if (GeneralHelpText.activeSelf)
			{
				GeneralHelpText.SetActive(false);
			}
			else
			{
				Cleanup();
				GeneralHelpText.SetActive(true);
			}
		}

		public void WardrobeHelpClick()
		{
			if (WardrobeHelpText.activeSelf)
			{
				WardrobeHelpText.SetActive(false);
			}
			else
			{
				Cleanup();
				WardrobeHelpText.SetActive(true);
			}
		}

		public void ColorsHelpClick()
		{
			if (ColorsHelpText.activeSelf)
			{
				ColorsHelpText.SetActive(false);
			}
			else
			{
				Cleanup();
				ColorsHelpText.SetActive(true);
			}
		}

		public void DNAHelpClick()
		{
			if (DnaHelpText.activeSelf)
			{
				DnaHelpText.SetActive(false);
			}
			else
			{
				Cleanup();
				DnaHelpText.SetActive(true);
			}
		}
		/// <summary>
		/// DNA Button event Handler
		/// </summary>
		public void DnaClick()
		{
			Cleanup();
			Dictionary<string, DnaSetter> AllDNA = Avatar.GetDNA();
			foreach (KeyValuePair<string, DnaSetter> ds in AllDNA)
			{
				// create a button. 
				// set set the dna setter on it.
				GameObject go = GameObject.Instantiate(DnaPrefab);
				DNAHandler ch = go.GetComponent<DNAHandler>();
				ch.Setup(Avatar, ds.Value, WardrobePanel);

				Text txt = go.GetComponentInChildren<Text>();
				txt.text = ds.Value.Name;
				go.transform.SetParent(SlotPanel.transform);
			}
		}

		/// <summary>
		/// Colors Button event handler
		/// </summary>
		public void ColorsClick()
		{
			Cleanup();

			foreach (UMA.OverlayColorData ocd in Avatar.CurrentSharedColors)
			{
				GameObject go = GameObject.Instantiate(ColorPrefab);
				AvailableColorsHandler ch = go.GetComponent<AvailableColorsHandler>();

				SharedColorTable currColors = ClothingColor;

				if (ocd.name.ToLower() == "skin")
					currColors = SkinColor;
				else if (ocd.name.ToLower() == "hair")
					currColors = HairColor;
				else if (ocd.name.ToLower() == "eyes")
					currColors = EyesColor;

				ch.Setup(Avatar, ocd.name, WardrobePanel, currColors);

				Text txt = go.GetComponentInChildren<Text>();
				txt.text = ocd.name;
				go.transform.SetParent(SlotPanel.transform);
			}
		}

		/// <summary>
		/// Wardrobe Button event handler
		/// </summary>
		public void WardrobeClick()
		{
			Cleanup();

			Dictionary<string, List<UMATextRecipe>> recipes = Avatar.AvailableRecipes;

			foreach (string s in recipes.Keys)
			{
				GameObject go = GameObject.Instantiate(SlotPrefab);
				SlotHandler sh = go.GetComponent<SlotHandler>();
				sh.Setup(Avatar, s, WardrobePanel);
				Text txt = go.GetComponentInChildren<Text>();
				txt.text = s;
				go.transform.SetParent(SlotPanel.transform);
			}
		}

		public SharedColorTable SkinColors;
		public SharedColorTable HairColors;

		public void DynamicCreateClick()
		{
			List<string> exisitingAvatars = new List<string>();
			string[] files = { "UgoAvatar", "UgoAvatar", "UgoAvatar" };
			float x = Random.Range(-8.0f, 8.0f);
			float z = Random.Range(1.0f, 12.0f);
			GameObject go = GameObject.Instantiate(AvatarPrefab);
			DynamicCharacterAvatar dca = go.GetComponent<DynamicCharacterAvatar>();
#if true
			// this shows how to load it from a string at initialization
			TextAsset t = Resources.Load<TextAsset>("CharacterRecipes/f03775cb-32ba-4b7a-b54c-547449ecd202");
			string bobAvatar = Resources.Load<TextAsset>("CharacterRecipes/Troll1c").text;
			string handGuyAvatar = Resources.Load<TextAsset>("CharacterRecipes/HandsGuy").text;
			string framAvatar = Resources.Load<TextAsset>("CharacterRecipes/Fram").text;
			exisitingAvatars.Add(bobAvatar);
			exisitingAvatars.Add(handGuyAvatar);
			exisitingAvatars.Add(framAvatar);

			bool isNewAvatarUnique = exisitingAvatars.Contains(t.text);
			Debug.Log("Ugo avatar unique: " + !isNewAvatarUnique);
			dca.SetLoadString(t.text.Trim());

#else
            // this shows how to load it from a resource file at initialization
            dca.loadPathType = DynamicCharacterAvatar.loadPathTypes.CharacterSystem;
            dca.loadFilename = files[Random.Range(0, 3)];
#endif
			go.transform.localPosition = new Vector3(x, 1.53f, z);
			go.SetActive(true);
		}

		public void ChangeSex()
		{
			if (Avatar.activeRace.name == "HumanMale")
			{
				Avatar.ChangeRace("HumanFemale");
			}
			else
			{
				Avatar.ChangeRace("HumanMale");
			}

		}

		public void CenterCam()
		{
			Orbiter.Reset();
		}

		public void ToggleUpdateBounds()
		{
			SkinnedMeshRenderer[] sm = FindObjectsOfType<SkinnedMeshRenderer>();
			foreach (SkinnedMeshRenderer smr in sm)
			{
				smr.updateWhenOffscreen = !smr.updateWhenOffscreen;
			}
		}

		public void RandomClick()
		{
			RandomizeAvatar(Avatar);

		}

		int i = 0;
		public float trackTime = 0.2f;
		List<Texture2D> textures = new List<Texture2D>();
		WaitForEndOfFrame frameEnd = new WaitForEndOfFrame();
		IEnumerator Test()
		{
			while (i < 20)
			{
				TakeSnapshots();
				yield return frameEnd;
				i++;
			}
			Canvas.SetActive(true);

		}

		public void StartSnapshotCoroutine()
		{
			Canvas.SetActive(false);
			StartCoroutine(Test());

		}
		private void TakeSnapshots()
		{
			//Debug.Log(CharacterName);
			if (!Directory.Exists("Assets/All My Stuff/Resources/CharacterImages/Character "+CharacterName))
			{
				DirectoryInfo directoryInfo = Directory.CreateDirectory("Assets/All My Stuff/Resources/CharacterImages/Character " + CharacterName);
			}

			ScreenCapture.CaptureScreenshot("Assets/All My Stuff/Resources/CharacterImages/Character " + CharacterName+"/Image" + count + ".png");

			//Texture2D tex = new Texture2D(Screen.width, Screen.height); 
			//tex.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0); 
			//tex.Apply();

			// Encode texture into PNG
			//var bytes = tex.EncodeToPNG();
			//Destroy(tex);

			//File.WriteAllBytes("shot" + count + ".png", bytes);

			//			var texture2D = ScreenCapture.CaptureScreenshotAsTexture ();
			//			// Encode texture into PNG
			//			var bytes = texture2D.EncodeToPNG();
			//			Destroy (texture2D);
			//			File.WriteAllBytes("shot"+count+".png", bytes);

			count++;
		}
		private void RandomizeAvatar(DynamicCharacterAvatar Avatar)
		{



			Dictionary<string, List<UMATextRecipe>> recipes = Avatar.AvailableRecipes;

			// Set random wardrobe slots.
			foreach (string SlotName in recipes.Keys)
			{
				int cnt = recipes[SlotName].Count;
				if (cnt > 0)
				{
					//Get a random recipe from the slot, and apply it
					int min = 0;
					if (SlotName == "Legs") min = 0; // Don't allow pants removal in random test
					int rnd = Random.Range(min, cnt);
					if (rnd == -1)
					{
						Avatar.ClearSlot(SlotName);
					}
					else
					{

						Avatar.SetSlot(recipes[SlotName][rnd]);
					}
				}
			}


			// Set Random DNA 
			Dictionary<string, DnaSetter> setters = Avatar.GetDNA();
			foreach (KeyValuePair<string, DnaSetter> dna in setters)
			{
				dna.Value.Set(0.35f + (Random.value * 0.3f));
			}

			// Set Random Colors for Skin and Hair
			int RandHair = Random.Range(0, HairColors.colors.Length);
			int RandSkin = Random.Range(0, SkinColors.colors.Length);

			Avatar.SetColor("Hair", HairColors.colors[RandHair]);
			Avatar.SetColor("Skin", SkinColors.colors[RandSkin]);
			Avatar.SetColor("SpartanHelmetColor", ClothingColor.colors[RandHair]);
			Avatar.SetColor("RobeColor", ClothingColor.colors[RandHair]);

			Avatar.BuildCharacter(true);
			Avatar.ForceUpdate(true, true, true);

			foreach (var item in Avatar.WardrobeRecipes)
			{
				if (item.Key == "AlternateHead")
				{
					if (item.Value.name.ToLower() == "spartanshield")
					{
						Debug.Log("He has a shied");
					}
				}
				if (item.Key == "Helmet")
				{
					if (item.Value.name.ToLower() == "spartanhelmet")
					{
						Debug.Log("He has a helmet");

					}
				}
			}

			//Create a folder and save the avatars there and then compare the values of each avatar

		}

		public void LinkToAssets()
		{
			Application.OpenURL("https://www.assetstore.unity3d.com/en/#!/search/page=1/sortby=popularity/query=publisher:5619");
		}

		public void ToggleAnimation()
		{
			// RuntimeAnimatorController rac = Avatar.gameObject.GetComponentInChildren<>
		}

		public void BuildMaleWorker()
		{
			//set random colour for skin and hair
			int RandHair = Random.Range(0, HairColors.colors.Length);
			int RandSkin = Random.Range(0, SkinColors.colors.Length);

			Avatar.SetColor("Hair", HairColors.colors[RandHair]);
			Avatar.SetColor("Skin", SkinColors.colors[RandSkin]);

			Character maleCharacter = DynamicCharacterBuilderLogic.BuildWorkerAvatar(Avatar, Gender.Male);

			//to save avatar file
			string avatarName = System.Guid.NewGuid().ToString();
			Avatar.BuildCharacter(true);
            Avatar.ForceUpdate(true, true, true);
			Avatar.DoSave(false, "Assets/All My Stuff/Resources/AutoGeneratedUniqueAvatars/" + avatarName + ".txt");
		
			BuildRoleCategory(maleCharacter);
			fileHandler.EnsureAvatarUniqueness(avatarName, maleCharacter);
			CharacterName = maleCharacter.Name;
		}

		public void BuildFemaleWorker()
		{
			//set random colour for skin and hair
			int RandHair = Random.Range(0, HairColors.colors.Length);
			int RandSkin = Random.Range(0, SkinColors.colors.Length);

			Avatar.SetColor("Hair", HairColors.colors[RandHair]);
			Avatar.SetColor("Skin", SkinColors.colors[RandSkin]);

			Character femaleCharacter = DynamicCharacterBuilderLogic.BuildWorkerAvatar(Avatar, Gender.Female);

			//to save avatar file
			string avatarName = System.Guid.NewGuid().ToString();

			Avatar.BuildCharacter(true);
			Avatar.ForceUpdate(true, true, true);
			BuildRoleCategory(femaleCharacter);
			Avatar.DoSave(false, "Assets/All My Stuff/Resources/AutoGeneratedUniqueAvatars/" + avatarName + ".txt");

			fileHandler.EnsureAvatarUniqueness(avatarName, femaleCharacter);
			CharacterName = femaleCharacter.Name;


		}

		#region helper
		public void BuildRoleCategory(Character character)
        {

			var HelmetEnchantedHoodRecipe = Avatar.GetWardrobeItemName(SlotNames.Helmet.ToString());

			//Debug.Log(HelmetEnchantedHoodRecipe);

            if (HelmetEnchantedHoodRecipe != null)
			{
				if (HelmetEnchantedHoodRecipe == WardrobeItemNames.EnchantedHood.ToString())
				{
					character.RoleCategoryId = (int)RoleCategoryEnum.Enchanted;

				}else{
					character.RoleCategoryId = (int)RoleCategoryEnum.Regular;

				}

			}else{
				character.RoleCategoryId = (int)RoleCategoryEnum.Regular;
			}


		}
#endregion

	}
}
