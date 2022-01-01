/*
 * In order to add a new shape with NEW, UNREALIZED functionality, you will need:
 * 1. Create an interface with new functionality and inherit it from IArea. because any shape has an area.
 * 2. Create a new shape class and inherit from the new interface, for example: Cylinder, and implement the quality measurement function.
 * 3. Create an interface variable in Figure.cs, for example: Cylinder cylinder.
 * 4. In the general interface (ExtensionInterface), make it inheritable from the new interface: ExtensionInterface: Cylinder.
 * 5. Create a new constructor in Figure.cs and implement the CYLINDER interface.
 */
namespace FindArea.FigureS.Interfaces
{
    //Только в текущей DLL
    internal interface IExtensionInterface : IArea, IsRectengular
    {
    }
}
