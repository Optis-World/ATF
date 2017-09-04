﻿using System.Windows.Automation.Peers;
using System.Windows;

namespace Sce.Atf.Wpf.Docking.Automation
{
	class GridLayoutAutomationPeer:FrameworkElementAutomationPeer
	{
		GridLayoutAutomationPeer(FrameworkElement owner) : base(owner)
		{

		}

		#region Override Members
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		protected override string GetClassNameCore()
		{
			return nameof(GridLayout);
		}
		#endregion
	}
}
