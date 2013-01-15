// Type: System.Web.Mvc.Html.ValidationExtensions
// Assembly: System.Web.Mvc, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// Assembly location: C:\Program Files\Microsoft ASP.NET\ASP.NET MVC 4\Assemblies\System.Web.Mvc.dll

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web.Mvc;

namespace System.Web.Mvc.Html
{
  /// <summary>
  /// Provides support for validating the input from an HTML form.
  /// </summary>
  public static class ValidationExtensions
  {
    /// <summary>
    /// Retrieves the validation metadata for the specified model and applies each rule to the data field.
    /// </summary>
    /// <param name="htmlHelper">The HTML helper instance that this method extends.</param><param name="modelName">The name of the property or model object that is being validated.</param><exception cref="T:System.ArgumentNullException">The <paramref name="modelName"/> parameter is null.</exception>
    public static void Validate(this HtmlHelper htmlHelper, string modelName);
    /// <summary>
    /// Retrieves the validation metadata for the specified model and applies each rule to the data field.
    /// </summary>
    /// <param name="htmlHelper">The HTML helper instance that this method extends.</param><param name="expression">An expression that identifies the object that contains the properties to render.</param><typeparam name="TModel">The type of the model.</typeparam><typeparam name="TProperty">The type of the property.</typeparam>
    public static void ValidateFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression);
    /// <summary>
    /// Displays a validation message if an error exists for the specified field in the <see cref="T:System.Web.Mvc.ModelStateDictionary"/> object.
    /// </summary>
    /// 
    /// <returns>
    /// If the property or object is valid, an empty string; otherwise, a span element that contains an error message.
    /// </returns>
    /// <param name="htmlHelper">The HTML helper instance that this method extends.</param><param name="modelName">The name of the property or model object that is being validated.</param>
    public static MvcHtmlString ValidationMessage(this HtmlHelper htmlHelper, string modelName);
    /// <summary>
    /// Displays a validation message if an error exists for the specified field in the <see cref="T:System.Web.Mvc.ModelStateDictionary"/> object.
    /// </summary>
    /// 
    /// <returns>
    /// If the property or object is valid, an empty string; otherwise, a span element that contains an error message.
    /// </returns>
    /// <param name="htmlHelper">The HTML helper instance that this method extends.</param><param name="modelName">The name of the property or model object that is being validated.</param><param name="htmlAttributes">An object that contains the HTML attributes for the element. </param>
    public static MvcHtmlString ValidationMessage(this HtmlHelper htmlHelper, string modelName, object htmlAttributes);
    /// <summary>
    /// Displays a validation message if an error exists for the specified field in the <see cref="T:System.Web.Mvc.ModelStateDictionary"/> object.
    /// </summary>
    /// 
    /// <returns>
    /// If the property or object is valid, an empty string; otherwise, a span element that contains an error message.
    /// </returns>
    /// <param name="htmlHelper">The HTML helper instance that this method extends.</param><param name="modelName">The name of the property or model object that is being validated.</param><param name="validationMessage">The message to display if the specified field contains an error.</param>
    public static MvcHtmlString ValidationMessage(this HtmlHelper htmlHelper, string modelName, string validationMessage);
    /// <summary>
    /// Displays a validation message if an error exists for the specified field in the <see cref="T:System.Web.Mvc.ModelStateDictionary"/> object.
    /// </summary>
    /// 
    /// <returns>
    /// If the property or object is valid, an empty string; otherwise, a span element that contains an error message.
    /// </returns>
    /// <param name="htmlHelper">The HTML helper instance that this method extends.</param><param name="modelName">The name of the property or model object that is being validated.</param><param name="validationMessage">The message to display if the specified field contains an error.</param><param name="htmlAttributes">An object that contains the HTML attributes for the element. </param>
    public static MvcHtmlString ValidationMessage(this HtmlHelper htmlHelper, string modelName, string validationMessage, object htmlAttributes);
    /// <summary>
    /// Displays a validation message if an error exists for the specified field in the <see cref="T:System.Web.Mvc.ModelStateDictionary"/> object.
    /// </summary>
    /// 
    /// <returns>
    /// If the property or object is valid, an empty string; otherwise, a span element that contains an error message.
    /// </returns>
    /// <param name="htmlHelper">The HTML helper instance that this method extends.</param><param name="modelName">The name of the property or model object that is being validated.</param><param name="htmlAttributes">An object that contains the HTML attributes for the element.</param>
    public static MvcHtmlString ValidationMessage(this HtmlHelper htmlHelper, string modelName, IDictionary<string, object> htmlAttributes);
    /// <summary>
    /// Displays a validation message if an error exists for the specified field in the <see cref="T:System.Web.Mvc.ModelStateDictionary"/> object.
    /// </summary>
    /// 
    /// <returns>
    /// If the property or object is valid, an empty string; otherwise, a span element that contains an error message.
    /// </returns>
    /// <param name="htmlHelper">The HTML helper instance that this method extends.</param><param name="modelName">The name of the property or model object that is being validated.</param><param name="validationMessage">The message to display if the specified field contains an error.</param><param name="htmlAttributes">An object that contains the HTML attributes for the element.</param>
    public static MvcHtmlString ValidationMessage(this HtmlHelper htmlHelper, string modelName, string validationMessage, IDictionary<string, object> htmlAttributes);
    /// <summary>
    /// Returns the HTML markup for a validation-error message for each data field that is represented by the specified expression.
    /// </summary>
    /// 
    /// <returns>
    /// If the property or object is valid, an empty string; otherwise, a span element that contains an error message.
    /// </returns>
    /// <param name="htmlHelper">The HTML helper instance that this method extends.</param><param name="expression">An expression that identifies the object that contains the properties to render.</param><typeparam name="TModel">The type of the model.</typeparam><typeparam name="TProperty">The type of the property.</typeparam>
    public static MvcHtmlString ValidationMessageFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression);
    /// <summary>
    /// Returns the HTML markup for a validation-error message for each data field that is represented by the specified expression, using the specified message.
    /// </summary>
    /// 
    /// <returns>
    /// If the property or object is valid, an empty string; otherwise, a span element that contains an error message.
    /// </returns>
    /// <param name="htmlHelper">The HTML helper instance that this method extends.</param><param name="expression">An expression that identifies the object that contains the properties to render.</param><param name="validationMessage">The message to display if the specified field contains an error.</param><typeparam name="TModel">The type of the model.</typeparam><typeparam name="TProperty">The type of the property.</typeparam>
    public static MvcHtmlString ValidationMessageFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression, string validationMessage);
    /// <summary>
    /// Returns the HTML markup for a validation-error message for each data field that is represented by the specified expression, using the specified message and HTML attributes.
    /// </summary>
    /// 
    /// <returns>
    /// If the property or object is valid, an empty string; otherwise, a span element that contains an error message.
    /// </returns>
    /// <param name="htmlHelper">The HTML helper instance that this method extends.</param><param name="expression">An expression that identifies the object that contains the properties to render.</param><param name="validationMessage">The message to display if the specified field contains an error.</param><param name="htmlAttributes">An object that contains the HTML attributes for the element.</param><typeparam name="TModel">The type of the model.</typeparam><typeparam name="TProperty">The type of the property.</typeparam>
    public static MvcHtmlString ValidationMessageFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression, string validationMessage, object htmlAttributes);
    /// <summary>
    /// Returns the HTML markup for a validation-error message for each data field that is represented by the specified expression, using the specified message and HTML attributes.
    /// </summary>
    /// 
    /// <returns>
    /// If the property or object is valid, an empty string; otherwise, a span element that contains an error message.
    /// </returns>
    /// <param name="htmlHelper">The HTML helper instance that this method extends.</param><param name="expression">An expression that identifies the object that contains the properties to render.</param><param name="validationMessage">The message to display if the specified field contains an error.</param><param name="htmlAttributes">An object that contains the HTML attributes for the element.</param><typeparam name="TModel">The type of the model.</typeparam><typeparam name="TProperty">The type of the property.</typeparam>
    public static MvcHtmlString ValidationMessageFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression, string validationMessage, IDictionary<string, object> htmlAttributes);
    /// <summary>
    /// Returns an unordered list (ul element) of validation messages that are in the <see cref="T:System.Web.Mvc.ModelStateDictionary"/> object.
    /// </summary>
    /// 
    /// <returns>
    /// A string that contains an unordered list (ul element) of validation messages.
    /// </returns>
    /// <param name="htmlHelper">The HTML helper instance that this method extends.</param>
    public static MvcHtmlString ValidationSummary(this HtmlHelper htmlHelper);
    /// <summary>
    /// Returns an unordered list (ul element) of validation messages that are in the <see cref="T:System.Web.Mvc.ModelStateDictionary"/> object and optionally displays only model-level errors.
    /// </summary>
    /// 
    /// <returns>
    /// A string that contains an unordered list (ul element) of validation messages.
    /// </returns>
    /// <param name="htmlHelper">The HTML helper instance that this method extends.</param><param name="excludePropertyErrors">true to have the summary display model-level errors only, or false to have the summary display all errors.</param>
    public static MvcHtmlString ValidationSummary(this HtmlHelper htmlHelper, bool excludePropertyErrors);
    /// <summary>
    /// Returns an unordered list (ul element) of validation messages that are in the <see cref="T:System.Web.Mvc.ModelStateDictionary"/> object.
    /// </summary>
    /// 
    /// <returns>
    /// A string that contains an unordered list (ul element) of validation messages.
    /// </returns>
    /// <param name="htmlHelper">The HMTL helper instance that this method extends.</param><param name="message">The message to display if the specified field contains an error.</param>
    public static MvcHtmlString ValidationSummary(this HtmlHelper htmlHelper, string message);
    /// <summary>
    /// Returns an unordered list (ul element) of validation messages that are in the <see cref="T:System.Web.Mvc.ModelStateDictionary"/> object and optionally displays only model-level errors.
    /// </summary>
    /// 
    /// <returns>
    /// A string that contains an unordered list (ul element) of validation messages.
    /// </returns>
    /// <param name="htmlHelper">The HTML helper instance that this method extends.</param><param name="excludePropertyErrors">true to have the summary display model-level errors only, or false to have the summary display all errors.</param><param name="message">The message to display with the validation summary.</param>
    public static MvcHtmlString ValidationSummary(this HtmlHelper htmlHelper, bool excludePropertyErrors, string message);
    /// <summary>
    /// Returns an unordered list (ul element) of validation messages in the <see cref="T:System.Web.Mvc.ModelStateDictionary"/> object.
    /// </summary>
    /// 
    /// <returns>
    /// A string that contains an unordered list (ul element) of validation messages.
    /// </returns>
    /// <param name="htmlHelper">The HTML helper instance that this method extends.</param><param name="message">The message to display if the specified field contains an error.</param><param name="htmlAttributes">An object that contains the HTML attributes for the element. </param>
    public static MvcHtmlString ValidationSummary(this HtmlHelper htmlHelper, string message, object htmlAttributes);
    /// <summary>
    /// Returns an unordered list (ul element) of validation messages that are in the <see cref="T:System.Web.Mvc.ModelStateDictionary"/> object and optionally displays only model-level errors.
    /// </summary>
    /// 
    /// <returns>
    /// A string that contains an unordered list (ul element) of validation messages.
    /// </returns>
    /// <param name="htmlHelper">The HTML helper instance that this method extends.</param><param name="excludePropertyErrors">true to have the summary display model-level errors only, or false to have the summary display all errors.</param><param name="message">The message to display with the validation summary.</param><param name="htmlAttributes">An object that contains the HTML attributes for the element.</param>
    public static MvcHtmlString ValidationSummary(this HtmlHelper htmlHelper, bool excludePropertyErrors, string message, object htmlAttributes);
    /// <summary>
    /// Returns an unordered list (ul element) of validation messages that are in the <see cref="T:System.Web.Mvc.ModelStateDictionary"/> object.
    /// </summary>
    /// 
    /// <returns>
    /// A string that contains an unordered list (ul element) of validation messages.
    /// </returns>
    /// <param name="htmlHelper">The HTML helper instance that this method extends.</param><param name="message">The message to display if the specified field contains an error.</param><param name="htmlAttributes">A dictionary that contains the HTML attributes for the element.</param>
    public static MvcHtmlString ValidationSummary(this HtmlHelper htmlHelper, string message, IDictionary<string, object> htmlAttributes);
    /// <summary>
    /// Returns an unordered list (ul element) of validation messages that are in the <see cref="T:System.Web.Mvc.ModelStateDictionary"/> object and optionally displays only model-level errors.
    /// </summary>
    /// 
    /// <returns>
    /// A string that contains an unordered list (ul element) of validation messages.
    /// </returns>
    /// <param name="htmlHelper">The HTML helper instance that this method extends.</param><param name="excludePropertyErrors">true to have the summary display model-level errors only, or false to have the summary display all errors.</param><param name="message">The message to display with the validation summary.</param><param name="htmlAttributes">A dictionary that contains the HTML attributes for the element.</param>
    public static MvcHtmlString ValidationSummary(this HtmlHelper htmlHelper, bool excludePropertyErrors, string message, IDictionary<string, object> htmlAttributes);
    /// <summary>
    /// Gets or sets the name of the resource file (class key) that contains localized string values.
    /// </summary>
    /// 
    /// <returns>
    /// The name of the resource file (class key).
    /// </returns>
    public static string ResourceClassKey { get; set; }
  }
}
