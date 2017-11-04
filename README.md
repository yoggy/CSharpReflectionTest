CSharpReflectionTest
====

    using System.Reflection;
        .
        .
        .
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
        .
        .
        .

    > CSharpReflectionTest.exe
    
    Name=i, Type=System.Int32
    Name=f, Type=System.Single
    Name=b, Type=System.Boolean
    Name=s, Type=System.String
    Name=i, Value=123
    Name=f, Value=123.45
    Name=b, Value=True
    Name=s, Value=string1234

Copyright and license
----
Copyright (c) 2017 yoggy

Released under the [MIT license](LICENSE.txt)

