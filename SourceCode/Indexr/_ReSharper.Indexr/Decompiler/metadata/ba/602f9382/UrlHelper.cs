﻿// Type: System.Web.Mvc.UrlHelper
// Assembly: System.Web.Mvc, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// Assembly location: C:\Program Files\Microsoft ASP.NET\ASP.NET MVC 4\Assemblies\System.Web.Mvc.dll

using System.Web;
using System.Web.Routing;

namespace System.Web.Mvc
{
  /// <summary>
  /// Contains methods to build URLs for ASP.NET MVC within an application.
  /// </summary>
  public class UrlHelper
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="T:System.Web.Mvc.UrlHelper"/> class using the specified request context.
    /// </summary>
    /// <param name="requestContext">An object that contains information about the current request and about the route that it matched.</param><exception cref="T:System.ArgumentNullException">The <paramref name="requestContext"/> parameter is null.</exception>
    public UrlHelper(RequestContext requestContext);
    /// <summary>
    /// Initializes a new instance of the <see cref="T:System.Web.Mvc.UrlHelper"/> class by using the specified request context and route collection.
    /// </summary>
    /// <param name="requestContext">An object that contains information about the current request and about the route that it matched.</param><param name="routeCollection">A collection of routes.</param><exception cref="T:System.ArgumentNullException">The <paramref name="requestContext"/> or the <paramref name="routeCollection"/> parameter is null.</exception>
    public UrlHelper(RequestContext requestContext, RouteCollection routeCollection);
    /// <summary>
    /// Generates a fully qualified URL to an action method by using the specified action name.
    /// </summary>
    /// 
    /// <returns>
    /// The fully qualified URL to an action method.
    /// </returns>
    /// <param name="actionName">The name of the action method.</param>
    public string Action(string actionName);
    /// <summary>
    /// Generates a fully qualified URL to an action method by using the specified action name and route values.
    /// </summary>
    /// 
    /// <returns>
    /// The fully qualified URL to an action method.
    /// </returns>
    /// <param name="actionName">The name of the action method.</param><param name="routeValues">An object that contains the parameters for a route. The parameters are retrieved through reflection by examining the properties of the object. The object is typically created by using object initializer syntax.</param>
    public string Action(string actionName, object routeValues);
    /// <summary>
    /// Generates a fully qualified URL to an action method for the specified action name and route values.
    /// </summary>
    /// 
    /// <returns>
    /// The fully qualified URL to an action method.
    /// </returns>
    /// <param name="actionName">The name of the action method.</param><param name="routeValues">An object that contains the parameters for a route.</param>
    public string Action(string actionName, RouteValueDictionary routeValues);
    /// <summary>
    /// Generates a fully qualified URL to an action method by using the specified action name and controller name.
    /// </summary>
    /// 
    /// <returns>
    /// The fully qualified URL to an action method.
    /// </returns>
    /// <param name="actionName">The name of the action method.</param><param name="controllerName">The name of the controller.</param>
    public string Action(string actionName, string controllerName);
    /// <summary>
    /// Generates a fully qualified URL to an action method by using the specified action name, controller name, and route values.
    /// </summary>
    /// 
    /// <returns>
    /// The fully qualified URL to an action method.
    /// </returns>
    /// <param name="actionName">The name of the action method.</param><param name="controllerName">The name of the controller.</param><param name="routeValues">An object that contains the parameters for a route. The parameters are retrieved through reflection by examining the properties of the object. The object is typically created by using object initializer syntax.</param>
    public string Action(string actionName, string controllerName, object routeValues);
    /// <summary>
    /// Generates a fully qualified URL to an action method by using the specified action name, controller name, and route values.
    /// </summary>
    /// 
    /// <returns>
    /// The fully qualified URL to an action method.
    /// </returns>
    /// <param name="actionName">The name of the action method.</param><param name="controllerName">The name of the controller.</param><param name="routeValues">An object that contains the parameters for a route.</param>
    public string Action(string actionName, string controllerName, RouteValueDictionary routeValues);
    /// <summary>
    /// Generates a fully qualified URL to an action method by using the specified action name, controller name, route values, and protocol to use.
    /// </summary>
    /// 
    /// <returns>
    /// The fully qualified URL to an action method.
    /// </returns>
    /// <param name="actionName">The name of the action method.</param><param name="controllerName">The name of the controller.</param><param name="routeValues">An object that contains the parameters for a route. The parameters are retrieved through reflection by examining the properties of the object. The object is typically created by using object initializer syntax.</param><param name="protocol">The protocol for the URL, such as "http" or "https".</param>
    public string Action(string actionName, string controllerName, object routeValues, string protocol);
    /// <summary>
    /// Generates a fully qualified URL for an action method by using the specified action name, controller name, route values, protocol to use, and host name.
    /// </summary>
    /// 
    /// <returns>
    /// The fully qualified URL to an action method.
    /// </returns>
    /// <param name="actionName">The name of the action method.</param><param name="controllerName">The name of the controller.</param><param name="routeValues">An object that contains the parameters for a route.</param><param name="protocol">The protocol for the URL, such as "http" or "https".</param><param name="hostName">The host name for the URL.</param>
    public string Action(string actionName, string controllerName, RouteValueDictionary routeValues, string protocol, string hostName);
    /// <summary>
    /// Converts a virtual (relative) path to an application absolute path.
    /// </summary>
    /// 
    /// <returns>
    /// The application absolute path.
    /// </returns>
    /// <param name="contentPath">The virtual path of the content.</param>
    public string Content(string contentPath);
    /// <summary>
    /// Returns a string that contains a content URL.
    /// </summary>
    /// 
    /// <returns>
    /// A string that contains a content URL.
    /// </returns>
    /// <param name="contentPath">The content path.</param><param name="httpContext">The HTTP context.</param>
    public static string GenerateContentUrl(string contentPath, HttpContextBase httpContext);
    /// <summary>
    /// Encodes special characters in a URL string into character-entity equivalents.
    /// </summary>
    /// 
    /// <returns>
    /// An encoded URL string.
    /// </returns>
    /// <param name="url">The text to encode.</param>
    public string Encode(string url);
    /// <summary>
    /// Returns a string that contains a URL.
    /// </summary>
    /// 
    /// <returns>
    /// A string that contains a URL.
    /// </returns>
    /// <param name="routeName">The route name.</param><param name="actionName">The action name.</param><param name="controllerName">The controller name.</param><param name="protocol">The HTTP protocol.</param><param name="hostName">The host name.</param><param name="fragment">The fragment.</param><param name="routeValues">The route values.</param><param name="routeCollection">The route collection.</param><param name="requestContext">The request context.</param><param name="includeImplicitMvcValues">true to include implicit MVC values; otherwise false.</param>
    public static string GenerateUrl(string routeName, string actionName, string controllerName, string protocol, string hostName, string fragment, RouteValueDictionary routeValues, RouteCollection routeCollection, RequestContext requestContext, bool includeImplicitMvcValues);
    /// <summary>
    /// Returns a string that contains a URL.
    /// </summary>
    /// 
    /// <returns>
    /// A string that contains a URL.
    /// </returns>
    /// <param name="routeName">The route name.</param><param name="actionName">The action name.</param><param name="controllerName">The controller name.</param><param name="routeValues">The route values.</param><param name="routeCollection">The route collection.</param><param name="requestContext">The request context.</param><param name="includeImplicitMvcValues">true to include implicit MVC values; otherwise. false.</param>
    public static string GenerateUrl(string routeName, string actionName, string controllerName, RouteValueDictionary routeValues, RouteCollection routeCollection, RequestContext requestContext, bool includeImplicitMvcValues);
    /// <summary>
    /// Returns a value that indicates whether the URL is local.
    /// </summary>
    /// 
    /// <returns>
    /// true if the URL is local; otherwise, false.
    /// </returns>
    /// <param name="url">The URL.</param>
    public bool IsLocalUrl(string url);
    /// <summary>
    /// Generates a fully qualified URL for the specified route values.
    /// </summary>
    /// 
    /// <returns>
    /// The fully qualified URL.
    /// </returns>
    /// <param name="routeValues">An object that contains the parameters for a route. The parameters are retrieved through reflection by examining the properties of the object. The object is typically created by using object initializer syntax.</param>
    public string RouteUrl(object routeValues);
    /// <summary>
    /// Generates a fully qualified URL for the specified route values.
    /// </summary>
    /// 
    /// <returns>
    /// The fully qualified URL.
    /// </returns>
    /// <param name="routeValues">An object that contains the parameters for a route.</param>
    public string RouteUrl(RouteValueDictionary routeValues);
    /// <summary>
    /// Generates a fully qualified URL for the specified route name.
    /// </summary>
    /// 
    /// <returns>
    /// The fully qualified URL.
    /// </returns>
    /// <param name="routeName">The name of the route that is used to generate the URL.</param>
    public string RouteUrl(string routeName);
    /// <summary>
    /// Generates a fully qualified URL for the specified route values by using a route name.
    /// </summary>
    /// 
    /// <returns>
    /// The fully qualified URL.
    /// </returns>
    /// <param name="routeName">The name of the route that is used to generate the URL.</param><param name="routeValues">An object that contains the parameters for a route. The parameters are retrieved through reflection by examining the properties of the object. The object is typically created by using object initializer syntax.</param>
    public string RouteUrl(string routeName, object routeValues);
    /// <summary>
    /// Generates a fully qualified URL for the specified route values by using a route name.
    /// </summary>
    /// 
    /// <returns>
    /// The fully qualified URL.
    /// </returns>
    /// <param name="routeName">The name of the route that is used to generate the URL.</param><param name="routeValues">An object that contains the parameters for a route.</param>
    public string RouteUrl(string routeName, RouteValueDictionary routeValues);
    /// <summary>
    /// Generates a fully qualified URL for the specified route values by using a route name and the protocol to use.
    /// </summary>
    /// 
    /// <returns>
    /// The fully qualified URL.
    /// </returns>
    /// <param name="routeName">The name of the route that is used to generate the URL.</param><param name="routeValues">An object that contains the parameters for a route. The parameters are retrieved through reflection by examining the properties of the object. The object is typically created by using object initializer syntax.</param><param name="protocol">The protocol for the URL, such as "http" or "https".</param>
    public string RouteUrl(string routeName, object routeValues, string protocol);
    /// <summary>
    /// Generates a fully qualified URL for the specified route values by using the specified route name, protocol to use, and host name.
    /// </summary>
    /// 
    /// <returns>
    /// The fully qualified URL.
    /// </returns>
    /// <param name="routeName">The name of the route that is used to generate the URL.</param><param name="routeValues">An object that contains the parameters for a route.</param><param name="protocol">The protocol for the URL, such as "http" or "https".</param><param name="hostName">The host name for the URL.</param>
    public string RouteUrl(string routeName, RouteValueDictionary routeValues, string protocol, string hostName);
    /// <summary>
    /// Generates a fully qualified URL for the specified route values.
    /// </summary>
    /// 
    /// <returns>
    /// A fully qualified URL for the specified route values.
    /// </returns>
    /// <param name="routeName">The route name.</param><param name="routeValues">The route values.</param>
    public string HttpRouteUrl(string routeName, object routeValues);
    /// <summary>
    /// Generates a fully qualified URL for the specified route values.
    /// </summary>
    /// 
    /// <returns>
    /// A fully qualified URL for the specified route values.
    /// </returns>
    /// <param name="routeName">The route name.</param><param name="routeValues">The route values.</param>
    public string HttpRouteUrl(string routeName, RouteValueDictionary routeValues);
    /// <summary>
    /// Gets information about an HTTP request that matches a defined route.
    /// </summary>
    /// 
    /// <returns>
    /// The request context.
    /// </returns>
    public RequestContext RequestContext { get; }
    /// <summary>
    /// Gets a collection that contains the routes that are registered for the application.
    /// </summary>
    /// 
    /// <returns>
    /// The route collection.
    /// </returns>
    public RouteCollection RouteCollection { get; }
  }
}
