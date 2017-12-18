# 介绍
本项目为易盛内盘启明星交易接口的C#版本，是使用swig从其C++ API生成，版本为9.0
详见：
http://www.esunny.com.cn/index.php?m=content&c=index&a=lists&catid=71

# 项目结构
- `api` 易盛内盘启明星交易接口头文件及DLL文件
- `swig` swig接口文件及易盛交易接口的头文件
- `TapQuoteCppWrapper` swig生成的C++ wrapper
- `TapQuoteCSharpWrapper` swig生成的C# wrapper
- `TapQuoteTest` TapQuote的C#测试程序
- `TapTradeCppWrapper` swig生成的C++ wrapper
- `TapTradeCSharpWrapper` swig生成的C# wrapper
- `TapTradeTest` TapTrade的C#测试程序

# swig使用方式
如需要修改swig接口文件，重新生成C#接口，可按以下步骤（以TapQuote为例）

- 在`swig\TapQuote`目录下运行：

`swig.exe -c++ -csharp -directors TapQuoteCppWrapper.i`

- 将生成的以下两个文件拷贝至TapQuoteCppWrapper项目中，并重新编译

```
    TapQuoteCppWrapper_wrap.h
    TapQuoteCppWrapper_wrap.cxx
```

- 将生成的C#源文件拷贝至TapQuoteCSharpWrapper项目中，并重新编译


