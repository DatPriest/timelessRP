using Sandbox.UI.Construct;

namespace Sandbox.UI
{
	public class Health : Label
	{
		public Label Label;

		public Health()
		{
			Add.Label( "<3", "icon" );
			Label = Add.Label( "100", "value" );
		}

		public override void Tick()
		{
			var player = Local.Pawn;
			if ( player == null ) return;

			Label.Text = $"{player.Health:n0}";
		}
	}
}
