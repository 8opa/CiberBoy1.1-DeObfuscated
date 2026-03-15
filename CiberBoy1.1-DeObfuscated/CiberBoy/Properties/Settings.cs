// Decompiled with JetBrains decompiler
// Type: CiberBoy.Properties.Settings
// Assembly: CiberBoy, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB83906B-E35D-4320-A15B-B6580A2E70B1
// Assembly location: C:\Users\Admin\Documents\CiberBoy1.1-DeObfuscated.exe

using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

#nullable disable
namespace CiberBoy.Properties;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
internal sealed class Settings : ApplicationSettingsBase
{
  private static Settings defaultInstance = (Settings) SettingsBase.Synchronized((SettingsBase) new Settings());

  public static Settings Default
  {
    get
    {
      Settings defaultInstance = Settings.defaultInstance;
      return defaultInstance;
    }
  }
}
