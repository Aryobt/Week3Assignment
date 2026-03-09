using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class ColorChange : ActionTask {

		public BBParameter<Transform> target;
		public BBParameter<Renderer> renderer;
		public BBParameter<Color> color;


		private Color defaultColor;

		protected override string OnInit()
		{
			defaultColor = agent.GetComponent<Renderer>().material.color;
			return null;
		}
		
		protected override void OnExecute() {

			//EndAction(true);
		}

		protected override void OnUpdate() {
			float interpolant = 1 - Vector3.Distance(target.value.position, agent.transform.position) / 7f;

			Color steppedColor = Color.Lerp(defaultColor, color.value, interpolant);
			renderer.value.material.color = steppedColor;
		}

	}
}