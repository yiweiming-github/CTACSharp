%module HSMarketCppWrapper
%{
#include "HSDataType.h"
#include "HSStruct.h"
#include "HSMdApi.h"
%}

%typemap(imtype) char*[] "string[]"
%typemap(cstype) char*[] "string[]"

%include "HSDataType.h"
%include "HSStruct.h"
%include "HSMdApi.h"