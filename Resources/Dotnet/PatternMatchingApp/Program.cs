using PatternMatching;

var s = Tryout.CreateShape("square");
var c = Tryout.CreateShape("circle");

Console.WriteLine(GeometricUtilities.ComputeArea(s));
Console.WriteLine(GeometricUtilities.ComputeArea(c));

Console.WriteLine(GeometricUtilities.ComputeAreaModernIs(s));
Console.WriteLine(GeometricUtilities.ComputeAreaModernIs(c));

Console.WriteLine(GeometricUtilities.ComputeArea_Version3(s));
Console.WriteLine(GeometricUtilities.ComputeArea_Version3(c));

var what = Tryout.CreateShape("       ");
Console.WriteLine(what);

var wrong = Tryout.CreateShape("trapezoid");
Console.WriteLine(wrong);

       