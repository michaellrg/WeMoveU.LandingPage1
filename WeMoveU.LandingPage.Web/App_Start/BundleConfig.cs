using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace WeMoveU.LandingPage.Web.App_Start
{
    public class BundleConfig
    {// For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                     "~/Scripts/html5shiv.js",
                     "~/Scripts/jquery-1.8.3.min.js",
                     "~/Scripts/jquery.musemenu.js",
                     "~/Scripts/jquery.museoverlay.js",
                     "~/Scripts/jquery.musepolyfill.bgsize.js",
                     "~/ Scripts / jquery.scrolleffects.js",
                     "~/ Scripts / jquery.watch.js",
                     "~/ Scripts / museutils.js",
                     "~/ Scripts / jquery.musewpslideshow.js", 
                     "~/ Scripts / pie.js",
                     "~/ Scripts / touchswipe.js",
                     "~/ Scripts / webpro.js"
                     ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/site_global.css",
                      "~/Content/index.css"));
        }
        }
}