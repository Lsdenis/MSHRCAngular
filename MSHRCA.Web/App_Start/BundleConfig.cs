using System.Web;
using System.Web.Optimization;

namespace MSHRCA.Web
{
	public class BundleConfig
	{
		// For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
		public static void RegisterBundles(BundleCollection bundles)
		{
			bundles.Add(new StyleBundle("~/Bundles/Stylesheets").Include("~/Content/*.css"));

			bundles.Add(new ScriptBundle("~/Bundles/Jquery").Include("~/Scripts/jquery-{version}.js", "~/Scripts/jquery.validate.min.js"));
			bundles.Add(new ScriptBundle("~/Bundles/Angular").Include("~/Scripts/Angular/angular.js", "~/Scripts/Angular/angular.route.js"));
			bundles.Add(new ScriptBundle("~/Bundles/Application")
			.IncludeDirectory("~/Scripts/Angular/Controllers", "*.js")
			.IncludeDirectory("~/Scripts/Angular/Factories", "*.js")
			.Include("~/Scripts/Angular/application.js"));
			bundles.Add(new ScriptBundle("~/Bundles/Scripts").Include("~/Scripts/fastclick.js", "~/Scripts/foundation.min.js", "~/Scripts/moment.min.js"));
		}
	}
}
