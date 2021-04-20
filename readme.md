C# 7.3 feature is not available in VS2017 by default (targeting .Net Framework 4.8)

Three methods with `Func<>` parameter require either
* func notation to be used `WithParentActivityOrWindow(() => GetHandle())` 
* c# 7.3 (or `latest minor` option to be specified for the project

  [![language versions][f2]][f2]
    
    [f2]: langList.png

if VS 2017 is used. 

