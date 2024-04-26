using Danial.Menu;
using Danial.Shapes;

Console.WriteLine("Hello,My names Danial");

//ShapeManager shapeManager = new ShapeManager();
ShapeManagerMenu menu = new ShapeManagerMenu(shapeManager);
menu.Select();