// Decompiled with JetBrains decompiler
// Type: CiberBoy.Properties.Resources
// Assembly: CiberBoy, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB83906B-E35D-4320-A15B-B6580A2E70B1
// Assembly location: C:\Users\Admin\Documents\CiberBoy1.1-DeObfuscated.exe

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace CiberBoy.Properties;

[DebuggerNonUserCode]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[CompilerGenerated]
internal class Resources
{
  private static ResourceManager resourceManager_0;
  private static CultureInfo cultureInfo_0;

  internal Resources()
  {
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  internal static ResourceManager ResourceManager
  {
    get
    {
      if (CiberBoy.Properties.Resources.resourceManager_0 == null)
        CiberBoy.Properties.Resources.resourceManager_0 = new ResourceManager("CiberBoy.Properties.Resources", typeof (CiberBoy.Properties.Resources).Assembly);
      return CiberBoy.Properties.Resources.resourceManager_0;
    }
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  internal static CultureInfo Culture
  {
    get => CiberBoy.Properties.Resources.cultureInfo_0;
    set => CiberBoy.Properties.Resources.cultureInfo_0 = value;
  }
}
