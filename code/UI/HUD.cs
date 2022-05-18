using Sandbox.UI;

namespace Sandbox
{
	public class HUD : HudEntity<RootPanel>
	{
		public HUD()
		{
			if ( !IsClient ) return;

			RootPanel.StyleSheet.Load( "Resources/styles/HUD.scss" );

			//RootPanel.AddChild<Health>();
			//RootPanel.AddChild<Money>();
			//RootPanel.AddChild<Armor>();

			var healthPanel = RootPanel.AddChild<BarContainer>();

			healthPanel.Style.Dirty();

			healthPanel.AddChild<Health>();
			healthPanel.AddChild<Money>();
			healthPanel.AddChild<Armor>();
		}
	}
}
