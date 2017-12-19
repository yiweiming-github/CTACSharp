# 介绍
本项目为CTP交易接口的C#版本，是使用swig从其C++ API生成.

swig Windows版本下载地址
http://prdownloads.sourceforge.net/swig/swigwin-3.0.12.zip

# 项目结构
- `api` CTP交易接口头文件及DLL文件
- `swig` swig接口文件及CTP的头文件
- `CTPMarketCppWrapper` swig生成的C++ wrapper
- `CTPMarketCSharpWrapper` swig生成的C# wrapper
- `CTPMarketTest` TapQuote的C#测试程序
- `CTPTradeCppWrapper` swig生成的C++ wrapper
- `CTPTradeCSharpWrapper` swig生成的C# wrapper
- `CTPTradeTest` TapTrade的C#测试程序

# swig使用方式
如需要修改swig接口文件，重新生成C#接口，可按以下步骤（以CTPMarket为例）

- 在`swig\Market`目录下运行：

`swig.exe -c++ -csharp -directors CTPMarketCppWrapper.i`

- CTPMarketCppWrapper

```
    CTPMarketCppWrapper_wrap.h
    CTPMarketCppWrapper_wrap.cxx
```

- 将生成的C#源文件拷贝至CTPMarketCSharpWrapper项目中，并重新编译



