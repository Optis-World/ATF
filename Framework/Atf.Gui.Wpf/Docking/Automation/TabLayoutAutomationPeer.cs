//Modified file in context of repo fork : https://github.com/Optis-World/ATF

using System.Windows;
using System.Windows.Automation.Peers;

namespace Sce.Atf.Wpf.Docking.Automation
{
    public class TabLayoutAutomationPeer:FrameworkElementAutomationPeer
    {
        public TabLayoutAutomationPeer(FrameworkElement owner):base(owner)
        {

        }

        #region Override Members
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        protected override string GetClassNameCore()
        {
            return nameof(TabLayout);
        }
        #endregion
    }
}
