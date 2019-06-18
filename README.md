# HumorHack
Humor Hack is a website that includes humor and coding merchandise


NuGit packages installed structureMap.MVC5 and MOQ

This project contains a class library (HumorHack.Domain), a MVC (HumorHack.WebUI), and a Unit Test(HumorHack.UnitTest) note only download 
packages to HumorHack.WebUI. If packages are downloaded to the Library(HumorHack.Domain) or to the Unit test, everything will break horribly.
I also installed Ninject, Ninject.Web.Common, Ninject.MVC5 to HumorHack.WebUI and Microsoft.Aspnet.Mvc to HumorHack.Domain.

Bug: line 29 in ControllerConvention.cs file
Fix: In the DependencyResolution folder.  I commented out line 31 "scan.With(new ControllerConvention());" 
Also commented out the whole ControllerConventions.cs file.

