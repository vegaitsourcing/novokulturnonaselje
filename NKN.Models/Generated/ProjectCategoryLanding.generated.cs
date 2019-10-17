//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v8.1.0
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

namespace NKN.Models.Generated
{
	/// <summary>Project Category Landing</summary>
	[PublishedModel("projectCategoryLanding")]
	public partial class ProjectCategoryLanding : PublishedContentModel, IBanner, IPage, ISiteSettings
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new const string ModelTypeAlias = "projectCategoryLanding";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ProjectCategoryLanding, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public ProjectCategoryLanding(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("image")]
		public IPublishedContent Image => this.Value<IPublishedContent>("image");

		///<summary>
		/// Items
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("items")]
		public IEnumerable<FutureProjectItem> Items => this.Value<IEnumerable<FutureProjectItem>>("items");

		///<summary>
		/// Newsletter Block
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("newsletterBlock")]
		public IEnumerable<NewsletterBlock> NewsletterBlock => this.Value<IEnumerable<NewsletterBlock>>("newsletterBlock");

		///<summary>
		/// Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("text")]
		public IHtmlString Text => this.Value<IHtmlString>("text");

		///<summary>
		/// Banner Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("bannerImage")]
		public IPublishedContent BannerImage => Banner.GetBannerImage(this);

		///<summary>
		/// Alternate Languages: Language codes (en-US, en-GB etc).
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("alternateLanguages")]
		public IEnumerable<string> AlternateLanguages => Page.GetAlternateLanguages(this);

		///<summary>
		/// Alternate Pages
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("alternatePages")]
		public IEnumerable<IPublishedContent> AlternatePages => Page.GetAlternatePages(this);

		///<summary>
		/// Canonical Link: The page canonical link.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("canonicalLink")]
		public Umbraco.Web.Models.Link CanonicalLink => Page.GetCanonicalLink(this);

		///<summary>
		/// External Redirect: Redirects to provided external URL.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("externalRedirect")]
		public string ExternalRedirect => Page.GetExternalRedirect(this);

		///<summary>
		/// Hide From Search Engines: Hides page from search engines like Google, Yahoo etc.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("hideFromSearchEngines")]
		public bool HideFromSearchEngines => Page.GetHideFromSearchEngines(this);

		///<summary>
		/// Hide From Sitemap: If selected, the node will be hidden from the sitemap.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("hideFromSitemap")]
		public bool HideFromSitemap => Page.GetHideFromSitemap(this);

		///<summary>
		/// Hide From Site Search: Hides page from the site search.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("hideFromSiteSearch")]
		public bool HideFromSiteSearch => Page.GetHideFromSiteSearch(this);

		///<summary>
		/// Page Title: The page title.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("pageTitle")]
		public string PageTitle => Page.GetPageTitle(this);

		///<summary>
		/// Seo Description: The page SEO description.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("seoDescription")]
		public string SeoDescription => Page.GetSeoDescription(this);

		///<summary>
		/// Seo Keywords: The page SEO keywords.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("seoKeywords")]
		public string SeoKeywords => Page.GetSeoKeywords(this);

		///<summary>
		/// Seo Title: The page SEO title.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("seoTitle")]
		public string SeoTitle => Page.GetSeoTitle(this);

		///<summary>
		/// Sitemap Change Frequency: The expected change frequency of the page, associated with the sitemap used by search engines.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("sitemapChangeFrequency")]
		public string SitemapChangeFrequency => Page.GetSitemapChangeFrequency(this);

		///<summary>
		/// Sitemap Priority: Priority of the page, associated with the sitemap used by search engines.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("sitemapPriority")]
		public string SitemapPriority => Page.GetSitemapPriority(this);

		///<summary>
		/// Hide From Site Navigation: If selected, the node will be hidden from site navigation.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide => Page.GetUmbracoNaviHide(this);

		///<summary>
		/// Internal Redirect: Redirects to selected Umbraco node.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("umbracoRedirect")]
		public IPublishedContent UmbracoRedirect => Page.GetUmbracoRedirect(this);

		///<summary>
		/// URL Alias: Alternative URLs of the node. Separate with commas.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("umbracoUrlAlias")]
		public string UmbracoUrlAlias => Page.GetUmbracoUrlAlias(this);

		///<summary>
		/// URL Name: Enables overriding default URL of the node.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("umbracoUrlName")]
		public string UmbracoUrlName => Page.GetUmbracoUrlName(this);

		///<summary>
		/// Canonical Domain: The site canonical domain.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("canonicalDomain")]
		public string CanonicalDomain => SiteSettings.GetCanonicalDomain(this);

		///<summary>
		/// Google Analytics Script Code
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("googleAnalyticsScriptCode")]
		public string GoogleAnalyticsScriptCode => SiteSettings.GetGoogleAnalyticsScriptCode(this);

		///<summary>
		/// Google Tag Manager Non-Script Code
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("googleTagManagerNonScriptCode")]
		public string GoogleTagManagerNonScriptCode => SiteSettings.GetGoogleTagManagerNonScriptCode(this);

		///<summary>
		/// Google Tag Manager Script Code
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("googleTagManagerScriptCode")]
		public string GoogleTagManagerScriptCode => SiteSettings.GetGoogleTagManagerScriptCode(this);

		///<summary>
		/// Hide All Pages From Search Engines: This will create robots meta tag with "noindex,nofollow" value. Note: this should be unchecked on the live site.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("hideAllPagesFromSearchEngines")]
		public bool HideAllPagesFromSearchEngines => SiteSettings.GetHideAllPagesFromSearchEngines(this);

		///<summary>
		/// Robots: Content that will be served when Robots.txt is requested.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("robots")]
		public string Robots => SiteSettings.GetRobots(this);

		///<summary>
		/// Site Name: The site name.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("siteName")]
		public string SiteName => SiteSettings.GetSiteName(this);
	}
}
