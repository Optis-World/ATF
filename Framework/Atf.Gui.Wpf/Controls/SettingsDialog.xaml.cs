//Copyright © 2014 Sony Computer Entertainment America LLC. See License.txt.

using System.Collections;
using System.ComponentModel;
using System.Windows;
using System.Windows.Data;
using Sce.Atf.Wpf.Controls.PropertyEditing;
using Sce.Atf.Wpf.Models;

namespace Sce.Atf.Wpf.Controls
{
    /// <summary>
    ///     Interaction logic for SettingsDialog.xaml
    /// </summary>
    public partial class SettingsDialog : CommonDialog
    {
        #region CTORS

        /// <summary>
        ///     Constructor
        /// </summary>
        /// <param name="viewModel">View model to use</param>
        public SettingsDialog(DialogViewModelBase viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }

        #endregion

        #region Refresh Property

        /// <summary>
        ///    Refresh setting view.
        /// </summary>
        public void Refresh()
        {
            PropertyGrid.Rebuild();
        }

        #endregion

        #region Sorting Property

        /// <summary>
        ///     Gets or sets PropertyGrid's Sorting dependency property
        /// </summary>
        public IComparer Sorting
        {
            get => (IComparer)GetValue(SortingProperty);
            set => SetValue(SortingProperty, value);
        }

        /// <summary>
        ///     PropertyGrid's Sorting dependency property
        /// </summary>
        public static readonly DependencyProperty SortingProperty = DependencyProperty.Register(nameof(Sorting), typeof(IComparer), typeof(SettingsDialog));

        #endregion

        #region Grouping Property

        /// <summary>
        ///     Gets or sets PropertyGrid's Grouping dependency property
        /// </summary>
        public GroupDescription Grouping
        {
            get => (GroupDescription)GetValue(GroupingProperty);
            set => SetValue(GroupingProperty, value);
        }

        /// <summary>
        ///     PropertyGrid's Grouping dependency property
        /// </summary>
        public static readonly DependencyProperty GroupingProperty = DependencyProperty.Register(nameof(Grouping), typeof(GroupDescription), typeof(SettingsDialog), new FrameworkPropertyMetadata(DefaultPropertyGrouping.None));

        #endregion
    }
}