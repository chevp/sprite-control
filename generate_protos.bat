@rem Generate the C# code for .proto files

setlocal

@rem enter this directory
cd /d %~dp0

set TOOLS_PATH=..\ocean-agent\packages\Grpc.Tools.1.0.1\tools\windows_x64

cd ../ocean-protos

@rem Avatar2
%TOOLS_PATH%\protoc.exe ipcoe1.proto --csharp_out ../sprite-control/Avatar/protos
%TOOLS_PATH%\protoc.exe ipcoe1.proto --grpc_out ../sprite-control/Avatar/protos --plugin=protoc-gen-grpc=%TOOLS_PATH%\grpc_csharp_plugin.exe

endlocal

pause