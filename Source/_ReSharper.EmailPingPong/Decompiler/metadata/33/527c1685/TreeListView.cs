// Type: DevExpress.Xpf.Grid.TreeListView
// Assembly: DevExpress.Xpf.Grid.v11.2, Version=11.2.11.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a
// Assembly location: C:\Program Files (x86)\DevExpress 2011.2\Components\Bin\Framework\DevExpress.Xpf.Grid.v11.2.dll

using DevExpress.Data;
using DevExpress.Utils.Serializing;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Core.Serialization;
using DevExpress.Xpf.Data;
using DevExpress.Xpf.Grid.Native;
using DevExpress.Xpf.Grid.TreeList;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;

namespace DevExpress.Xpf.Grid
{
  /// <summary>
  /// 
  /// <para>
  /// A View that displays information in a Tree hierarchical structure.
  /// 
  /// 
  /// </para>
  /// 
  /// </summary>
  public class TreeListView : GridDataViewBase, ITableView
  {
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly DependencyProperty FitColumnWidthProperty;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly DependencyProperty HeaderFitColumnWidthProperty;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly DependencyProperty AdditionalRowFitColumnWidthProperty;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly DependencyProperty IndicatorHeaderWidthProperty;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly DependencyProperty ActualDataRowTemplateSelectorProperty;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly DependencyProperty RowStyleProperty;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly DependencyProperty ShowAutoFilterRowProperty;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly DependencyProperty AllowCascadeUpdateProperty;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly DependencyProperty AllowPerPixelScrollingProperty;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly DependencyProperty ScrollAnimationDurationProperty;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly DependencyProperty ScrollAnimationModeProperty;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly DependencyProperty AutoWidthProperty;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly DependencyProperty LeftDataAreaIndentProperty;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly DependencyProperty RightDataAreaIndentProperty;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly DependencyProperty FixedLeftVisibleColumnsProperty;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly DependencyProperty FixedRightVisibleColumnsProperty;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly DependencyProperty FixedNoneVisibleColumnsProperty;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly DependencyProperty HorizontalViewportProperty;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly DependencyProperty FixedLineWidthProperty;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly DependencyProperty ShowVerticalLinesProperty;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly DependencyProperty ShowHorizontalLinesProperty;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly DependencyProperty RowDecorationTemplateProperty;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly DependencyProperty DefaultDataRowTemplateProperty;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly DependencyProperty DataRowTemplateProperty;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly DependencyProperty DataRowTemplateSelectorProperty;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly DependencyProperty RowIndicatorContentTemplateProperty;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly DependencyProperty AllowResizingProperty;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly DependencyProperty AllowHorizontalScrollingVirtualizationProperty;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly DependencyProperty ScrollingVirtualizationMarginProperty;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly DependencyProperty ScrollingHeaderVirtualizationMarginProperty;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly DependencyProperty RowMinHeightProperty;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly DependencyProperty HeaderPanelMinHeightProperty;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly DependencyProperty AutoMoveRowFocusProperty;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly DependencyProperty BestFitMaxRowCountProperty;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly DependencyProperty BestFitModeProperty;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly DependencyProperty BestFitAreaProperty;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly DependencyProperty AllowBestFitProperty;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  routed event.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly RoutedEvent CustomBestFitEvent;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly DependencyProperty ShowIndicatorProperty;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly DependencyProperty IndicatorWidthProperty;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly DependencyProperty FocusedRowBorderTemplateProperty;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly DependencyProperty MultiSelectModeProperty;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly DependencyProperty UseIndicatorForSelectionProperty;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly DependencyProperty SelectedRowsSourceProperty;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly DependencyProperty AllowFixedColumnMenuProperty;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly DependencyProperty AllowScrollHeadersProperty;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly DependencyProperty RowIndentProperty;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly DependencyProperty KeyFieldNameProperty;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly DependencyProperty ParentFieldNameProperty;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly DependencyProperty ImageFieldNameProperty;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly DependencyProperty NodeImageSelectorProperty;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly DependencyProperty RootValueProperty;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly DependencyProperty AutoPopulateServiceColumnsProperty;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly DependencyProperty VisibleColumnsProperty;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly DependencyProperty FocusedNodeProperty;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  routed event.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly RoutedEvent NodeExpandingEvent;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  routed event.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly RoutedEvent NodeExpandedEvent;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  routed event.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly RoutedEvent NodeCollapsingEvent;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  routed event.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly RoutedEvent NodeCollapsedEvent;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  routed event.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly RoutedEvent ShowingEditorEvent;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  routed event.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly RoutedEvent ShownEditorEvent;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  routed event.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly RoutedEvent HiddenEditorEvent;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  routed event.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly RoutedEvent CellValueChangedEvent;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  routed event.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly RoutedEvent CellValueChangingEvent;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  routed event.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly RoutedEvent CustomScrollAnimationEvent;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  routed event.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly RoutedEvent InvalidNodeExceptionEvent;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  routed event.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly RoutedEvent ValidateNodeEvent;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  routed event.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly RoutedEvent ValidateCellEvent;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  routed event.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly RoutedEvent RowDoubleClickEvent;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  routed event.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly RoutedEvent SelectionChangedEvent;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  routed event.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly RoutedEvent CopyingToClipboardEvent;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly DependencyProperty FocusedColumnProperty;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly DependencyProperty ShowNodeImagesProperty;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly DependencyProperty ShowExpandButtonsProperty;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly DependencyProperty ShowRootIndentProperty;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly DependencyProperty TreeLineStyleProperty;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly DependencyProperty RowPresenterMarginProperty;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly DependencyProperty AutoFilterRowCellStyleProperty;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly DependencyProperty ChildNodesPathProperty;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly DependencyProperty TreeDerivationModeProperty;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly DependencyProperty ChildNodesSelectorProperty;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly DependencyProperty AutoExpandAllNodesProperty;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly DependencyProperty FetchSublevelChildrenOnExpandProperty;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly DependencyProperty VerticalScrollbarVisibilityProperty;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly DependencyProperty HorizontalScrollbarVisibilityProperty;
    /// <summary>
    /// 
    /// <para>
    /// Identifies the  dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// [To be supplied]
    /// </returns>
    public static readonly DependencyProperty AllowDefaultContentForHierarchicalDataTemplateProperty;
    /// <summary>
    /// 
    /// <para>
    /// Initializes a new instance of the TreeListView class.
    /// 
    /// </para>
    /// 
    /// </summary>
    public TreeListView();
    protected virtual void OnFocusedNodeChanged();
    /// <summary>
    /// 
    /// <para>
    /// This member supports the internal infrastructure and is not intended to be used directly from your code. This is a dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// <param name="manager">@nbsp;
    /// 
    ///             </param>
    /// <returns>
    /// @nbsp;
    /// 
    /// </returns>
    [Browsable(false)]
    public bool ShouldSerializeFixedLeftVisibleColumns(XamlDesignerSerializationManager manager);
    /// <summary>
    /// 
    /// <para>
    /// This member supports the internal infrastructure and is not intended to be used directly from your code. This is a dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// <param name="manager">@nbsp;
    /// 
    ///             </param>
    /// <returns>
    /// @nbsp;
    /// 
    /// </returns>
    [Browsable(false)]
    public bool ShouldSerializeFixedRightVisibleColumns(XamlDesignerSerializationManager manager);
    /// <summary>
    /// 
    /// <para>
    /// This member supports the internal infrastructure and is not intended to be used directly from your code. This is a dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// <param name="manager">@nbsp;
    /// 
    ///             </param>
    /// <returns>
    /// @nbsp;
    /// 
    /// </returns>
    [Browsable(false)]
    public bool ShouldSerializeFixedNoneVisibleColumns(XamlDesignerSerializationManager manager);
    /// <summary>
    /// 
    /// <para>
    /// This member supports the internal infrastructure and is not intended to be used directly from your code. This is a dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// <param name="manager">@nbsp;
    /// 
    ///             </param>
    /// <returns>
    /// @nbsp;
    /// 
    /// </returns>
    [Browsable(false)]
    public bool ShouldSerializeVisibleColumns(XamlDesignerSerializationManager manager);
    protected internal override GridFilterColumn CreateFilterColumn(ColumnBase column, bool useDomainDataSourceRestrictions);
    protected virtual TreeListDataProvider CreateDataProvider();
    protected override DataIteratorBase CreateDataIterator();
    protected override DataViewBehavior CreateViewBehavior();
    protected override DataViewCommandsBase CreateCommandsContainer();
    protected override SelectionStrategyBase CreateSelectionStrategy();
    protected override bool ChangeVisibleRowExpandCore(RowHandle handle);
    protected internal override void MoveColumnToCore(ColumnBase source, int newVisibleIndex, HeaderPresenterType moveFrom, HeaderPresenterType moveTo);
    /// <summary>
    /// 
    /// <para>
    /// Expands all nodes.
    /// 
    /// </para>
    /// 
    /// </summary>
    public void ExpandAllNodes();
    /// <summary>
    /// 
    /// <para>
    /// Collapses all nodes.
    /// 
    /// </para>
    /// 
    /// </summary>
    public void CollapseAllNodes();
    /// <summary>
    /// 
    /// <para>
    /// Expands the specified node.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// <param name="rowHandle">An integer value that identifies a node by its handle.
    /// 
    ///             </param>
    public void ExpandNode(int rowHandle);
    /// <summary>
    /// 
    /// <para>
    /// Collapses the specified node.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// <param name="rowHandle">An integer value that identifies a node by its handle.
    /// 
    ///             </param>
    public void CollapseNode(int rowHandle);
    /// <summary>
    /// 
    /// <para>
    /// Specifies the expanded state of a node.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// <param name="rowHandle">An integer value that identifies a node by its handle.
    /// 
    ///             </param><param name="isExpanded"><b>true</b> to expand the node; otherwise, <b>false</b>.
    /// 
    ///             </param>
    public void ChangeNodeExpanded(int rowHandle, bool isExpanded);
    /// <summary>
    /// 
    /// <para>
    /// Returns the value of the specified cell.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// <param name="node">A <see cref="T:DevExpress.Xpf.Grid.TreeListNode"/> object that is the node which contains the cell.
    /// 
    ///             </param><param name="fieldName">A <see cref="T:System.String"/> value that identifies the column containing the cell by its field name.
    /// 
    ///             </param>
    /// <returns>
    /// An object that is the value of the specified cell. <b>null</b> (<b>Nothing</b> in Visual Basic) if the cell was not found.
    /// 
    /// </returns>
    public object GetNodeValue(TreeListNode node, string fieldName);
    /// <summary>
    /// 
    /// <para>
    /// Returns the value of the specified cell.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// <param name="node">A <see cref="T:DevExpress.Xpf.Grid.TreeListNode"/> object that is the node which contains the cell.
    /// 
    ///             </param><param name="column">A <see cref="T:DevExpress.Xpf.Grid.ColumnBase"/> descendant that is the column containing the cell by its field name.
    /// 
    ///             </param>
    /// <returns>
    /// An object that is the value of the specified cell. <b>null</b> (<b>Nothing</b> in Visual Basic) if the cell was not found.
    /// 
    /// </returns>
    public object GetNodeValue(TreeListNode node, ColumnBase column);
    /// <summary>
    /// 
    /// <para>
    /// Sets the value of the specified cell in the specified node.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// <param name="node">A <see cref="T:DevExpress.Xpf.Grid.TreeListNode"/> object that is the node containing the cell.
    /// 
    ///             </param><param name="fieldName">A <see cref="T:System.String"/> value that identifies the column containing the cell by its field name.
    /// 
    ///             </param><param name="value">An object that specifies the specified cell's new value.
    /// 
    ///             </param>
    public void SetNodeValue(TreeListNode node, string fieldName, object value);
    /// <summary>
    /// 
    /// <para>
    /// Sets the value of the specified cell in the specified node.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// <param name="node">A <see cref="T:DevExpress.Xpf.Grid.TreeListNode"/> object that is the node containing the cell.
    /// 
    ///             </param><param name="column">A <see cref="T:DevExpress.Xpf.Grid.ColumnBase"/> descendant that is the column containing the cell.
    /// 
    ///             </param><param name="value">An object that specifies the specified cell's new value.
    /// 
    ///             </param>
    public void SetNodeValue(TreeListNode node, ColumnBase column, object value);
    /// <summary>
    /// 
    /// <para>
    /// Returns a node with the specified handle.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// <param name="rowHandle">An integer value that specifies the row handle.
    /// 
    ///             </param>
    /// <returns>
    /// A <see cref="T:DevExpress.Xpf.Grid.TreeListNode"/> object that is the node with the specified handle. <b>null</b> (<b>Nothing</b> in Visual Basic) if the node was not found.
    /// 
    /// </returns>
    public TreeListNode GetNodeByRowHandle(int rowHandle);
    /// <summary>
    /// 
    /// <para>
    /// Returns a node with the specified visible index.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// <param name="visibleIndex">An integer value that specifies the node's position within a View.
    /// 
    ///             </param>
    /// <returns>
    /// A <see cref="T:DevExpress.Xpf.Grid.TreeListNode"/> object that is the node with the specified visible index. <b>null</b> (<b>Nothing</b> in Visual Basic) if the node was not found.
    /// 
    /// </returns>
    public TreeListNode GetNodeByVisibleIndex(int visibleIndex);
    /// <summary>
    /// 
    /// <para>
    /// Returns the node's position within a View among visible nodes.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// <param name="node">A <see cref="T:DevExpress.Xpf.Grid.TreeListNode"/> object that is the node whose visible index is returned.
    /// 
    ///             </param>
    /// <returns>
    /// An integer value that specifies the node's position among visible nodes. <b>-1</b> if the specified node is hidden.
    /// 
    /// </returns>
    public int GetNodeVisibleIndex(TreeListNode node);
    /// <summary>
    /// 
    /// <para>
    /// Returns a node with the specified content.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// <param name="content">An object that is the content of the required node.
    /// 
    ///             </param>
    /// <returns>
    /// A <see cref="T:DevExpress.Xpf.Grid.TreeListNode"/> object that is the node with the specified content. <b>null</b> (<b>Nothing</b> in Visual Basic) if the node was not found.
    /// 
    /// </returns>
    public TreeListNode GetNodeByContent(object content);
    /// <summary>
    /// 
    /// <para>
    /// Searches for a node with the specified value within the specified cell, and returns the first found node.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// <param name="fieldName">A <see cref="T:System.String"/> value that specifies the field name of the column containing the required cell.
    /// 
    ///             </param><param name="value">An object that specifies the value of the required cell.
    /// 
    ///             </param>
    /// <returns>
    /// A <see cref="T:DevExpress.Xpf.Grid.TreeListNode"/> object that is the node with the specified value within the specified cell. <b>null</b> (<b>Nothing</b> in Visual Basic) if the node was not found.
    /// 
    /// </returns>
    public TreeListNode GetNodeByCellValue(string fieldName, object value);
    /// <summary>
    /// 
    /// <para>
    /// Returns the node with the specified key value.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// <param name="keyValue">An object that specifies the key value.
    /// 
    ///             </param>
    /// <returns>
    /// A <see cref="T:DevExpress.Xpf.Grid.TreeListNode"/> object that is the node with the specified key value.
    /// 
    /// </returns>
    public TreeListNode GetNodeByKeyValue(object keyValue);
    /// <summary>
    /// 
    /// <para>
    /// Removes the specified node and all its children (if any).
    /// 
    /// 
    /// </para>
    /// 
    /// </summary>
    /// <param name="rowHandle">An integer value that identifies the node by its handle.
    /// 
    ///             </param>
    public void DeleteNode(int rowHandle);
    /// <summary>
    /// 
    /// <para>
    /// Removes the specified node and optionally, all its children.
    /// 
    /// 
    /// </para>
    /// 
    /// </summary>
    /// <param name="rowHandle">An integer value that identifies the node by its handle.
    /// 
    ///             </param><param name="deleteChildren"><b>true</b> to remove all child nodes; otherwise, <b>false</b>.
    /// 
    ///             </param>
    public void DeleteNode(int rowHandle, bool deleteChildren);
    /// <summary>
    /// 
    /// <para>
    /// Removes the specified node and all its children (if any).
    /// 
    /// </para>
    /// 
    /// </summary>
    /// <param name="node">A <see cref="T:DevExpress.Xpf.Grid.TreeListNode"/> object that is the node to remove.
    /// 
    ///             </param>
    public void DeleteNode(TreeListNode node);
    /// <summary>
    /// 
    /// <para>
    /// Removes the specified node and optionally, all its children.
    /// 
    /// 
    /// </para>
    /// 
    /// </summary>
    /// <param name="node">A <see cref="T:DevExpress.Xpf.Grid.TreeListNode"/> object that is the node to remove.
    /// 
    ///             </param><param name="deleteChildren"><b>true</b> to remove all child nodes; otherwise, <b>false</b>.
    /// 
    ///             </param>
    public void DeleteNode(TreeListNode node, bool deleteChildren);
    /// <summary>
    /// 
    /// <para>
    /// Moves focus to the node preceding the one currently focused.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// <param name="allowNavigateToAutoFilterRow"><b>true</b> to allow moving focus to the Auto Filter Row; otherwise, <b>false</b>.
    /// 
    /// 
    ///             </param>
    public void MovePrevRow(bool allowNavigateToAutoFilterRow);
    protected bool ChangeNodeExpanded(int rowHandle);
    protected override void OnFocusedRowHandleChangedCore(int oldRowHandle);
    protected internal virtual void OnChangeNodeExpanded(object commandParameter);
    protected override int CalculateNextRowHandle();
    protected internal virtual bool CanChangeNodeExpaned(object commandParameter);
    protected internal IList<IColumnInfo> GetColumns();
    protected internal virtual void UpdateRows();
    protected void CheckServiceColumns();
    protected internal override void OnDataChanged();
    protected internal virtual void OnCurrentIndexChanged();
    protected internal virtual string GetNodeDisplayText(TreeListNode node, string fieldName, object value);
    protected internal virtual bool RaiseNodeExpanding(TreeListNode node);
    protected internal virtual void RaiseNodeExpanded(TreeListNode node);
    protected internal virtual bool RaiseNodeCollapsing(TreeListNode node);
    protected internal virtual void RaiseNodeCollapsed(TreeListNode node);
    protected virtual string RaiseCustomColumnDisplayText(TreeListNode node, ColumnBase column, object value, string displayText);
    protected internal virtual object RaiseCustomUnboundColumnData(object p, string propName, object value, bool isGetAction);
    protected internal virtual bool? RaiseCustomNodeFilter(TreeListNode node);
    protected internal bool RaiseCustomFiterPopupList(TreeListNode node, DataColumnInfo columnInfo);
    protected internal virtual void RaiseCustomColumnSort(TreeListCustomColumnSortEventArgs e);
    protected internal virtual void RaiseCustomSummary(TreeListCustomSummaryEventArgs e);
    protected internal virtual void RaiseInvalidNodeException(TreeListNode node, ControllerRowExceptionEventArgs args);
    protected internal virtual bool RaiseValidateNode(int rowHandle, object value);
    protected internal virtual void ChildrenPropertyUpdate();
    protected internal virtual void OnChildNodesSelectorChanged();
    protected internal RowMarginControl FindRowMarginControl(DependencyObject obj);
    protected internal override object GetGroupDisplayValue(int rowHandle);
    protected internal override string GetGroupRowDisplayText(int rowHandle);
    protected override DependencyProperty GetFocusedColumnProperty();
    protected override void SetVisibleColumns(IList<ColumnBase> columns);
    protected internal void CheckFocusedNodeOnCollapse(TreeListNode treeListNode);
    protected internal void OnDataSourceChanged();
    protected internal override void ResetHeadersChildrenCache();
    protected internal override void UpdateContentLayout();
    protected override ControlTemplate GetRowFocusedRectangleTemplate();
    protected internal IEnumerable<TreeListNode> GetNodesFromRowHandles(IEnumerable<int> rowHandles);
    protected internal IEnumerable<int> GetRowHandlesFromNodes(IEnumerable<TreeListNode> nodes);
    /// <summary>
    /// 
    /// <para>
    /// Returns information about the specified element contained within the treelist view.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// <param name="d">A <see cref="T:System.Windows.DependencyObject"/> object that is the element contained within the treelist view.
    /// 
    /// 
    ///             </param>
    /// <returns>
    /// A <see cref="T:DevExpress.Xpf.Grid.TreeList.TreeListViewHitInfo"/> object that contains information about the specified view element.
    /// 
    /// </returns>
    public TreeListViewHitInfo CalcHitInfo(DependencyObject d);
    /// <summary>
    /// 
    /// <para>
    /// Resizes the specified column to the minimum width required to display the column's contents completely.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// <param name="column">A <see cref="T:DevExpress.Xpf.Grid.TreeListColumn"/> that is the column whose width should be optimized.
    /// 
    /// 
    ///             </param>
    public void BestFitColumn(ColumnBase column);
    /// <summary>
    /// 
    /// <para>
    /// Resizes all visible columns to optimally fit their contents.
    /// 
    /// </para>
    /// 
    /// </summary>
    public void BestFitColumns();
    /// <summary>
    /// 
    /// <para>
    /// Returns the column's optimal (minimum) width required to display its contents completely.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// <param name="column">A <see cref="T:DevExpress.Xpf.Grid.TreeListColumn"/> object that is the treelist column.
    /// 
    /// 
    ///             </param>
    /// <returns>
    /// A <see cref="T:System.Double"/> value that specifies the column's optimal (minimum) width required to display its contents completely.
    /// 
    /// </returns>
    public double CalcColumnBestFitWidth(ColumnBase column);
    protected virtual double CalcColumnBestFitWidthCore(ColumnBase column);
    void ITableView.SetHorizontalViewport(double value);
    double ITableView.CalcColumnBestFitWidthCore(ColumnBase column);
    void ITableView.SetFixedLeftVisibleColumns(IList<ColumnBase> columns);
    void ITableView.SetFixedNoneVisibleColumns(IList<ColumnBase> columns);
    void ITableView.SetFixedRightVisibleColumns(IList<ColumnBase> columns);
    void ITableView.CopyCellsToClipboard(IEnumerable<CellBase> gridCells);
    CellBase ITableView.CreateGridCell(int rowHandle, ColumnBase column);
    ITableViewHitInfo ITableView.CalcHitInfo(DependencyObject d);
    protected internal virtual void RaiseShowingEditor(TreeListShowingEditorEventArgs e);
    protected internal virtual void RaiseShownEditor(TreeListEditorEventArgs e);
    protected internal virtual void RaiseHiddenEditor(TreeListEditorEventArgs e);
    protected internal override void OnValidation(ColumnBase column, DataValidationEventArgsBase e);
    protected internal override void RaiseCustomScrollAnimation(CustomScrollAnimationEventArgs e);
    protected override void OnPreviewMouseDoubleClick(MouseButtonEventArgs e);
    /// <summary>
    /// 
    /// <para>
    /// Prevents selection updates until the <see cref="M:DevExpress.Xpf.Grid.TreeListView.EndSelection"/> method is called.
    /// 
    /// </para>
    /// 
    /// </summary>
    public void BeginSelection();
    /// <summary>
    /// 
    /// <para>
    /// Enables selection updates after calling the <see cref="M:DevExpress.Xpf.Grid.TreeListView.BeginSelection"/> method, and forces an immediate update.
    /// 
    /// </para>
    /// 
    /// </summary>
    public void EndSelection();
    /// <summary>
    /// 
    /// <para>
    /// Selects the specified node.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// <param name="rowHandle">An integer value which specifies the handle of the node to select.
    /// 
    ///             </param>
    public void SelectNode(int rowHandle);
    /// <summary>
    /// 
    /// <para>
    /// Selects the specified node.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// <param name="node">A <see cref="T:DevExpress.Xpf.Grid.TreeListNode"/> object that is the node to select.
    /// 
    ///             </param>
    public void SelectNode(TreeListNode node);
    /// <summary>
    /// 
    /// <para>
    /// Selects multiple nodes, while preserving the current selection (if any).
    /// 
    /// </para>
    /// 
    /// </summary>
    /// <param name="startRowHandle">An integer value specifying the row handle at which the selection starts.
    /// 
    ///             </param><param name="endRowHandle">An integer value specifying the row handle at which the selection ends.
    /// 
    ///             </param>
    public void SelectRange(int startRowHandle, int endRowHandle);
    /// <summary>
    /// 
    /// <para>
    /// Selects multiple nodes, while preserving the current selection (if any).
    /// 
    /// </para>
    /// 
    /// </summary>
    /// <param name="startNode">A <see cref="T:DevExpress.Xpf.Grid.TreeListNode"/> object that is the node at which the selection starts.
    /// 
    ///             </param><param name="endNode">A <see cref="T:DevExpress.Xpf.Grid.TreeListNode"/> object that is the node at which the selection ends.
    /// 
    ///             </param>
    public void SelectRange(TreeListNode startNode, TreeListNode endNode);
    /// <summary>
    /// 
    /// <para>
    /// Unselects the specified node.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// <param name="rowHandle">An integer value identifying the node by its handle.
    /// 
    ///             </param>
    public void UnselectNode(int rowHandle);
    /// <summary>
    /// 
    /// <para>
    /// Unselects the specified node.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// <param name="node">A <see cref="T:DevExpress.Xpf.Grid.TreeListNode"/> object that is the node to unselect.
    /// 
    ///             </param>
    public void UnselectNode(TreeListNode node);
    /// <summary>
    /// 
    /// <para>
    /// Unselects any selected nodes.
    /// 
    /// </para>
    /// 
    /// </summary>
    public void ClearSelection();
    /// <summary>
    /// 
    /// <para>
    /// Returns the handles of the selected nodes.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// An array of integer values specifying the handles of the selected nodes. An empty array if no nodes are selected.
    /// 
    /// </returns>
    public int[] GetSelectedRowHandles();
    /// <summary>
    /// 
    /// <para>
    /// Returns selected nodes.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// An array of nodes currently selected within a View.
    /// 
    /// </returns>
    public TreeListNode[] GetSelectedNodes();
    protected virtual void OnSelectedRowsSourceChanged();
    protected internal virtual void OnSelectionChanged(DevExpress.Data.SelectionChangedEventArgs e);
    protected void UpdateSelectedRows(DevExpress.Data.SelectionChangedEventArgs e);
    /// <summary>
    /// 
    /// <para>
    /// Copies the display values of selected nodes to the clipboard.
    /// 
    /// </para>
    /// 
    /// </summary>
    public void CopySelectedRowsToClipboard();
    /// <summary>
    /// 
    /// <para>
    /// Copies the values displayed within the focused node to the clipboard.
    /// 
    /// </para>
    /// 
    /// </summary>
    public override void CopyFocusedRowToClipboard();
    public void CopyRowsToClipboard(IEnumerable<int> rows);
    public void CopyRowsToClipboard(IEnumerable<TreeListNode> nodes);
    /// <summary>
    /// 
    /// <para>
    /// Copies the values displayed within the specified range of nodes, to the clipboard.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// <param name="startRowHandle">An integer value specifying the handle of the first node in the range.
    /// 
    ///             </param><param name="endRowHandle">An integer value specifying the handle of the last node in the range.
    /// 
    ///             </param>
    public void CopyRangeToClipboard(int startRowHandle, int endRowHandle);
    /// <summary>
    /// 
    /// <para>
    /// Copies the values displayed within the specified range of nodes, to the clipboard.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// <param name="startNode">A <see cref="T:DevExpress.Xpf.Grid.TreeListNode"/> object that is the first node in the range.
    /// 
    ///             </param><param name="endNode">A <see cref="T:DevExpress.Xpf.Grid.TreeListNode"/> object that is the last node in the range.
    /// 
    ///             </param>
    public void CopyRangeToClipboard(TreeListNode startNode, TreeListNode endNode);
    protected internal override void RaiseCopyingToClipboard(CopyingToClipboardEventArgsBase e);
    protected virtual bool OnDeserializeAllowProperty(AllowPropertyEventArgs e);
    protected virtual void OnSerializeStart();
    protected virtual void OnDeserializeStart(StartDeserializingEventArgs e);
    protected virtual void OnDeserializeEnd(EndDeserializingEventArgs e);
    protected virtual DefaultColumnChooserState ForceCreateColumnChooserState();
    /// <summary>
    /// 
    /// <para>
    /// Gets the width of the fit column. This is a dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <value>
    /// A <see cref="T:System.Double"/> value that specifies the column's width.
    /// 
    /// </value>
    [Description("Gets the width of the fit column. This is a dependency property.")]
    public double FitColumnWidth { get; private set; }
    /// <summary>
    /// 
    /// <para>
    /// Gets the width of the fit column's header. This is a dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <value>
    /// A <see cref="T:System.Double"/> value that specifies the column header's width.
    /// 
    /// </value>
    [Description("Gets the width of the fit column\'s header. This is a dependency property.")]
    public double HeaderFitColumnWidth { get; private set; }
    /// <summary>
    /// 
    /// <para>
    /// Returns the width of the fit column in additional rows (New Item Row or Auto Filter Row). This is a dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <value>
    /// A <see cref="T:System.Double"/> value that is the fit column's width.
    /// 
    /// 
    /// </value>
    [Description("Returns the width of the fit column in additional rows (New Item Row or Auto Filter Row). This is a dependency property.")]
    public double AdditionalRowFitColumnWidth { get; private set; }
    /// <summary>
    /// 
    /// <para>
    /// Gets the width of the row indicator header. This is a dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <value>
    /// A <see cref="T:System.Double"/> value that specifies the width of the row indicator header, in pixels.
    /// 
    /// </value>
    [Description("Gets the width of the row indicator header. This is a dependency property.")]
    public double IndicatorHeaderWidth { get; private set; }
    /// <summary>
    /// 
    /// <para>
    /// Gets the actual template selector that chooses a node template based on custom logic. This is a dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <value>
    /// A <see cref="T:System.Windows.Controls.DataTemplateSelector"/> descendant that chooses a template based on custom logic.
    /// 
    /// </value>
    [Description("Gets the actual template selector that chooses a node template based on custom logic. This is a dependency property.")]
    public DataTemplateSelector ActualDataRowTemplateSelector { get; private set; }
    /// <summary>
    /// 
    /// <para>
    /// Gets or sets the template that defines the presentation of a focused node's border. This is a dependency property.
    /// 
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <value>
    /// A <see cref="T:System.Windows.Controls.ControlTemplate"/> object that specifies the template that displays the border.
    /// 
    /// 
    /// </value>
    [Category("Appearance ")]
    [Description("Gets or sets the template that defines the presentation of a focused node\'s border. This is a dependency property.")]
    public ControlTemplate FocusedRowBorderTemplate { get; set; }
    /// <summary>
    /// 
    /// <para>
    /// This is a dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <value>
    /// [To be supplied]
    /// </value>
    [Category("Options Selection")]
    [XtraSerializableProperty]
    [Description("This is a dependency property.")]
    public TableViewSelectMode MultiSelectMode { get; set; }
    /// <summary>
    /// 
    /// <para>
    /// Gets or sets whether the TreeListView fetches child nodes of sub-level nodes when their parent node is being expanded. This is a dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <value>
    /// <b>true</b> to fetch child nodes of sub-level nodes when their parent node is being expanded; otherwise, <b>false</b>.
    /// 
    /// </value>
    [XtraSerializableProperty]
    public bool FetchSublevelChildrenOnExpand { get; set; }
    /// <summary>
    /// 
    /// <para>
    /// Gets or sets whether rows can be selected via the Row Indicator Panel. This is a dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <value>
    /// <b>true</b> if rows can be selected via the row indicator; otherwise, <b>false</b>. The default is <b>true</b>.
    /// 
    /// </value>
    [Category("Options Selection")]
    [Description("Gets or sets whether rows can be selected via the Row Indicator Panel. This is a dependency property.")]
    [XtraSerializableProperty]
    public bool UseIndicatorForSelection { get; set; }
    /// <summary>
    /// 
    /// <para>
    /// Gets or sets whether menu items used to fix a column to the left or right, are shown within a column's context menu. This is a dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <value>
    /// <b>true</b> to show items used to fix a column to the left or right, within a column's context menu; otherwise, <b>false</b>.
    /// 
    /// </value>
    [Category("Options Behavior")]
    [XtraSerializableProperty]
    [Description("Gets or sets whether menu items used to fix a column to the left or right, are shown within a column\'s context menu. This is a dependency property.")]
    public bool AllowFixedColumnMenu { get; set; }
    /// <summary>
    /// 
    /// <para>
    /// Gets or sets whether column headers are automatically scrolled once a user drags a column header to the View's left or right. This is a dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <value>
    /// <b>true</b> to allow horizontal scrolling of column headers; otherwise, <b>false</b>.
    /// 
    /// </value>
    [XtraSerializableProperty]
    [Category("Options Behavior")]
    [Description("Gets or sets whether column headers are automatically scrolled once a user drags a column header to the View\'s left or right. This is a dependency property.")]
    public bool AllowScrollHeaders { get; set; }
    /// <summary>
    /// 
    /// <para>
    /// This member supports the internal infrastructure and is not intended to be used directly from your code. This is a dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <value>
    /// @nbsp;
    /// 
    /// </value>
    [Description("This member supports the internal infrastructure and is not intended to be used directly from your code. This is a dependency property.")]
    [Browsable(false)]
    public Thickness ScrollingVirtualizationMargin { get; internal set; }
    /// <summary>
    /// 
    /// <para>
    /// This member supports the internal infrastructure and is not intended to be used directly from your code. This is a dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <value>
    /// @nbsp;
    /// 
    /// </value>
    [Browsable(false)]
    [Description("This member supports the internal infrastructure and is not intended to be used directly from your code. This is a dependency property.")]
    public Thickness ScrollingHeaderVirtualizationMargin { get; internal set; }
    /// <summary>
    /// 
    /// <para>
    /// This is a dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <value>
    /// [To be supplied]
    /// </value>
    [Description("This is a dependency property.")]
    [Category("Appearance ")]
    public Style RowStyle { get; set; }
    /// <summary>
    /// 
    /// <para>
    /// Gets or sets whether the Automatic Filter Row is displayed. This is a dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <value>
    /// <b>true</b> to show the automatic filter row; otherwise, <b>false</b>. The default is <b>false</b>.
    /// 
    /// </value>
    [Description("Gets or sets whether the Automatic Filter Row is displayed. This is a dependency property.")]
    [XtraSerializableProperty]
    [Category("Options Filter")]
    public bool ShowAutoFilterRow { get; set; }
    /// <summary>
    /// 
    /// <para>
    /// Gets or sets whether or not cascading data updates are allowed. This is a dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <value>
    /// <b>true</b> to allow cascading data updates; otherwise, <b>false</b>. The default is <b>false</b>.
    /// 
    /// </value>
    [Description("Gets or sets whether or not cascading data updates are allowed. This is a dependency property.")]
    [XtraSerializableProperty]
    [Category("Options View")]
    public bool AllowCascadeUpdate { get; set; }
    /// <summary>
    /// 
    /// <para>
    /// Gets or sets whether per-pixel scrolling is enabled or not. This is a dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <value>
    /// <b>true</b> to enable per-pixel scrolling; <b>false</b> to enable row by row scrolling.
    /// 
    /// </value>
    [XtraSerializableProperty]
    [Description("Gets or sets whether per-pixel scrolling is enabled or not. This is a dependency property.")]
    [Category("Options View")]
    public bool AllowPerPixelScrolling { get; set; }
    /// <summary>
    /// 
    /// <para>
    /// Gets or sets the scroll animation length. This is a dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <value>
    /// A <see cref="T:System.Double"/> value that specifies the animation length, in milliseconds.
    /// 
    /// </value>
    [Category("Options View")]
    [XtraSerializableProperty]
    [Description("Gets or sets the scroll animation length. This is a dependency property.")]
    public double ScrollAnimationDuration { get; set; }
    /// <summary>
    /// 
    /// <para>
    /// Gets or sets the per-pixel scrolling mode. This is a dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <value>
    /// A <see cref="T:DevExpress.Xpf.Grid.ScrollAnimationMode"/> enumeration value that specifies the per-pexel scrolling mode.
    /// 
    /// </value>
    [Description("Gets or sets the per-pixel scrolling mode. This is a dependency property.")]
    [XtraSerializableProperty]
    [Category("Options View")]
    public ScrollAnimationMode ScrollAnimationMode { get; set; }
    /// <summary>
    /// 
    /// <para>
    /// Gets an object that is the Auto Filter Row's data.
    /// 
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <value>
    /// A <see cref="T:DevExpress.Xpf.Grid.RowData"/> object that specifies the row's data.
    /// 
    /// 
    /// </value>
    [Description("Gets an object that is the Auto Filter Row\'s data.")]
    public RowData AutoFilterRowData { get; }
    /// <summary>
    /// 
    /// <para>
    /// Gets an object that is the New Item Row's data. This property is reserved for future use.
    /// 
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <value>
    /// A <see cref="T:DevExpress.Xpf.Grid.RowData"/> object that is the row's data.
    /// 
    /// 
    /// </value>
    [Browsable(false)]
    public RowData NewItemRowData { get; }
    /// <summary>
    /// 
    /// <para>
    /// Gets or sets a value indicating whether virtualization is enabled for horizontal scrolling. This is a dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <value>
    /// <b>true</b> to enable virtualization; <b>false</b> to disable it.
    /// 
    /// </value>
    [XtraSerializableProperty]
    [Description("Gets or sets a value indicating whether virtualization is enabled for horizontal scrolling. This is a dependency property.")]
    [Category("Options Behavior")]
    public bool AllowHorizontalScrollingVirtualization { get; set; }
    /// <summary>
    /// 
    /// <para>
    /// Gets or sets a node's minimum height. This is a dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <value>
    /// A <see cref="T:System.Double"/> value that specifies a row's minimum height.
    /// 
    /// </value>
    [Category("Appearance ")]
    [Description("Gets or sets a node\'s minimum height. This is a dependency property.")]
    public double RowMinHeight { get; set; }
    /// <summary>
    /// 
    /// <para>
    /// Gets or sets the minimum height of the Column Header Panel. This is a dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <value>
    /// A <see cref="T:System.Double"/> value that is the minimum height of the Column Header Panel.
    /// 
    /// </value>
    public double HeaderPanelMinHeight { get; set; }
    /// <summary>
    /// 
    /// <para>
    /// Gets or sets the node decoration template. This is a dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <value>
    /// A <see cref="T:System.Windows.Controls.ControlTemplate"/> object that is the node decoration template.
    /// 
    /// 
    /// </value>
    [Description("Gets or sets the node decoration template. This is a dependency property.")]
    [Category("Appearance ")]
    public ControlTemplate RowDecorationTemplate { get; set; }
    /// <summary>
    /// 
    /// <para>
    /// Gets the template that defines the default presentation of nodes. This is a dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <value>
    /// A <see cref="T:System.Windows.DataTemplate"/> object that defines the default presentation of nodes.
    /// 
    /// </value>
    [Browsable(false)]
    [Category("Appearance ")]
    public DataTemplate DefaultDataRowTemplate { get; set; }
    /// <summary>
    /// 
    /// <para>
    /// Gets or sets the template that defines the presentation of data rows. This is a dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <value>
    /// A <see cref="T:System.Windows.DataTemplate"/> object that defines the presentation of data rows.
    /// 
    /// </value>
    [Category("Appearance ")]
    [Description("Gets or sets the template that defines the presentation of data rows. This is a dependency property.")]
    public DataTemplate DataRowTemplate { get; set; }
    /// <summary>
    /// 
    /// <para>
    /// Gets or sets an object that chooses a node template based on custom logic. This is a dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <value>
    /// A <see cref="T:System.Windows.Controls.DataTemplateSelector"/> descendant that chooses a template based on custom logic.
    /// 
    /// </value>
    [Description("Gets or sets an object that chooses a node template based on custom logic. This is a dependency property.")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Category("Appearance ")]
    public DataTemplateSelector DataRowTemplateSelector { get; set; }
    /// <summary>
    /// 
    /// <para>
    /// Gets or sets the template that defines the presentation of a row indicator's content. This is a dependency property.
    /// 
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <value>
    /// A <see cref="T:System.Windows.DataTemplate"/> object that defines the presentation of row indicators.
    /// 
    /// </value>
    [Category("Appearance ")]
    [Description("Gets or sets the template that defines the presentation of a row indicator\'s content. This is a dependency property.")]
    public DataTemplate RowIndicatorContentTemplate { get; set; }
    /// <summary>
    /// 
    /// <para>
    /// Gets or sets a value specifying whether horizontal navigation keys move focus to the next/previous node when the current node's last/first cell is focused. This is a dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <value>
    /// <b>true</b> if horizontal navigation keys can move focus between nodes; otherwise, <b>false</b>. The default is <b>true</b>.
    /// 
    /// </value>
    [XtraSerializableProperty]
    [Description("Gets or sets a value specifying whether horizontal navigation keys move focus to the next/previous node when the current node\'s last/first cell is focused. This is a dependency property.")]
    [Category("Options Behavior")]
    public bool AutoMoveRowFocus { get; set; }
    /// <summary>
    /// 
    /// <para>
    /// Gets or sets the number of records taken into account when calculating the optimal widths required for columns to completely display their contents. This is a dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <value>
    /// An integer value that specifies the number of records processed by a View to apply <b>best fit</b>.
    /// 
    /// </value>
    [Category("BestFit")]
    [Description("Gets or sets the number of records taken into account when calculating the optimal widths required for columns to completely display their contents. This is a dependency property.")]
    [XtraSerializableProperty]
    public int BestFitMaxRowCount { get; set; }
    /// <summary>
    /// 
    /// <para>
    /// Gets or sets how the optimal width required for a column to completely display its contents is calculated. This is a dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <value>
    /// A <see cref="T:DevExpress.Xpf.Core.BestFitMode"/> enumeration value.
    /// 
    /// </value>
    [Description("Gets or sets how the optimal width required for a column to completely display its contents is calculated. This is a dependency property.")]
    [XtraSerializableProperty]
    [Category("BestFit")]
    public BestFitMode BestFitMode { get; set; }
    /// <summary>
    /// 
    /// <para>
    /// Gets or sets which interface elements are taken into account when calculating optimal width for columns. This is a dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <value>
    /// A <see cref="T:DevExpress.Xpf.Grid.BestFitArea"/> enumeration value that specifies interface elements that are taken into account when calculating optimal width for columns.
    /// 
    /// </value>
    [XtraSerializableProperty]
    [Description("Gets or sets which interface elements are taken into account when calculating optimal width for columns. This is a dependency property.")]
    [Category("BestFit")]
    public BestFitArea BestFitArea { get; set; }
    /// <summary>
    /// 
    /// <para>
    /// Gets or sets whether it's allowed to calculate optimal widths, and apply them to all columns displayed within a View. This is a dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <value>
    /// <b>true</b> to allow optimal widths to be calculated and applied to all columns displayed within a View; otherwise, <b>false</b>. The default is <b>true</b>.
    /// 
    /// </value>
    [Description("Gets or sets whether it\'s allowed to calculate optimal widths, and apply them to all columns displayed within a View. This is a dependency property.")]
    [XtraSerializableProperty]
    [Category("BestFit")]
    public bool AllowBestFit { get; set; }
    /// <summary>
    /// 
    /// <para>
    /// Gets or sets a value specifying whether the Indicator panel is displayed. This is a dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <value>
    /// <b>true</b> to display the node indicator panel; otherwise, <b>false</b>. The default is <b>true</b>.
    /// 
    /// </value>
    [XtraSerializableProperty]
    [Description("Gets or sets a value specifying whether the Indicator panel is displayed. This is a dependency property.")]
    [Category("Options View")]
    public bool ShowIndicator { get; set; }
    /// <summary>
    /// 
    /// <para>
    /// Gets or sets the width of the indicator panel. This is a dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <value>
    /// An integer value specifying the width of the indicator panel, in pixels.
    /// 
    /// </value>
    [Category("Appearance ")]
    [Description("Gets or sets the width of the indicator panel. This is a dependency property.")]
    [XtraSerializableProperty]
    public double IndicatorWidth { get; set; }
    /// <summary>
    /// 
    /// <para>
    /// Gets or sets whether vertical lines are displayed. This is a dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <value>
    /// <b>true</b> to display vertical lines; otherwise, <b>false</b>. The default is <b>true</b>.
    /// 
    /// </value>
    [Category("Options View")]
    [XtraSerializableProperty]
    [Description("Gets or sets whether vertical lines are displayed. This is a dependency property.")]
    public bool ShowVerticalLines { get; set; }
    /// <summary>
    /// 
    /// <para>
    /// Gets or sets whether horizontal lines are displayed. This is a dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <value>
    /// <b>true</b> to display horizontal lines; otherwise, <b>false</b>. The default is <b>true</b>.
    /// 
    /// </value>
    [Description("Gets or sets whether horizontal lines are displayed. This is a dependency property.")]
    [XtraSerializableProperty]
    [Category("Options View")]
    public bool ShowHorizontalLines { get; set; }
    /// <summary>
    /// 
    /// <para>
    /// Gets or sets whether column widths are automatically changed so that the total columns' width matches the grid's width. This is a dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <value>
    /// <b>true</b> to enable the column auto width feature; otherwise, <b>false</b>. The default is <b>false</b>.
    /// 
    /// </value>
    [XtraSerializableProperty]
    [Description("Gets or sets whether column widths are automatically changed so that the total columns\' width matches the grid\'s width. This is a dependency property.")]
    [Category("Options Behavior")]
    public bool AutoWidth { get; set; }
    /// <summary>
    /// 
    /// <para>
    /// Gets or sets whether an end-user can change column widths by dragging the edges of their headers. This is a dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <value>
    /// <b>true</b> to allow an end-user to change column widths; otherwise, <b>false</b>.
    /// 
    /// </value>
    [XtraSerializableProperty]
    [Category("Options Behavior")]
    [Description("Gets or sets whether an end-user can change column widths by dragging the edges of their headers. This is a dependency property.")]
    public bool AllowResizing { get; set; }
    /// <summary>
    /// 
    /// <para>
    /// Gets or sets the fixed line's width. This is a dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <value>
    /// A <see cref="T:System.Double"/> value that specifies the fixed line's width.
    /// 
    /// </value>
    [Category("Appearance ")]
    [Description("Gets or sets the fixed line\'s width. This is a dependency property.")]
    [XtraSerializableProperty]
    public double FixedLineWidth { get; set; }
    /// <summary>
    /// 
    /// <para>
    /// This member supports the internal infrastructure and is not intended to be used directly from your code. This is a dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <value>
    /// @nbsp;
    /// 
    /// </value>
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public double LeftDataAreaIndent { get; set; }
    /// <summary>
    /// 
    /// <para>
    /// This member supports the internal infrastructure and is not intended to be used directly from your code. This is a dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <value>
    /// @nbsp;
    /// 
    /// </value>
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Thickness RowPresenterMargin { get; set; }
    /// <summary>
    /// 
    /// <para>
    /// This member supports the internal infrastructure and is not intended to be used directly from your code. This is a dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <value>
    /// @nbsp;
    /// 
    /// </value>
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public double RightDataAreaIndent { get; set; }
    /// <summary>
    /// 
    /// <para>
    /// Returns the list of visible columns that are fixed to the left. This is a dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <value>
    /// The list of visible columns fixed to the left.
    /// 
    /// </value>
    [Description("Returns the list of visible columns that are fixed to the left. This is a dependency property.")]
    public IList<ColumnBase> FixedLeftVisibleColumns { get; private set; }
    /// <summary>
    /// 
    /// <para>
    /// Returns the list of visible columns that are fixed to the right. This is a dependency property.
    /// 
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <value>
    /// The list of visible columns fixed to the right.
    /// 
    /// </value>
    [Description("Returns the list of visible columns that are fixed to the right. This is a dependency property.")]
    public IList<ColumnBase> FixedRightVisibleColumns { get; private set; }
    /// <summary>
    /// 
    /// <para>
    /// Returns the list of visible columns that are not fixed within a View. This is a dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <value>
    /// The list of visible columns that are not fixed within a View.
    /// 
    /// </value>
    [Description("Returns the list of visible columns that are not fixed within a View. This is a dependency property.")]
    public IList<ColumnBase> FixedNoneVisibleColumns { get; private set; }
    /// <summary>
    /// 
    /// <para>
    /// Gets the width of the view's client area. This is a dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <value>
    /// A <see cref="T:System.Double"/> value that specifies the client area's width.
    /// 
    /// </value>
    [Description("Gets the width of the view\'s client area. This is a dependency property.")]
    public double HorizontalViewport { get; private set; }
    /// <summary>
    /// 
    /// <para>
    /// Gets or sets the style applied to data cells displayed within the Auto Filter Row. This is a dependency property.
    /// 
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <value>
    /// A <see cref="T:System.Windows.Style"/> object that specifies the style applied to data cells.
    /// 
    /// 
    /// </value>
    [Description("Gets or sets the style applied to data cells displayed within the Auto Filter Row. This is a dependency property.")]
    [Category("Appearance ")]
    public Style AutoFilterRowCellStyle { get; set; }
    /// <summary>
    /// 
    /// <para>
    /// Gets or sets the name of the 'children' field. This is a dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <value>
    /// A <see cref="T:System.String"/> value that specifies the 'children' field name.
    /// 
    /// </value>
    [Category("Options Behavior")]
    [XtraSerializableProperty]
    public string ChildNodesPath { get; set; }
    /// <summary>
    /// 
    /// <para>
    /// Gets or sets the tree derivation mode. This is a dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <value>
    /// A <see cref="T:DevExpress.Xpf.Grid.TreeDerivationMode"/> enumeration value that specifies the tree derivation mode.
    /// 
    /// </value>
    [Category("Options Behavior")]
    [XtraSerializableProperty]
    public TreeDerivationMode TreeDerivationMode { get; set; }
    /// <summary>
    /// 
    /// <para>
    /// Gets or sets a selector that returns the list of child nodes for the processed node. This is a dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <value>
    /// The child nodes selector.
    /// 
    /// </value>
    [Category("Options Behavior")]
    public IChildNodesSelector ChildNodesSelector { get; set; }
    /// <summary>
    /// 
    /// <para>
    /// Gets or sets whether all nodes are automatically expanded when the View is being loaded. This is a dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <value>
    /// <b>true</b> to expand all nodes when the View is being loaded; otherwise, <b>false</b>.
    /// 
    /// </value>
    [Category("Options Behavior")]
    [XtraSerializableProperty]
    public bool AutoExpandAllNodes { get; set; }
    /// <summary>
    /// 
    /// <para>
    /// Gets or sets the vertical scrollbar's visibility. This is a dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <value>
    /// A <see cref="T:System.Windows.Controls.ScrollBarVisibility"/> enumeration value that specifies the vertical scrollbar's visibility.
    /// 
    /// </value>
    public ScrollBarVisibility VerticalScrollbarVisibility { get; set; }
    /// <summary>
    /// 
    /// <para>
    /// Gets or sets the horizontal scrollbar's visibility. This is a dependence property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <value>
    /// A <see cref="T:System.Windows.Controls.ScrollBarVisibility"/> enumeration value that specifies the horizontal scrollbar's visibility.
    /// 
    /// </value>
    public ScrollBarVisibility HorizontalScrollbarVisibility { get; set; }
    /// <summary>
    /// 
    /// <para>
    /// Gets or sets the focused column. This is a dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <value>
    /// A <see cref="T:DevExpress.Xpf.Grid.GridColumn"/> object that is the focused column.
    /// 
    /// 
    /// </value>
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public ColumnBase FocusedColumn { get; set; }
    /// <summary>
    /// 
    /// <para>
    /// Gets or sets the name of the service field in a data source that contains unique values. This is a dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <value>
    /// A <see cref="T:System.String"/> value that specifies the name of the data source key field.
    /// 
    /// </value>
    [Category("Options Behavior")]
    [XtraSerializableProperty]
    [Description("Gets or sets the name of the service field in a data source that contains unique values. This is a dependency property.")]
    public string KeyFieldName { get; set; }
    /// <summary>
    /// 
    /// <para>
    /// Gets or sets the name of the service field in a data source that contains parent node values. This is a dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <value>
    /// A <see cref="T:System.String"/> value that contains parent node values.
    /// 
    /// </value>
    [XtraSerializableProperty]
    [Description("Gets or sets the name of the service field in a data source that contains parent node values. This is a dependency property.")]
    [Category("Options Behavior")]
    public string ParentFieldName { get; set; }
    /// <summary>
    /// 
    /// <para>
    /// Gets or sets the name of the field in a data source that contains node images. This is a dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <value>
    /// A <see cref="T:System.String"/> value that specifies the field name.
    /// 
    /// </value>
    [Category("Options Behavior")]
    [Description("Gets or sets the name of the field in a data source that contains node images. This is a dependency property.")]
    [XtraSerializableProperty]
    public string ImageFieldName { get; set; }
    /// <summary>
    /// 
    /// <para>
    /// Gets or sets a selector that chooses a node image based on custom logic. This is a dependency property.
    /// 
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <value>
    /// A <see cref="T:DevExpress.Xpf.Grid.TreeListNodeImageSelector"/> descendant that chooses a node image based on custom logic.
    /// 
    /// </value>
    public TreeListNodeImageSelector NodeImageSelector { get; set; }
    /// <summary>
    /// 
    /// <para>
    /// Gets or sets the root value. This is a dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <value>
    /// An object that specifies the root value.
    /// 
    /// </value>
    [Category("Options Behavior")]
    [Description("Gets or sets the root value. This is a dependency property.")]
    [XtraSerializableProperty]
    public object RootValue { get; set; }
    /// <summary>
    /// 
    /// <para>
    /// Gets or sets whether or not columns are automatically created for service fields in the underlying data source. This is a dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <value>
    /// <b>true</b> to automatically create columns for service fields in the underlying data source; otherwise, <b>false</b>.
    /// 
    /// </value>
    [Description("Gets or sets whether or not columns are automatically created for service fields in the underlying data source. This is a dependency property.")]
    [Category("Options Behavior")]
    public bool AutoPopulateServiceColumns { get; set; }
    /// <summary>
    /// 
    /// <para>
    /// Gets or sets the node indent. This is a dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <value>
    /// A <see cref="T:System.Double"/> value that specifies the node indent, in pixels.
    /// 
    /// </value>
    [Category("Options View")]
    [Description("Gets or sets the node indent. This is a dependency property.")]
    public double RowIndent { get; set; }
    /// <summary>
    /// 
    /// <para>
    /// Gets or sets whether to display node images or not. This is a dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <value>
    /// <b>true</b> to allow display node images; otherwise, <b>false</b>.
    /// 
    /// </value>
    [XtraSerializableProperty]
    [Description("Gets or sets whether to display node images or not. This is a dependency property.")]
    [Category("Options View")]
    public bool ShowNodeImages { get; set; }
    /// <summary>
    /// 
    /// <para>
    /// Gets or sets whether or not to show expand buttons. This is a dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <value>
    /// <b>true</b> to show expand buttons; otherwise, <b>false</b>.
    /// 
    /// </value>
    [Description("Gets or sets whether or not to show expand buttons. This is a dependency property.")]
    [XtraSerializableProperty]
    [Category("Options View")]
    public bool ShowExpandButtons { get; set; }
    /// <summary>
    /// 
    /// <para>
    /// Gets or sets whether or not to show an expand button for the root node.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <value>
    /// <b>true</b> to show the expand button for the root node; otherwise, <b>false</b>.
    /// 
    /// </value>
    [Description("Gets or sets whether or not to show an expand button for the root node.")]
    [Category("Options View")]
    [XtraSerializableProperty]
    public bool ShowRootIndent { get; set; }
    /// <summary>
    /// 
    /// <para>
    /// Gets or sets the style of tree lines used to connect nodes. This is a dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <value>
    /// A <see cref="T:DevExpress.Xpf.Grid.TreeListLineStyle"/> enumeration value that specifies the style of tree lines.
    /// 
    /// </value>
    [Category("Options View")]
    [XtraSerializableProperty]
    [Description("Gets or sets the style of tree lines used to connect nodes. This is a dependency property.")]
    public TreeListLineStyle TreeLineStyle { get; set; }
    /// <summary>
    /// 
    /// <para>
    /// Gets the list of visible columns. This is a dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <value>
    /// The list of visible columns.
    /// 
    /// </value>
    [Description("Gets the list of visible columns. This is a dependency property.")]
    public IList<ColumnBase> VisibleColumns { get; protected set; }
    /// <summary>
    /// 
    /// <para>
    /// Gets or sets the focused node. This is a dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <value>
    /// A <see cref="T:DevExpress.Xpf.Grid.TreeListNode"/> object that is the focused node.
    /// 
    /// </value>
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public TreeListNode FocusedNode { get; set; }
    /// <summary>
    /// 
    /// <para>
    /// Gets or sets whether to use the default content in case both the <see cref="P:DevExpress.Xpf.Grid.TreeListView.DataRowTemplate"/> and <see cref="P:DevExpress.Xpf.Grid.TreeListView.DataRowTemplateSelector"/> return <b>null</b>.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <value>
    /// <b>true</b> to use the default content; otherwise, <b>false</b>.
    /// 
    /// </value>
    public bool AllowDefaultContentForHierarchicalDataTemplate { get; set; }
    /// <summary>
    /// 
    /// <para>
    /// Gets the collection of root nodes.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <value>
    /// A <see cref="T:DevExpress.Xpf.Grid.TreeListNodeCollection"/> object that contains root nodes.
    /// 
    /// </value>
    [Description("Gets the collection of root nodes.")]
    public new TreeListNodeCollection Nodes { get; }
    protected internal override DataProviderBase DataProviderBase { get; }
    protected internal override bool NeedCellsWidthUpdateOnScrolling { get; }
    /// <summary>
    /// 
    /// <para>
    /// Gets the total number of nodes contained within the view.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <value>
    /// An integer value that specifies the total number of nodes.
    /// 
    /// </value>
    [Description("Gets the total number of nodes contained within the view.")]
    public int TotalNodesCount { get; }
    protected internal TreeListViewBehavior TreeListViewBehavior { get; }
    protected override bool ShouldChangeRowByTab { get; }
    protected override int FixedNoneColumnsCount { get; }
    protected TreeListBestFitCalculator BestFitCalculator { get; }
    double ITableView.LeftGroupAreaIndent { get; }
    double ITableView.RightGroupAreaIndent { get; }
    TableViewBehavior ITableView.TableViewBehavior { get; }
    double ITableView.FitColumnWidth { get; set; }
    double ITableView.HeaderFitColumnWidth { get; set; }
    double ITableView.AdditionalRowFitColumnWidth { get; set; }
    double ITableView.IndicatorHeaderWidth { get; set; }
    Thickness ITableView.ScrollingVirtualizationMargin { get; set; }
    Thickness ITableView.ScrollingHeaderVirtualizationMargin { get; set; }
    DataTemplateSelector ITableView.ActualDataRowTemplateSelector { get; set; }
    bool ITableView.IsEditing { get; }
    DataViewBase ITableView.ViewBase { get; }
    /// <summary>
    /// 
    /// <para>
    /// Gets data objects that correspond to nodes currently selected within a View.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <value>
    /// A <see cref="T:DevExpress.Xpf.Grid.SelectedRowsCollection"/> object that is the collection of data objects corresponding to selected nodes.
    /// 
    /// </value>
    [Description("Gets data objects that correspond to nodes currently selected within a View.")]
    [Browsable(false)]
    public SelectedRowsCollection SelectedRows { get; }
    /// <summary>
    /// 
    /// <para>
    /// Gets or sets the source of selected nodes. This is a dependency property.
    /// 
    /// </para>
    /// 
    /// </summary>
    /// 
    /// <value>
    /// The collection of selected nodes.
    /// 
    /// </value>
    public IList SelectedRowsSource { get; set; }
    protected internal bool IsDesignTime { get; }
    /// <summary>
    /// 
    /// <para>
    /// [To be supplied]
    /// </para>
    /// 
    /// </summary>
    [Category("BestFit")]
    public event CustomBestFitEventHandler CustomBestFit;
    /// <summary>
    /// 
    /// <para>
    /// Occurs before a node is expanded.
    /// 
    /// </para>
    /// 
    /// </summary>
    [Category("Events")]
    public event TreeListNodeAllowEventHandler NodeExpanding;
    /// <summary>
    /// 
    /// <para>
    /// Occurs after a node has been expanded.
    /// 
    /// </para>
    /// 
    /// </summary>
    [Category("Events")]
    public event TreeListNodeEventHandler NodeExpanded;
    /// <summary>
    /// 
    /// <para>
    /// Occurs before a node is collapsed and allowing the action to be canceled.
    /// 
    /// </para>
    /// 
    /// </summary>
    [Category("Events")]
    public event TreeListNodeAllowEventHandler NodeCollapsing;
    /// <summary>
    /// 
    /// <para>
    /// Occurs after a node has been collapsed.
    /// 
    /// </para>
    /// 
    /// </summary>
    [Category("Events")]
    public event TreeListNodeEventHandler NodeCollapsed;
    /// <summary>
    /// 
    /// <para>
    /// Fires when a node fails validation, or when it cannot be saved to a data source.
    /// 
    /// </para>
    /// 
    /// </summary>
    [Category("Events")]
    public event TreeListInvalidNodeExceptionEventHandler InvalidNodeException;
    /// <summary>
    /// 
    /// <para>
    /// Enables you to specify whether the focused node's data is valid, and whether the node can lose focus.
    /// 
    /// </para>
    /// 
    /// </summary>
    [Category("Events")]
    public event TreeListNodeValidationEventHandler ValidateNode;
    /// <summary>
    /// 
    /// <para>
    /// Enables you to specify whether the focused cell's data is valid, and whether the cell's editor can be closed.
    /// 
    /// </para>
    /// 
    /// </summary>
    [Category("Events")]
    public event TreeListCellValidationEventHandler ValidateCell;
    /// <summary>
    /// 
    /// <para>
    /// Enables data to be supplied to unbound columns.
    /// 
    /// </para>
    /// 
    /// </summary>
    [Category("Events")]
    public event TreeListUnboundColumnDataEventHandler CustomUnboundColumnData;
    /// <summary>
    /// 
    /// <para>
    /// Enables you to filter nodes using custom rules.
    /// 
    /// </para>
    /// 
    /// </summary>
    [Category("Events")]
    public event TreeListNodeFilterEventHandler CustomNodeFilter;
    /// <summary>
    /// 
    /// <para>
    /// Enables you to sort data using custom rules.
    /// 
    /// </para>
    /// 
    /// </summary>
    [Category("Events")]
    public event TreeListCustomColumnSortEventHandler CustomColumnSort;
    /// <summary>
    /// 
    /// <para>
    /// Enables custom display text to be provided for any data cell.
    /// 
    /// </para>
    /// 
    /// </summary>
    [Category("Events")]
    public event TreeListCustomColumnDisplayTextEventHandler CustomColumnDisplayText;
    /// <summary>
    /// 
    /// <para>
    /// Enables you to calculate summary values manually.
    /// 
    /// </para>
    /// 
    /// </summary>
    [Category("Events")]
    public event TreeListCustomSummaryEventHandler CustomSummary;
    /// <summary>
    /// 
    /// <para>
    /// Enables you to filter unique values displayed within a column's Filter Dropdown.
    /// 
    /// </para>
    /// 
    /// </summary>
    [Category("Events")]
    public event CustomColumnFilterListEventHandler CustomFiterPopupList;
    /// <summary>
    /// 
    /// <para>
    /// Occurs after the focused cell's editor has been shown.
    /// 
    /// </para>
    /// 
    /// </summary>
    [Category("Behavior")]
    public event TreeListEditorEventHandler ShownEditor;
    /// <summary>
    /// 
    /// <para>
    /// Enables you to prevent an end-user from activating editors of individual cells.
    /// 
    /// </para>
    /// 
    /// </summary>
    [Category("Behavior")]
    public event TreeListShowingEditorEventHandler ShowingEditor;
    /// <summary>
    /// 
    /// <para>
    /// Occurs after a cell's editor has been closed.
    /// 
    /// </para>
    /// 
    /// </summary>
    [Category("Behavior")]
    public event TreeListEditorEventHandler HiddenEditor;
    /// <summary>
    /// 
    /// <para>
    /// Occurs after a cell's value has been changed.
    /// 
    /// </para>
    /// 
    /// </summary>
    [Category("Behavior")]
    public event TreeListCellValueChangedEventHandler CellValueChanged;
    /// <summary>
    /// 
    /// <para>
    /// Enables you to provide custom animation played when grid data is vertically scrolled (per-pixel).
    /// 
    /// </para>
    /// 
    /// </summary>
    [Category("Options View")]
    public event CustomScrollAnimationEventHandler CustomScrollAnimation;
    /// <summary>
    /// 
    /// <para>
    /// Fires in response to changing the edit value.
    /// 
    /// </para>
    /// 
    /// </summary>
    [Category("Behavior")]
    public event TreeListCellValueChangedEventHandler CellValueChanging;
    /// <summary>
    /// 
    /// <para>
    /// Occurs when a node is double-clicked.
    /// 
    /// </para>
    /// 
    /// </summary>
    [Category("Behavior")]
    public event RowDoubleClickEventHandler RowDoubleClick;
    /// <summary>
    /// 
    /// <para>
    /// Occurs after node selection has been changed.
    /// 
    /// </para>
    /// 
    /// </summary>
    [Category("Behavior")]
    public event TreeListSelectionChangedEventHandler SelectionChanged;
    /// <summary>
    /// 
    /// <para>
    /// Occurs when data is copied to the clipboard, allowing you to manually copy required data.
    /// 
    /// </para>
    /// 
    /// </summary>
    [Category("Behavior")]
    public event TreeListCopyingToClipboardEventHandler CopyingToClipboard;
  }
}
