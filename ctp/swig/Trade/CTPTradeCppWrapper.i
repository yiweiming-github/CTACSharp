%module CTPMarketCppWrapper
%{
#include "ThostFtdcUserApiDataType.h"
#include "ThostFtdcUserApiStruct.h"
#include "ThostFtdcTraderApi.h"
%}

%typemap(imtype) char*[] "string[]"
%typemap(cstype) char*[] "string[]"

%include "ThostFtdcUserApiDataType.h"
%include "ThostFtdcUserApiStruct.h"
%include "ThostFtdcTraderApi.h"