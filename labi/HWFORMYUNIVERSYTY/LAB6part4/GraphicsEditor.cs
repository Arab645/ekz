using System;
using System.Collections.Generic;

namespace LAB6part4
{
    public class GraphicsEditor
    {
        private List<GraphicPrimitive> primitives = new List<GraphicPrimitive>();

        public void AddPrimitive(GraphicPrimitive primitive)
        {
            primitives.Add(primitive);
        }

        public void DrawAll()
        {
            foreach (var primitive in primitives)
            {
                primitive.Draw();
            }
        }

        public IEnumerable<GraphicPrimitive> GetPrimitives()
        {
            return primitives;
        }
    }
}