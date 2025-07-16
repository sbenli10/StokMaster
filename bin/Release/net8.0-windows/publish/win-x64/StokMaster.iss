#define MyAppName "StokMaster"
#define MyAppVersion "1.0"
#define MyAppPublisher "Said Benli"

[Setup]
AppId={{E59ADFAD-4899-4E5C-A2DD-BEBDDBC78959}}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
AppPublisher={#MyAppPublisher}
DefaultDirName={autopf}\{#MyAppName}
DefaultGroupName={#MyAppName}
OutputDir=C:\Users\benli\OneDrive\Desktop
OutputBaseFilename=StokMasterKurulum
SolidCompression=yes
WizardStyle=modern

[Languages]
Name: "turkish"; MessagesFile: "compiler:Languages\Turkish.isl"

[Files]
Source: "C:\Users\benli\source\repos\GirisEkranı\GirisEkranı\GirisEkranı\bin\Release\net8.0-windows\publish\win-x64\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs

[Tasks]
Name: "desktopicon"; Description: "Masaüstü simgesi oluştur"; GroupDescription: "Ek görevler:"

[Icons]
Name: "{group}\StokMaster"; Filename: "{app}\GirisEkranı.exe"
Name: "{commondesktop}\StokMaster"; Filename: "{app}\GirisEkranı.exe"; Tasks: desktopicon

[Run]
Filename: "{app}\GirisEkranı.exe"; Description: "StokMaster'ı Başlat"; Flags: nowait postinstall skipifsilent

