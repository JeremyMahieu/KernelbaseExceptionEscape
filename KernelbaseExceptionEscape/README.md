As a replication for problem https://github.com/dotnet/runtime/issues/91447


1) Run this in cmd as Administrator
`sc create MyService binPath= "C:\<yourdebugfolder>\KernelbaseExceptionEscape.exe"`

2) Start the service

3) Find the exception in Event Log