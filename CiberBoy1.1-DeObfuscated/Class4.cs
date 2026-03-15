// Decompiled with JetBrains decompiler
// Type: Class4
// Assembly: CiberBoy, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB83906B-E35D-4320-A15B-B6580A2E70B1
// Assembly location: C:\Users\Admin\Documents\CiberBoy1.1-DeObfuscated.exe

using System;
using System.Reflection;

#nullable disable
internal class Class4
{
  internal static Module module_0 = typeof (Class4).Assembly.ManifestModule;

  internal static void smethod_0(int typemdt)
  {
    Type type = Class4.module_0.ResolveType(33554432 /*0x02000000*/ + typemdt);
    foreach (FieldInfo field in type.GetFields())
    {
      MethodInfo method = (MethodInfo) Class4.module_0.ResolveMethod(field.MetadataToken + 100663296 /*0x06000000*/);
      field.SetValue((object) null, (object) (MulticastDelegate) Delegate.CreateDelegate(type, method));
    }
  }

  internal delegate void Delegate1(object o);
}
