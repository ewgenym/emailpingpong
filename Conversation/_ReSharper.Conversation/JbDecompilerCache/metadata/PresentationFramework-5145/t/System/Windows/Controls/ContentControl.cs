// Type: System.Windows.Controls.ContentControl
// Assembly: PresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// Assembly location: C:\Windows\Microsoft.NET\Framework\v4.0.30319\WPF\PresentationFramework.dll

using System.Collections;
using System.ComponentModel;
using System.Windows;
using System.Windows.Markup;

namespace System.Windows.Controls
{
	/// <summary>
	/// Represents a control with a single piece of content of any type.
	/// </summary>
	[ContentProperty("Content")]
	[Localizability(LocalizationCategory.None, Readability = Readability.Unreadable)]
	[DefaultProperty("Content")]
	public class ContentControl : Control, IAddChild
	{
		/// <summary>
		/// Identifies the <see cref="P:System.Windows.Controls.ContentControl.Content"/> dependency property.
		/// </summary>
		/// 
		/// <returns>
		/// The identifier for the <see cref="P:System.Windows.Controls.ContentControl.Content"/> dependency property.
		/// </returns>
		public static readonly DependencyProperty ContentProperty;

		/// <summary>
		/// Identifies the <see cref="P:System.Windows.Controls.ContentControl.HasContent"/> dependency property.
		/// </summary>
		/// 
		/// <returns>
		/// The identifier for the <see cref="P:System.Windows.Controls.ContentControl.HasContent"/> dependency property.
		/// </returns>
		public static readonly DependencyProperty HasContentProperty;

		/// <summary>
		/// Identifies the <see cref="P:System.Windows.Controls.ContentControl.ContentTemplate"/> dependency property.
		/// </summary>
		/// 
		/// <returns>
		/// The identifier for the <see cref="P:System.Windows.Controls.ContentControl.ContentTemplate"/> dependency property.
		/// </returns>
		public static readonly DependencyProperty ContentTemplateProperty;

		/// <summary>
		/// Identifies the <see cref="P:System.Windows.Controls.ContentControl.ContentTemplateSelector"/> dependency property.
		/// </summary>
		/// 
		/// <returns>
		/// The identifier for the <see cref="P:System.Windows.Controls.ContentControl.ContentTemplateSelector"/> dependency property.
		/// </returns>
		public static readonly DependencyProperty ContentTemplateSelectorProperty;

		/// <summary>
		/// Identifies the <see cref="P:System.Windows.Controls.ContentControl.ContentStringFormat"/> dependency property.
		/// </summary>
		/// 
		/// <returns>
		/// The identifier for the <see cref="P:System.Windows.Controls.ContentControl.ContentStringFormat"/> dependency property.
		/// </returns>
		public static readonly DependencyProperty ContentStringFormatProperty;

		/// <summary>
		/// Initializes a new instance of the <see cref="T:System.Windows.Controls.ContentControl"/> class.
		/// </summary>
		public ContentControl();

		/// <summary>
		/// Indicates whether the <see cref="P:System.Windows.Controls.ContentControl.Content"/> property should be persisted.
		/// </summary>
		/// 
		/// <returns>
		/// true if the <see cref="P:System.Windows.Controls.ContentControl.Content"/> property should be persisted; otherwise, false.
		/// </returns>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public virtual bool ShouldSerializeContent();

		/// <summary>
		/// This type or member supports the Windows Presentation Foundation (WPF) infrastructure and is not intended to be used directly from your code.
		/// </summary>
		/// <param name="value">An object to add as a child.</param>
		void IAddChild.AddChild(object value);

		/// <summary>
		/// Adds a specified object as the child of a <see cref="T:System.Windows.Controls.ContentControl"/>.
		/// </summary>
		/// <param name="value">The object to add.</param>
		protected virtual void AddChild(object value);

		/// <summary>
		/// This type or member supports the Windows Presentation Foundation (WPF) infrastructure and is not intended to be used directly from your code.
		/// </summary>
		/// <param name="text">A string to add to the object.</param>
		void IAddChild.AddText(string text);

		/// <summary>
		/// Adds a specified text string to a <see cref="T:System.Windows.Controls.ContentControl"/>.
		/// </summary>
		/// <param name="text">The string to add.</param>
		protected virtual void AddText(string text);

