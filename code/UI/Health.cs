using Sandbox.UI.Construct;

namespace Sandbox.UI
{
	public class Health : Label
	{
		public IconPanel Icon;
		public Label Label;

		public Health()
		{
			Icon = Add.Icon( "add_box", "icon icon-health" );
			Label = Add.Label( "100", "health" );

			Label.Style.Dirty();
		}

		public override void Tick()
		{
			var player = Local.Pawn;
			if ( player == null ) return;

			Label.Text = $"{player.Health:n0}";
		}
	}

	public class Armor : Label
	{
		public IconPanel Icon;
		public Label Label;

		public Armor()
		{
			Icon = Add.Icon( "shield", "icon icon-armor" );
			Label = Add.Label( "0", "armor" );

			Label.Style.Dirty();
		}

		public override void Tick()
		{
			var player = Local.Pawn;
			if ( player == null ) return;

			Label.Text = $"{player.Health*2:n0}";
		}
	}

	public class BarContainer : Panel
	{
		public Label Label;

		public BarContainer()
		{
			Label = Add.Label( "100", "value" );
			//Label.Style.Dirty();
		}

		public override void Tick()
		{
			var player = Local.Pawn;
			if ( player == null ) return;

			Label.Text = $"{player.Health.CeilToInt()}";
		}
	}
}
