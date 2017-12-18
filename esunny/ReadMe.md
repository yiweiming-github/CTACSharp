# 介绍
本项目为易盛内盘启明星交易接口的C#版本，是使用swig从其C++ API生成，版本为9.0
详见：
http://www.esunny.com.cn/index.php?m=content&c=index&a=lists&catid=71

swig Windows版本下载地址
http://prdownloads.sourceforge.net/swig/swigwin-3.0.12.zip

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

编译过程中提示虚函数声明错误，可在SwigDirector_ITapQuoteAPINotify和SwigDirector_ITapQuoteAPI类的成员函数声明前加上TAP_CDECL，例如：

```
    virtual TAPIINT32 TAP_CDECL SetAPINotify(ITapQuoteAPINotify *apiNotify);
```

- 将生成的C#源文件拷贝至TapQuoteCSharpWrapper项目中，并重新编译

编译过程中提示一些整数类型变量相关的IntPtr错误，可修改为ref加变量的形式，例如：
 
```
  public static ITapQuoteAPI CreateTapQuoteAPI(TapAPIApplicationInfo appInfo, ref int iResult) {
    global::System.IntPtr cPtr = TapQuoteCppWrapperPINVOKE.CreateTapQuoteAPI(TapAPIApplicationInfo.getCPtr(appInfo), ref iResult);
    ITapQuoteAPI ret = (cPtr == global::System.IntPtr.Zero) ? null : new ITapQuoteAPI(cPtr, false);
    if (TapQuoteCppWrapperPINVOKE.SWIGPendingException.Pending) throw TapQuoteCppWrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

```


