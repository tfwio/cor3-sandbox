; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "Feed Tool (WPF)"
#include "setup-feed-tool-v1.inc"
#define MyAppPublisher "tfwroble@gmail.com"
#define MyAppExeName "FeedTool.exe"
  
#define FeedBinPath "D:\DEV\WIN\CS_ROOT\Projects\github-cor3\Source-AppWpf\FeedTool\bin"
#define FeedResPath "D:\DEV\WIN\CS_ROOT\Projects\github-cor3\Source-AppWpf\FeedTool\Build\Fringe"
; {#FeedBinPath}\Build\Setup
; {#FeedBinPath}\Build\bin
; \Build\Setup

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{C7164864-E6FA-4135-827B-B67DACDED4D7}
AppName={#MyAppName}
AppVersion={#MyAppVersion}

;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
DefaultDirName={pf}\{#MyAppName}
DefaultGroupName={#MyAppName}
AllowNoIcons=yes
OutputDir=..
OutputBaseFilename={#MyOutputFile}
SetupIconFile={#FeedResPath}\FeedToolIcon.ico
Compression=lzma
SolidCompression=yes
VersionInfoVersion={#MyAppVersion}
VersionInfoProductVersion={#MyAppVersion}
VersionInfoProductTextVersion=v{#MyAppVersion}

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked
Name: "quicklaunchicon"; Description: "{cm:CreateQuickLaunchIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked; OnlyBelowVersion: 0,6.1

[Files]
;Source: "F:\DEV\WIN\CS_ROOT\Projects\System.Cor3\Source-Tools\XmlRssTest\Build\Bin\FeedTool.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#FeedBinPath}\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs; AfterInstall: MyAfterInstall('{app}\FeedTool.exe')
;Source: "D:\DEV\WIN\CS_ROOT\Projects\github-cor3\Source-AppWpf\FeedTool\Build\Setup\AppData\feedtool.cfg"; DestDir: "{userappdata}\Macromedia\Flash Player\#Security\FlashPlayerTrust"
; BeforeInstall: MyBeforeInstall
; NOTE: Don't use "Flags: ignoreversion" on any shared system files
; Source: "{#FeedBinPath}\Build\Attribution\*"; DestDir: "{app}\Attribution"; Flags: ignoreversion createallsubdirs recursesubdirs

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{group}\{cm:UninstallProgram,{#MyAppName}}"; Filename: "{uninstallexe}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon
Name: "{userappdata}\Microsoft\Internet Explorer\Quick Launch\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: quicklaunchicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

;[Dirs]
;Name: "{app}\Attribution\OPML Icon from Wikipedia\"

[Code]
var
  MyProgChecked     : Boolean;
  MyProgCheckResult : Boolean;
  MyMessage         : String;
  MyCfg             : String;
  MyCfgTxt          : String;

//function MessageBox(hWnd: Integer; lpText, lpCaption: AnsiString; uType: Cardinal): Integer; external 'MessageBoxA@user32.dll stdcall';

procedure MyBeforeInstall();
begin
    MyProgCheckResult := MsgBox('Should I check for Flash Security? here: ' + ExtractFilePath(CurrentFileName) + '?', mbConfirmation, MB_YESNO) = idYes;
    MyProgChecked := True;
end;
procedure MyAfterInstall(FileName: String);
begin
  if (CurrentFileName = FileName) THEN begin
    //MsgBox(CurrentFileName, mbConfirmation, MB_YESNO);
    MyMessage := 'userappdata:' + ExpandConstant('{userappdata}') + #10 + #13 + 'appdata: '+ ExpandConstant('{commonappdata}');
    MyCfg     :=  ExpandConstant('{userappdata}')+'\Macromedia\Flash Player\#Security\FlashPlayerTrust\FeedTool.cfg';
    MyCfgTxt  :=  ExpandConstant('{app}');
    DeleteFile(MyCfg);
    SaveStringToFile(MyCfg,MyCfgTxt,false);
  end;
end;


//procedure CurPageChanged(CurPageID: Integer);
//begin
//  if CurPageID = wpWelcome then
//    MyMessage := 'userappdata:' + ExpandConstant('{userappdata}') + #10 + #13 + 'appdata: '+ ExpandConstant('{commonappdata}');
//    MyCfg     :=  ExpandConstant('{userappdata}')+'\Macromedia\Flash Player\#Security\FlashPlayerTrust\FeedTool.cfg';
//    MyCfgTxt  :=  ExpandConstant('{app}');
//    DeleteFile(MyCfg);
//    SaveStringToFile(MyCfg,MyCfgTxt,false);
//    MyProgCheckResult := MsgBox(MyCfgTxt, mbConfirmation, MB_YESNO) = idYes;
//end;