		/// <summary>
		/// Called when the <see cref="P:System.Windows.Controls.ContentControl.Content"/> property changes.
		/// </summary>
		/// <param name="oldContent">The old value of the <see cref="P:System.Windows.Controls.ContentControl.Content"/> property.</param><param name="newContent">The new value of the <see cref="P:System.Windows.Controls.ContentControl.Content"/> property.</param>
		protected virtual void OnContentChanged(object oldContent, object newContent);

		/// <summary>
		/// Called when the <see cref="P:System.Windows.Controls.ContentControl.ContentTemplate"/> property changes.
		/// </summary>
		/// <param name="oldContentTemplate">The old value of the <see cref="P:System.Windows.Controls.ContentControl.ContentTemplate"/> property.</param><param name="newContentTemplate">The new value of the <see cref="P:System.Windows.Controls.ContentControl.ContentTemplate"/> property.</param>
		protected virtual void OnContentTemplateChanged(DataTemplate oldContentTemplate, DataTemplate newContentTemplate);

		/// <summary>
		/// Called when the <see cref="P:System.Windows.Controls.ContentControl.ContentTemplateSelector"/> property changes.
		/// </summary>
		/// <param name="oldContentTemplateSelector">The old value of the <see cref="P:System.Windows.Controls.ContentControl.ContentTemplateSelector"/> property.</param><param name="newContentTemplateSelector">The new value of the <see cref="P:System.Windows.Controls.ContentControl.ContentTemplateSelector"/> property.</param>
		protected virtual void OnContentTemplateSelectorChanged(DataTemplateSelector oldContentTemplateSelector, DataTemplateSelector newContentTemplateSelector);

		/// <summary>
		/// Occurs when the <see cref="P:System.Windows.Controls.ContentControl.ContentStringFormat"/> property changes.
		/// </summary>
		/// <param name="oldContentStringFormat">The old value of <see cref="P:System.Windows.Controls.ContentControl.ContentStringFormat"/>.</param><param name="newContentStringFormat">The new value of <see cref="P:System.Windows.Controls.ContentControl.ContentStringFormat"/>.</param>
		protected virtual void OnContentStringFormatChanged(string oldContentStringFormat, string newContentStringFormat);

		/// <summary>
		/// Gets an enumerator to the content control's logical child elements.
		/// </summary>
		/// 
		/// <returns>
		/// An enumerator. The default value is null.
		/// </returns>
		protected internal override IEnumerator LogicalChildren { get; }

		/// <summary>
		/// Gets or sets the content of a <see cref="T:System.Windows.Controls.ContentControl"/>.
		/// </summary>
		/// 
		/// <returns>
		/// An object that contains the control's content. The default value is null.
		/// </returns>
		[Bindable(true)]
		public object Content { get; set; }

		/// <summary>
		/// Gets a value that indicates whether the <see cref="T:System.Windows.Controls.ContentControl"/> contains content.
		/// </summary>
		/// 
		/// <returns>
		/// true if the <see cref="T:System.Windows.Controls.ContentControl"/> has content; otherwise false. The default value is false.
		/// </returns>
		[ReadOnly(true)]
		[Browsable(false)]
		public bool HasContent { get; }

		/// <summary>
		/// Gets or sets the data template used to display the content of the <see cref="T:System.Windows.Controls.ContentControl"/>.
		/// </summary>
		/// 
		/// <returns>
		/// A data template. The default value is null.
		/// </returns>
		[Bindable(true)]
		public DataTemplate ContentTemplate { get; set; }

		/// <summary>
		/// Gets or sets a template selector that enables an application writer to provide custom template-selection logic.
		/// </summary>
		/// 
		/// <returns>
		/// A data template selector. The default value is null.
		/// </returns>
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Bindable(true)]
		public DataTemplateSelector ContentTemplateSelector { get; set; }

		/// <summary>
		/// Gets or sets a composite string that specifies how to format the <see cref="P:System.Windows.Controls.ContentControl.Content"/> property if it is displayed as a string.
		/// </summary>
		/// 
		/// <returns>
		/// A composite string that specifies how to format the <see cref="P:System.Windows.Controls.ContentControl.Content"/> property if it is displayed as a string.
		/// </returns>
		[Bindable(true)]
		public string ContentStringFormat { get; set; }
	}
}
