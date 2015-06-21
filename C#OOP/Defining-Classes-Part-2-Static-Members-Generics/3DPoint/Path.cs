namespace DefiningClassesPartII
{
    using System.Collections.Generic;
    public class Path
    {
        List<Point3D> sequence = new List<Point3D>();

        public List<Point3D> ThePath { get; private set; }

        public void AddPoint(Point3D point)
        {
            this.sequence.Add(point);
        }
        public void RemovePoint(Point3D point)
        {
            this.sequence.Remove(point);
        }
    }
}
