using System;
using System.Collections.Generic;
using System.Reflection;

namespace CSharpReflectionTest
{
    public class ReflectionTest
    {
        public int i = 123;
        public float f = 123.45f;
        public bool b = true;
        public string s = "string1234";

        public void SetValue(string name, object value)
        {
            Type t = this.GetType();
            t.GetField(name).SetValue(this, value);
        }

        public object GetValue(string name)
        {
            Type t = this.GetType();
            return t.GetField(name).GetValue(this);
        }

        public Type GetFieldType(string name)
        {
            Type t = this.GetType();
            return t.GetField(name).FieldType;
        }

        public string[] GetFieldNames()
        {
            List<string> names = new List<string>();

            Type t = this.GetType();
            FieldInfo[] infos = t.GetFields();
            foreach (FieldInfo i in infos)
            {
                names.Add(i.Name);
            }
            return names.ToArray();
        }

        public void PrintFields()
        {
            Type t = this.GetType();
            FieldInfo[] infos = t.GetFields();
            foreach (FieldInfo i in infos)
            {
                Console.WriteLine("Name=" + i.Name + ", Type=" + i.FieldType);
            }
        }

        public void PrintFieldValues()
        {
            Type t = this.GetType();
            FieldInfo[] infos = t.GetFields();
            foreach (FieldInfo i in infos)
            {
                Console.WriteLine("Name=" + i.Name + ", Value=" + t.GetField(i.Name).GetValue(this));
            }
        }

    }
}
