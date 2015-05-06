using System.IO;

namespace DefiningClassesPartII
{
    public static class PathStorage //problem4
    {
        public static void SavePath(Path path, string pathIdentifier) //saves the file in the main project directory
        {                                                             //where all the .cs files are
            using (StreamWriter sw = new StreamWriter("..//..//the" + pathIdentifier + ".txt"))
            {
                for (int i = 0; i < path.ThePath.Count; i++)
                {
                    sw.WriteLine(path.ThePath[i]);
                }
            }
        }

        public static Path LoadPath(string filePath)
        {
            Path path = new Path();

            using (StreamReader sr = new StreamReader(filePath))
            {
                while (sr.EndOfStream == false)
                {
                    string nextPointTxt = sr.ReadLine();
                    Point3D nextPoint = Point3D.Parse(nextPointTxt);
                    path.AddPoint(nextPoint);
                }
            }

            return path;
        }
    }
}