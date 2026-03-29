using NodeCanvas.Framework;
using ParadoxNotion.Design;


namespace NodeCanvas.Tasks.Actions {

	public class guard2Chase : ActionTask {

		public BBParameter<bool> GuardIsChasing;
		public bool value;

		protected override void OnExecute() {
			GuardIsChasing.value = value;
			EndAction(true);
		}

	
	}
}