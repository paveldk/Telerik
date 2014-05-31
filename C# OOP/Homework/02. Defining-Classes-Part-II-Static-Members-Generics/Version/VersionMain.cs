/*Create a [Version] attribute that can be applied to structures, classes, interfaces, 
 * enumerations and methods and holds a version in the format major.minor (e.g. 2.11). 
 * Apply the version attribute to a sample class and display its version at runtime.
 * */
namespace VersionTask
{
    using System;
    using System.Reflection;

    [Version("2", "13")]
    enum SomeEnum
    {
        MainMenu,
        GameWindow,
        AboutWindow,
        ControlWindow
    }

    [Version("1", "0")]
    class VersionMain
    {
        [Version("7", "16")]
        static int ReturnOne()
        {
            return 1;
        }

        [Version("1", "1")]
        static void Main()
        {
            // Version's of classes
            Type type = typeof(VersionMain);
            object[] customAttributes = type.GetCustomAttributes(false);

            if (customAttributes.Length > 0)
            {
                Console.WriteLine("This class has version {0}.{1}", (customAttributes[0] as Version).Major, (customAttributes[0] as Version).Minor);
            }

            // Version of methods
            MethodInfo[] methods = type.GetMethods(BindingFlags.Static | BindingFlags.NonPublic);

            foreach (MethodInfo method in methods)
            {
                object[] methodAttributes = method.GetCustomAttributes(false);

               Console.WriteLine("Method {0} has version {1}.{2}", method.Name, (methodAttributes[0] as Version).Major, (methodAttributes[0] as Version).Minor);
            }

            // Version of enumerations
            Type enumType = typeof(SomeEnum);

            object[] enumCustomAttributes = enumType.GetCustomAttributes(false);

            if (enumCustomAttributes.Length > 0 && enumCustomAttributes[0] is Version)
            {
                Console.WriteLine("Enum {0} has version {1}.{2}", enumType.Name, (enumCustomAttributes[0] as Version).Major, (enumCustomAttributes[0] as Version).Minor);
            }
        }
    }
}
