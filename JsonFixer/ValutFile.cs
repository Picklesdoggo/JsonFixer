using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonFixer
{
    public class ValutFile
    {

       
            public string FileName { get; set; }
            public string ReferencePath { get; set; }
            public string Creator { get; set; }
            public object[] ModsUsed { get; set; }
            public List<Object> Objects { get; set; }
            public string QuickbeltLayoutName { get; set; }
        

        public class Object
        {
            public int Index { get; set; }
            public int IsContainedIn { get; set; }
            public int QuickbeltSlotIndex { get; set; }
            public int InSlotOfRootObjectIndex { get; set; }
            public int InSlotOfElementIndex { get; set; }
            public List<Element> Elements { get; set; }
        }

        public class Element
        {
            public int Index { get; set; }
            public string ObjectID { get; set; }
            public string Type { get; set; }
            public Posoffset PosOffset { get; set; }
            public Orientationforward OrientationForward { get; set; }
            public Orientationup OrientationUp { get; set; }
            public int ObjectAttachedTo { get; set; }
            public int MountAttachedTo { get; set; }
            public object[] LoadedRoundsInChambers { get; set; }
            public object[] LoadedRoundsInMag { get; set; }
            public object[] GenericInts { get; set; }
            public object[] GenericStrings { get; set; }
            public object[] GenericVector3s { get; set; }
            public object[] GenericRotations { get; set; }
            public Flags Flags { get; set; }
        }

        public class Posoffset
        {
            public float x { get; set; }
            public float y { get; set; }
            public float z { get; set; }
        }

        public class Orientationforward
        {
            public float x { get; set; }
            public float y { get; set; }
            public float z { get; set; }
        }

        public class Orientationup
        {
            public float x { get; set; }
            public float y { get; set; }
            public float z { get; set; }
        }

        public class Flags
        {
            public string[] _keys { get; set; }
            public string[] _values { get; set; }
        }

    }
}
