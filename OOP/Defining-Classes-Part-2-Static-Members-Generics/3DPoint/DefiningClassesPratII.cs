/// <summary>
/// 'Strarts the program '
/// </summary>
namespace DefiningClassesPartII
{
    using System;
    using System.Globalization;
    using System.Threading;

    /// <summary>
    /// 'Where the tings started '
    /// </summary>
    public class DefiningClassesPartIIMain
    {
        /// <summary>
        /// 'main method'
        /// </summary>
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Point3D point1 = new Point3D(1.5, 2.5, 3.5); //creating points for testing purposes
            Point3D point2 = new Point3D(-1, -4, 7);
            Point3D point3 = new Point3D(1, 2, 3);
            Point3D point4 = new Point3D(-1, -2, 3);
            Point3D point5 = new Point3D(1.25, 2.375, 3.8);

            Path testPath = new Path(); //creating a path of points for testing purposes

            testPath.AddPoint(point1);
            testPath.AddPoint(point2);
            testPath.AddPoint(point3);
            testPath.AddPoint(point4);
            testPath.AddPoint(point5);

            PathStorage.SavePath(testPath, "Path"); //saving the test points to the file "thePath.txt"

            Path loadedPath = PathStorage.LoadPath("..//..//thePath.txt"); //loading the saved file and printing the points

            for (int i = 0; i < loadedPath.ThePath.Count; i++)
            {
                Console.WriteLine(loadedPath.ThePath[i]);
            }
        }
    }
}
