%module HSTradeCppWrapper
%{
#include "HSDataType.h"
#include "HSStruct.h"
#include "HSTradeApi.h"
%}

%typemap(imtype) char*[] "string[]"
%typemap(cstype) char*[] "string[]"

%include "HSDataType.h"
%include "HSStruct.h"
%include "HSTradeApi.h"