# KernelbaseExceptionEscape
As a replication for problem https://github.com/dotnet/runtime/issues/91447


1) Run this in cmd as Administrator
`sc create MyService binPath= "C:\Users\<your debug location>\KernelbaseExceptionEscape.exe"`

2) Start the service `sc start MyService`

3) Find the exception in Event Log

4) run `sc delete MyService` to clean up the service
