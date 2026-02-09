using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class ToggleScout : ActionTask {

		public BBParameter<bool> scoutingBBP;
        public AudioSource audioSource;
		public AudioClip whistleSFX;

        protected override void OnExecute()
        {
            scoutingBBP.value = !scoutingBBP.value;

            AudioManager1.Instance.PlaySoundEffect(audioSource,whistleSFX);

            Debug.Log("Toggle scouting!");

            EndAction(true);
        }

	}
}